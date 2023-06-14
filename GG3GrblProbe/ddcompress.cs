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
            openFileDialog.Filter = "YML files (*.yml)|*.yml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] selectedFiles = openFileDialog.FileNames;
                string firstSelectedYmlFile = selectedFiles[0];
                string initialFolder = Path.GetDirectoryName(firstSelectedYmlFile);

                FolderBrowserDialog firstFolderDialog = new FolderBrowserDialog();
                firstFolderDialog.Description = "Select the First Folder to Move";
                firstFolderDialog.ShowNewFolderButton = false;
                firstFolderDialog.RootFolder = Environment.SpecialFolder.Desktop;
                firstFolderDialog.SelectedPath = initialFolder;

                if (firstFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] selectedFolders = { firstFolderDialog.SelectedPath };

                    string secondFolderInitialPath = initialFolder;

                    FolderBrowserDialog secondFolderDialog = new FolderBrowserDialog();
                    secondFolderDialog.Description = "Select the Second Folder to Move";
                    secondFolderDialog.ShowNewFolderButton = false;
                    secondFolderDialog.RootFolder = Environment.SpecialFolder.Desktop;
                    secondFolderDialog.SelectedPath = secondFolderInitialPath;

                    if (secondFolderDialog.ShowDialog() == DialogResult.OK)
                    {
                        Array.Resize(ref selectedFolders, selectedFolders.Length + 1);
                        selectedFolders[selectedFolders.Length - 1] = secondFolderDialog.SelectedPath;

                        if (selectedFiles.Length > 0 || selectedFolders.Length > 0)
                        {
                            // Create a zip file using the current date and time as the file name
                            string zipFileName = TextName.Text + ".zip";
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

                                // Rename the zip file to a .dd file
                                string newFilePath = Path.ChangeExtension(zipFilePath, ".dd");
                                File.Move(zipFilePath, newFilePath);

                                MessageBox.Show("Files and folders zipped successfully.");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred while zipping files and folders: " + ex.Message);
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
    }
}
