using System;
using System.IO;
using System.Windows.Forms;
using Ionic.Zip;

namespace GG3GrblProbe
{
    public partial class ddcompress : Form
    {
        public ddcompress()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Select Files to Compress";

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select Folders to Move";

            if (openFileDialog.ShowDialog() == DialogResult.OK && folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string[] selectedFiles = openFileDialog.FileNames;
                string[] selectedFolders = { folderBrowserDialog.SelectedPath };

                if (selectedFiles.Length > 0 || selectedFolders.Length > 0)
                {
                    // Create a zip file using the current date and time as the file name
                    string zipFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".zip";
                    string zipFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), zipFileName);

                    try
                    {
                        // Create a new zip file
                        using (ZipFile zip = new ZipFile(zipFilePath))
                        {
                            // Add individual files to the zip file
                            foreach (string file in selectedFiles)
                            {
                                if (File.Exists(file))
                                {
                                    zip.AddFile(file, "");
                                }
                            }

                            // Add selected folders and their contents to the zip file
                            foreach (string folder in selectedFolders)
                            {
                                if (Directory.Exists(folder))
                                {
                                    zip.AddDirectory(folder, Path.GetFileName(folder));
                                }
                            }

                            // Save the zip file
                            zip.Save();
                        }

                        MessageBox.Show("Files zipped successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while zipping files: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No files or folders selected.");
                }
            }
        }
    }
}
