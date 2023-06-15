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

        private void CommandCenter_Load(object sender, EventArgs e)
        {
            // Get the list of available COM ports
            string[] comPorts = SerialPort.GetPortNames();

            if (comPorts.Length == 0)
            {
                MessageBox.Show("No COM ports found. Make sure the Arduino is connected.");
                return;
            }

            // Populate the dropdown list
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
            // Write the command to the serial port
            serialPort.WriteLine(command);
            MessageBox.Show("Sent command: " + command);
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
            // Configure the serial port
            serialPort = new SerialPort(comPort, 115200);
            serialPort.BaudRate = 115200; // Set the Baud rate to match the Arduino configuration
            serialPort.Open();

            // Send commands to the Arduino
            SendCommand($"{CommandToSend}"); // Example GRBL command

            // Close the serial port
            serialPort.Close();
        }
    }
}
