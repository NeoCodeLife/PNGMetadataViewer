namespace PNGMetadataViewer.UserControls
{
    partial class EasyCopyInputBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputBox = new AntdUI.Input();
            this.Copy_button = new AntdUI.Button();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputBox.Location = new System.Drawing.Point(0, 0);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(120, 40);
            this.InputBox.TabIndex = 0;
            this.InputBox.Text = "input1";
            this.InputBox.MouseEnter += new System.EventHandler(this.InputBox_MouseEnter);
            this.InputBox.MouseLeave += new System.EventHandler(this.InputBox_MouseLeave);
            // 
            // Copy_button
            // 
            this.Copy_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Copy_button.Location = new System.Drawing.Point(95, 0);
            this.Copy_button.Name = "Copy_button";
            this.Copy_button.Radius = 2;
            this.Copy_button.Size = new System.Drawing.Size(25, 40);
            this.Copy_button.TabIndex = 1;
            this.Copy_button.Text = "C";
            this.Copy_button.Visible = false;
            this.Copy_button.Click += new System.EventHandler(this.Copy_button_Click);
            this.Copy_button.MouseEnter += new System.EventHandler(this.Copy_button_MouseEnter);
            this.Copy_button.MouseLeave += new System.EventHandler(this.Copy_button_MouseLeave);
            // 
            // EasyCopyInputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Copy_button);
            this.Controls.Add(this.InputBox);
            this.Name = "EasyCopyInputBox";
            this.Size = new System.Drawing.Size(120, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Input InputBox;
        private AntdUI.Button Copy_button;
    }
}
