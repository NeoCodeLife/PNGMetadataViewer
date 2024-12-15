using Microsoft.Win32;
using PNGMetadataViewer.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace PNGMetadataViewer.Utils
{
    /// <summary>
    /// 辅助类，用于将应用程序添加到或从Windows资源管理器右键菜单移除。
    /// </summary>
    public static class ContextMenuHelper
    {
        private const string AppName = "PNG元数据查看器"; // 应用程序名称
        private const string CommandKey = "Command"; // 注册表命令键名
        // 注意下面路径中的".png", 只把选项添加到 png 文件的右键菜单中
        private const string RegistryPath = @"Software\Classes\SystemFileAssociations\.png\shell\" + AppName;
        private const string CommandRegistryPath = RegistryPath + @"\command";

        /// <summary>
        /// 将应用程序添加到右键菜单。
        /// </summary>
        /// <param name="exePath">应用程序可执行文件路径。</param>
        /// <param name="iconPath">图标文件路径（.ico, .exe, 或 .dll），如果不需要图标则为 null。</param>
        public static bool AddToContextMenu(string exePath, string iconPath = null)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryPath))
                {
                    if (key != null)
                    {
                        key.SetValue(null, $"用 {AppName} 查看"); // 设置右键菜单显示文本
                        if (string.IsNullOrEmpty(iconPath))
                        {
                            iconPath = Path.Combine(Application.StartupPath, "Resources", "favicon.ico");
                        }
                        // 设置图标路径
                        key.SetValue("Icon", iconPath);
                        key.Close();
                    }
                }

                using (RegistryKey commandKey = Registry.CurrentUser.CreateSubKey(CommandRegistryPath))
                {
                    if (commandKey != null)
                    {
                        // 设置点击右键菜单项时执行的命令
                        commandKey.SetValue(null, $"\"{exePath}\" \"%1\"");
                        commandKey.Close();
                    }
                }
                AntdUI.Message.success(Form.ActiveForm, "添加到右键菜单成功");
                return true;
            }
            catch (Exception ex)
            {
                AntdUI.Message.error(Form.ActiveForm, "添加到右键菜单失败：" + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 从右键菜单移除应用程序。
        /// </summary>
        public static void RemoveFromContextMenu()
        {
            try
            {
                // 删除命令执行路径
                Registry.CurrentUser.DeleteSubKeyTree(CommandRegistryPath);
                // 删除右键菜单项路径
                Registry.CurrentUser.DeleteSubKeyTree(RegistryPath);
                AntdUI.Message.success(Form.ActiveForm, "已从右键菜单移除");
            }
            catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
            {
                AntdUI.Message.success(Form.ActiveForm, "不在右键菜单中，不需要移除");
                // 忽略异常，因为这些异常可能表示键不存在
            }
        }
    }
}