using Microsoft.Windows.Themes;
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
using static System.Windows.Forms.DataFormats;
using System.Management;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using static eprii.Form1;

namespace eprii
{
    public partial class Form2 : Form
    {
        private const int WM_DEVICECHANGE = 0x0219;
        private const int DBT_DEVICEARRIVAL = 0x8000;
        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        private const int DBT_DEVTYP_VOLUME = 0x00000002;
        private ManagementEventWatcher watcher;
        private string exitPassword = "your_password"; // Set your desired exit password here
        public Form2()
        {
            Load += Form2_Load;
            InitializeComponent();
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct DEV_BROADCAST_VOLUME
        {
            public int dbcv_size;
            public int dbcv_devicetype;
            public int dbcv_reserved;
            public int dbcv_unitmask;
            public short dbcv_flags;
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


        private void Form2_Load(object sender, EventArgs e)
        {
            watcher = new ManagementEventWatcher();
            WqlEventQuery query = new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2");
            watcher.EventArrived += Watcher_EventArrived;
            watcher.Query = query;
            watcher.Start();
            this.FormClosing += MainForm_FormClosing;
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop the watcher when the form is closing
            watcher?.Stop();
        }
        private void Watcher_EventArrived(object sender, EventArrivedEventArgs e)
        {
            // Display the pop-up notification when a USB device is inserted
            MessageBox.Show("Successfully Inserted USB device", "Xyma Analytics", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string originalExePath = @"C:\Users\Home\Desktop\EPRI_2023\application3\dist\epri3.exe";
            string alternativeExePath = @"C:\Users\Xyma\Desktop\EPRI_2023\dist\epri3.exe";
            string fileName = System.IO.Path.GetFileName(originalExePath);
            string exePath = File.Exists(originalExePath) ? originalExePath : alternativeExePath;


            if (File.Exists(exePath))
            {
                try
                {
                    Process[] processes = Process.GetProcessesByName(fileName);
                    if (processes.Length > 0)
                    {
                        MessageBox.Show("The process is already running.\n", "Xyma Analytics(XYER002)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Process.Start(exePath);
                    }
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while starting the executable:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The specified executable file does not exist in\n 'C:\\Users\\Home\\Desktop\\EPRI_2023\\application3\\dist\\epri3.exe' ", "Xyma Analytics(XYER001)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }
        //usb

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_DEVICECHANGE)
            {
                if (m.WParam.ToInt32() == DBT_DEVICEARRIVAL)
                {
                    DEV_BROADCAST_VOLUME volume = (DEV_BROADCAST_VOLUME)Marshal.PtrToStructure(m.LParam, typeof(DEV_BROADCAST_VOLUME));
                    if (volume.dbcv_devicetype == DBT_DEVTYP_VOLUME)
                    {
                        string driveLetter = GetDriveLetterFromMask(volume.dbcv_unitmask);
                        ShowPopup("USB device inserted: " + driveLetter);
                    }
                }
                else if (m.WParam.ToInt32() == DBT_DEVICEREMOVECOMPLETE)
                {
                    DEV_BROADCAST_VOLUME volume = (DEV_BROADCAST_VOLUME)Marshal.PtrToStructure(m.LParam, typeof(DEV_BROADCAST_VOLUME));
                    if (volume.dbcv_devicetype == DBT_DEVTYP_VOLUME)
                    {
                        string driveLetter = GetDriveLetterFromMask(volume.dbcv_unitmask);
                        ShowPopup("USB device ejected: " + driveLetter);
                    }
                }
            }

            base.WndProc(ref m);
        }

        private string GetDriveLetterFromMask(int unitmask)
        {
            char letter = '\0'; // Initialize letter with a default value
            string drives = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int cnt = 0;
            int mask = 0x1;

            for (int i = 0; i < 26; ++i)
            {
                if ((unitmask & mask) != 0)
                {
                    letter = drives[i];
                    cnt++;
                }
                mask <<= 1;
            }

            if (cnt == 1)
            {
                return letter + ":\\";
            }
            else
            {
                return "";
            }
        }

        private void ShowPopup(string message)
        {
            MessageBox.Show(message, "USB Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.TopMost = true;
            form5.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.TopMost = true;
            form4.ShowDialog();
        }
    }
}
