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
    public partial class Checkpoint : Form
    {
        public string CurrentFilePath;

        public Checkpoint()
        {
            InitializeComponent();
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {
            CurrentFilePath = FindDocument();

            if (!string.IsNullOrEmpty(CurrentFilePath))
            {
                string fileContent = System.IO.File.ReadAllText(CurrentFilePath);
                int numberOfFiles = GetNumberOfFiles();

                if (numberOfFiles > 0)
                {
                    string[] keyPhrases = { "Chapter", "Section", "Subsection" };
                    int linesBefore = 3;

                    string[] splitText = SplitText(fileContent, keyPhrases, linesBefore, numberOfFiles);

                    SaveSplitFiles(splitText);
                }
            }
        }

        private int GetNumberOfFiles()
        {
            int numberOfFiles = 0;

            // Prompt the user to enter the number of files
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter the number of files to split the text into:", "Number of Files", "1");

            if (!int.TryParse(input, out numberOfFiles))
            {
                // Invalid input, set the default value
                numberOfFiles = 1;
            }

            return numberOfFiles;
        }

        private string[] SplitText(string text, string[] keyPhrases, int linesBefore, int numberOfFiles)
        {
            List<string> splitText = new List<string>();

            if (keyPhrases.Length == 0)
            {
                // No key phrases provided, split the entire text
                splitText.Add(text);
                return splitText.ToArray();
            }

            string[] lines = text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            int totalLines = lines.Length;
            int linesPerFile = (int)Math.Ceiling((double)totalLines / numberOfFiles);

            int startIndex = 0;
            int filesCreated = 0;

            while (startIndex < totalLines && filesCreated < numberOfFiles)
            {
                int endIndex = Math.Min(startIndex + linesPerFile, totalLines) - 1;
                int keyPhraseIndex = Array.FindIndex(lines, startIndex, endIndex - startIndex + 1, line => keyPhrases.Any(phrase => line.Contains(phrase)));

                if (keyPhraseIndex >= 0)
                {
                    int startLineIndex = Math.Max(0, keyPhraseIndex - linesBefore);
                    int endLineIndex = Math.Min(totalLines - 1, keyPhraseIndex);

                    string[] splitLines = lines[startLineIndex..(endLineIndex + 1)];
                    string split = string.Join(Environment.NewLine, splitLines);
                    splitText.Add(split);

                    startIndex = endLineIndex + 1;
                    filesCreated++;
                }
                else
                {
                    // If no key phrase is found, split the remaining lines
                    int remainingLines = totalLines - startIndex;
                    int endLineIndex = Math.Min(startIndex + remainingLines - 1, totalLines - 1);

                    string[] splitLines = lines[startIndex..(endLineIndex + 1)];
                    string split = string.Join(Environment.NewLine, splitLines);
                    splitText.Add(split);

                    startIndex = endLineIndex + 1;
                    filesCreated++;
                }
            }

            return splitText.ToArray();
        }








        private void SaveSplitFiles(string[] splitText)
        {
            for (int i = 0; i < splitText.Length; i++)
            {
                // Prompt the user to select the save location for each file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.FileName = $"SplitFile{i + 1}.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string saveFilePath = saveFileDialog.FileName;
                    System.IO.File.WriteAllText(saveFilePath, splitText[i]);
                }
            }
            MessageBox.Show("File splitting completed.", "Completion Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string FindDocument()
        {
            string selectedFilePath = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|NetCDF Files (*.nc)|*.nc";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
            }

            return selectedFilePath;
        }
    }
}
