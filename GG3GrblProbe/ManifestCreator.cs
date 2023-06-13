﻿using System;
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

                    if (!string.IsNullOrEmpty(folderName))
                    {
                        string path = Path.Combine(selectedPath, folderName);
                        string codefolder = Path.Combine(path, CodeFolderName);

                        try
                        {
                            Directory.CreateDirectory(path);
                            Directory.CreateDirectory(codefolder);
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
            string sourceFilePath = selectedgcode;
            string codepath = "Code";
            string targetFolderPath = Path.Combine(savepath, codepath);

            if (File.Exists(sourceFilePath))
            {
                try
                {
                    string targetFilePath = Path.Combine(targetFolderPath,sourceFilePath);
                    File.Move(sourceFilePath, targetFilePath);
                    MessageBox.Show("File wrote successfully!");
                    OutputCode.Text += $"\r\n      step_gcode: Code/{Path.GetFileName(sourceFilePath)}\r\n";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while cutting the file: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Selected file does not exist!");
            }
            stepGcodeSelect.BackColor = Color.White;
            WriteStepGcode.BackColor = Color.White;
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
    }
}