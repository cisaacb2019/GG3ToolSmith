using System;
using System.IO;
using System.Windows.Forms;

namespace GG3GrblProbe
{
    public partial class Checkpoint : Form
    {
        public string CurrentFilePath;

        public Checkpoint()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = PromptForName();
            if (!string.IsNullOrEmpty(name))
            {
                string selectedDirectory = GetDirectory();
                CurrentFilePath = selectedDirectory;
                if (!string.IsNullOrEmpty(selectedDirectory))
                {
                    string folderPath = Path.Combine(selectedDirectory, name);
                    CreateFolder(folderPath);
                }
            }
            AddOne.Visible = true;
            Sub1.Visible = true;
            CurrentStep.Visible = true;
            Counter.Visible = true;
        }

        private string PromptForName()
        {
            string name = "";
            using (var namePrompt = new Form())
            {
                namePrompt.Text = "Enter Name";
                var nameLabel = new Label() { Left = 50, Top = 20, Text = "Name:" };
                var nameTextBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
                var okButton = new Button() { Text = "OK", Left = 50, Top = 80, Width = 100 };
                var cancelButton = new Button() { Text = "Cancel", Left = 160, Top = 80, Width = 100 };

                okButton.Click += (s, e) =>
                {
                    name = nameTextBox.Text;
                    namePrompt.Close();
                };

                cancelButton.Click += (s, e) =>
                {
                    namePrompt.Close();
                };

                namePrompt.Controls.Add(nameLabel);
                namePrompt.Controls.Add(nameTextBox);
                namePrompt.Controls.Add(okButton);
                namePrompt.Controls.Add(cancelButton);

                namePrompt.ShowDialog();
            }

            return name;
        }

        private string GetDirectory()
        {
            string documentsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string toolsmithFolderPath = Path.Combine(documentsFolderPath, "toolsmith");

            if (!Directory.Exists(toolsmithFolderPath))
            {
                Directory.CreateDirectory(toolsmithFolderPath);
            }

            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.ValidateNames = false;
                openFileDialog.CheckFileExists = false;
                openFileDialog.CheckPathExists = true;

                // Set the custom folder browser style
                openFileDialog.CustomPlaces.Add(new FileDialogCustomPlace(toolsmithFolderPath));

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return Path.GetDirectoryName(openFileDialog.FileName);
                }
            }

            return null;
        }







        private void CreateFolder(string folderPath)
        {
            try
            {
                Directory.CreateDirectory(folderPath);

                string filePath = Path.Combine(folderPath, "document.txt");

                WriteToFile(filePath, "0"); // Call the method to write content to the file

                MessageBox.Show("Folder and text document created successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating folder and text document: " + ex.Message);
            }
        }

        private void WriteToFile(string filePath, string content)
        {
            using (StreamWriter writer = File.CreateText(filePath))
            {
                writer.WriteLine(content);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int counting = Convert.ToInt32(Counter.Text);
            string currentpathing = Path.Combine(CurrentFilePath, "document.txt");
            counting += 1;
            WriteToFile(currentpathing, Convert.ToString(counting));
            Counter.Text = counting.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int counting = Convert.ToInt32(Counter.Text);
            string currentpathing = Path.Combine(CurrentFilePath, "document.txt");
            counting -= 1;
            WriteToFile(currentpathing, Convert.ToString(counting));
            Counter.Text = counting.ToString();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            string selectedDirectory = GetDirectory();
            if (!string.IsNullOrEmpty(selectedDirectory))
            {
                string filePath = Path.Combine(selectedDirectory, "document.txt");
                string content = ReadFromFile(filePath);
                CurrentFilePath = selectedDirectory;
                Counter.Text = content;
                AddOne.Visible = true;
                Sub1.Visible = true;
                CurrentStep.Visible = true;
                Counter.Visible = true;
            }
        }

        private string ReadFromFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = File.OpenText(filePath))
                    {
                        string content = reader.ReadToEnd();
                        MessageBox.Show("Content of the file:\n" + content);
                        return content;
                    }
                }
                else
                {
                    MessageBox.Show("The file does not exist.");
                    return "ERROR";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
                return "ERROR";
            }
        }
    }
}
