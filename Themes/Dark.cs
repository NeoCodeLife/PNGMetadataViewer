using AntdUI;
using AntdUI.Theme;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;

namespace PNGMetadataViewer.Theme
{

    /// <summary>
    /// 暗色
    /// </summary>
    public class Dark
    {
        private static Dark instant;

        public static Dark Instant
        {
            get
            {
                if (instant == null)
                {
                    instant = new Dark();
                }
                return instant;
            }
            set { instant = value; }
        }

        /// <summary>
        /// 背景色
        /// </summary>
        public  Color BackColor { get; set; } = "#282C34".ToColor();

        /// <summary>
        /// 前景色
        /// </summary>
        public  Color ForeColor { get; set; } = "#DFE1E5".ToColor();

        /// <summary>
        /// 转成字典给 AntdUI用
        ///  AntdUI.Style.LoadCustom(Theme.Dark.ToDictionary());
        /// </summary>
        /// <returns></returns>
        public  Dictionary<string, string> ToDictionary()
        {
            Dictionary<string, string> ColorPairs = new Dictionary<string, string>();

            // 通过反射获取Temp类的所有属性
            PropertyInfo[] properties = typeof(Dark).GetProperties();

            // 遍历属性并将属性名和属性值存入字典
            foreach (PropertyInfo property in properties)
            {
                var value = property.GetValue(Instant)?.ToString();
                if (value != null)
                {
                    ColorPairs.Add(property.Name, value);
                }
            }

            return ColorPairs;
        }

        //  ！！！ 没有设置值的会被忽略，然后用UI库定义的颜色，所以只需要修改自己想要自定义的颜色即可 ！！！ //
        public  string NeoDarkBg = "red";

        /// <summary>
        ///  品牌色
        /// </summary>
        public  string Primary { get; set; } = "#1E88E5";

        /// <summary>
        ///  文本颜色
        /// </summary>
        public  string PrimaryColor { get; set; } = "#DFE1E5";

        /// <summary>
        ///  主色悬浮态（按钮、开关、复选框）
        /// </summary>
        public  string PrimaryHover { get; set; } = "#42A5F5";

        /// <summary>
        ///  主色激活态（按钮动画）
        /// </summary>
        public  string PrimaryActive { get; set; } = "#1565C0";

        /// <summary>
        ///  主色背景色（按钮底部、下拉激活、文本框激活、菜单激活）
        /// </summary>
        public  string PrimaryBg { get; set; } = "#E3F2FD";

        /// <summary>
        ///  成功色
        /// </summary>
        public  string Success { get; set; } = "#43A047";

        /// <summary>
        ///  文本颜色
        /// </summary>
        public  string SuccessColor { get; set; } = "#DFE1E5";

        /// <summary>
        ///  成功色的背景颜色
        /// </summary>
        public  string SuccessBg { get; set; } = "#E8F5E9";

        /// <summary>
        ///  成功色的描边色
        /// </summary>
        public  string SuccessBorder { get; set; } = "#43A047";

        /// <summary>
        ///  成功色的悬浮态
        /// </summary>
        public  string SuccessHover { get; set; } = "#66BB6A";

        /// <summary>
        ///  成功色的激活态
        /// </summary>
        public  string SuccessActive { get; set; } = "#2E7D32";

        /// <summary>
        ///  警戒色
        /// </summary>
        public  string Warning { get; set; } = "#E37103";

        /// <summary>
        ///  文本颜色
        /// </summary>
        public  string WarningColor { get; set; } = "#DFE1E5";

        /// <summary>
        ///  警戒色的背景颜色
        /// </summary>
        public  string WarningBg { get; set; } = "#FFF8E1";

        /// <summary>
        ///  警戒色的描边色
        /// </summary>
        public  string WarningBorder { get; set; } = "#FFA000";

        /// <summary>
        ///  警戒色的悬浮态
        /// </summary>
        public  string WarningHover { get; set; } = "#FF7D00";

        /// <summary>
        ///  警戒色的激活态
        /// </summary>
        public  string WarningActive { get; set; } = "#FF8F00";

        /// <summary>
        ///  错误色
        /// </summary>
        public  string Error { get; set; } = "#E53935";

        /// <summary>
        ///  文本颜色
        /// </summary>
        public  string ErrorColor { get; set; } = "#DFE1E5";

        /// <summary>
        ///  警戒色的背景颜色（按钮底部）
        /// </summary>
        public  string ErrorBg { get; set; } = "#FFEBEE";

        /// <summary>
        ///  警戒色的描边色
        /// </summary>
        public  string ErrorBorder { get; set; } = "#E53935";

        /// <summary>
        ///  错误色的悬浮态
        /// </summary>
        public  string ErrorHover { get; set; } = "#EF5350";

        /// <summary>
        ///  错误色的激活态
        /// </summary>
        public  string ErrorActive { get; set; } = "#C62828";

        /// <summary>
        ///  信息色
        /// </summary>
        public  string Info { get; set; } = "#039BE5";

        /// <summary>
        ///  文本颜色
        /// </summary>
        public  string InfoColor { get; set; } = "#DFE1E5";

        /// <summary>
        ///  信息色的背景颜色（按钮底部）
        /// </summary>
        public  string InfoBg { get; set; } = "#E1F5FE";

        /// <summary>
        ///  信息色的描边色
        /// </summary>
        public  string InfoBorder { get; set; } = "#039BE5";

        /// <summary>
        ///  信息色的悬浮态
        /// </summary>
        public  string InfoHover { get; set; } = "#29B6F6";

        /// <summary>
        ///  信息色的激活态
        /// </summary>
        public  string InfoActive { get; set; } = "#0277BD";

        public  string DefaultBg { get; set; } = "#2F333D";
        public  string DefaultColor { get; set; } = "#A2A8AE";
        public  string DefaultBorder { get; set; } = "#5C6370";
        public  string TagDefaultBg { get; set; } = "#2F333D";
        public  string TagDefaultColor { get; set; } = "#A2A8AE";

        /// <summary>
        ///  基础文本色
        /// </summary>
        public  string TextBase { get; set; } = "#A2A8AE";

        /// <summary>
        ///  一级文本色（菜单颜色、非激活下颜色、小清除按钮悬浮态）
        /// </summary>
        public  string Text { get; set; } = "#4390B8";
        //public  string Text { get; set; } = "#309556";

        /// <summary>
        ///  二级文本色
        /// </summary>
        public  string TextSecondary { get; set; } = "#ABB2BF";

        /// <summary>
        ///  三级文本色（小清除按钮）
        /// </summary>
        public  string TextTertiary { get; set; } = "#828997";

        /// <summary>
        ///  四级文本色（禁用色）
        /// </summary>
        public  string TextQuaternary { get; set; } = "#636D7A";

        /// <summary>
        ///  基础背景色
        /// </summary>
        public  string BgBase { get; set; } = "#282C34";

        /// <summary>
        ///  组件的容器背景色 例如：默认按钮、输入框等。务必不要将其与 `colorBgElevated` 混淆。
        /// </summary>
        public  string BgContainer { get; set; } = "#2F333D";

        /// <summary>
        ///  浮层容器背景色，在暗色模式下该 token 的色值会比 `colorBgContainer` 要亮一些。例如：模态框、弹出框、菜单等。
        /// </summary>
        public  string BgElevated { get; set; } = "#2F333D";

        /// <summary>
        ///  该色用于页面整体布局的背景色，只有需要在页面中处于 B1 的视觉层级时才会使用该 token，其他用法都是错误的
        /// </summary>
        public  string BgLayout { get; set; } = "#282C34";

        /// <summary>
        ///  一级填充色
        /// </summary>
        public  string Fill { get; set; } = "#2F333D";

        /// <summary>
        ///  二级填充色（分页悬浮态、菜单悬浮态）
        /// </summary>
        public  string FillSecondary { get; set; } = "#4B515D";

        /// <summary>
        ///  三级填充色（下拉悬浮态）
        /// </summary>
        public  string FillTertiary { get; set; } = "#5C6370";

        /// <summary>
        ///  四级填充色（幽灵按钮底部）
        /// </summary>
        public  string FillQuaternary { get; set; } = "#22252D";

        /// <summary>
        ///  边框颜色
        /// </summary>
        public  string BorderColor { get; set; } = "#5C6370";
        public  string BorderSecondary { get; set; } = "#6C7380";

        /// <summary>
        ///  禁用边框颜色
        /// </summary>
        public  string BorderColorDisable { get; set; } = "#7D8491";

        /// <summary>
        ///  用于作为分割线的颜色，此颜色和 BorderSecondary 的颜色一致，但是用的是透明色
        /// </summary>
        public  string Split { get; set; } = "#5C6370";

        /// <summary>
        ///  选项悬浮态背景颜色
        /// </summary>
        public  string HoverBg { get; set; } = "#4B515D";

        /// <summary>
        ///  选项悬浮态文本颜色
        /// </summary>
        public  string HoverColor { get; set; } = "#A2A8AE";
        public  string SliderHandleColorDisabled { get; set; } = "#7D8491";
    }
}
