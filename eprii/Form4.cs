using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eprii
{
    public partial class Form4 : Form
    {
        private string exitPassword = "epri@2023"; // Set your desired exit password here
        public Form4()
        {
            InitializeComponent();
            MaximizeBox = false;
            ControlBox = false;
            MinimizeBox = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string enteredPassword = textBox1.Text;

            if (enteredPassword == exitPassword)
            {
                // Password is correct, close the application
                Environment.Exit(0);
                //Process.Start("shutdown", "/s /t 0");
            }
            else
            {
                // Password is incorrect, display an error message
                MessageBox.Show("Incorrect password. Please try again.", "Xyma Analytics(XYQA002)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
