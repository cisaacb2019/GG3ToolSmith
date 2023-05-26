using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;



namespace GG3GrblProbe
{
    public partial class Set_Up : Form
    {
        public string ErrorMessage { get; set; }
        public Set_Up()
        {
            InitializeComponent();
        }

        private void Set_Up_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string StartWCS = StartWcs.SelectedItem.ToString();
            double StartX = Convert.ToDouble(StartXInput.Text);
            double StartY = Convert.ToDouble(StartYInput.Text);
            double StartZ = Convert.ToDouble(StartZInput.Text);
            bool CclampOffset = CclampYes.Checked;
            double XADD = Convert.ToDouble(AdditionalOffset.Text);


            string AxisCheckResult = AxisCheck(StartX, StartY, StartZ);
            if (AxisCheckResult != "Good To Proceed")
            {
                Error error = new Error();
                error.ErrorMessage = AxisCheckResult; // Pass the error message to the Error form
                DialogResult result = error.ShowDialog();
            }
            else
            {
                AlignOutput(CclampOffset, StartX, StartY, StartZ, StartWCS, XADD);
            }


        }

        public string AxisCheck(double StartX, double StartY, double StartZ)
        {
            const double MaxX = -0.5;
            const double MaxY = -0.5;
            const double Maxz = -0.5;
            const double MinX = -86;
            const double MinY = -241.5;
            const double MinZ = -78.5;

            if (StartX > MaxX)
            {
                return "ERROR: StartX larger then machine can handle";
            }
            else if (StartY > MaxY)
            {
                return "ERROR: StartY larger then machine can handle";
            }
            else if (StartZ > Maxz)
            {
                return "ERROR: StartZ larger then machine can handle";
            }
            else if (StartZ < MinZ)
            {
                return "ERROR: StartZ smaller then machine can handle";
            }
            else if (StartY < MinY)
            {
                return "ERROR: StartY smaller then machine can handle";
            }
            else if (StartY < MinX)
            {
                return "ERROR: StartX smaller then machine can handle";
            }
            else
            {
                return "Good To Proceed";
            }
        }

        private void AlignOutput(bool CclampOffset, double StartX, double StartY, double StartZ, string StartWCS, double XADD)
        {
            double StartXCALCULATED = StartX;
            bool Cclamp = CclampOffset;
            double CclampXCALC = 17.5;
            string StartWCSSTart = StartWCS;
            string FilePath = CreateTextDocument();
            const double MaxX = -0.5;
            const double MinX = -86;
            double XADDIT = XADD;

            if (Cclamp)
            {
                StartXCALCULATED = StartX - CclampXCALC;
            }
            StartXCALCULATED = StartXCALCULATED - XADDIT;
            if (StartXCALCULATED > MaxX)
                {
                Error error = new Error();
                error.ErrorMessage = "ERROR: CalculatedX Offsets smaller then machine can handle"; // Pass the error message to the Error form
                DialogResult result = error.ShowDialog();
            }
            else if (StartXCALCULATED < MinX)
            {
                Error error = new Error();
                error.ErrorMessage = "ERROR: CalculatedX Offsets larger then machine can handle"; // Pass the error message to the Error form
                DialogResult result = error.ShowDialog();
            }
            else if (FilePath != null)
            {
                string content = $"G54\r\nG21\r\nG90\r\nG0 Z-1 \r\nG{StartWCSSTart} \r\nG0 Z{StartZ}\r\nG0 X{StartXCALCULATED} Y{StartY}\r\nG4 P0";

                File.WriteAllText(FilePath, content);
                Error error = new Error();
                error.ErrorMessage = "FileSaved"; // Pass the error message to the Error form
                DialogResult result = error.ShowDialog();
            }

        }


        public string CreateTextDocument()
        {
            // Create an instance of SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Set the file filter and other properties if needed
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.Title = "Create Text Document";

            // Show the file dialog and check if the user clicked the OK button
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Create a new text file at the specified path
                File.WriteAllText(filePath, string.Empty);

                return filePath;
            }

            return null; // Return null if the user didn't select a file
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void StartYInput_TextChanged(object sender, EventArgs e)
        {
            GenerateProbeY.Text = StartYInput.Text;
        }

        private void StartZInput_TextChanged(object sender, EventArgs e)
        {
            GenerateProbeZ.Text = StartYInput.Text;
        }

        private void StartXInput_TextChanged(object sender, EventArgs e)
        {
            GenerateProbeX.Text = StartXInput.Text;
        }

        private void GenerateProbe_Click(object sender, EventArgs e)
        {
           string ProbeWCS = ProbeWcs.SelectedItem.ToString();
            double ProbeX = Convert.ToDouble(GenerateProbeX.Text);
            double ProbeY = Convert.ToDouble(GenerateProbeY.Text);
            double ProbeZ = Convert.ToDouble(GenerateProbeZ.Text);
            double StockX = Convert.ToDouble(StockSizeX.Text);
            double StockY = Convert.ToDouble(StockSizeY.Text);
            double StockZ = Convert.ToDouble(StockSizeZ.Text);
            string Direction = "";
            double DistanceFromSpindle = Convert.ToDouble(DistanceInput.Text);
            double SafeMovementDistance = Convert.ToDouble(SafeMovementInput.Text);
            double ToolSize = Convert.ToDouble(ToolSizeInput.Text);
            double ToolPercentage = Convert.ToDouble(ToolPercentageInput.Text);
            double ToolLength = Convert.ToDouble(ToolLengthInput.Text);
            //Convert all to negative that need to be negative//
            if (StockX >= 0)
            {
                StockX = StockX * -1;
            }
            if (StockY >= 0)
            {
                StockY = StockY * -1;
            }
            if (StockZ >= 0)
            {
                StockZ = StockZ * -1;
            }


            if (LeftButton.BackColor == Color.LightGreen)
            {
                Direction = "Left";
            }
            else if (RightButton.BackColor == Color.LightGreen)
            {
                Direction = "Right";
                DistanceFromSpindle = DistanceFromSpindle * -1;
            }
            else
            {
                Error error = new Error();
                error.ErrorMessage = "ERROR: No Direction Selected."; // Pass the error message to the Error form
                DialogResult result = error.ShowDialog();
            }
            if (Direction == "Left" || Direction == "Right")
            {
                ProbeOutput(ProbeZ,ProbeY,DistanceFromSpindle, ProbeWCS,ToolSize,StockZ, SafeMovementDistance,ToolPercentage,ToolLength,
                    StockY,StockX);
            }


        }
        private void ProbeOutput(double PROBEZ,double PROBEY,double DistanceFromSpindle,string ProbeWCS,double TOOLSIZE,double STOCKZSIZE,double SAFEMOVEMENT,
            double TOOLPERCENTAGE,double TOOLLENGTH,double STOCKSIZEY,double STOCKSIZEX)
        {
            string FilePath = CreateTextDocument();
            int SpindleSpeed = 5000;

            if (FilePath != null)
            {
                string content = $"M3\r\nG4 P2\r\nG54\r\nS{SpindleSpeed}\r\nG21\r\nG0 Z{PROBEZ}\r\nG38.2 Y{PROBEY - DistanceFromSpindle} F30\r\nG{ProbeWCS}\r\n";
                content += $"G10 L20 P2 Y{TOOLSIZE / 2}\r\nG54\r\nG4 P2\r\nG0 Y{PROBEY}\r\nG0 Z{PROBEZ + ((TOOLLENGTH / 100 )* TOOLPERCENTAGE) + SAFEMOVEMENT}\r\n";
                content += $"G{ProbeWCS}\r\nG0 Y{STOCKSIZEY /2}\r\nG54\r\nG91\r\nG0 X{STOCKSIZEX /2 + SAFEMOVEMENT}\r\nG90\r\nG0 Z{PROBEZ}\r\nG91\r\nG21\r\nG38.2 X{(SAFEMOVEMENT * -1) + (STOCKSIZEX/2)} F30\r\n";
                content += $"G90\r\nG{ProbeWCS}\r\nG10 L20 P2 X{TOOLSIZE / 2}\r\nG54\r\nG4 P2\r\nG91\r\nG0 X5\r\nG90\r\nG0 Z{PROBEZ + ((TOOLLENGTH / 100) * TOOLPERCENTAGE) + SAFEMOVEMENT}\r\nG{ProbeWCS}\r\nG0 X{(STOCKSIZEX/2) * -1}\r\nG54\r\n";
                content += $"G21\r\nG38.2 Z{PROBEZ}F30\r\nG{ProbeWCS}\r\nG10 L20 P2 Z0\r\nG{ProbeWCS} G90\r\nG0 Z10\r\nG0 Y0\r\nG0 X0\r\nM3 S0";
                File.WriteAllText(FilePath, content);
                Error error = new Error();
                error.ErrorMessage = "FileSaved"; // Pass the error message to the Error form
                DialogResult result = error.ShowDialog();
            }

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            string SELECT = "Left";
            DirectionSelect(SELECT);

        }
        private void RightButton_Click(object sender, EventArgs e)
        {

            string SELECT = "Right";
            DirectionSelect(SELECT);
        }

        public string DirectionSelect(string Selector)
        {
            string Direction = "NONE";
            string SELECTOR = Selector;
            if (SELECTOR == "Left")
            {
                Direction = "Left";
                LeftButton.BackColor = Color.LightGreen;
                RightButton.BackColor = Color.LightGray;
            }
            if (SELECTOR == "Right")
            {
                Direction = "Right";
                RightButton.BackColor = Color.LightGreen;
                LeftButton.BackColor = Color.LightGray;
            }
            return Direction;
        }


        private void DefaultInput_Click(object sender, EventArgs e)
        {
            ToolPercentageInput.Text = "80";
            DefaultInput.BackColor = Color.LightGreen;
        }

        private void ToolPercentageInput_TextChanged(object sender, EventArgs e)
        {
            DefaultInput.BackColor = Color.White;
        }
    }
}
