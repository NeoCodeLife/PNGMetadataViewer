using System;
using System.Drawing;
using System.Windows.Forms;

namespace PNGMetadataViewer.Utils
{
    public static class ThemeHelper
    {
        /// <summary>
        /// 切换主题
        /// 单独引用的方式：Copy_button.OriginalBackColor = AntdUI.Style.Db.Error;
        /// 可用的颜色请查看 Themes 文件夹里面主题定义的属性
        /// </summary>
        static public bool ToggleTheme()
        {
            AntdUI.Config.IsDark = !AntdUI.Config.IsDark;
            bool IsDark = AntdUI.Config.IsDark;
            return ChangeThemeAllForm(IsDark);
        }
        /// <summary>
        /// 为所有面板切换指定主题
        /// </summary>
        /// <param name="isDark"></param>
        /// <returns></returns>
        static public bool ChangeThemeAllForm(bool isDark)
        {
            AntdUI.Config.IsDark = isDark;
            FormCollection forms = Application.OpenForms;
            foreach (Form form in forms)
            {
                ChangeTheme(form, isDark);
            }
            ConfigHelper.SaveConfig();
            return isDark;
        }

        /// <summary>
        /// 切换某个面板的主题
        /// </summary>
        /// <param name="form"></param>
        /// <param name="isDark"></param>
        static public void ChangeTheme(Form form, bool isDark)
        {
            Color bgColor = isDark ? Theme.Dark.Instant.BackColor : Theme.Light.Instant.BackColor;
            Color fgColor = isDark ? Theme.Dark.Instant.ForeColor : Theme.Light.Instant.ForeColor;

            form.BackColor = bgColor;
            form.ForeColor = fgColor;

            NewMethod(isDark);
        }

        private static void NewMethod(bool isDark)
        {
            // 这里载入自定义的颜色
            if (isDark)
            {
                AntdUI.Style.LoadCustom(Theme.Dark.Instant.ToDictionary());
            }
            else
            {
                AntdUI.Style.LoadCustom(Theme.Light.Instant.ToDictionary());
            }
        }

        /// <summary>
        /// 初始化面板主题(根据全局主题设置来初始化)
        /// </summary>
        /// <param name="form"></param>
        static public void InitThemeOfForm(Form form)
        {
            bool IsDark = AntdUI.Config.IsDark;
            ChangeTheme(form, IsDark);
        }
        /// <summary>
        /// 修改内容文本的颜色
        /// </summary>
        /// <param name="ColorHex">类似 ffaabb 的值，如果为空，则设为默认颜色</param>
        static public string ChangeContentTextColor(string ColorHex)
        {
            bool isDark = AntdUI.Config.IsDark;

            if (isDark)
            {
                if (string.IsNullOrEmpty(ColorHex))
                {
                    Theme.Dark dark = new Theme.Dark();
                    ColorHex = dark.Text.TrimStart('#');
                }
                Theme.Dark.Instant.Text = ColorHex;
                AntdUI.Style.LoadCustom(Theme.Dark.Instant.ToDictionary());
                Config.TextColorDarkTheme = ColorHex;
            }
            else
            {
                if (string.IsNullOrEmpty(ColorHex))
                {
                    Theme.Light light = new Theme.Light();
                    ColorHex = light.Text.TrimStart('#');
                }
                Theme.Light.Instant.Text = ColorHex;
                AntdUI.Style.LoadCustom(Theme.Light.Instant.ToDictionary());
                Config.TextColorLightTheme = ColorHex;
            }
            FormCollection forms = Application.OpenForms;
            foreach (Form form in forms)
            {
                form.Refresh();
            }
            ConfigHelper.SaveConfig();
            return ColorHex;
        }
    }
}
