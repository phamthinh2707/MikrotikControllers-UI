using System;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tik4net.Api;
using tik4net;
using Newtonsoft.Json;
using System.IO;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using tik4net.Objects.Interface;
using tik4net.Objects;


namespace tik4net.controller
{
    public partial class Form1 : Form
    {
        private ITikConnection connection = ConnectionFactory.CreateConnection(TikConnectionType.Api);
        private List<string> commandRows = new List<string>();
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public delegate ITikConnection sendConnection(ITikConnection con);

        public Form1()
        {
            InitializeComponent();
            if (lblStatus.Text.Equals("Disconnect") || lblStatus.Text.Equals("Not Connected!"))
            {
                btnSubmit.Enabled = false;
                tableOption.Visible = false;
                txtCommand.ReadOnly = true;
            }
        }
        //
        // Script Object
        //
        public class Script
        {
            public int ScriptIndex { get; set; }
            public List<string> ScriptValue { get; set; }
        }
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
        // Button Submit Commands
        //
        private void btnSubmit_MouseClick(object sender, MouseEventArgs e)
        {
            string command = txtCommand.Text;
            ExecuteCommand(command);
            txtCommand.Text = "";
        }
        //
        // Button Connect
        //
        private void btnConnect_MouseClick(object sender, MouseEventArgs e)
        {
            string action = btnConnect.Text;
            if (action == "Connect")
            {
                string host = txtHost.Text;
                string user = txtUser.Text;
                string password = txtPassword.Text;
                if (!host.IsNullOrWhiteSpace() && !user.IsNullOrWhiteSpace())
                {
                    try
                    {
                        connection.OnReadRow += Connection_OnReadRow;
                        connection.OnWriteRow += Connection_OnWriteRow;
                        connection.Open(host, user, password);
                        lblStatus.Text = "Connected";
                        lblStatus.ForeColor = System.Drawing.Color.Green;
                        tableOption.Visible = true;
                        btnSubmit.Enabled = true;
                        txtCommand.ReadOnly = false;
                        btnConnect.Text = "Disconnect";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Your Host and Password.");
                }
            }
            else if (action == "Disconnect")
            {
                connection.Close();
                btnConnect.Text = "Connect";
                lblStatus.Text = "Disconnect";
                lblStatus.ForeColor = Color.Crimson;
                rtxDisplay.Text = "";
                tableOption.Visible = false;
                btnSubmit.Enabled = false;
                txtCommand.ReadOnly = true;
            }
        }
        //
        // 
        //
        private void Connection_OnWriteRow(object sender, TikConnectionCommCallbackEventArgs args)
        {
            rtxDisplay.Text += (args.Word + "\n");
        }
        //
        //
        //
        private void Connection_OnReadRow(object sender, TikConnectionCommCallbackEventArgs args)
        {
            rtxDisplay.Text += (args.Word + "\n");
        }
        //
        // Add command by Enter key
        //
        private void txtCommand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCommand.Text.Equals("clear"))
                {
                    rtxDisplay.Text = "";
                    txtCommand.Text = "";
                }
                else
                {
                    commandRows.Add(txtCommand.Text);
                    List<string> rows = new List<string>();
                    foreach (string row in commandRows)
                    {
                        rtxDisplay.Text = txtCommand.Text + "\n";
                    }
                    txtCommand.Text = "";
                }
            }
        }
        //
        // Button Browser File
        //
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                var router = JsonConvert.DeserializeObject<dynamic>(sr.ReadToEnd());
                txtHost.Text = router.host;
                txtUser.Text = router.user;
                txtPassword.Text = router.password;
            }
        }
        //
        // Button Reboot
        //
        private void btnReboot_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to reboot Router?", "Reboot Router", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ExecuteCommand("/system/reboot");
            }
            else
            {
                MessageBox.Show("Action Cancelled!");
            }
        }
        //
        // Show Reset Form and Tranfer Connection
        //
        private void btnResetConfiguration_Click(object sender, EventArgs e)
        {
            Reset reset = new Reset();
            reset.getter(connection);
            reset.ShowDialog();
        }
        //
        // Open Wall Garden Dialog
        //
        private void btnWallGarden_Click(object sender, EventArgs e)
        {
            WalledGardenForm wallGarden = new WalledGardenForm();
            wallGarden.getter(connection);
            wallGarden.ShowDialog();
        }
        //
        // Button Setup Wifi Marketing
        //
        private void btnWifiMarketing_Click(object sender, EventArgs e)
        {
            using (StreamReader stream = new StreamReader("C:/Users/firel/Desktop/ScriptWifiSplit.json"))
            {
                var str = stream.ReadToEnd();
                var scripts = JsonConvert.DeserializeObject<List<Script>>(str);
                foreach (Script command in scripts)
                {
                    foreach (string row in command.ScriptValue)
                    {
                        commandRows.Add(row);
                    }

                }
            }
            //using (var conn = tik4net.ConnectionFactory.OpenConnection(TikConnectionType.Api, "192.168.88.1", 8728, "admin", ""))
            //{
            //    var obj = conn.LoadList<InterfaceWireless>(conn.CreateParameter("default-name", "wlan1")).First();
            //    obj.Disabled = false;
            //    obj.Mode = tik4net.Objects.Interface.InterfaceWireless.WirelessMode.ApBridge;
            //    obj.Ssid = "Testing Wifi Marketing";
            //    conn.Save(obj);
            //}
        }
        //
        // Get Router MAC
        //
        private void btnGetMAC_Click(object sender, EventArgs e)
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String MACAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (MACAddress == String.Empty)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    MACAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            txtHost.Text = MACAddress;
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            UserMangementForm umf = new UserMangementForm();
            umf.getter(connection);
            umf.ShowDialog();
        }

        private void btnBasicConfig_Click(object sender, EventArgs e)
        {
            BasicConfigurationForm basicConfig = new BasicConfigurationForm();
            basicConfig.getter(connection);
            basicConfig.ShowDialog();
        }
    }
}