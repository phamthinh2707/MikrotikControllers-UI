using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tik4net.controller
{
    public partial class AddUserForm : Form
    {
        List<string> commandRows = new List<string>();
        private ITikConnection connection;
        public delegate void getConnection(ITikConnection conn);
        public getConnection getter;
        public AddUserForm()
        {
            InitializeComponent();
            getter = new getConnection(getConn);
        }

        private void getConn(ITikConnection conn)
        {
            connection = conn;
        }

        public class Group
        {
            public string name { get; set; }
            public string policies { get; set; }
            public string skin { get; set; }
        }

        private bool checkUsername()
        {
            bool check = true;
            List<string> nameList = getUsername();
            foreach (string name in nameList)
            {
                if (name.Equals(txtUsername.Text))
                {
                    check = false;
                    break;
                }
            }
            return check;
        }

        private List<string> getUsername()
        {
            List<string> nameList = new List<string>();
            var result = connection.CallCommandSync("/user/print");
            foreach (var resultItem in result)
                foreach (var item in resultItem.Words)
                {
                    if (item.Key.Equals("name"))
                        nameList.Add(item.Value);
                }
            return nameList;
        }

        private List<string> getGroup(List<string> command)
        {
            List<string> groupName = new List<string>();
            if (commandRows.Any())
            {
                List<string> rows = new List<string>();
                foreach (string row in commandRows)
                {
                    rows.AddRange(row.Split('|').Where(r => !string.IsNullOrEmpty(r)));
                }
                var result = connection.CallCommandSync(rows.ToArray());
                foreach (var resultItem in result)
                {
                    string g = "";
                    foreach (var word in resultItem.Words)
                    {
                        if (word.Key.Equals("name"))
                        {
                            g = word.Value;
                        }
                    }
                    groupName.Add(g);
                }
                commandRows.Clear();
            }
            return groupName;
        }
        //
        // Add User
        //
        private void btnOk_Click(object sender, EventArgs e)
        {
            bool check = checkUsername();
            bool flag = true;
            if (txtUsername.Text.IsNullOrWhiteSpace())
            {
                MessageBox.Show("Username is required.");
                flag = false;
            }
            else if (cbGroup.SelectedItem.ToString().IsNullOrWhiteSpace())
            {
                MessageBox.Show("Group is required.");
                flag = false;
            }
            else if (txtPassword.Text.IsNullOrWhiteSpace())
            {
                MessageBox.Show("Password is invalid.");
                flag = false;
            }
            else if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                MessageBox.Show("Password does not match.");
                flag = false;
            }
            else if (check == false)
            {
                MessageBox.Show("Username is already existed.");
            }
            else if( check == true && flag == true)
            {
                commandRows.Add("/user/add");
                commandRows.Add("=name=" + txtUsername.Text);
                commandRows.Add("=group=" + cbGroup.SelectedItem.ToString());
                commandRows.Add("=password=" + txtPassword.Text);
                ExecuteParameterCommand(commandRows);
                Close();
            }
        }
        //
        // Form on Load
        //
        private void AddUserForm_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "User";
            commandRows.Add("/user/group/print");
            List<string> name = getGroup(commandRows);
            if (name.Any())
            {
                foreach (var n in name)
                {
                    cbGroup.Items.Add(n);
                }
                cbGroup.SelectedIndex = 0;
            }
        }
        //-------------------------------------------Function--------------------------------------//
        //
        // Execute Command
        //
        private void ExecuteCommand(string commandStr)
        {
            if (!string.IsNullOrWhiteSpace(commandStr))
                commandRows.Add(commandStr);
            if (commandRows.Any())
            {
                List<string> rows = new List<string>();
                foreach (string row in commandRows)
                {
                    rows.AddRange(row.Split('|').Where(r => !string.IsNullOrEmpty(r)));
                }
                var result = connection.CallCommandSync(rows.ToArray());
                commandRows.Clear();
            }
        }
        //
        // Execute Command With Parameter
        //
        private void ExecuteParameterCommand(List<string> commandRows)
        {
            if (commandRows.Any())
            {
                List<string> rows = new List<string>();
                foreach (string row in commandRows)
                {
                    rows.AddRange(row.Split('|').Where(r => !string.IsNullOrEmpty(r)));
                }
                var result = connection.CallCommandSync(rows.ToArray());
                commandRows.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
