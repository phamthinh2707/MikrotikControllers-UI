using System;
using System.Windows.Forms;

namespace tik4net.controller
{
    partial class Form1
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.tableOption = new System.Windows.Forms.TableLayoutPanel();
            this.btnReboot = new System.Windows.Forms.Button();
            this.btnResetConfiguration = new System.Windows.Forms.Button();
            this.btnWifiMarketing = new System.Windows.Forms.Button();
            this.btnWallGarden = new System.Windows.Forms.Button();
            this.btnNatPort = new System.Windows.Forms.Button();
            this.btnEncryptPassword = new System.Windows.Forms.Button();
            this.btnGetMAC = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnBasicConfig = new System.Windows.Forms.Button();
            this.btnBasicSetting = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rtxDisplay = new System.Windows.Forms.RichTextBox();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableOption.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblHost, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtHost, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblUser, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtPassword, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblPassword, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtUser, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.tableOption, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(728, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.97878F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.896552F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.97878F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.6313F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.448276F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.427056F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.74801F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.30746F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(220, 428);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(3, 0);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 13);
            this.lblHost.TabIndex = 8;
            this.lblHost.Text = "Host:";
            // 
            // txtHost
            // 
            this.txtHost.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHost.Location = new System.Drawing.Point(3, 20);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(214, 20);
            this.txtHost.TabIndex = 5;
            this.txtHost.Text = "192.168.120.1";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(3, 46);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(32, 13);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "User:";
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPassword.Location = new System.Drawing.Point(3, 108);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(214, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 91);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUser.Location = new System.Drawing.Point(3, 66);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(214, 20);
            this.txtUser.TabIndex = 6;
            this.txtUser.Text = "admin";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblStatus, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnConnect, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnBrowser, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 288);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.96032F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.01587F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.02381F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(214, 137);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Crimson;
            this.lblStatus.Location = new System.Drawing.Point(66, 31);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(82, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Not Connected!";
            // 
            // btnConnect
            // 
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Location = new System.Drawing.Point(3, 79);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(208, 25);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnConnect_MouseClick);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowser.Location = new System.Drawing.Point(3, 110);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(208, 24);
            this.btnBrowser.TabIndex = 13;
            this.btnBrowser.Text = "Browse File";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // tableOption
            // 
            this.tableOption.ColumnCount = 2;
            this.tableOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOption.Controls.Add(this.btnReboot, 0, 0);
            this.tableOption.Controls.Add(this.btnResetConfiguration, 1, 0);
            this.tableOption.Controls.Add(this.btnWifiMarketing, 0, 1);
            this.tableOption.Controls.Add(this.btnWallGarden, 1, 1);
            this.tableOption.Controls.Add(this.btnNatPort, 0, 2);
            this.tableOption.Controls.Add(this.btnEncryptPassword, 1, 2);
            this.tableOption.Controls.Add(this.btnGetMAC, 0, 3);
            this.tableOption.Controls.Add(this.btnUserManagement, 1, 3);
            this.tableOption.Controls.Add(this.btnBasicConfig);
            this.tableOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableOption.Location = new System.Drawing.Point(3, 139);
            this.tableOption.Name = "tableOption";
            this.tableOption.RowCount = 5;
            this.tableOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableOption.Size = new System.Drawing.Size(214, 143);
            this.tableOption.TabIndex = 12;
            this.tableOption.Visible = false;
            // 
            // btnReboot
            // 
            this.btnReboot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReboot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReboot.Location = new System.Drawing.Point(3, 3);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(101, 22);
            this.btnReboot.TabIndex = 0;
            this.btnReboot.Text = "Reboot";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // btnResetConfiguration
            // 
            this.btnResetConfiguration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResetConfiguration.Location = new System.Drawing.Point(110, 3);
            this.btnResetConfiguration.Name = "btnResetConfiguration";
            this.btnResetConfiguration.Size = new System.Drawing.Size(101, 22);
            this.btnResetConfiguration.TabIndex = 1;
            this.btnResetConfiguration.Text = "Reset Setting";
            this.btnResetConfiguration.UseVisualStyleBackColor = true;
            this.btnResetConfiguration.Click += new System.EventHandler(this.btnResetConfiguration_Click);
            // 
            // btnWifiMarketing
            // 
            this.btnWifiMarketing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWifiMarketing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWifiMarketing.Location = new System.Drawing.Point(3, 31);
            this.btnWifiMarketing.Name = "btnWifiMarketing";
            this.btnWifiMarketing.Size = new System.Drawing.Size(101, 22);
            this.btnWifiMarketing.TabIndex = 2;
            this.btnWifiMarketing.Text = "Wifi Marketing";
            this.btnWifiMarketing.UseVisualStyleBackColor = true;
            this.btnWifiMarketing.Click += new System.EventHandler(this.btnWifiMarketing_Click);
            // 
            // btnWallGarden
            // 
            this.btnWallGarden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWallGarden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWallGarden.Location = new System.Drawing.Point(110, 31);
            this.btnWallGarden.Name = "btnWallGarden";
            this.btnWallGarden.Size = new System.Drawing.Size(101, 22);
            this.btnWallGarden.TabIndex = 3;
            this.btnWallGarden.Text = "Walled Garden";
            this.btnWallGarden.UseVisualStyleBackColor = true;
            this.btnWallGarden.Click += new System.EventHandler(this.btnWallGarden_Click);
            // 
            // btnNatPort
            // 
            this.btnNatPort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNatPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNatPort.Location = new System.Drawing.Point(3, 59);
            this.btnNatPort.Name = "btnNatPort";
            this.btnNatPort.Size = new System.Drawing.Size(101, 22);
            this.btnNatPort.TabIndex = 4;
            this.btnNatPort.Text = "NAT Port";
            this.btnNatPort.UseVisualStyleBackColor = true;
            // 
            // btnEncryptPassword
            // 
            this.btnEncryptPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncryptPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEncryptPassword.Location = new System.Drawing.Point(110, 59);
            this.btnEncryptPassword.Name = "btnEncryptPassword";
            this.btnEncryptPassword.Size = new System.Drawing.Size(101, 22);
            this.btnEncryptPassword.TabIndex = 5;
            this.btnEncryptPassword.Text = "Encrypt Password";
            this.btnEncryptPassword.UseVisualStyleBackColor = true;
            // 
            // btnGetMAC
            // 
            this.btnGetMAC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGetMAC.Location = new System.Drawing.Point(3, 87);
            this.btnGetMAC.Name = "btnGetMAC";
            this.btnGetMAC.Size = new System.Drawing.Size(101, 22);
            this.btnGetMAC.TabIndex = 6;
            this.btnGetMAC.Text = "Get MAC";
            this.btnGetMAC.UseVisualStyleBackColor = true;
            this.btnGetMAC.Click += new System.EventHandler(this.btnGetMAC_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUserManagement.Location = new System.Drawing.Point(110, 87);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(101, 22);
            this.btnUserManagement.TabIndex = 7;
            this.btnUserManagement.Text = "User Manage";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnBasicConfig
            // 
            this.btnBasicConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBasicConfig.Location = new System.Drawing.Point(3, 115);
            this.btnBasicConfig.Name = "btnBasicConfig";
            this.btnBasicConfig.Size = new System.Drawing.Size(101, 25);
            this.btnBasicConfig.TabIndex = 8;
            this.btnBasicConfig.Text = "Basic Config";
            this.btnBasicConfig.UseVisualStyleBackColor = true;
            this.btnBasicConfig.Click += new System.EventHandler(this.btnBasicConfig_Click);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.26113F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.73887F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSubmit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.rtxDisplay, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCommand, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.696133F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.83117F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.493506F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(951, 489);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(719, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Command:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmit.Location = new System.Drawing.Point(728, 459);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(220, 27);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSubmit_MouseClick);
            // 
            // rtxDisplay
            // 
            this.rtxDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxDisplay.Location = new System.Drawing.Point(3, 25);
            this.rtxDisplay.Name = "rtxDisplay";
            this.rtxDisplay.ReadOnly = true;
            this.rtxDisplay.Size = new System.Drawing.Size(719, 428);
            this.rtxDisplay.TabIndex = 4;
            this.rtxDisplay.Text = "";
            // 
            // txtCommand
            // 
            this.txtCommand.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCommand.Location = new System.Drawing.Point(3, 459);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(719, 20);
            this.txtCommand.TabIndex = 1;
            this.txtCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCommand_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableOption.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RichTextBox rtxDisplay;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TableLayoutPanel tableOption;
        private System.Windows.Forms.Button btnReboot;
        private System.Windows.Forms.Button btnResetConfiguration;
        private System.Windows.Forms.Button btnWifiMarketing;
        private System.Windows.Forms.Button btnWallGarden;
        private System.Windows.Forms.Button btnNatPort;
        private System.Windows.Forms.Button btnEncryptPassword;
        private System.Windows.Forms.Button btnGetMAC;
        private System.Windows.Forms.Button btnUserManagement;
        private Button btnBasicSetting;
        private System.Windows.Forms.Button btnBasicConfig;
    }
}

