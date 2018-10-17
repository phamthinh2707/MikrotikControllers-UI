using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quickLogin;

namespace quickLogin1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "SHA256":
                    textBox2.Text = Hashing.ComputeHash(textBox1.Text, Supported_HA.SHA256, null);
                    break;
                case "SH384":
                    textBox2.Text = Hashing.ComputeHash(textBox1.Text, Supported_HA.SHA384, null);
                    break;
                case "SH512":
                    textBox2.Text = Hashing.ComputeHash(textBox1.Text, Supported_HA.SHA512, null);
                    break;
            }
        }

        private void Confirm(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "SHA256":
                    label3.Text = (Hashing.Confirm(textBox1.Text,textBox2.Text,Supported_HA.SHA256)) ? "Status: Correct": "Status: Incorrect";
                    break;
                case "SH384":
                    label3.Text = (Hashing.Confirm(textBox1.Text, textBox2.Text, Supported_HA.SHA384)) ? "Status: Correct" : "Status: Incorrect";
                    break;
                case "SH512":
                    label3.Text = (Hashing.Confirm(textBox1.Text, textBox2.Text, Supported_HA.SHA512)) ? "Status: Correct" : "Status: Incorrect";
                    break;
            } 
        }
    }
}
