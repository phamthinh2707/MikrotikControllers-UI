namespace tik4net.controller
{
    partial class UserMangementForm
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
            this.tabUser = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.UserGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDisabledUser = new System.Windows.Forms.Button();
            this.btnEnabledUser = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.AmountOfUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabGroup = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveGroup = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.GroupGridView = new System.Windows.Forms.DataGridView();
            this.nameGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policiesGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.AmountOfGroup = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabActiveUser = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ActiveUserGridView = new System.Windows.Forms.DataGridView();
            this.ActiveUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLoggedIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.AmountOfActiveUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.Numbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLastLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabUser.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabGroup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGridView)).BeginInit();
            this.statusStrip2.SuspendLayout();
            this.tabActiveUser.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveUserGridView)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.statusStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.tabUsers);
            this.tabUser.Controls.Add(this.tabGroup);
            this.tabUser.Controls.Add(this.tabActiveUser);
            this.tabUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUser.Location = new System.Drawing.Point(0, 0);
            this.tabUser.Name = "tabUser";
            this.tabUser.SelectedIndex = 0;
            this.tabUser.Size = new System.Drawing.Size(763, 450);
            this.tabUser.TabIndex = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.tableLayoutPanel3);
            this.tabUsers.Controls.Add(this.statusStrip1);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(755, 424);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.UserGridView, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(749, 396);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // UserGridView
            // 
            this.UserGridView.AllowUserToAddRows = false;
            this.UserGridView.AllowUserToDeleteRows = false;
            this.UserGridView.AllowUserToResizeColumns = false;
            this.UserGridView.AllowUserToResizeRows = false;
            this.UserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numbers,
            this.username,
            this.userGroup,
            this.userAddress,
            this.userLastLogin,
            this.Status});
            this.UserGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.UserGridView.Location = new System.Drawing.Point(3, 42);
            this.UserGridView.MultiSelect = false;
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.ReadOnly = true;
            this.UserGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserGridView.Size = new System.Drawing.Size(743, 351);
            this.UserGridView.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnEditUser, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnRemoveUser, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnAddUser, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnDisabledUser, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnEnabledUser, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(743, 33);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditUser.Location = new System.Drawing.Point(151, 3);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(68, 27);
            this.btnEditUser.TabIndex = 11;
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveUser.Location = new System.Drawing.Point(77, 3);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(68, 27);
            this.btnRemoveUser.TabIndex = 9;
            this.btnRemoveUser.Text = "Remove";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddUser.Location = new System.Drawing.Point(3, 3);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(68, 27);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDisabledUser
            // 
            this.btnDisabledUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisabledUser.Location = new System.Drawing.Point(299, 3);
            this.btnDisabledUser.Name = "btnDisabledUser";
            this.btnDisabledUser.Size = new System.Drawing.Size(68, 27);
            this.btnDisabledUser.TabIndex = 2;
            this.btnDisabledUser.Text = "Disabled";
            this.btnDisabledUser.UseVisualStyleBackColor = true;
            this.btnDisabledUser.Click += new System.EventHandler(this.btnDisabledUser_Click);
            // 
            // btnEnabledUser
            // 
            this.btnEnabledUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEnabledUser.Location = new System.Drawing.Point(225, 3);
            this.btnEnabledUser.Name = "btnEnabledUser";
            this.btnEnabledUser.Size = new System.Drawing.Size(68, 27);
            this.btnEnabledUser.TabIndex = 1;
            this.btnEnabledUser.Text = "Enabled";
            this.btnEnabledUser.UseVisualStyleBackColor = true;
            this.btnEnabledUser.Click += new System.EventHandler(this.btnEnabledUser_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AmountOfUser});
            this.statusStrip1.Location = new System.Drawing.Point(3, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(749, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusUserManagement";
            // 
            // AmountOfUser
            // 
            this.AmountOfUser.Name = "AmountOfUser";
            this.AmountOfUser.Size = new System.Drawing.Size(31, 17);
            this.AmountOfUser.Text = "Item";
            // 
            // tabGroup
            // 
            this.tabGroup.Controls.Add(this.tableLayoutPanel1);
            this.tabGroup.Controls.Add(this.statusStrip2);
            this.tabGroup.Location = new System.Drawing.Point(4, 22);
            this.tabGroup.Name = "tabGroup";
            this.tabGroup.Padding = new System.Windows.Forms.Padding(3);
            this.tabGroup.Size = new System.Drawing.Size(755, 424);
            this.tabGroup.TabIndex = 1;
            this.tabGroup.Text = "Group";
            this.tabGroup.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GroupGridView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(749, 396);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.btnRemoveGroup, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddGroup, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRefresh, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(743, 33);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnRemoveGroup
            // 
            this.btnRemoveGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveGroup.Location = new System.Drawing.Point(77, 3);
            this.btnRemoveGroup.Name = "btnRemoveGroup";
            this.btnRemoveGroup.Size = new System.Drawing.Size(68, 27);
            this.btnRemoveGroup.TabIndex = 1;
            this.btnRemoveGroup.Text = "Remove";
            this.btnRemoveGroup.UseVisualStyleBackColor = true;
            this.btnRemoveGroup.Click += new System.EventHandler(this.btnRemoveGroup_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddGroup.Location = new System.Drawing.Point(3, 3);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(68, 27);
            this.btnAddGroup.TabIndex = 0;
            this.btnAddGroup.Text = "Add";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Location = new System.Drawing.Point(151, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(68, 27);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // GroupGridView
            // 
            this.GroupGridView.AllowUserToAddRows = false;
            this.GroupGridView.AllowUserToDeleteRows = false;
            this.GroupGridView.AllowUserToResizeColumns = false;
            this.GroupGridView.AllowUserToResizeRows = false;
            this.GroupGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.GroupGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GroupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameGroup,
            this.policiesGroup,
            this.skinGroup});
            this.GroupGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupGridView.Location = new System.Drawing.Point(3, 42);
            this.GroupGridView.MultiSelect = false;
            this.GroupGridView.Name = "GroupGridView";
            this.GroupGridView.ReadOnly = true;
            this.GroupGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GroupGridView.Size = new System.Drawing.Size(743, 351);
            this.GroupGridView.TabIndex = 1;
            // 
            // nameGroup
            // 
            this.nameGroup.HeaderText = "Name";
            this.nameGroup.Name = "nameGroup";
            this.nameGroup.ReadOnly = true;
            // 
            // policiesGroup
            // 
            this.policiesGroup.HeaderText = "Policies";
            this.policiesGroup.Name = "policiesGroup";
            this.policiesGroup.ReadOnly = true;
            this.policiesGroup.Width = 500;
            // 
            // skinGroup
            // 
            this.skinGroup.HeaderText = "Skin";
            this.skinGroup.Name = "skinGroup";
            this.skinGroup.ReadOnly = true;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AmountOfGroup});
            this.statusStrip2.Location = new System.Drawing.Point(3, 399);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(749, 22);
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // AmountOfGroup
            // 
            this.AmountOfGroup.Name = "AmountOfGroup";
            this.AmountOfGroup.Size = new System.Drawing.Size(40, 17);
            this.AmountOfGroup.Text = "Group";
            // 
            // tabActiveUser
            // 
            this.tabActiveUser.Controls.Add(this.tableLayoutPanel5);
            this.tabActiveUser.Controls.Add(this.statusStrip3);
            this.tabActiveUser.Location = new System.Drawing.Point(4, 22);
            this.tabActiveUser.Name = "tabActiveUser";
            this.tabActiveUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabActiveUser.Size = new System.Drawing.Size(755, 424);
            this.tabActiveUser.TabIndex = 2;
            this.tabActiveUser.Text = "Active User";
            this.tabActiveUser.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.ActiveUserGridView, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(749, 396);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // ActiveUserGridView
            // 
            this.ActiveUserGridView.AllowUserToAddRows = false;
            this.ActiveUserGridView.AllowUserToDeleteRows = false;
            this.ActiveUserGridView.AllowUserToResizeColumns = false;
            this.ActiveUserGridView.AllowUserToResizeRows = false;
            this.ActiveUserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActiveUserGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActiveUserName,
            this.TimeLoggedIn,
            this.ActiveAddress,
            this.VIA});
            this.ActiveUserGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActiveUserGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.ActiveUserGridView.Location = new System.Drawing.Point(3, 42);
            this.ActiveUserGridView.MultiSelect = false;
            this.ActiveUserGridView.Name = "ActiveUserGridView";
            this.ActiveUserGridView.ReadOnly = true;
            this.ActiveUserGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ActiveUserGridView.Size = new System.Drawing.Size(743, 351);
            this.ActiveUserGridView.TabIndex = 0;
            // 
            // ActiveUserName
            // 
            this.ActiveUserName.HeaderText = "Name";
            this.ActiveUserName.Name = "ActiveUserName";
            this.ActiveUserName.ReadOnly = true;
            this.ActiveUserName.Width = 175;
            // 
            // TimeLoggedIn
            // 
            this.TimeLoggedIn.HeaderText = "At";
            this.TimeLoggedIn.Name = "TimeLoggedIn";
            this.TimeLoggedIn.ReadOnly = true;
            this.TimeLoggedIn.Width = 175;
            // 
            // ActiveAddress
            // 
            this.ActiveAddress.HeaderText = "Address";
            this.ActiveAddress.Name = "ActiveAddress";
            this.ActiveAddress.ReadOnly = true;
            this.ActiveAddress.Width = 175;
            // 
            // VIA
            // 
            this.VIA.HeaderText = "Via";
            this.VIA.Name = "VIA";
            this.VIA.ReadOnly = true;
            this.VIA.Width = 175;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(743, 33);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(597, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 0;
            // 
            // statusStrip3
            // 
            this.statusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AmountOfActiveUser});
            this.statusStrip3.Location = new System.Drawing.Point(3, 399);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.Size = new System.Drawing.Size(749, 22);
            this.statusStrip3.TabIndex = 0;
            this.statusStrip3.Text = "statusStrip3";
            // 
            // AmountOfActiveUser
            // 
            this.AmountOfActiveUser.Name = "AmountOfActiveUser";
            this.AmountOfActiveUser.Size = new System.Drawing.Size(66, 17);
            this.AmountOfActiveUser.Text = "Active User";
            // 
            // Numbers
            // 
            this.Numbers.HeaderText = "No.";
            this.Numbers.Name = "Numbers";
            this.Numbers.ReadOnly = true;
            this.Numbers.Width = 75;
            // 
            // username
            // 
            this.username.HeaderText = "Name";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 150;
            // 
            // userGroup
            // 
            this.userGroup.HeaderText = "Group";
            this.userGroup.Name = "userGroup";
            this.userGroup.ReadOnly = true;
            // 
            // userAddress
            // 
            this.userAddress.HeaderText = "Address";
            this.userAddress.Name = "userAddress";
            this.userAddress.ReadOnly = true;
            this.userAddress.Width = 150;
            // 
            // userLastLogin
            // 
            this.userLastLogin.HeaderText = "Last-Logged-In";
            this.userLastLogin.Name = "userLastLogin";
            this.userLastLogin.ReadOnly = true;
            this.userLastLogin.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 75;
            // 
            // UserMangementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.tabUser);
            this.MaximumSize = new System.Drawing.Size(779, 489);
            this.MinimumSize = new System.Drawing.Size(779, 489);
            this.Name = "UserMangementForm";
            this.Text = "User Mangement";
            this.Load += new System.EventHandler(this.UserMangementForm_Load);
            this.tabUser.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabGroup.ResumeLayout(false);
            this.tabGroup.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupGridView)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.tabActiveUser.ResumeLayout(false);
            this.tabActiveUser.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ActiveUserGridView)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.statusStrip3.ResumeLayout(false);
            this.statusStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUser;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabActiveUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView UserGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnDisabledUser;
        private System.Windows.Forms.Button btnEnabledUser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage tabGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnRemoveGroup;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.DataGridView GroupGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn policiesGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn skinGroup;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView ActiveUserGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip3;
        public System.Windows.Forms.ToolStripStatusLabel AmountOfUser;
        private System.Windows.Forms.ToolStripStatusLabel AmountOfGroup;
        private System.Windows.Forms.ToolStripStatusLabel AmountOfActiveUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLoggedIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIA;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn userGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn userAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLastLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}