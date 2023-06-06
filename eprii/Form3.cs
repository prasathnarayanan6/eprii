using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;
namespace eprii
{
    public partial class Form3 : Form
    {
        private string exitPassword = "your_password"; // Set your desired exit password here

        public Form3()
        {
            InitializeComponent();
            timer1.Start(); // Start the timer when the form is loaded
            timer2.Start();

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

        private void Form3_Load(object sender, EventArgs e)
        {
            bool mySQLRunning = IsServiceRunning("mysql");
            bool apacheRunning = IsServiceRunning("apache");

            if (!mySQLRunning || !apacheRunning)
            {
                string message = "XAMPP services are not running!";
                string caption = "XAMPP Status";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;

                MessageBox.Show(message, caption, buttons, icon);
            }
            UpdateTime();
        }

        private bool IsServiceRunning(string serviceName)
        {
            // Check if the specified service is running using Windows command line
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c sc query " + serviceName + " | findstr STATE";
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            process.StartInfo = startInfo;
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            return output.Contains("RUNNING");
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            // Create a rectangle with rounded corners
            Rectangle rect = panel1.ClientRectangle;
            rect.Inflate(-5, -5);
            path.AddArc(rect.X, rect.Y, 10, 10, 180, 90);
            path.AddArc(rect.X + rect.Width - 10, rect.Y, 10, 10, 270, 90);
            path.AddArc(rect.X + rect.Width - 10, rect.Y + rect.Height - 10, 10, 10, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - 10, 10, 10, 90, 90);
            path.CloseFigure();

            // Set the Region property of the Panel to the GraphicsPath
            panel1.Region = new Region(path);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            // Create a rectangle with rounded corners
            Rectangle rect = panel2.ClientRectangle;
            rect.Inflate(-5, -5);
            path.AddArc(rect.X, rect.Y, 10, 10, 180, 90);
            path.AddArc(rect.X + rect.Width - 10, rect.Y, 10, 10, 270, 90);
            path.AddArc(rect.X + rect.Width - 10, rect.Y + rect.Height - 10, 10, 10, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - 10, 10, 10, 90, 90);
            path.CloseFigure();

            // Set the Region property of the Panel to the GraphicsPath
            panel2.Region = new Region(path);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            // Create a rectangle with rounded corners
            Rectangle rect = panel3.ClientRectangle;
            rect.Inflate(-5, -5);
            path.AddArc(rect.X, rect.Y, 10, 10, 180, 90);
            path.AddArc(rect.X + rect.Width - 10, rect.Y, 10, 10, 270, 90);
            path.AddArc(rect.X + rect.Width - 10, rect.Y + rect.Height - 10, 10, 10, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - 10, 10, 10, 90, 90);
            path.CloseFigure();

            // Set the Region property of the Panel to the GraphicsPath
            panel3.Region = new Region(path);

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            // Create a rectangle with rounded corners
            Rectangle rect = panel4.ClientRectangle;
            rect.Inflate(-5, -5);
            path.AddArc(rect.X, rect.Y, 10, 10, 180, 90);
            path.AddArc(rect.X + rect.Width - 10, rect.Y, 10, 10, 270, 90);
            path.AddArc(rect.X + rect.Width - 10, rect.Y + rect.Height - 10, 10, 10, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - 10, 10, 10, 90, 90);
            path.CloseFigure();

            // Set the Region property of the Panel to the GraphicsPath
            panel4.Region = new Region(path);

        }
        public class MyDataObject
        {
            public string date { get; set; }
            public string s1 { get; set; }
            public string s2 { get; set; }

            public string s3 { get; set; }
            public string s4 { get; set; }

            public string error { get; set; }

            // ...
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Process process in Process.GetProcesses().Where(p => p.ProcessName == "epri3"))
                {
                    process.Kill();
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Does'nt exixts");
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string json = client.DownloadString("http://127.0.0.1:8080/appp/data.php");
            // Deserialize the JSON data into a .NET object
            MyDataObject data = JsonConvert.DeserializeObject<MyDataObject>(json);

            // Use the deserialized object to populate your dashboar
            label18.Text = data.date;
            label3.Text = data.s1;
            label5.Text = data.s2;
            label10.Text = data.s3;
            label13.Text = data.s4;
            label15.Text = data.error;
            if (data.error == "XYER100")
            {
                label15.ForeColor = Color.Green;
                label16.ForeColor = Color.Green;
                iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Check;
                iconPictureBox6.ForeColor = Color.Green;
            }
            else
            {
                label15.ForeColor = Color.Red; // Replace with the default text color you want to use
                label16.ForeColor = Color.Red;
                iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
                iconPictureBox6.ForeColor = Color.Red;
            }
        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void Form3_Load_1(object sender, EventArgs e)
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
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {


        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {


        }
        private void UpdateTime()
        {
            DateTime currentTime = DateTime.Now;
            label20.Text = currentTime.ToString("dd-MM-yyyy HH:mm:ss");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }
    }
}
