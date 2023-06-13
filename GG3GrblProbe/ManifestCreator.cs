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
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                string codeFolderPath = Path.Combine(selectedPath, "Code");

                if (!Directory.Exists(codeFolderPath))
                {
                    try
                    {
                        Directory.CreateDirectory(codeFolderPath);
                        MessageBox.Show("'Code' folder created successfully.");
                        savepath = selectedPath;
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
                    savepath = selectedPath;
                    PageDisplay();

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
            OutputCode.Text += $"- job_name: {jobName}";
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
                MessageBox.Show("A G-code file with the same name already exists in the 'Code' folder. Please choose a different file or rename the existing one.");
                return;
            }

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

            selectedgcode = null; // Reset the selected G-code file path
        }


        private void OutputCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveOutput_Click(object sender, EventArgs e)
        {
            {
                string outputText = OutputCode.Text;
                string manifestpath = "Manifest.yml";
                string filePath = savepath;
                string followpath = Path.Combine(filePath, manifestpath);

                try
                {
                    // Create a StreamWriter to write the text to the file
                    using (StreamWriter writer = new StreamWriter(followpath))
                    {
                        writer.Write(outputText);
                    }

                    Console.WriteLine("manifest.yml file created successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while creating the manifest.yml file: " + ex.Message);
                }
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
            OutputCode.Text += $"timeout:{timeoutwriter}";
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
                    MessageBox.Show("An image with the same name already exists in the 'Images' folder. Please choose a different image or rename the existing one.");
                    return;
                }

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
    }
}