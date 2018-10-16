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
    public partial class EditUserForm : Form
    {
        List<string> commandRows = new List<string>();
        private List<string> userData;
        private ITikConnection connection;
        public delegate void getConnection(ITikConnection conn);
        public delegate void getUser(List<string> user);
        public getConnection getter;
        public getUser userGetter;
        public EditUserForm()
        {
            InitializeComponent();
            getter = new getConnection(getConn);
            userGetter = new getUser(getUserData);
        }

        private void getConn(ITikConnection conn)
        {
            connection = conn;
        }

        private void getUserData(List<string> user)
        {
            userData = user;
        }
        //
        // Set Data Onload
        //
        private void EditUserForm_Load(object sender, EventArgs e)
        {
            List<string> groupName = getGroup();
            foreach (string name in groupName)
            {
                cbGroup.Items.Add(name);
            }
            cbGroup.SelectedItem = userData[2];
            txtUsername.Text = userData[1];
            txtAddress.Text = userData[3];
            txtLastLoggedIn.Text = userData[4];
        }
        //
        //
        //
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //
        //
        //
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.IsNullOrWhiteSpace())
            {
                MessageBox.Show("Name is required.");
            } else if (cbGroup.SelectedIndex.ToString().IsNullOrWhiteSpace())
            {
                MessageBox.Show("Group is required.");
            } else
            {
                commandRows.Add("/user/set");
                commandRows.Add("=numbers="+ userData[0]);
                commandRows.Add("=name=" + txtUsername.Text);
                commandRows.Add("=group=" + cbGroup.SelectedItem.ToString());
                commandRows.Add("=address=" + txtAddress.Text);
                ExecuteParameterCommand(commandRows);
            }
        }
        //-------------------------------------------Function--------------------------------------//
        //
        // getGroup
        //
        private List<string> getGroup()
        {
            commandRows.Add("/user/group/print");
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
    }
}
