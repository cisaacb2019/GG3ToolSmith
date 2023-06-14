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
            // Find the Arduino COM port automatically
            string comPort = FindArduinoPort();
            if (comPort == null)
            {
                MessageBox.Show("Arduino not found. Make sure it is connected.");
                return;
            }

            // Configure the serial port
            serialPort = new SerialPort(comPort, 115200);
            serialPort.Open();

            // Send commands to the Arduino
            SendCommand("G90"); // Example GRBL command

            // Close the serial port
            serialPort.Close();
        }

        private string FindArduinoPort()
        {
            string[] comPorts = SerialPort.GetPortNames();
            foreach (string port in comPorts)
            {
                // Customize the condition if needed
                if (port.Contains("Arduino"))
                {
                    MessageBox.Show("Arduino found on port: " + port);
                    return port;
                }
            }

            return null;
        }

        private void SendCommand(string command)
        {
            // Write the command to the serial port
            serialPort.WriteLine(command);
            MessageBox.Show("Sent command: " + command);
        }
    }
}
