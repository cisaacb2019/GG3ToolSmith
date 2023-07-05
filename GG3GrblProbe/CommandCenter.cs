using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace GG3GrblProbe
{
    public partial class CommandCenter : Form
    {
        private SerialPort serialPort;

        public CommandCenter()
        {
            InitializeComponent();
            this.Width = 717;
        }

        public bool Continuous = false;
        public bool HOMED = false;
        public double Monitory = -0.5;
        public double Monitorz = -0.5;
        public double Monitorx = -86.5;

        public double MonitoryMIN = -0.5;
        public double MonitorzMIN = -0.5;
        public double MonitorxMIN = -1;
        public double MonitorYMAX = -200;
        public double MonitorZMAX = -70;
        public double MonitorXMAX = -86.5;

        public string OUTPUTTEXT = "";
        public int CLICKCOUNT = 0;

        private void CommandCenter_Load(object sender, EventArgs e)
        {
            string[] comPorts = SerialPort.GetPortNames();

            if (comPorts.Length == 0)
            {
                MessageBox.Show("No COM ports found. Make sure the Arduino is connected.");
                return;
            }

            comboBoxPortList.Items.AddRange(comPorts);
            comboBoxPortList.SelectedIndex = 0; // Select the first port by default
        }

        private string FindSelectedPort()
        {
            string selectedPort = comboBoxPortList.SelectedItem as string;
            return selectedPort;
        }

        private void SendCommand(string command)
        {
            if (!HOMED)
            {
                DialogResult result = MessageBox.Show("It is recommended to home. Hit OK when you are ready to proceed.", "Confirmation", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    ConfigureAndOpenSerialPort();
                    if (serialPort != null && serialPort.IsOpen)
                    {
                        HOMED = true;
                        serialPort.WriteLine("$H"); // Send the "$H" command to home the machine
                        OUTPUTTEXT = "$H";
                        DISPLAYOUTPUTTEXT.Text = OUTPUTTEXT;
                        serialPort.Close();
                    }
                }
                else
                {
                    // User canceled, do nothing or handle the action as desired
                }
            }
            else
            {
                string comPort = FindSelectedPort();
                if (comPort == null)
                {
                    MessageBox.Show("No COM port selected. Please choose a port.");
                    return;
                }

                ConfigureAndOpenSerialPort();

                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.WriteLine(command);
                    serialPort.Close();
                }
                else
                {
                    MessageBox.Show("Serial port is not open. Please check your configuration.");
                }
            }

    }



    private void ConfigureAndOpenSerialPort()
        {
            string comPort = FindSelectedPort();

            if (comPort == null)
            {
                MessageBox.Show("No COM port selected. Please choose a port.");
                return;
            }

            serialPort = new SerialPort(comPort, 115200);
            serialPort.BaudRate = 115200;

            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening the serial port: " + ex.Message);
            }
        }

        private void buttonDetect_Click(object sender, EventArgs e)
        {
            string comPort = FindSelectedPort();
            if (comPort == null)
            {
                MessageBox.Show("No COM port selected. Please choose a port.");
                return;
            }

            string CommandToSend = CommandSend.Text;

            ConfigureAndOpenSerialPort();

            serialPort.WriteLine(CommandToSend); // Example GRBL command

            serialPort.Close();
        }

        private void IncrementButton_Click(object sender, EventArgs e)
        {
            ContinuousButton.BackColor = Color.LightGray;
            IncrementButton.BackColor = Color.LightGreen;
            IncrementMovement.Visible = true;
            mmlabel.Visible = true;
            Continuous = false;
        }

        private void ContinuousButton_Click(object sender, EventArgs e)
        {
            ContinuousButton.BackColor = Color.LightGray;
            IncrementButton.BackColor = Color.LightGreen;
            IncrementMovement.Visible = false;
            mmlabel.Visible = false;
            Continuous = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!Continuous)
            {
                double move = Convert.ToDouble(IncrementMovement.Text);
                Monitory -= move;
                SendCommand($"G91G0Y-{move}");
                SendCommand("G90");
                OUTPUTTEXT += $"\r\nG91G0Y-{move}";
                DISPLAYOUTPUTTEXT.Text = OUTPUTTEXT;
            }
            else
            {
                MessageBox.Show("Y Movment will set error.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Continuous)
            {
                double move = Convert.ToDouble(IncrementMovement.Text);
                Monitory += move;
                SendCommand($"G91G0Y{move}");
                SendCommand("G90");
                OUTPUTTEXT += $"\r\nG91G0Y{move}";
                DISPLAYOUTPUTTEXT.Text = OUTPUTTEXT;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Continuous)
            {
                double move = Convert.ToDouble(IncrementMovement.Text);
                SendCommand($"G91G0X-{move}");
                SendCommand("G90");
                OUTPUTTEXT += $"\r\nG91G0X-{move}";
                DISPLAYOUTPUTTEXT.Text = OUTPUTTEXT;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!Continuous)
            {
                double move = Convert.ToDouble(IncrementMovement.Text);
                SendCommand($"G91G0X{move}");
                SendCommand("G90");
                OUTPUTTEXT += $"\r\nG91G0X{move}";
                DISPLAYOUTPUTTEXT.Text = OUTPUTTEXT;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!Continuous)
            {
                double move = Convert.ToDouble(IncrementMovement.Text);
                SendCommand($"G91G0Z{move}");
                SendCommand("G90");
                OUTPUTTEXT += $"\r\nG91G0Z{move}";
                DISPLAYOUTPUTTEXT.Text = OUTPUTTEXT;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!Continuous)
            {
                double move = Convert.ToDouble(IncrementMovement.Text);
                SendCommand($"G91G0Z-{move}");
                SendCommand("G90");
                OUTPUTTEXT += $"\r\nG91G0Z-{move}";
                DISPLAYOUTPUTTEXT.Text = OUTPUTTEXT;
            }
        }
        private void buttonDetect_Click_1(object sender, EventArgs e)
        {
            string comPort = FindSelectedPort();
            if (comPort == null)
            {
                MessageBox.Show("No COM port selected. Please choose a port.");
                return;
            }

            string CommandToSend = CommandSend.Text;

            ConfigureAndOpenSerialPort();

            SendCommand(CommandToSend);
            OUTPUTTEXT += $"\r\n{CommandToSend}";
            DISPLAYOUTPUTTEXT.Text = OUTPUTTEXT;
            serialPort.Close();
        }
        private void RefreshPortList()
        {
            comboBoxPortList.Items.Clear();

            // Get the list of available COM ports
            string[] comPorts = SerialPort.GetPortNames();

            if (comPorts.Length == 0)
            {
                MessageBox.Show("No COM ports found. Make sure the device is connected.");
                return;
            }

            // Populate the dropdown list
            comboBoxPortList.Items.AddRange(comPorts);
            comboBoxPortList.SelectedIndex = 0; // Select the first port by default
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RefreshPortList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Width = 1500;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (CLICKCOUNT == 2)
            {
                DISPLAYOUTPUTTEXT.Text = "";
                OUTPUTTEXT = "";
                CLICKCOUNT = 0;
            }
            if (CLICKCOUNT == 1)
            {
                button9.Text = "CLICK AGAIN TO DELETE...";
                CLICKCOUNT = 2;
            }
            if (CLICKCOUNT == 0)
            {
                button9.Text = "Reset Output:";
                CLICKCOUNT = 1;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string fileName = PromptFileName();
            if (!string.IsNullOrWhiteSpace(fileName))
            {
                using (var folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.Description = "Select a folder to save the file.";

                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFolder = folderBrowserDialog.SelectedPath;
                        string filePath = Path.Combine(selectedFolder, fileName);
                        string text = DISPLAYOUTPUTTEXT.Text;

                        try
                        {
                            // Write the text to the file
                            File.WriteAllText(filePath, text);
                            MessageBox.Show("File saved successfully!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error saving file: " + ex.Message);
                        }
                    }
                }
            }
        }
        private string PromptFileName()
        {
            string fileName = null;

            using (var form = new Form())
            {
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.StartPosition = FormStartPosition.CenterParent;
                form.Text = "Enter File Name";

                var textBox = new TextBox();
                textBox.Dock = DockStyle.Fill;

                var buttonPanel = new FlowLayoutPanel();
                buttonPanel.FlowDirection = FlowDirection.RightToLeft;
                buttonPanel.Dock = DockStyle.Bottom;

                var cancelButton = new Button();
                cancelButton.Text = "Cancel";
                cancelButton.DialogResult = DialogResult.Cancel;
                buttonPanel.Controls.Add(cancelButton);

                var okButton = new Button();
                okButton.Text = "OK";
                okButton.DialogResult = DialogResult.OK;
                buttonPanel.Controls.Add(okButton);

                form.Controls.Add(textBox);
                form.Controls.Add(buttonPanel);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    fileName = textBox.Text;
                }
            }

            return fileName;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }
    }
}
