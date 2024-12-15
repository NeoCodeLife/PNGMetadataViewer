namespace PNGMetadataViewer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Workflow_Input = new AntdUI.Input();
            this.CheckPointName_Label = new AntdUI.Label();
            this.Prompt_input = new AntdUI.Input();
            this.Prompt_label = new AntdUI.Label();
            this.Steps_label = new AntdUI.Label();
            this.Step_input = new AntdUI.Input();
            this.CFG_label = new AntdUI.Label();
            this.CFG_input = new AntdUI.Input();
            this.Sampler_label = new AntdUI.Label();
            this.Sampler_input = new AntdUI.Input();
            this.Seed_label = new AntdUI.Label();
            this.Seed_input = new AntdUI.Input();
            this.PreviewImage_panel = new AntdUI.Panel();
            this.Info_panel = new System.Windows.Forms.Panel();
            this.Setting_button = new AntdUI.Button();
            this.Start_Button = new AntdUI.Button();
            this.Denoise_input = new AntdUI.Input();
            this.Scheduler_input = new AntdUI.Input();
            this.label2 = new AntdUI.Label();
            this.Workflow_label = new AntdUI.Label();
            this.Scheduler_label = new AntdUI.Label();
            this.FilePath_input = new AntdUI.Input();
            this.ImageSize_input = new AntdUI.Input();
            this.CheckPointName_Input = new AntdUI.Input();
            this.FilePath_label = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pageHeader1 = new AntdUI.PageHeader();
            this.Info_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Workflow_Input
            // 
            this.Workflow_Input.AutoScroll = true;
            this.Workflow_Input.BorderWidth = 0F;
            this.Workflow_Input.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.Workflow_Input.Location = new System.Drawing.Point(14, 523);
            this.Workflow_Input.Multiline = true;
            this.Workflow_Input.Name = "Workflow_Input";
            this.Workflow_Input.Size = new System.Drawing.Size(440, 155);
            this.Workflow_Input.TabIndex = 13;
            // 
            // CheckPointName_Label
            // 
            this.CheckPointName_Label.LocalizationText = "CheckPointName";
            this.CheckPointName_Label.Location = new System.Drawing.Point(18, 134);
            this.CheckPointName_Label.Name = "CheckPointName_Label";
            this.CheckPointName_Label.Size = new System.Drawing.Size(283, 23);
            this.CheckPointName_Label.TabIndex = 19;
            this.CheckPointName_Label.Text = "Checkpoint";
            // 
            // Prompt_input
            // 
            this.Prompt_input.AutoScroll = true;
            this.Prompt_input.BorderWidth = 0F;
            this.Prompt_input.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.Prompt_input.Location = new System.Drawing.Point(14, 331);
            this.Prompt_input.Multiline = true;
            this.Prompt_input.Name = "Prompt_input";
            this.Prompt_input.Size = new System.Drawing.Size(440, 162);
            this.Prompt_input.TabIndex = 12;
            // 
            // Prompt_label
            // 
            this.Prompt_label.LocalizationText = "Prompt";
            this.Prompt_label.Location = new System.Drawing.Point(18, 312);
            this.Prompt_label.Name = "Prompt_label";
            this.Prompt_label.Size = new System.Drawing.Size(431, 23);
            this.Prompt_label.TabIndex = 19;
            this.Prompt_label.Text = "Prompt";
            // 
            // Steps_label
            // 
            this.Steps_label.LocalizationText = "Steps";
            this.Steps_label.Location = new System.Drawing.Point(167, 194);
            this.Steps_label.Name = "Steps_label";
            this.Steps_label.Size = new System.Drawing.Size(130, 23);
            this.Steps_label.TabIndex = 19;
            this.Steps_label.Text = "Steps";
            // 
            // Step_input
            // 
            this.Step_input.BorderWidth = 0F;
            this.Step_input.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.Step_input.Location = new System.Drawing.Point(163, 212);
            this.Step_input.Name = "Step_input";
            this.Step_input.Size = new System.Drawing.Size(140, 34);
            this.Step_input.TabIndex = 7;
            // 
            // CFG_label
            // 
            this.CFG_label.LocalizationText = "CFG";
            this.CFG_label.Location = new System.Drawing.Point(313, 194);
            this.CFG_label.Name = "CFG_label";
            this.CFG_label.Size = new System.Drawing.Size(148, 23);
            this.CFG_label.TabIndex = 19;
            this.CFG_label.Text = "CFG";
            // 
            // CFG_input
            // 
            this.CFG_input.BorderWidth = 0F;
            this.CFG_input.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.CFG_input.Location = new System.Drawing.Point(312, 212);
            this.CFG_input.Name = "CFG_input";
            this.CFG_input.Size = new System.Drawing.Size(140, 34);
            this.CFG_input.TabIndex = 8;
            // 
            // Sampler_label
            // 
            this.Sampler_label.LocalizationText = "Sampler";
            this.Sampler_label.Location = new System.Drawing.Point(18, 253);
            this.Sampler_label.Name = "Sampler_label";
            this.Sampler_label.Size = new System.Drawing.Size(135, 23);
            this.Sampler_label.TabIndex = 19;
            this.Sampler_label.Text = "Sampler";
            // 
            // Sampler_input
            // 
            this.Sampler_input.BorderWidth = 0F;
            this.Sampler_input.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.Sampler_input.Location = new System.Drawing.Point(14, 272);
            this.Sampler_input.Name = "Sampler_input";
            this.Sampler_input.Size = new System.Drawing.Size(140, 34);
            this.Sampler_input.TabIndex = 9;
            // 
            // Seed_label
            // 
            this.Seed_label.LocalizationText = "Seed";
            this.Seed_label.Location = new System.Drawing.Point(18, 194);
            this.Seed_label.Name = "Seed_label";
            this.Seed_label.Size = new System.Drawing.Size(134, 23);
            this.Seed_label.TabIndex = 19;
            this.Seed_label.Text = "Seed";
            // 
            // Seed_input
            // 
            this.Seed_input.BorderWidth = 0F;
            this.Seed_input.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.Seed_input.Location = new System.Drawing.Point(14, 212);
            this.Seed_input.Name = "Seed_input";
            this.Seed_input.Size = new System.Drawing.Size(140, 34);
            this.Seed_input.TabIndex = 6;
            // 
            // PreviewImage_panel
            // 
            this.PreviewImage_panel.BackgroundImageLayout = AntdUI.TFit.Contain;
            this.PreviewImage_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewImage_panel.Location = new System.Drawing.Point(10, 40);
            this.PreviewImage_panel.Name = "PreviewImage_panel";
            this.PreviewImage_panel.Size = new System.Drawing.Size(424, 635);
            this.PreviewImage_panel.TabIndex = 22;
            this.PreviewImage_panel.Text = "PreviewImage_panel";
            // 
            // Info_panel
            // 
            this.Info_panel.Controls.Add(this.Setting_button);
            this.Info_panel.Controls.Add(this.Start_Button);
            this.Info_panel.Controls.Add(this.Denoise_input);
            this.Info_panel.Controls.Add(this.Seed_input);
            this.Info_panel.Controls.Add(this.Scheduler_input);
            this.Info_panel.Controls.Add(this.Sampler_input);
            this.Info_panel.Controls.Add(this.CFG_input);
            this.Info_panel.Controls.Add(this.label2);
            this.Info_panel.Controls.Add(this.Workflow_Input);
            this.Info_panel.Controls.Add(this.Seed_label);
            this.Info_panel.Controls.Add(this.Workflow_label);
            this.Info_panel.Controls.Add(this.Step_input);
            this.Info_panel.Controls.Add(this.Scheduler_label);
            this.Info_panel.Controls.Add(this.Steps_label);
            this.Info_panel.Controls.Add(this.Sampler_label);
            this.Info_panel.Controls.Add(this.FilePath_input);
            this.Info_panel.Controls.Add(this.ImageSize_input);
            this.Info_panel.Controls.Add(this.CheckPointName_Input);
            this.Info_panel.Controls.Add(this.CFG_label);
            this.Info_panel.Controls.Add(this.Prompt_input);
            this.Info_panel.Controls.Add(this.label1);
            this.Info_panel.Controls.Add(this.CheckPointName_Label);
            this.Info_panel.Controls.Add(this.Prompt_label);
            this.Info_panel.Controls.Add(this.FilePath_label);
            this.Info_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Info_panel.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.Info_panel.Location = new System.Drawing.Point(0, 0);
            this.Info_panel.Name = "Info_panel";
            this.Info_panel.Size = new System.Drawing.Size(460, 685);
            this.Info_panel.TabIndex = 22;
            // 
            // Setting_button
            // 
            this.Setting_button.LocalizationText = "Setting";
            this.Setting_button.Location = new System.Drawing.Point(380, 88);
            this.Setting_button.Name = "Setting_button";
            this.Setting_button.Size = new System.Drawing.Size(72, 32);
            this.Setting_button.TabIndex = 3;
            this.Setting_button.Text = "Setting";
            this.Setting_button.Click += new System.EventHandler(this.Setting_button_Click);
            // 
            // Start_Button
            // 
            this.Start_Button.LocalizationText = "Start";
            this.Start_Button.Location = new System.Drawing.Point(380, 57);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(72, 32);
            this.Start_Button.TabIndex = 2;
            this.Start_Button.Text = "Start";
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Denoise_input
            // 
            this.Denoise_input.BorderWidth = 0F;
            this.Denoise_input.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.Denoise_input.Location = new System.Drawing.Point(312, 272);
            this.Denoise_input.Name = "Denoise_input";
            this.Denoise_input.Size = new System.Drawing.Size(140, 34);
            this.Denoise_input.TabIndex = 11;
            // 
            // Scheduler_input
            // 
            this.Scheduler_input.BorderWidth = 0F;
            this.Scheduler_input.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.Scheduler_input.Location = new System.Drawing.Point(163, 272);
            this.Scheduler_input.Name = "Scheduler_input";
            this.Scheduler_input.Size = new System.Drawing.Size(140, 34);
            this.Scheduler_input.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.LocalizationText = "Denoise";
            this.label2.Location = new System.Drawing.Point(315, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Denoise";
            // 
            // Workflow_label
            // 
            this.Workflow_label.LocalizationText = "Workflow";
            this.Workflow_label.Location = new System.Drawing.Point(18, 505);
            this.Workflow_label.Name = "Workflow_label";
            this.Workflow_label.Size = new System.Drawing.Size(431, 23);
            this.Workflow_label.TabIndex = 19;
            this.Workflow_label.Text = "Workflow ComfyUI";
            // 
            // Scheduler_label
            // 
            this.Scheduler_label.LocalizationText = "Scheduler";
            this.Scheduler_label.Location = new System.Drawing.Point(167, 253);
            this.Scheduler_label.Name = "Scheduler_label";
            this.Scheduler_label.Size = new System.Drawing.Size(130, 23);
            this.Scheduler_label.TabIndex = 19;
            this.Scheduler_label.Text = "Scheduler";
            // 
            // FilePath_input
            // 
            this.FilePath_input.BorderWidth = 0F;
            this.FilePath_input.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.FilePath_input.LocalizationPlaceholderText = "Drop the PNG file here";
            this.FilePath_input.Location = new System.Drawing.Point(14, 58);
            this.FilePath_input.Multiline = true;
            this.FilePath_input.Name = "FilePath_input";
            this.FilePath_input.PlaceholderText = "Drop the PNG file here";
            this.FilePath_input.Size = new System.Drawing.Size(360, 63);
            this.FilePath_input.TabIndex = 1;
            // 
            // ImageSize_input
            // 
            this.ImageSize_input.BorderWidth = 0F;
            this.ImageSize_input.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.ImageSize_input.Location = new System.Drawing.Point(311, 152);
            this.ImageSize_input.Name = "ImageSize_input";
            this.ImageSize_input.Size = new System.Drawing.Size(140, 34);
            this.ImageSize_input.TabIndex = 5;
            // 
            // CheckPointName_Input
            // 
            this.CheckPointName_Input.BorderWidth = 0F;
            this.CheckPointName_Input.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.CheckPointName_Input.Location = new System.Drawing.Point(14, 152);
            this.CheckPointName_Input.Name = "CheckPointName_Input";
            this.CheckPointName_Input.Size = new System.Drawing.Size(290, 34);
            this.CheckPointName_Input.TabIndex = 4;
            // 
            // FilePath_label
            // 
            this.FilePath_label.LocalizationText = "FilePath";
            this.FilePath_label.Location = new System.Drawing.Point(18, 39);
            this.FilePath_label.Name = "FilePath_label";
            this.FilePath_label.Size = new System.Drawing.Size(87, 23);
            this.FilePath_label.TabIndex = 16;
            this.FilePath_label.Text = "File Path";
            // 
            // label1
            // 
            this.label1.LocalizationText = "ImageSize";
            this.label1.Location = new System.Drawing.Point(313, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Image Size";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Info_panel);
            this.splitContainer1.Panel1MinSize = 460;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PreviewImage_panel);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10, 40, 10, 10);
            this.splitContainer1.Size = new System.Drawing.Size(908, 685);
            this.splitContainer1.SplitterDistance = 460;
            this.splitContainer1.TabIndex = 23;
            // 
            // pageHeader1
            // 
            this.pageHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageHeader1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.pageHeader1.Icon = ((System.Drawing.Image)(resources.GetObject("pageHeader1.Icon")));
            this.pageHeader1.LocalizationText = "AppName";
            this.pageHeader1.Location = new System.Drawing.Point(0, 0);
            this.pageHeader1.Name = "pageHeader1";
            this.pageHeader1.ShowButton = true;
            this.pageHeader1.ShowIcon = true;
            this.pageHeader1.Size = new System.Drawing.Size(908, 34);
            this.pageHeader1.TabIndex = 1;
            this.pageHeader1.Text = "PNG Metadata Viewer (Support ComfyUI and WebUI) - by 程序员小枫";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(908, 685);
            this.Controls.Add(this.pageHeader1);
            this.Controls.Add(this.splitContainer1);
            this.Dark = true;
            this.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Mode = AntdUI.TAMode.Dark;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PNG Metadata Viewer (Support ComfyUI and WebUI) - by 程序员小枫";
            this.UseDwm = false;
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.Info_panel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Input Workflow_Input;
        private AntdUI.Label CheckPointName_Label;
        private AntdUI.Input Prompt_input;
        private AntdUI.Label Prompt_label;
        private AntdUI.Label Steps_label;
        private AntdUI.Input Step_input;
        private AntdUI.Label CFG_label;
        private AntdUI.Input CFG_input;
        private AntdUI.Label Sampler_label;
        private AntdUI.Input Sampler_input;
        private AntdUI.Label Seed_label;
        private AntdUI.Input Seed_input;
        private AntdUI.Panel PreviewImage_panel;
        private System.Windows.Forms.Panel Info_panel;
        private AntdUI.Input FilePath_input;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private AntdUI.Label FilePath_label;
        private AntdUI.Button Start_Button;
        private AntdUI.Label label1;
        private AntdUI.Input ImageSize_input;
        private AntdUI.Input Scheduler_input;
        private AntdUI.Label Scheduler_label;
        private AntdUI.Label Workflow_label;
        private AntdUI.Input CheckPointName_Input;
        private AntdUI.Input Denoise_input;
        private AntdUI.Label label2;
        private AntdUI.Button Setting_button;
    }
}