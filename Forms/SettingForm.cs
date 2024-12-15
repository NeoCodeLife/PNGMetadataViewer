using AntdUI;
using PNGMetadataViewer.Utils;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PNGMetadataViewer.Forms
{
    public partial class SettingForm : AntdUI.BorderlessForm
    {
        public SettingForm()
        {
            InitializeComponent();
            ThemeHelper.InitThemeOfForm(this);
            InitColorPicker();
        }

        private void InitColorPicker()
        {
            Text_colorPicker.Value = AntdUI.Style.Db.Text;
        }

        private void ChangeTheme_button_Click(object sender, EventArgs e)
        {
            ThemeHelper.ToggleTheme();
            InitColorPicker();
        }

        private void ChangeLanguage_button_Click(object sender, EventArgs e)
        {
            LanguageHelper.SetLanguage(LanguageHelper.LanguageType.English);
        }

        private void DarkTheme_button_Click(object sender, EventArgs e)
        {
            ThemeHelper.ChangeThemeAllForm(true);
            InitColorPicker();
        }

        private void LigthTheme_button_Click(object sender, EventArgs e)
        {
            ThemeHelper.ChangeThemeAllForm(false);
            InitColorPicker();
        }

        private void Chinese_button_Click(object sender, EventArgs e)
        {
            LanguageHelper.SetLanguage(LanguageHelper.LanguageType.中文);
        }

        private void English_button_Click(object sender, EventArgs e)
        {
            LanguageHelper.SetLanguage(LanguageHelper.LanguageType.English);
        }

        private void AddToContextMenu_button_Click(object sender, EventArgs e)
        {
            string exePath = Application.ExecutablePath;

            ContextMenuHelper.AddToContextMenu(exePath);
        }

        private void RemoveContextMenu_button_Click(object sender, EventArgs e)
        {
            ContextMenuHelper.RemoveFromContextMenu();
        }

        private void Feedback_button_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText("neo_code@qq.com");
                AntdUI.Message.success(this, AntdUI.Localization.Get("Copy Success", "Copy Success"));
            }
            catch (Exception ex)
            {
                AntdUI.Message.error(
                    this,
                    $"{AntdUI.Localization.Get("Copy Fail", "Copy Fail")}! {ex.Message}"
                );
            }
        }

        private void OpenUrl(string url)
        {
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void MetadataExtractor_Url_input_TextChanged(object sender, EventArgs e)
        {
            OpenUrl(((TextBox)sender).Text);
        }

        private void AntdUI_Url_input_TextChanged(object sender, EventArgs e)
        {
            OpenUrl(((TextBox)sender).Text);
        }

        private void Text_colorPicker_ValueChanged(object sender, AntdUI.ColorEventArgs e)
        {
            ThemeHelper.ChangeContentTextColor(e.Value.ToHex());
        }

        private void Default_Color_button_Click(object sender, EventArgs e)
        {
            string colorHex = ThemeHelper.ChangeContentTextColor(null);
            Text_colorPicker.Value = colorHex.ToColor();
        }
    }
}
