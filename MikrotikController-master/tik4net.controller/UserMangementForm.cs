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
    public partial class UserMangementForm : Form
    {
        private ITikConnection connection;
        public delegate void getConnection(ITikConnection conn);
        List<string> commandRows = new List<string>();
        public getConnection getter;
        public UserMangementForm()
        {
            InitializeComponent();
            getter = new getConnection(getConn);
        }

        private void getConn(ITikConnection conn)
        {
            connection = conn;
        }
        //-------------------------------------------User--------------------------------------//
        public class User
        {
            public string name { get; set; }
            public string group { get; set; }
            public string lastLoggedIn { get; set; }
            public string address { get; set; }
            public string disabled { get; set; }
        }
        //
        // Get User 
        //
        private List<User> getUsers(List<string> command)
        {
            List<User> users = new List<User>();
            if (command.Any())
            {
                List<string> rows = new List<string>();
                foreach (string row in commandRows)
                {
                    rows.AddRange(row.Split('|').Where(r => !string.IsNullOrEmpty(r)));
                }
                var result = connection.CallCommandSync(rows.ToArray());
                foreach (var resultItem in result)
                {
                    User u = new User();
                    foreach (var word in resultItem.Words)
                    {
                        if (word.Key.Equals("name"))
                        {
                            u.name = word.Value;
                        }
                        else if (word.Key.Equals("group"))
                        {
                            u.group = word.Value;
                        }
                        else if (word.Key.Equals("last-logged-in"))
                        {
                            u.lastLoggedIn = word.Value;
                        }
                        else if (word.Key.Equals("disabled"))
                        {
                            u.disabled = word.Value;
                        }
                        u.address = "";
                    }
                    users.Add(u);
                }
                commandRows.Clear();
            }
            return users;
        }
        //
        // Display All Users Into DataGrip
        //
        private void displayUsers(List<User> item)
        {
            int amountOfUser = 0;
            List<User> users = item;
            foreach (var u in users)
            {
                object[] Rows = new object[]
                {
                    amountOfUser,
                    u.name,
                    u.group,
                    u.address,
                    u.lastLoggedIn,
                    u.disabled
                };
                amountOfUser++;
                UserGridView.Rows.Add(Rows);
            }
            #region Render Color for User Grid View
            foreach (DataGridViewRow row in UserGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells[5].Value))
                {
                    row.DefaultCellStyle.ForeColor = Color.Gray;
                }
            }
            #endregion
            if (amountOfUser == 2)
                AmountOfUser.Text = (amountOfUser - 1) + " User.";
            else
                AmountOfUser.Text = (amountOfUser - 1) + " Users.";
        }
        //
        // Add New User Dialog
        //
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm auf = new AddUserForm();
            auf.getter(connection);
            auf.ShowDialog();
            UserGridView.Rows.Clear();
            commandRows.Add("/user/print");
            displayUsers(getUsers(commandRows));
        }
        //
        // Remove User Button
        //
        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            string name = UserGridView.CurrentRow.Cells["username"].FormattedValue.ToString();
            if (!name.Equals("admin"))
            {
                commandRows.Add("/user/remove");
                commandRows.Add("=numbers=" + name);
                ExecuteParameterCommand(commandRows);
            }
            else
            {
                MessageBox.Show("Couldn't change User <admin>");
            }
            UserGridView.Refresh();
            UserGridView.Rows.Clear();
            commandRows.Add("/user/print");
            displayUsers(getUsers(commandRows));
        }
        //
        // Enable User Button   
        //
        private void btnEnabledUser_Click(object sender, EventArgs e)
        {
            string name = UserGridView.CurrentRow.Cells["username"].FormattedValue.ToString();
            if (name.Any())
            {
                commandRows.Add("/user/enable");
                commandRows.Add("=numbers=" + name);
                ExecuteParameterCommand(commandRows);
                UserGridView.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
            }
        }
        //
        // Disable User Button
        //
        private void btnDisabledUser_Click(object sender, EventArgs e)
        {
            string name = UserGridView.CurrentRow.Cells["username"].FormattedValue.ToString();
            if (!name.Equals("admin"))
            {
                commandRows.Add("/user/disable");
                commandRows.Add("=numbers=" + name);
                ExecuteParameterCommand(commandRows);
                UserGridView.CurrentRow.DefaultCellStyle.ForeColor = Color.Gray;
            }
            else
            {
                MessageBox.Show("Couldn't change User <admin>");
            }
        }
        //
        // Edit User
        //
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            List<string> userData = new List<string>();
            userData.Add(UserGridView.CurrentRow.Cells["Numbers"].FormattedValue.ToString());
            userData.Add(UserGridView.CurrentRow.Cells["username"].FormattedValue.ToString());
            userData.Add(UserGridView.CurrentRow.Cells["userGroup"].FormattedValue.ToString());
            userData.Add(UserGridView.CurrentRow.Cells["userAddress"].FormattedValue.ToString());
            userData.Add(UserGridView.CurrentRow.Cells["userLastLogin"].FormattedValue.ToString());
            EditUserForm euf = new EditUserForm();
            euf.getter(connection);
            euf.userGetter(userData);
            euf.ShowDialog();
        }

        //-------------------------------------------Active User--------------------------------//
        private class ActiveUser
        {
            public string name { get; set; }
            public string at { get; set; }
            public string address { get; set; }
            public string via { get; set; }
        }
        //
        // Get Active User from Router
        //
        private List<ActiveUser> getActiveUsers(List<string> command)
        {
            List<ActiveUser> activeUsers = new List<ActiveUser>();
            if (commandRows.Any())
            {
                List<string> rows = new List<string>();
                foreach (string row in commandRows)
                {
                    rows.AddRange(row.Split('|').Where(r => !string.IsNullOrEmpty(r)));
                }
                var result = connection.CallCommandSync(rows.ToArray());
                foreach (var resutlItem in result)
                {
                    ActiveUser au = new ActiveUser();
                    foreach (var word in resutlItem.Words)
                    {
                        if (word.Key.Equals("name"))
                        {
                            au.name = word.Value;
                        }
                        else if (word.Key.Equals("when"))
                        {
                            au.at = word.Value;
                        }
                        else if (word.Key.Equals("via"))
                        {
                            au.via = word.Value;
                        }
                        else if (word.Key.Equals("address"))
                        {
                            au.address = word.Value;
                        }
                    }
                    activeUsers.Add(au);
                }
                commandRows.Clear();
            }
            return activeUsers;
        }
        private void displayActiveUsers(List<ActiveUser> item)
        {
            List<ActiveUser> activeUsers = item;
            int amountOfAcitve = 0;
            foreach (var au in activeUsers)
            {
                object[] Rows = new object[]
                {
                    au.name,
                    au.at,
                    au.address,
                    au.via
                };
                ActiveUserGridView.Rows.Add(Rows);
                amountOfAcitve++;
            }
            if (amountOfAcitve == 2)
                AmountOfActiveUser.Text = (amountOfAcitve - 1) + " Active User.";
            else
                AmountOfActiveUser.Text = (amountOfAcitve - 1) + " Active Users.";
        }
        //-------------------------------------------Group--------------------------------------//
        public class Group
        {
            public string name { get; set; }
            public string policies { get; set; }
            public string skin { get; set; }
        }
        //
        // Get Group from Router
        //
        private List<Group> getGroups(List<string> command)
        {
            List<Group> groups = new List<Group>();
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
                    Group g = new Group();
                    foreach (var word in resultItem.Words)
                    {
                        if (word.Key.Equals("name"))
                        {
                            g.name = word.Value;
                        }
                        else if (word.Key.Equals("policy"))
                        {
                            g.policies = word.Value;
                        }
                        else if (word.Key.Equals("skin"))
                        {
                            g.skin = word.Value;
                        }
                    }
                    groups.Add(g);
                }
                commandRows.Clear();
            }
            return groups;
        }
        //
        // Display All Group Into DataGrip
        //
        private void displayGroup(List<Group> item)
        {
            int amountOfGroup = 0;
            List<Group> groups = item;
            foreach (var g in groups)
            {
                object[] Rows = new object[]
                {
                    g.name,
                    g.policies,
                    g.skin
                };
                GroupGridView.Rows.Add(Rows);
                amountOfGroup++;
            }
            if (amountOfGroup == 2)
                AmountOfGroup.Text = (amountOfGroup - 1) + " Group.";
            else
                AmountOfGroup.Text = (amountOfGroup - 1) + " Groups.";
        }
        //
        // Add Group
        //
        private void btnAddGroup_Click(object sender, EventArgs e)
        {

        }
        //
        // Remove Group
        //
        private void btnRemoveGroup_Click(object sender, EventArgs e)
        {
            string name = GroupGridView.CurrentRow.Cells["nameGroup"].FormattedValue.ToString();
            if (name != null)
            {
                commandRows.Add("/user/group/remove");
                commandRows.Add("=numbers=" + name);
                ExecuteParameterCommand(commandRows);
            }
            GroupGridView.Rows.Clear();
            commandRows.Add("/user/group/print");
            displayGroup(getGroups(commandRows));
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
        //
        // Get Data from Router On Load 
        //
        private void UserMangementForm_Load(object sender, EventArgs e)
        {
            commandRows.Add("/user/print");
            if (commandRows.Any())
            {
                displayUsers(getUsers(commandRows));
            }
            commandRows.Clear();
            commandRows.Add("/user/group/print");
            if (commandRows.Any())
            {
                displayGroup(getGroups(commandRows));
            }
            commandRows.Clear();
            commandRows.Add("/user/active/print");
            displayActiveUsers(getActiveUsers(commandRows));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GroupGridView.Refresh();
        }
    }
}
