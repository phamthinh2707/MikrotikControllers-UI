using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using tik4net;

namespace tik4net.controller
{
    public partial class Reset : Form
    {
        private ITikConnection connection;
        public delegate void getConnection(ITikConnection conn);
        public getConnection getter;

        public Reset()
        {
            InitializeComponent();
            getter = new getConnection(getConn);
        }

        private void getConn(ITikConnection conn)
        {
            connection = conn;
        }

        public class Script
        {
            public int ScriptIndex { get; set; }
            public List<string> ScriptValue { get; set; }
        }
        //
        // Execute Command
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
        // Button Reset
        //
        private void btnResetConfiguration_Click(object sender, EventArgs e)
        {
            //
            // Reset Default Configuration
            //
            if (radioResetNoDefault.Checked == true)
            {
                using (StreamReader stream = new System.IO.StreamReader(@"C:\Users\firel\Desktop\Script.json"))
                {
                    var str = stream.ReadToEnd();
                    var script = JsonConvert.DeserializeObject<List<Script>>(str);
                    ExecuteParameterCommand(script[0].ScriptValue);
                    Close();
                    
                }
            }
            //
            // Reset Keep User Configuration
            //
            else if (radioResetKeepUserConfiguration.Checked == true)
            {
                using (StreamReader stream = new System.IO.StreamReader(@"C:\Users\firel\Desktop\Script.json"))
                {
                    var str = stream.ReadToEnd();
                    var script = JsonConvert.DeserializeObject<List<Script>>(str);
                    ExecuteParameterCommand(script[1].ScriptValue);
                    Close();
                }
            }
            //
            // Reset CAPS Mode
            //
            else if (radioResetCAPSMode.Checked == true)
            {
                using (StreamReader stream = new System.IO.StreamReader(@"C:\Users\firel\Desktop\Script.json"))
                {
                    List<string> commandRows = new List<string>();
                    var str = stream.ReadToEnd();
                    var script = JsonConvert.DeserializeObject<List<Script>>(str);
                    ExecuteParameterCommand(script[3].ScriptValue);
                    Close();
                }
            }
            //
            // Reset Not Backup
            //
            else if (radioResetNotBackup.Checked == true)
            {
                using (StreamReader stream = new System.IO.StreamReader(@"C:\Users\firel\Desktop\Script.json"))
                {
                    var str = stream.ReadToEnd();
                    var script = JsonConvert.DeserializeObject<List<Script>>(str);
                    ExecuteParameterCommand(script[2].ScriptValue);
                    Close();
                }
            }
            //
            //
            //
            else
            {
                MessageBox.Show("Please Choose An Option To Perform!");
            }
        }
        //
        //
        //
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
