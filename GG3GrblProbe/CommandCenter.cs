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
        }

        public bool Continuous = false;
        public bool HOMED = false;

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
                SendCommand($"G91G0Y-{move}");
                SendCommand("G90");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Continuous)
            {
                double move = Convert.ToDouble(IncrementMovement.Text);
                SendCommand($"G91G0Y{move}");
                SendCommand("G90");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Continuous)
            {
                double move = Convert.ToDouble(IncrementMovement.Text);
                SendCommand($"G91G0X-{move}");
                SendCommand("G90");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!Continuous)
            {
                double move = Convert.ToDouble(IncrementMovement.Text);
                SendCommand($"G91G0X{move}");
                SendCommand("G90");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!Continuous)
            {
                double move = Convert.ToDouble(IncrementMovement.Text);
                SendCommand($"G91G0Z{move}");
                SendCommand("G90");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!Continuous)
            {
                double move = Convert.ToDouble(IncrementMovement.Text);
                SendCommand($"G91G0Z-{move}");
                SendCommand("G90");
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
    }
}
