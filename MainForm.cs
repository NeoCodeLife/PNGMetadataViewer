using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AntdUI;
using MetadataExtractor;
using PNGMetadataViewer.Forms;
using PNGMetadataViewer.Utils;

namespace PNGMetadataViewer
{
    public partial class MainForm : AntdUI.BorderlessForm
    {
        private string imageFilePath = null;

        public MainForm()
        {
            InitializeComponent();
            ThemeHelper.InitThemeOfForm(this);
            // 检查命令行参数
            if (Environment.GetCommandLineArgs().Length > 1)
            {
                imageFilePath = Environment.GetCommandLineArgs()[1];
                StartExtra(imageFilePath);
            }
        }
        private void Start_Button_Click(object sender, EventArgs e)
        {
            try
            {
                StartExtra(imageFilePath);
            }
            catch (Exception ex)
            {
                AntdUI.Message.error(this, ex.Message);
            }
        }

        private void StartExtra(string imageFilePath)
        {
            ClearAllValue();
            FilePath_input.Text = imageFilePath;
            if (imageFilePath == null || imageFilePath.Trim() == string.Empty || !System.IO.File.Exists(imageFilePath.Trim()))
            {
                string errorText = "Please drag and drop the image file into this software first.";
                AntdUI.Message.error(this, AntdUI.Localization.Get(errorText, errorText));
                return;
            }
            try
            {
                LoadImgAndHandleMetaData(imageFilePath);
            }
            catch (Exception ex)
            {
                AntdUI.Message.error(this, $"读取元数据失败: {ex.Message}");
            }
        }

        private void LoadImgAndHandleMetaData(string imageFilePath)
        {
            Image img = Image.FromFile(imageFilePath);
            ImageSize_input.Text = $"{img.Size.Width} x {img.Size.Height}";
            PreviewImage_panel.BackgroundImage = img;

            IEnumerable<Directory> directories = ImageMetadataReader.ReadMetadata(imageFilePath);

            // 是不是包含 ComfyUI 或者 WebUI 元数据的文件
            bool isAValidFile = false;

            foreach (var directory in directories)
            {
                // 仅处理名称为 "PNG-tEXt" 的目录
                if (directory.Name != "PNG-tEXt") continue;

                foreach (var tag in directory.Tags)
                {
                    // 仅处理名称为 "Textual Data" 的标签
                    if (tag.Name != "Textual Data") continue;

                    var description = tag.Description;

                    if (description == null) return;

                    // 处理 ComfyUI 图片的元数据
                    if (description.StartsWith("workflow"))
                    {
                        isAValidFile = true;
                        string workflowStr = description.TrimStart("workflow: ".ToCharArray());
                        Workflow_Input.Text = workflowStr; // 设置工作流文本框内容
                    }
                    // 处理 ComfyUI 的提示数据
                    else if (description.StartsWith("prompt"))
                    {
                        isAValidFile = true;
                        string prompt = description.TrimStart("prompt: ".ToCharArray());
                        HandlePrompt(prompt);
                    }
                    // 处理 WebUI 图片的参数
                    else if (description.StartsWith("parameters"))
                    {
                        isAValidFile = true;
                        HandleWebUIData(description);
                    }
                }
            }

            // 文件不包含元数据
            if (!isAValidFile)
            {
                AntdUI.Message.warn(this, "图片不包含 ComfyUI 或者 WebUI 的元数据。");
            }
        }

        private void HandleWebUIData(string description)
        {
            string[] infos = description.Split('\n');

            var positive = string.Empty;
            var negative = string.Empty;
            var other = string.Empty;

            // 没有提示词
            if (infos.Length == 1)
            {
                other = infos[0];
            }
            // 只有正面或负面提示词 和 其他参数
            if (infos.Length == 2)
            {
                positive = infos[0];
                other = infos[1];
            }
            if (infos.Length >= 3)
            {
                positive = infos[0];
                negative = infos[1];
                // 可能超过 3，后面的都是 CFG 之类的参数，所以放到 other 里
                other = string.Join(",", infos.Skip(2));

            }
            var prompt = positive + "\n\n----------------------------------\n\n" + negative;
            Prompt_input.Text = prompt.Replace("parameters:", string.Empty).Replace("Negative prompt:", string.Empty);
            HandlePromptWebUI(other);
        }

        private void ClearAllValue()
        {
            imageFilePath = null;
            PreviewImage_panel.BackgroundImage?.Dispose();
            PreviewImage_panel.BackgroundImage = null;
            ImageSize_input.Text = string.Empty;

            CheckPointName_Input.Text = string.Empty;
            Prompt_input.Text = string.Empty;
            Sampler_input.Text = string.Empty;
            CFG_input.Text = string.Empty;
            Seed_input.Text = string.Empty;
            Step_input.Text = string.Empty;
            Workflow_Input.Text = string.Empty;
            Scheduler_input.Text = string.Empty;
            Denoise_input.Text = string.Empty;
            Refresh();
        }
        private void HandlePromptWebUI(string prompt)
        {
            // 在其他地方调用该方法
            MatchAndAssign("Model: (.*?),", prompt, value => CheckPointName_Input.Text = value);
            MatchAndAssign("Sampler: (.*?),", prompt, value => Sampler_input.Text = value);
            MatchAndAssign("CFG scale: (.*?),", prompt, value => CFG_input.Text = value);
            MatchAndAssign("Seed: (.*?),", prompt, value => Seed_input.Text = value);
            MatchAndAssign("Steps: (.*?),", prompt, value => Step_input.Text = value);
            MatchAndAssign("Denoising strength: (.*?),", prompt, value => Denoise_input.Text = value);
            //MatchAndAssign("Denoising strength:\"?: \"?(.*?)\"?,", prompt, value => Denoise_input.Text = value);
            // MatchAndAssign("Scheduler: (.*?),", prompt, value => Scheduler_input.Text = value);
        }

        private void HandlePrompt(string prompt)
        {
            // 在其他地方调用该方法
            MatchAndAssign("ckpt_name\": \"(.+?)\"}?", prompt, value => CheckPointName_Input.Text = value);
            // 提示词(官方节点)
            MatchAndAssign("text\": \"(.*?)\", .*?\"CLIPTextEncode\"}", prompt, value => Prompt_input.Text = value);
            // 有些自定义节点提示词的存放方式不一样
            MatchAndAssign("\"positive\": \"([^[].*?)\",", prompt, value => AppendToPromptInput(value));
            MatchAndAssign("\"negative\": \"([^[].*?)\",", prompt, value => AppendToPromptInput(value));
            MatchAndAssign("sampler_name\"?: \"(.*?)\",", prompt, value => Sampler_input.Text = value);
            MatchAndAssign("cfg\"?: \"?(.*?)\"?,", prompt, value => CFG_input.Text = value);
            MatchAndAssign("seed\"?: \"?(.*?)\"?,", prompt, value => Seed_input.Text = value);
            MatchAndAssign("steps\"?: \"?(.*?)\"?,", prompt, value => Step_input.Text = value);
            MatchAndAssign("scheduler\"?: \"?(.*?)\"?,", prompt, value => Scheduler_input.Text = value);
            MatchAndAssign("denoise\"?: \"?(.*?)\"?,", prompt, value => Denoise_input.Text = value);

            // 这些都还没有添加到界面上的
            // MatchAndAssign("clip_skip\"?: \"?(.*?)\"?,", prompt, value => Denoise_input.Text = value);
            // MatchAndAssign("vae_name\"?: \"?(.*?)\"?,", prompt, value => Denoise_input.Text = value);
            // MatchAndAssign("lora_name\"?: \"?(.*?)\"?,", prompt, value => Denoise_input.Text = value);

        }
        private void AppendToPromptInput(string value)
        {
            if (!string.IsNullOrWhiteSpace(Prompt_input.Text))
            {
                Prompt_input.Text += "\n\n";
            }
            Prompt_input.Text += value;
        }
        private void MatchAndAssign(string pattern, string inputText, Action<string> assignAction)
        {
            MatchCollection matchCollection = Regex.Matches(inputText, pattern, RegexOptions.IgnoreCase);
            int count = matchCollection.Count;
            if (count > 0)
            {
                string text = string.Empty;
                for (int i = 0; i < count; i++)
                {
                    Match match = matchCollection[i];
                    text += match.Groups[1].Value;
                    if (i < count - 1)
                    {
                        text += "\n\n"; ;
                    }
                }
                text = StringHelper.UnescapeString(text);
                assignAction(text);
            }
        }

        private void MainForm_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop, true);
                string ext = System.IO.Path.GetExtension(filePath[0]);
                if (ext == ".png")
                {
                    e.Effect = DragDropEffects.Copy;
                    imageFilePath = filePath[0];
                    FilePath_input.Text = imageFilePath;
                }
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            StartExtra(imageFilePath);
        }

        private void Setting_button_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.Owner = this;
            settingForm.ShowDialog();
        }
    }
}
