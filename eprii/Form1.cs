using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
namespace eprii
{
    public partial class Form1 : Form
    {
        private string exitPassword = "epri@2023"; // Set your desired exit password here
        public Form1()
        {
            InitializeComponent();
            timer1.Start(); // Start the timer when the form is loaded
            timer2.Start(); // Start the timer when the form is loaded
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Set the form properties for full-screen mode
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            // Check if the password is entered correctly
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                PromptForExitPassword();
            }
        }

        private void PromptForExitPassword()
        {
            string password = PromptForPassword();

            if (password == exitPassword)
            {
                // Exit the application
                Application.Exit();
            }
            else
            {
                // Incorrect password, do something (e.g., show an error message)
            }
        }

        private string PromptForPassword()
        {
            // Show a password input dialog
            // You can implement your own custom dialog or use a third-party library
            // For simplicity, let's use the built-in InputBox dialog in this example
            string password = Microsoft.VisualBasic.Interaction.InputBox("Enter password:", "Password Required");

            return password;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += MainForm_FormClosing;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to quit the application?", "Xyma Analytics(XYQA001)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Process.Start("shutdown", "/s /t 0");
                }
                else
                {
                    e.Cancel = true; // Cancel the close operation
                }
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private int elapsedSeconds = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;

            // Update progress bar value based on the elapsed time
            progressBar1.Value = (int)((float)elapsedSeconds / 3 * 100);
            if (elapsedSeconds >= 3)
            {
                timer1.Stop(); // Stop the timer
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop(); // Stop the timer to prevent it from ticking again

            Form2 form2 = new Form2();
            form2.Show();

            this.Hide();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }
    }
}