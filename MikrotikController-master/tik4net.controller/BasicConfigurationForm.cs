using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;



namespace tik4net.controller
{
    public partial class BasicConfigurationForm : Form
    {
        List<string> commandRows = new List<string>();
        private ITikConnection connection;
        public delegate void getConnection(ITikConnection conn);
        public getConnection getter;
        string username = null;
        string password = null;
        string wpaKey = null;
        string wpa2Key = null;

        public BasicConfigurationForm()
        {
            InitializeComponent();
            getter = new getConnection(getConn);
        }

        private void getConn(ITikConnection conn)
        {
            connection = conn;
        }
        //
        //Wizard page 1
        // 
        private void btnNext1_Click(object sender, EventArgs e)
        {
            this.page1.Visible = false;
            if (this.rdPppoe.Checked)
            {
                this.page2a.Visible = true;

            }
            else
            {
                if (this.rdDhcp.Checked)
                {
                    this.page3.Visible = true;
                }
                else
                {

                    MessageBox.Show("Your action is not supported!", "ERROR!", MessageBoxButtons.OK);

                }
            }
        }
        //
        //Wizard Page 2a PPPoE
        //
        private void btnNext2a_Click(object sender, EventArgs e)
        {
            this.page2a.Visible = false;
            this.page3.Visible = true;
            username = txtUsername.Text;
            password = txtPassword.Text;
        }

        private void btnBack2a_Click(object sender, EventArgs e)
        {
            this.page2a.Visible = false;
            this.page1.Visible = true;
        }


        //
        //Wizard Page 3 Wireless Security-profiles
        //
        private void btnBack3_Click(object sender, EventArgs e)
        {
            this.page3.Visible = false;
            if (this.rdPppoe.Checked)
            {
                this.page2a.Visible = true;
            }
            else
            {
                if (this.rdDhcp.Checked)
                {
                    this.page1.Visible = true;
                }
                else
                {

                    MessageBox.Show("Your action is not supported!", "ERROR!", MessageBoxButtons.OK);

                }
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            using (StreamReader stream = new StreamReader("D:/GitHub/MikrotikController/Json File/Script Basic API.json"))
            if (txtWpa.Text.Length < 8 || txtWpa.Text.Length > 63) {
                MessageBox.Show("The WPA pre-shared key must between 8-63 charaters!", "ERROR!", MessageBoxButtons.OK);
                return; 
            }
            else
            {
                if (txtWpa2.Text.Length < 8 || txtWpa2.Text.Length > 63)
                {
                    MessageBox.Show("The WPA2 pre-shared key key must between 8-63 charaters!", "ERROR!", MessageBoxButtons.OK);
                    return;
                }
            }
            using (StreamReader stream = new StreamReader("G:/Study's data/OJT/Script Basic Configuration.json"))
            {
                var str = stream.ReadToEnd();
                var scripts = JsonConvert.DeserializeObject<List<Script>>(str);
                foreach (Script command in scripts)
                {
                    foreach (string row in command.ScriptValue)
                    {
                        commandRows.Add(row);
                    }
                    ExecuteParameterCommand(commandRows);
                }
            }
            if (this.rdPppoe.Checked)
            {
                List<string> cmdRows = new List<string>();
                cmdRows.Add("/interface/pppoe-client/add");
                cmdRows.Add("=add-default-route=yes");
                cmdRows.Add("=disabled=no");
                cmdRows.Add("=interface=ether1");
                cmdRows.Add("=name=pppoe-out1");
                cmdRows.Add("=password=" + password);
                cmdRows.Add("=use-peer-dns=yes");
                cmdRows.Add("=user=" + username);
                ExecuteParameterCommand(cmdRows);
            }
            else
            {
                if (this.rdDhcp.Checked)
                {
                    List<string> rows = new List<string>();
                    rows.Add("/ip/dhcp-client/add");
                    rows.Add("=interface=ether1");
                    rows.Add("=disabled=no");
                    rows.Add("=dhcp-options=hostname,clientid");
                    ExecuteParameterCommand(rows);
                }
                else
                {

                    MessageBox.Show("Your action is not supported!", "ERROR!", MessageBoxButtons.OK);

                }
            }
            List<string> cmdWireless1 = new List<string>();
            cmdWireless1.Add("/interface/wireless/security-profiles/set");
            cmdWireless1.Add("=.id=default");
            cmdWireless1.Add("=supplicant-identity=MikroTik");
            ExecuteParameterCommand(cmdWireless1);
            wpaKey = txtWpa.Text;
            wpa2Key = txtWpa2.Text;
            List<string> cmdWireless2 = new List<string>();
            cmdWireless2.Add("/interface/wireless/security-profiles/add");
            cmdWireless2.Add("=authentication-types=wpa-psk,wpa2-psk");
            cmdWireless2.Add("=group-ciphers=tkip,aes-ccm");
            cmdWireless2.Add("=mode=dynamic-keys");
            cmdWireless2.Add("=name=wlan1-CaPhe191-repeater");
            cmdWireless2.Add("=supplicant-identity=MikroTik");
            cmdWireless2.Add("=unicast-ciphers=tkip,aes-ccm");
            cmdWireless2.Add("=wpa-pre-shared-key=" + wpaKey);
            cmdWireless2.Add("=wpa2-pre-shared-key=" + wpa2Key);
            ExecuteParameterCommand(cmdWireless2);
            this.Close();
        }

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
        public class Script
        {
            public int ScriptIndex { get; set; }
            public List<string> ScriptValue { get; set; }
        }
    }
}
