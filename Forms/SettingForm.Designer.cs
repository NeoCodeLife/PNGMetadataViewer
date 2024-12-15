namespace PNGMetadataViewer.Forms
{
    partial class SettingForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.DarkTheme_button = new AntdUI.Button();
            this.Chinese_button = new AntdUI.Button();
            this.label1 = new AntdUI.Label();
            this.panel1 = new AntdUI.Panel();
            this.Text_colorPicker = new AntdUI.ColorPicker();
            this.button1 = new AntdUI.Button();
            this.divider1 = new AntdUI.Divider();
            this.label4 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.Email = new AntdUI.Label();
            this.label6 = new AntdUI.Label();
            this.image3D1 = new AntdUI.Image3D();
            this.Default_Color_button = new AntdUI.Button();
            this.Feedback_button = new AntdUI.Button();
            this.LigthTheme_button = new AntdUI.Button();
            this.English_button = new AntdUI.Button();
            this.RemoveFromContextMenu_button = new AntdUI.Button();
            this.AddToContextMenu_button = new AntdUI.Button();
            this.label2 = new AntdUI.Label();
            this.AntdUI_Url_input = new AntdUI.Input();
            this.MetadataExtractor_Url_input = new AntdUI.Input();
            this.pageHeader1 = new AntdUI.PageHeader();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DarkTheme_button
            // 
            this.DarkTheme_button.LocalizationText = "DarkTheme";
            this.DarkTheme_button.Location = new System.Drawing.Point(81, 10);
            this.DarkTheme_button.Name = "DarkTheme_button";
            this.DarkTheme_button.Size = new System.Drawing.Size(98, 34);
            this.DarkTheme_button.TabIndex = 1;
            this.DarkTheme_button.Text = "Dark";
            this.DarkTheme_button.Click += new System.EventHandler(this.DarkTheme_button_Click);
            // 
            // Chinese_button
            // 
            this.Chinese_button.LocalizationText = "中文";
            this.Chinese_button.Location = new System.Drawing.Point(81, 50);
            this.Chinese_button.Name = "Chinese_button";
            this.Chinese_button.Size = new System.Drawing.Size(98, 34);
            this.Chinese_button.TabIndex = 1;
            this.Chinese_button.Text = "中文";
            this.Chinese_button.Click += new System.EventHandler(this.Chinese_button_Click);
            // 
            // label1
            // 
            this.label1.LocalizationText = "Theme";
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Theme";
            // 
            // panel1
            // 
            this.panel1.Back = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Feedback_button);
            this.panel1.Controls.Add(this.Text_colorPicker);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.divider1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.image3D1);
            this.panel1.Controls.Add(this.Default_Color_button);
            this.panel1.Controls.Add(this.LigthTheme_button);
            this.panel1.Controls.Add(this.DarkTheme_button);
            this.panel1.Controls.Add(this.English_button);
            this.panel1.Controls.Add(this.RemoveFromContextMenu_button);
            this.panel1.Controls.Add(this.AddToContextMenu_button);
            this.panel1.Controls.Add(this.Chinese_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AntdUI_Url_input);
            this.panel1.Controls.Add(this.MetadataExtractor_Url_input);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 368);
            this.panel1.TabIndex = 3;
            this.panel1.Text = "Setting";
            // 
            // Text_colorPicker
            // 
            this.Text_colorPicker.Location = new System.Drawing.Point(159, 89);
            this.Text_colorPicker.Name = "Text_colorPicker";
            this.Text_colorPicker.Size = new System.Drawing.Size(45, 38);
            this.Text_colorPicker.TabIndex = 12;
            this.Text_colorPicker.Text = "colorPicker1";
            this.Text_colorPicker.Value = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.Text_colorPicker.ValueChanged += new AntdUI.ColorEventHandler(this.Text_colorPicker_ValueChanged);
            // 
            // button1
            // 
            this.button1.LocalizationText = "Buy me a coffee";
            this.button1.Location = new System.Drawing.Point(287, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buy me a coffee";
            this.button1.Click += new System.EventHandler(this.Feedback_button_Click);
            // 
            // divider1
            // 
            this.divider1.LocalizationText = "Acknowledgments";
            this.divider1.Location = new System.Drawing.Point(27, 252);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(459, 23);
            this.divider1.TabIndex = 10;
            this.divider1.Text = "Acknowledgments";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.label4.Location = new System.Drawing.Point(25, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "AntdUI";
            // 
            // label3
            // 
            this.label3.LocalizationText = "Change Text Color";
            this.label3.Location = new System.Drawing.Point(27, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Change Text Color";
            // 
            // Email
            // 
            this.Email.LocalizationText = "Email";
            this.Email.Location = new System.Drawing.Point(25, 215);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(188, 23);
            this.Email.TabIndex = 7;
            this.Email.Text = "Email: neo_code@qq.com";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.label6.Location = new System.Drawing.Point(25, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 46);
            this.label6.TabIndex = 8;
            this.label6.Text = "Metadata Extractor";
            // 
            // image3D1
            // 
            this.image3D1.Image = global::PNGMetadataViewer.Properties.Resources.wechat;
            this.image3D1.ImageFit = AntdUI.TFit.Contain;
            this.image3D1.Location = new System.Drawing.Point(288, 11);
            this.image3D1.Name = "image3D1";
            this.image3D1.Radius = 12;
            this.image3D1.Size = new System.Drawing.Size(198, 191);
            this.image3D1.TabIndex = 5;
            this.image3D1.Text = "image3D1";
            // 
            // Default_Color_button
            // 
            this.Default_Color_button.LocalizationText = "Default";
            this.Default_Color_button.Location = new System.Drawing.Point(205, 89);
            this.Default_Color_button.Name = "Default_Color_button";
            this.Default_Color_button.Size = new System.Drawing.Size(73, 38);
            this.Default_Color_button.TabIndex = 4;
            this.Default_Color_button.Text = "Default";
            this.Default_Color_button.Click += new System.EventHandler(this.Default_Color_button_Click);
            // 
            // Feedback_button
            // 
            this.Feedback_button.LocalizationText = "Copy";
            this.Feedback_button.Location = new System.Drawing.Point(205, 209);
            this.Feedback_button.Name = "Feedback_button";
            this.Feedback_button.Size = new System.Drawing.Size(73, 34);
            this.Feedback_button.TabIndex = 4;
            this.Feedback_button.Text = "Copy";
            this.Feedback_button.Click += new System.EventHandler(this.Feedback_button_Click);
            // 
            // LigthTheme_button
            // 
            this.LigthTheme_button.LocalizationText = "LightTheme";
            this.LigthTheme_button.Location = new System.Drawing.Point(180, 10);
            this.LigthTheme_button.Name = "LigthTheme_button";
            this.LigthTheme_button.Size = new System.Drawing.Size(98, 34);
            this.LigthTheme_button.TabIndex = 1;
            this.LigthTheme_button.Text = "Light";
            this.LigthTheme_button.Click += new System.EventHandler(this.LigthTheme_button_Click);
            // 
            // English_button
            // 
            this.English_button.LocalizationText = "English";
            this.English_button.Location = new System.Drawing.Point(180, 50);
            this.English_button.Name = "English_button";
            this.English_button.Size = new System.Drawing.Size(98, 34);
            this.English_button.TabIndex = 1;
            this.English_button.Text = "English";
            this.English_button.Click += new System.EventHandler(this.English_button_Click);
            // 
            // RemoveFromContextMenu_button
            // 
            this.RemoveFromContextMenu_button.LocalizationText = "Remove From Contextmenu";
            this.RemoveFromContextMenu_button.Location = new System.Drawing.Point(23, 171);
            this.RemoveFromContextMenu_button.Name = "RemoveFromContextMenu_button";
            this.RemoveFromContextMenu_button.Size = new System.Drawing.Size(255, 34);
            this.RemoveFromContextMenu_button.TabIndex = 1;
            this.RemoveFromContextMenu_button.Text = "Remove From Context menu";
            this.RemoveFromContextMenu_button.Click += new System.EventHandler(this.RemoveContextMenu_button_Click);
            // 
            // AddToContextMenu_button
            // 
            this.AddToContextMenu_button.LocalizationText = "Add To Contextmenu";
            this.AddToContextMenu_button.Location = new System.Drawing.Point(23, 138);
            this.AddToContextMenu_button.Name = "AddToContextMenu_button";
            this.AddToContextMenu_button.Size = new System.Drawing.Size(255, 34);
            this.AddToContextMenu_button.TabIndex = 1;
            this.AddToContextMenu_button.Text = "Add to Context menu";
            this.AddToContextMenu_button.Click += new System.EventHandler(this.AddToContextMenu_button_Click);
            // 
            // label2
            // 
            this.label2.LocalizationText = "Language";
            this.label2.Location = new System.Drawing.Point(27, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lang";
            // 
            // AntdUI_Url_input
            // 
            this.AntdUI_Url_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.AntdUI_Url_input.BorderActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.AntdUI_Url_input.BorderHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.AntdUI_Url_input.BorderWidth = 0F;
            this.AntdUI_Url_input.Location = new System.Drawing.Point(112, 277);
            this.AntdUI_Url_input.Margin = new System.Windows.Forms.Padding(0);
            this.AntdUI_Url_input.Name = "AntdUI_Url_input";
            this.AntdUI_Url_input.ReadOnly = true;
            this.AntdUI_Url_input.Size = new System.Drawing.Size(348, 32);
            this.AntdUI_Url_input.TabIndex = 11;
            this.AntdUI_Url_input.Text = "https://github.com/AntdUI/AntdUI";
            this.AntdUI_Url_input.WaveSize = 0;
            this.AntdUI_Url_input.TextChanged += new System.EventHandler(this.AntdUI_Url_input_TextChanged);
            // 
            // MetadataExtractor_Url_input
            // 
            this.MetadataExtractor_Url_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.MetadataExtractor_Url_input.BorderActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.MetadataExtractor_Url_input.BorderHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.MetadataExtractor_Url_input.BorderWidth = 0F;
            this.MetadataExtractor_Url_input.Location = new System.Drawing.Point(112, 303);
            this.MetadataExtractor_Url_input.Margin = new System.Windows.Forms.Padding(0);
            this.MetadataExtractor_Url_input.Multiline = true;
            this.MetadataExtractor_Url_input.Name = "MetadataExtractor_Url_input";
            this.MetadataExtractor_Url_input.ReadOnly = true;
            this.MetadataExtractor_Url_input.Size = new System.Drawing.Size(384, 55);
            this.MetadataExtractor_Url_input.TabIndex = 11;
            this.MetadataExtractor_Url_input.Text = "https://github.com/drewnoakes/metadata-extractor-dotnet";
            this.MetadataExtractor_Url_input.WaveSize = 0;
            this.MetadataExtractor_Url_input.TextChanged += new System.EventHandler(this.MetadataExtractor_Url_input_TextChanged);
            // 
            // pageHeader1
            // 
            this.pageHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageHeader1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.pageHeader1.Icon = global::PNGMetadataViewer.Properties.Resources.logo;
            this.pageHeader1.LocalizationText = "Setting";
            this.pageHeader1.Location = new System.Drawing.Point(0, 0);
            this.pageHeader1.Name = "pageHeader1";
            this.pageHeader1.ShowButton = true;
            this.pageHeader1.ShowIcon = true;
            this.pageHeader1.Size = new System.Drawing.Size(507, 30);
            this.pageHeader1.TabIndex = 0;
            this.pageHeader1.Text = "Setting";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(507, 398);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pageHeader1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutForm";
            this.UseDwm = false;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Button DarkTheme_button;
        private AntdUI.Button Chinese_button;
        private AntdUI.Label label1;
        private AntdUI.Panel panel1;
        private AntdUI.Button LigthTheme_button;
        private AntdUI.Button English_button;
        private AntdUI.Label label2;
        private AntdUI.Button AddToContextMenu_button;
        private AntdUI.Button RemoveFromContextMenu_button;
        private AntdUI.Button Feedback_button;
        private AntdUI.Image3D image3D1;
        private AntdUI.Label label4;
        private AntdUI.Label label6;
        private AntdUI.Divider divider1;
        private AntdUI.Input MetadataExtractor_Url_input;
        private AntdUI.Input AntdUI_Url_input;
        private AntdUI.Label Email;
        private AntdUI.Button button1;
        private AntdUI.ColorPicker Text_colorPicker;
        private AntdUI.Label label3;
        private AntdUI.Button Default_Color_button;
    }
}