using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eprii
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            MaximizeBox = false;
            //ControlBox = false;
            MinimizeBox = false;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the selected dates from the DateTimePicker controls
            DateTime fromDate = dateTimePicker1.Value;
            DateTime toDate = dateTimePicker2.Value;

            // Specify the source and destination folders
            string sourceFolder = @"C:\Users\Home\Desktop\EPRI_error codes\error_results";
            string destinationFolder = @"E:\main_backup";

            // Copy files from the source folder to the destination folder based on date range
            CopyFilesByDateRange(sourceFolder, destinationFolder, fromDate, toDate);
        }
        private void CopyFilesByDateRange(string sourceFolder, string destinationFolder, DateTime fromDate, DateTime toDate)
        {
            try
            {
                // Get all directories (folders) in the source folder
                string[] folders = Directory.GetDirectories(sourceFolder);

                foreach (string folder in folders)
                {
                    // Get the folder name
                    string folderName = Path.GetFileName(folder);

                    // Extract the date and time from the folder name
                    string[] nameParts = folderName.Split('_');
                    if (nameParts.Length >= 2)
                    {
                        string dateString = nameParts[0];
                        string timeString = nameParts[1];
                        // Parse the date and time strings
                        if (DateTime.TryParseExact(dateString, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime folderDate) &&
                            DateTime.TryParseExact(timeString, "HH-mm-ss", null, System.Globalization.DateTimeStyles.None, out DateTime folderTime))
                        {
                            // Combine the date and time values
                            DateTime folderDateTime = folderDate.Date + folderTime.TimeOfDay;

                            // Check if the folder date falls within the selected date range
                            if (folderDateTime >= fromDate && folderDateTime <= toDate)
                            {
                                // Copy the entire folder to the destination folder
                                string destinationPath = Path.Combine(destinationFolder, folderName);
                                DirectoryCopy(folder, destinationPath);
                            }
                        }
                    }
                }

                MessageBox.Show("Backup completed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during backup: " + ex.Message);
            }
        }
        private static void DirectoryCopy(string sourceDirName, string destDirName)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the source directory does not exist, throw an exception
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException("Source directory does not exist or could not be found: " + sourceDirName);
            }

            // If the destination directory does not exist, create it
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Copy files
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, true);
            }
            // Copy subdirectories and their contents recursively
            foreach (DirectoryInfo subdir in dirs)
            {
                string tempPath = Path.Combine(destDirName, subdir.Name);
                DirectoryCopy(subdir.FullName, tempPath);
            }
        }
    }
}
