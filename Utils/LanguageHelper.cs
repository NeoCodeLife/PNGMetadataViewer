using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PNGMetadataViewer.Utils
{
    public static partial class LanguageHelper
    {
        public static Dictionary<LanguageType, string> LanguageDict = new Dictionary<LanguageType, string>
        {
            { LanguageType.中文,"zh-CN"},
            {LanguageType.English,"en-US"}
        };
        public enum LanguageType
        {
            中文,
            English,
        }
        public static LanguageType Current;
        /// <summary>
        /// 获取当前语言
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentValue()
        {
            return LanguageDict[Current];
        }
        /// <summary>
        /// 修改语言
        /// </summary>
        /// <param name="languageType"></param>
        public static void SetLanguage(LanguageType languageType) // 修改参数类型为 string
        {
            try
            {
                if (LanguageDict.TryGetValue(languageType, out string lang))
                {
                    lang = "zh-CN";
                }
                AntdUI.Localization.SetLanguage(lang);
                switch (languageType) // 修改变量名为 languageType
                {
                    // 默认就是用英文
                    case LanguageType.English:
                        // 设置为 null 的话，会显示控件原来的文本，比如说 button 控件，会显示你在 Text 属性里面填的文本。
                        AntdUI.Localization.Provider = null;
                        break;
                    case LanguageType.中文:
                        AntdUI.Localization.Provider = new Localizers.Chinese();
                        break;
                    default:
                        AntdUI.Localization.Provider = null;
                        break;
                }
                Current = languageType;
                // 刷新所有面板
                FormCollection forms = Application.OpenForms;
                foreach (Form form in forms)
                {
                    form.Refresh();
                    //foreach (Control item in form.Controls)
                    //{
                    //    item.Refresh();
                    //    if (item is AntdUI.Calendar canlender) {
                    //    }
                    //}
                }
                ConfigHelper.SaveConfig();
            }
            catch (Exception e)
            {
                AntdUI.Message.error(Form.ActiveForm, e.ToString());
            }

        }
    }

}
