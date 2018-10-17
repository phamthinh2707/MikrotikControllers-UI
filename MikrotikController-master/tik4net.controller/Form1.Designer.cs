using System;
using System.Windows.Forms;

namespace tik4net.controller
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnBasicSetting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.rtxDisplay = new System.Windows.Forms.RichTextBox();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.form1StatusStrip = new System.Windows.Forms.StatusStrip();
            this.lblConnectionStatus = new Bulb.LedBulb();
            this.panelSystem = new System.Windows.Forms.Panel();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnResetConfiguration = new System.Windows.Forms.Button();
            this.btnReboot = new System.Windows.Forms.Button();
            this.btnSystem = new System.Windows.Forms.Button();
            this.systemTimer = new System.Windows.Forms.Timer(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnBasicConfig = new System.Windows.Forms.Button();
            this.btnWalledGarden = new System.Windows.Forms.Button();
            this.btnWifiMarketing = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.menuTimer = new System.Windows.Forms.Timer(this.components);
            this.panelSystem.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBasicSetting
            // 
            this.btnBasicSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBasicSetting.Location = new System.Drawing.Point(3, 87);
            this.btnBasicSetting.Name = "btnBasicSetting";
            this.btnBasicSetting.Size = new System.Drawing.Size(101, 22);
            this.btnBasicSetting.TabIndex = 8;
            this.btnBasicSetting.Text = "Basic Setting";
            this.btnBasicSetting.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host/User/Password:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(140, 11);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(180, 20);
            this.txtHost.TabIndex = 1;
            this.txtHost.Text = "192.168.88.1";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(326, 11);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(180, 20);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "admin";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(512, 11);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(180, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // rtxDisplay
            // 
            this.rtxDisplay.Location = new System.Drawing.Point(12, 66);
            this.rtxDisplay.Name = "rtxDisplay";
            this.rtxDisplay.ReadOnly = true;
            this.rtxDisplay.Size = new System.Drawing.Size(723, 311);
            this.rtxDisplay.TabIndex = 6;
            this.rtxDisplay.Text = "";
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(12, 383);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(609, 20);
            this.txtCommand.TabIndex = 7;
            this.txtCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommand_KeyDown);
            this.txtCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCommand_KeyPress);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(627, 382);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 22);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSubmit_MouseClick);
            // 
            // form1StatusStrip
            // 
            this.form1StatusStrip.Location = new System.Drawing.Point(0, 411);
            this.form1StatusStrip.Name = "form1StatusStrip";
            this.form1StatusStrip.Size = new System.Drawing.Size(747, 22);
            this.form1StatusStrip.SizingGrip = false;
            this.form1StatusStrip.TabIndex = 10;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConnectionStatus.Color = System.Drawing.Color.Black;
            this.lblConnectionStatus.Location = new System.Drawing.Point(7, 415);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.On = true;
            this.lblConnectionStatus.Size = new System.Drawing.Size(10, 17);
            this.lblConnectionStatus.TabIndex = 11;
            this.lblConnectionStatus.Text = "ledBulb1";
            // 
            // panelSystem
            // 
            this.panelSystem.Controls.Add(this.btnUserManagement);
            this.panelSystem.Controls.Add(this.btnResetConfiguration);
            this.panelSystem.Controls.Add(this.btnReboot);
            this.panelSystem.Controls.Add(this.btnSystem);
            this.panelSystem.Location = new System.Drawing.Point(140, 37);
            this.panelSystem.MaximumSize = new System.Drawing.Size(272, 93);
            this.panelSystem.MinimumSize = new System.Drawing.Size(272, 24);
            this.panelSystem.Name = "panelSystem";
            this.panelSystem.Size = new System.Drawing.Size(272, 24);
            this.panelSystem.TabIndex = 12;
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserManagement.Location = new System.Drawing.Point(0, 69);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(272, 23);
            this.btnUserManagement.TabIndex = 3;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnResetConfiguration
            // 
            this.btnResetConfiguration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResetConfiguration.Location = new System.Drawing.Point(0, 46);
            this.btnResetConfiguration.Name = "btnResetConfiguration";
            this.btnResetConfiguration.Size = new System.Drawing.Size(272, 23);
            this.btnResetConfiguration.TabIndex = 2;
            this.btnResetConfiguration.Text = "Reset Configuration";
            this.btnResetConfiguration.UseVisualStyleBackColor = true;
            this.btnResetConfiguration.Click += new System.EventHandler(this.btnResetConfiguration_Click);
            // 
            // btnReboot
            // 
            this.btnReboot.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReboot.Location = new System.Drawing.Point(0, 23);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(272, 23);
            this.btnReboot.TabIndex = 1;
            this.btnReboot.Text = "Reboot";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // btnSystem
            // 
            this.btnSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSystem.Image = global::tik4net.controller.Properties.Resources.icons8_expand_arrow_16;
            this.btnSystem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSystem.Location = new System.Drawing.Point(0, 0);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(272, 23);
            this.btnSystem.TabIndex = 0;
            this.btnSystem.Text = "System";
            this.btnSystem.UseVisualStyleBackColor = true;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // systemTimer
            // 
            this.systemTimer.Interval = 1;
            this.systemTimer.Tick += new System.EventHandler(this.systemTimer_Tick);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.Control;
            this.btnConnect.Image = global::tik4net.controller.Properties.Resources.connect1;
            this.btnConnect.Location = new System.Drawing.Point(697, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(36, 22);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnConnect_MouseClick);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnBasicConfig);
            this.panelMenu.Controls.Add(this.btnWalledGarden);
            this.panelMenu.Controls.Add(this.btnWifiMarketing);
            this.panelMenu.Controls.Add(this.btnMenu);
            this.panelMenu.Location = new System.Drawing.Point(420, 37);
            this.panelMenu.MaximumSize = new System.Drawing.Size(272, 93);
            this.panelMenu.MinimumSize = new System.Drawing.Size(272, 24);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(272, 24);
            this.panelMenu.TabIndex = 13;
            // 
            // btnBasicConfig
            // 
            this.btnBasicConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBasicConfig.Location = new System.Drawing.Point(0, 69);
            this.btnBasicConfig.Name = "btnBasicConfig";
            this.btnBasicConfig.Size = new System.Drawing.Size(272, 23);
            this.btnBasicConfig.TabIndex = 3;
            this.btnBasicConfig.Text = "Basic Configuration";
            this.btnBasicConfig.UseVisualStyleBackColor = true;
            this.btnBasicConfig.Click += new System.EventHandler(this.btnBasicConfig_Click);
            // 
            // btnWalledGarden
            // 
            this.btnWalledGarden.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWalledGarden.Location = new System.Drawing.Point(0, 46);
            this.btnWalledGarden.Name = "btnWalledGarden";
            this.btnWalledGarden.Size = new System.Drawing.Size(272, 23);
            this.btnWalledGarden.TabIndex = 2;
            this.btnWalledGarden.Text = "Walled Garden";
            this.btnWalledGarden.UseVisualStyleBackColor = true;
            this.btnWalledGarden.Click += new System.EventHandler(this.btnWallGarden_Click);
            // 
            // btnWifiMarketing
            // 
            this.btnWifiMarketing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWifiMarketing.Location = new System.Drawing.Point(0, 23);
            this.btnWifiMarketing.Name = "btnWifiMarketing";
            this.btnWifiMarketing.Size = new System.Drawing.Size(272, 23);
            this.btnWifiMarketing.TabIndex = 1;
            this.btnWifiMarketing.Text = "Wifi Marketing";
            this.btnWifiMarketing.UseVisualStyleBackColor = true;
            this.btnWifiMarketing.Click += new System.EventHandler(this.btnWifiMarketing_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.Image = global::tik4net.controller.Properties.Resources.icons8_expand_arrow_16;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(272, 23);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // menuTimer
            // 
            this.menuTimer.Interval = 1;
            this.menuTimer.Tick += new System.EventHandler(this.menuTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 433);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelSystem);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.form1StatusStrip);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.rtxDisplay);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(763, 472);
            this.MinimumSize = new System.Drawing.Size(763, 472);
            this.Name = "MainForm";
            this.Text = "Mikrotik Controller";
            this.panelSystem.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnBasicSetting;
        private Label label1;
        private TextBox txtHost;
        private TextBox txtUser;
        private TextBox txtPassword;
        private RichTextBox rtxDisplay;
        private TextBox txtCommand;
        private Button btnSubmit;
        private Button btnConnect;
        private StatusStrip form1StatusStrip;
        private Bulb.LedBulb lblConnectionStatus;
        private Panel panelSystem;
        private Button btnUserManagement;
        private Button btnResetConfiguration;
        private Button btnReboot;
        private Button btnSystem;
        private Timer systemTimer;
        private Panel panelMenu;
        private Button btnBasicConfig;
        private Button btnWalledGarden;
        private Button btnWifiMarketing;
        private Button btnMenu;
        private Timer menuTimer;
    }
}

