using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PNGMetadataViewer.UserControls
{
    public partial class EasyCopyInputBox : UserControl
    {
        private bool isCopyButtonHover = false;

        [Category("外观")]
        [Description("Sets the text of the label.")]
        public string Value 
        {
            get { return InputBox.Text; }
            set { InputBox.Text = value; }
        }

        public EasyCopyInputBox()
        {
            InitializeComponent();
        }

        private void Copy_button_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(InputBox.Text);
                AntdUI.Message.success(this.ParentForm, AntdUI.Localization.Get("Copied", "Copied"));
            }
            catch (Exception ex)
            {
                AntdUI.Message.error(this.ParentForm, ex.Message);
            }

        }

        private void InputBox_MouseLeave(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Thread.Sleep(10);
                if (!isCopyButtonHover)
                {
                    CheckForIllegalCrossThreadCalls = false;
                    Copy_button.Visible = false;
                }
            });
        }


        private void InputBox_MouseEnter(object sender, EventArgs e)
        {
            Copy_button.Visible = true;
        }

        private void Copy_button_MouseEnter(object sender, EventArgs e)
        {
            Copy_button.Visible = true;
            isCopyButtonHover = true;
        }

        private void Copy_button_MouseLeave(object sender, EventArgs e)
        {
            isCopyButtonHover = false;
            Copy_button.Visible = false;
        }
    }
}
