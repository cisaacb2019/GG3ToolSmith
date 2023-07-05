using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GG3GrblProbe
{
    public partial class ManifestCreator : Form
    {
        public string savepath;
        public string selectedgcode;
        public string selectedimage;
        public ManifestCreator()
        {
            InitializeComponent();
            this.Height = 305;
            this.Width = 818;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    string folderName = FolderNameText.Text;
                    string CodeFolderName = "Code";
                    string ImagesFolderName = "Images";
                    if (!string.IsNullOrEmpty(folderName))
                    {
                        string path = Path.Combine(selectedPath, folderName);
                        string codefolder = Path.Combine(path, CodeFolderName);
                        string ImagesFolderCreate = Path.Combine(path, ImagesFolderName);
                        try
                        {
                            Directory.CreateDirectory(path);
                            Directory.CreateDirectory(codefolder);
                            Directory.CreateDirectory(ImagesFolderCreate);
                            savepath = path;
                            PageDisplay();
                            MessageBox.Show("Folder created successfully!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred while creating the folder: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a folder name!");
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "YAML Files (*.yml;*.yaml)|*.yml;*.yaml";
                openFileDialog.Title = "Select manifest.yml File";
                openFileDialog.CheckFileExists = true;
                openFileDialog.CheckPathExists = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    string selectedPath = Path.GetDirectoryName(selectedFilePath);
                    string codeFolderPath = Path.Combine(selectedPath, "Code");
                    savepath = selectedPath;

                    if (!Directory.Exists(codeFolderPath))
                    {
                        try
                        {
                            Directory.CreateDirectory(codeFolderPath);
                            MessageBox.Show("'Code' folder created successfully.");
                            PageDisplay();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while creating the 'code' folder: " + ex.Message);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Folder Selected Successfully!");
                        PageDisplay();
                    }

                    if (Path.GetFileName(selectedFilePath).Equals("manifest.yml", StringComparison.OrdinalIgnoreCase))
                    {
                        // Read the YAML file and display its content in the output code box
                        ReadYamlFile(selectedFilePath);
                    }
                    else
                    {
                        MessageBox.Show("Please select a file named 'manifest.yml'.");
                    }
                }
            }
        }



        public void PageDisplay()
        {
            button6.Visible = false;
            FolderNameText.Visible = false;
            button5.Visible = false;

            JobNameInput.Visible = true;
            jobNameWrite.Visible = true;
            jobTextInput.Visible = true;
            JobTextWrite.Visible = true;
            stepNameInput.Visible = true;
            stepNameWrite.Visible = true;
            StepTextInput.Visible = true;
            StepTextWrite.Visible = true;
            stepGcodeSelect.Visible = true;
            WriteStepGcode.Visible = true;
            SaveOutput.Visible = true;
            OutputCode.Visible = true;
            AdvSettings.Visible = true;
            //rescale form//
            this.Height = 929;
            this.Width = 818;
        }

        private void jobNameWrite_Click(object sender, EventArgs e)
        {
            string jobName = JobNameInput.Text;
            OutputCode.Text += $"\r\n- job_name: {jobName}";
            JobNameInput.Text = "Enter Job Name:";
            JobNameInput.BackColor = Color.White;
            jobNameWrite.BackColor = Color.White;
            jobTextInput.BackColor = Color.Aquamarine;
            JobTextWrite.BackColor = Color.Aquamarine;
        }

        private void JobTextWrite_Click(object sender, EventArgs e)
        {
            string jobtext = jobTextInput.Text;
            OutputCode.Text += $"\r\n  job_text: {jobtext}\r\n\r\n  job_steps:\r\n";
            jobTextInput.Text = "Enter Job Text:";
            jobTextInput.BackColor = Color.White;
            JobTextWrite.BackColor = Color.White;
            stepNameInput.BackColor = Color.Aquamarine;
            stepNameWrite.BackColor = Color.Aquamarine;
        }

        private void stepNameWrite_Click(object sender, EventArgs e)
        {
            string stepname = stepNameInput.Text;
            OutputCode.Text += $"\r\n    - step_name: {stepname}";
            stepNameInput.Text = "Enter Step Name:";
            stepNameInput.BackColor = Color.White;
            stepNameWrite.BackColor = Color.White;
            stepGcodeSelect.BackColor = Color.White;
            WriteStepGcode.BackColor = Color.White;
            StepTextInput.BackColor = Color.Aquamarine;
            StepTextWrite.BackColor = Color.Aquamarine;
        }

        private void StepTextWrite_Click(object sender, EventArgs e)
        {
            string steptext = StepTextInput.Text;
            OutputCode.Text += $"\r\n      step_text: {steptext}";
            StepTextInput.Text = "Enter Step Text:";
            StepTextInput.BackColor = Color.White;
            StepTextWrite.BackColor = Color.White;
            stepNameInput.BackColor = Color.Aquamarine;
            stepNameWrite.BackColor = Color.Aquamarine;
            stepGcodeSelect.BackColor = Color.Aquamarine;
            WriteStepGcode.BackColor = Color.Aquamarine;
        }

        private void stepGcodeSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                selectedgcode = selectedFilePath;
                MessageBox.Show("File selected successfully!");
            }
        }

        private void WriteStepGcode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedgcode))
            {
                MessageBox.Show("Please select a G-code file!");
                return;
            }

            string sourceFilePath = selectedgcode;
            string codeFolderPath = Path.Combine(savepath, "Code");
            string selectedGcodeFileName = Path.GetFileName(sourceFilePath);
            string targetFilePath = Path.Combine(codeFolderPath, selectedGcodeFileName);

            if (File.Exists(targetFilePath))
            {
                File.Move(sourceFilePath, targetFilePath);
                MessageBox.Show("G-code file moved successfully!");
                OutputCode.Text += $"\r\n      step_gcode: Code/{selectedGcodeFileName}\r\n";
            }
            else
            {
                try
                {
                    Directory.CreateDirectory(codeFolderPath);
                    File.Move(sourceFilePath, targetFilePath);
                    MessageBox.Show("G-code file moved successfully!");
                    OutputCode.Text += $"\r\n      step_gcode: Code/{selectedGcodeFileName}\r\n";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while moving the G-code file: " + ex.Message);
                }
            }
            selectedgcode = null; // Reset the selected G-code file path
        }


        private void OutputCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveOutput_Click(object sender, EventArgs e)
        {
            string outputText = OutputCode.Text;
            string manifestPath = "Manifest.yml";
            string filePath = savepath;
            string fullPath = Path.Combine(filePath, manifestPath);

            try
            {
                // Create a StreamWriter to write the text to the file, overwriting existing content
                using (StreamWriter writer = new StreamWriter(fullPath, false))
                {
                    writer.Write(outputText);
                }

                MessageBox.Show("manifest.yml file overwritten successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while overwriting the manifest.yml file: " + ex.Message);
            }
        }


        private void AdvSettings_Click(object sender, EventArgs e)
        {
            this.Height = 929;
            this.Width = 1400;
        }

        private void StepMarkdownInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void StepMarkdownWrite_Click(object sender, EventArgs e)
        {
            string StepMarkDownText = StepMarkdownInput.Text;
            OutputCode.Text += $"\r\n step_markdown: | {StepMarkDownText}";
        }

        private void TimeoutWrite_Click(object sender, EventArgs e)
        {
            OutputCode.Text += $"\r\ntimeout:{timeoutwriter.Text}";
        }

        private void ImageWriter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedimage))
            {
                MessageBox.Show("Please select an image file!");
                return;
            }

            string selectedPath = savepath;
            string imageFolderPath = Path.Combine(selectedPath, "Images");
            string selectedImageName = Path.GetFileName(selectedimage);
            string destinationPath = Path.Combine(imageFolderPath, selectedImageName);

            if (File.Exists(destinationPath))
            {
                Directory.CreateDirectory(imageFolderPath);
                File.Move(selectedimage, destinationPath);
                OutputCode.Text += $"\r\n      step_image: Images/{selectedImageName}";
                // MessageBox.Show("An image with the same name already exists in the 'Images' folder. Please choose a different image or rename the existing one.");

            }
            else
            {
                try
                {
                    Directory.CreateDirectory(imageFolderPath);
                    File.Move(selectedimage, destinationPath);
                    MessageBox.Show("Image moved successfully!");
                    OutputCode.Text += $"\r\n      step_image: Images/{selectedImageName}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while moving the image: " + ex.Message);
                }
            }
            selectedimage = null; // Reset the selected image path

        }

        private void SelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                selectedimage = selectedFilePath;
                MessageBox.Show("Image selected successfully!");
            }
        }

        private void ReadYamlFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                string yamlContent = string.Join(Environment.NewLine, lines);

                OutputCode.Text = yamlContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reading the YAML file: " + ex.Message);
            }
        }

        private void ManifestCreator_Load(object sender, EventArgs e)
        {

        }

        private void FolderNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }
    }
}