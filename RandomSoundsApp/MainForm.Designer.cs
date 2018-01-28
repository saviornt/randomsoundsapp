﻿// <copyright file="MainForm.Designer.cs" company="PublicDomain.com">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
// <auto-generated />
namespace RandomSoundsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
        	this.components = new System.ComponentModel.Container();
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        	this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
        	this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.scanDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        	this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.headquartersPatreoncomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        	this.originalThreadDonationCodercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
        	this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
        	this.mainToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.headerLabel = new System.Windows.Forms.Label();
        	this.onRadioButton = new System.Windows.Forms.RadioButton();
        	this.offRadioButton = new System.Windows.Forms.RadioButton();
        	this.label2 = new System.Windows.Forms.Label();
        	this.settingsLabel = new System.Windows.Forms.Label();
        	this.everyIntervalRadioButton = new System.Windows.Forms.RadioButton();
        	this.randomIntervalRadioButton = new System.Windows.Forms.RadioButton();
        	this.onOffPanel = new System.Windows.Forms.Panel();
        	this.everyIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
        	this.minutesLabel = new System.Windows.Forms.Label();
        	this.randomIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
        	this.minuteIntervalLabel = new System.Windows.Forms.Label();
        	this.inEveryLabel = new System.Windows.Forms.Label();
        	this.label7 = new System.Windows.Forms.Label();
        	this.startCheckBox = new System.Windows.Forms.CheckBox();
        	this.exactTimer = new System.Windows.Forms.Timer(this.components);
        	this.randomIntervalTimer = new System.Windows.Forms.Timer(this.components);
        	this.mainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
        	this.notifyContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.notifyExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.mainMenuStrip.SuspendLayout();
        	this.mainStatusStrip.SuspendLayout();
        	this.onOffPanel.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.everyIntervalNumericUpDown)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.randomIntervalNumericUpDown)).BeginInit();
        	this.notifyContextMenuStrip.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// mainMenuStrip
        	// 
        	this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.fileToolStripMenuItem,
        	        	        	this.helpToolStripMenuItem});
        	this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
        	this.mainMenuStrip.Name = "mainMenuStrip";
        	this.mainMenuStrip.Size = new System.Drawing.Size(260, 24);
        	this.mainMenuStrip.TabIndex = 4;
        	// 
        	// fileToolStripMenuItem
        	// 
        	this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.scanDirectoryToolStripMenuItem,
        	        	        	this.toolStripSeparator2,
        	        	        	this.exitToolStripMenuItem});
        	this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        	this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        	this.fileToolStripMenuItem.Text = "&File";
        	// 
        	// scanDirectoryToolStripMenuItem
        	// 
        	this.scanDirectoryToolStripMenuItem.Name = "scanDirectoryToolStripMenuItem";
        	this.scanDirectoryToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
        	this.scanDirectoryToolStripMenuItem.Text = "&Scan directory";
        	this.scanDirectoryToolStripMenuItem.Click += new System.EventHandler(this.OnScanDirectoryToolStripMenuItemClick);
        	// 
        	// toolStripSeparator2
        	// 
        	this.toolStripSeparator2.Name = "toolStripSeparator2";
        	this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
        	// 
        	// exitToolStripMenuItem
        	// 
        	this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        	this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
        	this.exitToolStripMenuItem.Text = "E&xit";
        	this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
        	// 
        	// helpToolStripMenuItem
        	// 
        	this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.headquartersPatreoncomToolStripMenuItem,
        	        	        	this.sourceCodeGithubcomToolStripMenuItem,
        	        	        	this.toolStripSeparator1,
        	        	        	this.originalThreadDonationCodercomToolStripMenuItem,
        	        	        	this.toolStripSeparator5,
        	        	        	this.aboutToolStripMenuItem});
        	this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        	this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
        	this.helpToolStripMenuItem.Text = "&Help";
        	// 
        	// headquartersPatreoncomToolStripMenuItem
        	// 
        	this.headquartersPatreoncomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("headquartersPatreoncomToolStripMenuItem.Image")));
        	this.headquartersPatreoncomToolStripMenuItem.Name = "headquartersPatreoncomToolStripMenuItem";
        	this.headquartersPatreoncomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
        	this.headquartersPatreoncomToolStripMenuItem.Text = "Headquarters @ Patreon.com";
        	this.headquartersPatreoncomToolStripMenuItem.Click += new System.EventHandler(this.OnHeadquartersPatreoncomToolStripMenuItemClick);
        	// 
        	// sourceCodeGithubcomToolStripMenuItem
        	// 
        	this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
        	this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
        	this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
        	this.sourceCodeGithubcomToolStripMenuItem.Text = "Source code @ Github.com";
        	this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
        	// 
        	// toolStripSeparator1
        	// 
        	this.toolStripSeparator1.Name = "toolStripSeparator1";
        	this.toolStripSeparator1.Size = new System.Drawing.Size(275, 6);
        	// 
        	// originalThreadDonationCodercomToolStripMenuItem
        	// 
        	this.originalThreadDonationCodercomToolStripMenuItem.Name = "originalThreadDonationCodercomToolStripMenuItem";
        	this.originalThreadDonationCodercomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
        	this.originalThreadDonationCodercomToolStripMenuItem.Text = "&Original thread @ DonationCoder.com";
        	this.originalThreadDonationCodercomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadDonationCodercomToolStripMenuItemClick);
        	// 
        	// toolStripSeparator5
        	// 
        	this.toolStripSeparator5.Name = "toolStripSeparator5";
        	this.toolStripSeparator5.Size = new System.Drawing.Size(275, 6);
        	// 
        	// aboutToolStripMenuItem
        	// 
        	this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        	this.aboutToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
        	this.aboutToolStripMenuItem.Text = "&About...";
        	this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
        	// 
        	// mainStatusStrip
        	// 
        	this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.mainToolStripStatusLabel});
        	this.mainStatusStrip.Location = new System.Drawing.Point(0, 262);
        	this.mainStatusStrip.Name = "mainStatusStrip";
        	this.mainStatusStrip.Size = new System.Drawing.Size(260, 22);
        	this.mainStatusStrip.TabIndex = 3;
        	// 
        	// mainToolStripStatusLabel
        	// 
        	this.mainToolStripStatusLabel.Name = "mainToolStripStatusLabel";
        	this.mainToolStripStatusLabel.Size = new System.Drawing.Size(156, 17);
        	this.mainToolStripStatusLabel.Text = "Scanning current directory...";
        	// 
        	// headerLabel
        	// 
        	this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.headerLabel.Location = new System.Drawing.Point(12, 33);
        	this.headerLabel.Name = "headerLabel";
        	this.headerLabel.Size = new System.Drawing.Size(235, 23);
        	this.headerLabel.TabIndex = 5;
        	this.headerLabel.Text = "The Random Sounds App is currently:";
        	// 
        	// onRadioButton
        	// 
        	this.onRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.onRadioButton.Location = new System.Drawing.Point(3, 5);
        	this.onRadioButton.Name = "onRadioButton";
        	this.onRadioButton.Size = new System.Drawing.Size(43, 24);
        	this.onRadioButton.TabIndex = 6;
        	this.onRadioButton.Text = "On";
        	this.onRadioButton.UseVisualStyleBackColor = true;
        	this.onRadioButton.CheckedChanged += new System.EventHandler(this.OnOnRadioButtonCheckedChanged);
        	// 
        	// offRadioButton
        	// 
        	this.offRadioButton.Checked = true;
        	this.offRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.offRadioButton.ForeColor = System.Drawing.Color.Red;
        	this.offRadioButton.Location = new System.Drawing.Point(52, 5);
        	this.offRadioButton.Name = "offRadioButton";
        	this.offRadioButton.Size = new System.Drawing.Size(43, 24);
        	this.offRadioButton.TabIndex = 6;
        	this.offRadioButton.TabStop = true;
        	this.offRadioButton.Text = "Off";
        	this.offRadioButton.UseVisualStyleBackColor = true;
        	this.offRadioButton.CheckedChanged += new System.EventHandler(this.OnOffRadioButtonCheckedChanged);
        	// 
        	// label2
        	// 
        	this.label2.Location = new System.Drawing.Point(15, 76);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(219, 23);
        	this.label2.TabIndex = 7;
        	this.label2.Text = "___________________________________________";
        	// 
        	// settingsLabel
        	// 
        	this.settingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.settingsLabel.Location = new System.Drawing.Point(12, 101);
        	this.settingsLabel.Name = "settingsLabel";
        	this.settingsLabel.Size = new System.Drawing.Size(235, 23);
        	this.settingsLabel.TabIndex = 5;
        	this.settingsLabel.Text = "Settings:";
        	// 
        	// everyIntervalRadioButton
        	// 
        	this.everyIntervalRadioButton.Checked = true;
        	this.everyIntervalRadioButton.Location = new System.Drawing.Point(15, 130);
        	this.everyIntervalRadioButton.Name = "everyIntervalRadioButton";
        	this.everyIntervalRadioButton.Size = new System.Drawing.Size(191, 24);
        	this.everyIntervalRadioButton.TabIndex = 8;
        	this.everyIntervalRadioButton.TabStop = true;
        	this.everyIntervalRadioButton.Text = "Play sound exactly every";
        	this.everyIntervalRadioButton.UseVisualStyleBackColor = true;
        	this.everyIntervalRadioButton.CheckedChanged += new System.EventHandler(this.OnSettingsRadioButtonCheckedChanged);
        	// 
        	// randomIntervalRadioButton
        	// 
        	this.randomIntervalRadioButton.Location = new System.Drawing.Point(15, 160);
        	this.randomIntervalRadioButton.Name = "randomIntervalRadioButton";
        	this.randomIntervalRadioButton.Size = new System.Drawing.Size(191, 24);
        	this.randomIntervalRadioButton.TabIndex = 8;
        	this.randomIntervalRadioButton.Text = "Play sound at a random time ";
        	this.randomIntervalRadioButton.UseVisualStyleBackColor = true;
        	this.randomIntervalRadioButton.CheckedChanged += new System.EventHandler(this.OnSettingsRadioButtonCheckedChanged);
        	// 
        	// onOffPanel
        	// 
        	this.onOffPanel.Controls.Add(this.onRadioButton);
        	this.onOffPanel.Controls.Add(this.offRadioButton);
        	this.onOffPanel.Location = new System.Drawing.Point(13, 47);
        	this.onOffPanel.Name = "onOffPanel";
        	this.onOffPanel.Size = new System.Drawing.Size(222, 33);
        	this.onOffPanel.TabIndex = 10;
        	// 
        	// everyIntervalNumericUpDown
        	// 
        	this.everyIntervalNumericUpDown.Location = new System.Drawing.Point(156, 133);
        	this.everyIntervalNumericUpDown.Maximum = new decimal(new int[] {
        	        	        	1440,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.everyIntervalNumericUpDown.Minimum = new decimal(new int[] {
        	        	        	1,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.everyIntervalNumericUpDown.Name = "everyIntervalNumericUpDown";
        	this.everyIntervalNumericUpDown.Size = new System.Drawing.Size(50, 20);
        	this.everyIntervalNumericUpDown.TabIndex = 11;
        	this.everyIntervalNumericUpDown.Value = new decimal(new int[] {
        	        	        	15,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.everyIntervalNumericUpDown.ValueChanged += new System.EventHandler(this.OnNumericUpDownValueChanged);
        	// 
        	// minutesLabel
        	// 
        	this.minutesLabel.Location = new System.Drawing.Point(209, 135);
        	this.minutesLabel.Name = "minutesLabel";
        	this.minutesLabel.Size = new System.Drawing.Size(53, 23);
        	this.minutesLabel.TabIndex = 12;
        	this.minutesLabel.Text = "minutes";
        	// 
        	// randomIntervalNumericUpDown
        	// 
        	this.randomIntervalNumericUpDown.Location = new System.Drawing.Point(82, 185);
        	this.randomIntervalNumericUpDown.Maximum = new decimal(new int[] {
        	        	        	1440,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.randomIntervalNumericUpDown.Minimum = new decimal(new int[] {
        	        	        	1,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.randomIntervalNumericUpDown.Name = "randomIntervalNumericUpDown";
        	this.randomIntervalNumericUpDown.Size = new System.Drawing.Size(50, 20);
        	this.randomIntervalNumericUpDown.TabIndex = 11;
        	this.randomIntervalNumericUpDown.Value = new decimal(new int[] {
        	        	        	15,
        	        	        	0,
        	        	        	0,
        	        	        	0});
        	this.randomIntervalNumericUpDown.ValueChanged += new System.EventHandler(this.OnNumericUpDownValueChanged);
        	// 
        	// minuteIntervalLabel
        	// 
        	this.minuteIntervalLabel.Location = new System.Drawing.Point(135, 187);
        	this.minuteIntervalLabel.Name = "minuteIntervalLabel";
        	this.minuteIntervalLabel.Size = new System.Drawing.Size(100, 23);
        	this.minuteIntervalLabel.TabIndex = 12;
        	this.minuteIntervalLabel.Text = "minute interval";
        	// 
        	// inEveryLabel
        	// 
        	this.inEveryLabel.Location = new System.Drawing.Point(34, 187);
        	this.inEveryLabel.Name = "inEveryLabel";
        	this.inEveryLabel.Size = new System.Drawing.Size(102, 23);
        	this.inEveryLabel.TabIndex = 12;
        	this.inEveryLabel.Text = "in every";
        	// 
        	// label7
        	// 
        	this.label7.Location = new System.Drawing.Point(16, 210);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(219, 23);
        	this.label7.TabIndex = 7;
        	this.label7.Text = "___________________________________________";
        	// 
        	// startCheckBox
        	// 
        	this.startCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.startCheckBox.Location = new System.Drawing.Point(15, 235);
        	this.startCheckBox.Name = "startCheckBox";
        	this.startCheckBox.Size = new System.Drawing.Size(219, 24);
        	this.startCheckBox.TabIndex = 13;
        	this.startCheckBox.Text = "Start when computer starts";
        	this.startCheckBox.UseVisualStyleBackColor = true;
        	this.startCheckBox.CheckedChanged += new System.EventHandler(this.OnStartCheckBoxCheckedChanged);
        	// 
        	// exactTimer
        	// 
        	this.exactTimer.Tick += new System.EventHandler(this.OnExactTimerTick);
        	// 
        	// randomIntervalTimer
        	// 
        	this.randomIntervalTimer.Tick += new System.EventHandler(this.OnRandomIntervalTimerTick);
        	// 
        	// mainNotifyIcon
        	// 
        	this.mainNotifyIcon.ContextMenuStrip = this.notifyContextMenuStrip;
        	this.mainNotifyIcon.Text = "Click to show Random Sounds App";
        	this.mainNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMainNotifyIconMouseClick);
        	this.mainNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnMainNotifyIconMouseClick);
        	// 
        	// notifyContextMenuStrip
        	// 
        	this.notifyContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.showToolStripMenuItem,
        	        	        	this.notifyExitToolStripMenuItem});
        	this.notifyContextMenuStrip.Name = "notifyContextMenuStrip";
        	this.notifyContextMenuStrip.Size = new System.Drawing.Size(104, 48);
        	// 
        	// showToolStripMenuItem
        	// 
        	this.showToolStripMenuItem.Name = "showToolStripMenuItem";
        	this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
        	this.showToolStripMenuItem.Text = "&Show";
        	this.showToolStripMenuItem.Click += new System.EventHandler(this.OnShowToolStripMenuItemClick);
        	// 
        	// notifyExitToolStripMenuItem
        	// 
        	this.notifyExitToolStripMenuItem.Name = "notifyExitToolStripMenuItem";
        	this.notifyExitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
        	this.notifyExitToolStripMenuItem.Text = "&Exit";
        	this.notifyExitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(260, 284);
        	this.Controls.Add(this.startCheckBox);
        	this.Controls.Add(this.minuteIntervalLabel);
        	this.Controls.Add(this.randomIntervalNumericUpDown);
        	this.Controls.Add(this.minutesLabel);
        	this.Controls.Add(this.everyIntervalNumericUpDown);
        	this.Controls.Add(this.onOffPanel);
        	this.Controls.Add(this.randomIntervalRadioButton);
        	this.Controls.Add(this.everyIntervalRadioButton);
        	this.Controls.Add(this.label7);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.settingsLabel);
        	this.Controls.Add(this.headerLabel);
        	this.Controls.Add(this.mainMenuStrip);
        	this.Controls.Add(this.mainStatusStrip);
        	this.Controls.Add(this.inEveryLabel);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.MaximizeBox = false;
        	this.MinimumSize = new System.Drawing.Size(276, 322);
        	this.Name = "MainForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Random Sounds App";
        	this.Load += new System.EventHandler(this.OnMainFormLoad);
        	this.Resize += new System.EventHandler(this.OnMainFormResize);
        	this.mainMenuStrip.ResumeLayout(false);
        	this.mainMenuStrip.PerformLayout();
        	this.mainStatusStrip.ResumeLayout(false);
        	this.mainStatusStrip.PerformLayout();
        	this.onOffPanel.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.everyIntervalNumericUpDown)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.randomIntervalNumericUpDown)).EndInit();
        	this.notifyContextMenuStrip.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripMenuItem notifyExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip notifyContextMenuStrip;
        private System.Windows.Forms.NotifyIcon mainNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem originalThreadDonationCodercomToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem scanDirectoryToolStripMenuItem;
        private System.Windows.Forms.Timer randomIntervalTimer;
        private System.Windows.Forms.Timer exactTimer;
        private System.Windows.Forms.CheckBox startCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label inEveryLabel;
        private System.Windows.Forms.Label minuteIntervalLabel;
        private System.Windows.Forms.NumericUpDown randomIntervalNumericUpDown;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.NumericUpDown everyIntervalNumericUpDown;
        private System.Windows.Forms.Panel onOffPanel;
        private System.Windows.Forms.RadioButton randomIntervalRadioButton;
        private System.Windows.Forms.RadioButton everyIntervalRadioButton;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton offRadioButton;
        private System.Windows.Forms.RadioButton onRadioButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ToolStripStatusLabel mainToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headquartersPatreoncomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
    }
}
