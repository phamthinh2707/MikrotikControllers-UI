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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnBasicSetting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSystem = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.rtxDisplay = new System.Windows.Forms.RichTextBox();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.form1StatusStrip = new System.Windows.Forms.StatusStrip();
            this.connectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ledBulb1 = new Bulb.LedBulb();
            this.form1StatusStrip.SuspendLayout();
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
            // btnSystem
            // 
            this.btnSystem.Location = new System.Drawing.Point(139, 37);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(272, 23);
            this.btnSystem.TabIndex = 4;
            this.btnSystem.Text = "System";
            this.btnSystem.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(420, 37);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(272, 23);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnGetMAC_Click);
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
            // form1StatusStrip
            // 
            this.form1StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatus});
            this.form1StatusStrip.Location = new System.Drawing.Point(0, 411);
            this.form1StatusStrip.Name = "form1StatusStrip";
            this.form1StatusStrip.Size = new System.Drawing.Size(747, 22);
            this.form1StatusStrip.SizingGrip = false;
            this.form1StatusStrip.TabIndex = 10;
            // 
            // connectionStatus
            // 
            this.connectionStatus.Name = "connectionStatus";
            this.connectionStatus.Size = new System.Drawing.Size(52, 17);
            this.connectionStatus.Text = "Connect";
            // 
            // ledBulb1
            // 
            this.ledBulb1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ledBulb1.Location = new System.Drawing.Point(12, 31);
            this.ledBulb1.Name = "ledBulb1";
            this.ledBulb1.On = true;
            this.ledBulb1.Size = new System.Drawing.Size(15, 23);
            this.ledBulb1.TabIndex = 11;
            this.ledBulb1.Text = "ledBulb1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 433);
            this.Controls.Add(this.ledBulb1);
            this.Controls.Add(this.form1StatusStrip);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.rtxDisplay);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnSystem);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(763, 472);
            this.MinimumSize = new System.Drawing.Size(763, 472);
            this.Name = "MainForm";
            this.Text = "Mikrotik Controller";
            this.form1StatusStrip.ResumeLayout(false);
            this.form1StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnBasicSetting;
        private Label label1;
        private TextBox txtHost;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnSystem;
        private Button btnMenu;
        private RichTextBox rtxDisplay;
        private TextBox txtCommand;
        private Button btnSubmit;
        private Button btnConnect;
        private StatusStrip form1StatusStrip;
        private ToolStripStatusLabel connectionStatus;
        private Bulb.LedBulb ledBulb1;
    }
}

