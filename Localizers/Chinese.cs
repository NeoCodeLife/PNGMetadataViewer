namespace PNGMetadataViewer.Localizers
{
    public class Chinese : AntdUI.ILocalization
    {
        public string GetLocalizedString(string key)
        {
            switch (key)
            {
                case "AppName":
                    return "PNG元数据查看器 (支持 ComfyUI 和 WebUI) - by 程序员小枫";
                case "ChangeTheme":
                    return "切换主题";
                case "CheckPointName":
                    return "模型名称 Checkpoint";
                case "Steps":
                    return "迭代步数 Steps";
                case "CFG":
                    return "提示词引导系数 CFG";
                case "Sampler":
                    return "采样方法 Sampler";
                case "Seed":
                    return "随机种子 Seed";
                case "Prompt":
                    return "提示词 Prompt";
                case "Start":
                    return "开始";
                case "FilePath":
                    return "文件路径";
                case "ImageSize":
                    return "图片尺寸 Size";
                case "Scheduler":
                    return "调度器 Scheduler";
                case "Denoise":
                    return "降噪 Denoise";
                case "Workflow":
                    return "工作流 ComfyUI";
                case "Copied":
                    return "成功复制";
                case "Copy":
                    return "复制";
                case "Setting":
                    return "设置";
                case "Theme":
                    return "主题";
                case "Language":
                    return "语言";
                case "DarkTheme":
                    return "暗主题";
                case "LightTheme":
                    return "亮主题";
                case "Drop the PNG file here":
                    return "将 PNG 文件拖放到此处";
                case "Add To Contextmenu":
                    return "添加到右键菜单";
                case "Remove From Contextmenu":
                    return "从右键菜单中移除";
                case "Email":
                    return "邮箱：neo_code@qq.com";
                case "Copy Fail":
                    return "复制失败，请稍后重试！";
                case "Copy Success":
                    return "复制成功";
                case "Please drag and drop the image file into this software first.":
                    return "请先把图片文件拖放到本软件中";
                case "Acknowledgments":
                    return "致谢";
                case "Buy me a coffee":
                    return "请我喝杯茶";
                case "Change Text Color":
                    return "修改文本颜色";
                case "Default":
                    return "默认";

                default:
                    return key;
            }
        }
    }
}
