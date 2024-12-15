using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PNGMetadataViewer.Utils
{
    class Config
    {
        public static string Theme
        {
            get => ConfigHelper.GetConfigValue(nameof(Theme));
            set => ConfigHelper.SetConfigValue(nameof(Theme), value);
        }
        public static string Language
        {
            get => ConfigHelper.GetConfigValue(nameof(Language));
            set => ConfigHelper.SetConfigValue(nameof(Language), value);
        }
        public static string TextColorDarkTheme
        {
            get => ConfigHelper.GetConfigValue(nameof(TextColorDarkTheme));
            set => ConfigHelper.SetConfigValue(nameof(TextColorDarkTheme), value);
        }
        public static string TextColorLightTheme
        {
            get => ConfigHelper.GetConfigValue(nameof(TextColorLightTheme));
            set => ConfigHelper.SetConfigValue(nameof(TextColorLightTheme), value);
        }
    }
    internal class ConfigHelper
    {
        public static void InitConfig()
        {
            bool isDark = Convert.ToBoolean(Config.Theme);
            AntdUI.Config.IsDark = isDark;
            if (isDark)
            {
                if (!string.IsNullOrEmpty(Config.TextColorDarkTheme))
                {
                    ThemeHelper.ChangeContentTextColor(Config.TextColorDarkTheme);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(Config.TextColorLightTheme))
                {
                    ThemeHelper.ChangeContentTextColor(Config.TextColorLightTheme);
                }
            }

            bool isSuccess = Enum.TryParse(Config.Language, out LanguageHelper.LanguageType lang);
            if (isSuccess)
            {
                LanguageHelper.SetLanguage(lang);
            }

        }
        public static void SaveConfig()
        {
            SetConfigValue(nameof(Config.Theme), AntdUI.Config.IsDark.ToString());
            SetConfigValue(nameof(Config.Language), LanguageHelper.Current.ToString());
        }
        public static Config Config = new Config();
        public static string GetConfigValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static void SetConfigValue(string key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
