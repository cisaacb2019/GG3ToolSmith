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
    public partial class SpeedCreator : Form
    {
        public SpeedCreator()
        {
            InitializeComponent();
        }
        public string ErrorMessage { get; set; }
        private void SpeedCreator_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MovementBox.Text == "G0 (Instant)")
            {
                MovementButton1.Visible = true;
                MovementButton2.Visible = false;
                FeedSpeedLabel.Visible = false;
                FeedSpeed.Visible = false;
            }
            if (MovementBox.Text == "G38.2 (Probe)")
            {
                MovementButton1.Visible = false;
                MovementButton2.Visible = true;
                FeedSpeedLabel.Visible = true;
                FeedSpeed.Visible = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string Units = UnitsComboBox.Text;
            if (Units == "Inches")
            {
                CodeOutput.Text += "\r\nG20";
            }
            else
            {
                CodeOutput.Text += "\r\nG21";
            }
        }

        private void WCSButton_Click(object sender, EventArgs e)
        {
            string WCS = WCSComboBox.Text;
           CodeOutput.Text += $"\r\nG{WCS}";
        }

        private void IncrementalModeTrue_Click(object sender, EventArgs e)
        {
            CodeOutput.Text += "\r\nG91";
            IncrementalModeTrue.BackColor = Color.LightGreen;
            IncrementalModeFalse.BackColor = Color.LightGray;
        }

        private void IncrementalModeFalse_Click(object sender, EventArgs e)
        {
            CodeOutput.Text += "\r\nG90";
            IncrementalModeFalse.BackColor = Color.LightGreen;
            IncrementalModeTrue.BackColor = Color.LightGray;
        }

        private void SpindleSpeedButton_Click(object sender, EventArgs e)
        {
            string SpindleSpeed = SpindleSpeedInput.Text;
            CodeOutput.Text += $"\r\n M3 \r\n S{SpindleSpeed}";
        }




        private void Leftminus_Click(object sender, EventArgs e)
        {
            Leftminus.BackColor = Color.LightGreen;
            Rightplus.BackColor = Color.LightGray;
            Upminus.BackColor = Color.LightGray;
            Downplus.BackColor = Color.LightGray;
            Forwardminus.BackColor = Color.LightGray;
            Forwardplus.BackColor = Color.LightGray;
        }
        private void Rightplus_Click(object sender, EventArgs e)
        {
            Leftminus.BackColor = Color.LightGray;
            Rightplus.BackColor = Color.LightGreen;
            Upminus.BackColor = Color.LightGray;
            Downplus.BackColor = Color.LightGray;
            Forwardminus.BackColor = Color.LightGray;
            Forwardplus.BackColor = Color.LightGray;
        }

        private void Upminus_Click(object sender, EventArgs e)
        {
            Leftminus.BackColor = Color.LightGray;
            Rightplus.BackColor = Color.LightGray;
            Upminus.BackColor = Color.LightGreen;
            Downplus.BackColor = Color.LightGray;
            Forwardminus.BackColor = Color.LightGray;
            Forwardplus.BackColor = Color.LightGray;
        }
 

        private void Downplus_Click(object sender, EventArgs e)
        {
            Leftminus.BackColor = Color.LightGray;
            Rightplus.BackColor = Color.LightGray;
            Upminus.BackColor = Color.LightGray;
            Downplus.BackColor = Color.LightGreen;
            Forwardminus.BackColor = Color.LightGray;
            Forwardplus.BackColor = Color.LightGray;
        }

        private void Forwardminus_Click(object sender, EventArgs e)
        {
            Leftminus.BackColor = Color.LightGray;
            Rightplus.BackColor = Color.LightGray;
            Upminus.BackColor = Color.LightGray;
            Downplus.BackColor = Color.LightGray;
            Forwardminus.BackColor = Color.LightGreen;
            Forwardplus.BackColor = Color.LightGray;
        }

        private void Forwardplus_Click(object sender, EventArgs e)
        {
            Leftminus.BackColor = Color.LightGray;
            Rightplus.BackColor = Color.LightGray;
            Upminus.BackColor = Color.LightGray;
            Downplus.BackColor = Color.LightGray;
            Forwardminus.BackColor = Color.LightGray;
            Forwardplus.BackColor = Color.LightGreen;
        }


        private void MovementButton_Click(object sender, EventArgs e)
        {
            MovementWriter();
        }

        private void MovementButton2_Click(object sender, EventArgs e)
        {
            MovementWriter();
        }
        public double YAntiRam = 0;
        public double XAntiRam = 0;
        public double ZAntiRam = 0;
        public double YANTIRAMSAVE = 0;
        public double XANTIRAMSAVE = 0;
        public double ZANTIRAMSAVE = 0;
        public bool AntiRamCheck = false;
        public void MovementWriter()
        {
            double DistanceMovement = Convert.ToDouble(DistanceInput.Text);
            string WriteType = MovementBox.Text;
            double CalculatedDistanceMovement = 0;
            string CalculatedOutputAxis = "";
            string FeedRate = FeedSpeed.Text;

            if (Leftminus.BackColor == Color.LightGreen)
            {
                CalculatedDistanceMovement = DistanceMovement * -1;
                CalculatedOutputAxis = "Y";
            }
            if (Rightplus.BackColor == Color.LightGreen)
            {
                CalculatedDistanceMovement = DistanceMovement;
                CalculatedOutputAxis = "Y";
            }
            if (Upminus.BackColor == Color.LightGreen)
            {
                CalculatedDistanceMovement = DistanceMovement * -1;
                CalculatedOutputAxis = "X";
            }
            if (Downplus.BackColor == Color.LightGreen)
            {
                CalculatedDistanceMovement = DistanceMovement;
                CalculatedOutputAxis = "X";
            }
            if (Forwardminus.BackColor == Color.LightGreen)
            {
                CalculatedDistanceMovement = DistanceMovement * -1;
                CalculatedOutputAxis = "Z";
            }
            if (Forwardplus.BackColor == Color.LightGreen)
            {
                CalculatedDistanceMovement = DistanceMovement;
                CalculatedOutputAxis = "Z";
            }

            if (WriteType == "G0 (Instant)")
            {
                if (!AntiRamCheck)
                {
                    CodeOutput.Text += $"\r\nG0 {CalculatedOutputAxis}{CalculatedDistanceMovement}";
                }
                else
                {
                    
                    bool XClear = false;
                    bool YClear = false;
                    bool ZClear = false;
                    if (CalculatedOutputAxis == "X")
                    {
                        XANTIRAMSAVE = XAntiRam;
                        XAntiRam += CalculatedDistanceMovement;
                    }
                    if (CalculatedOutputAxis == "Y")
                    {
                        YANTIRAMSAVE = YAntiRam;
                        YAntiRam += CalculatedDistanceMovement;
                    }
                    if (CalculatedOutputAxis == "Z")
                    {
                        ZANTIRAMSAVE = ZAntiRam;
                        ZAntiRam += CalculatedDistanceMovement;
                    }






                    if (XAntiRam != 0)
                    {
                        Error error = new Error();
                        error.ErrorMessage = $"X Axis anti ram error {XAntiRam}"; // Pass the error message to the Error form
                        DialogResult result = error.ShowDialog();
                        XAntiRam = XANTIRAMSAVE;
                    }
                    else
                    {
                        XClear = true;
                    }

                    if (YAntiRam != 0)
                    {
                        Error error = new Error();
                        error.ErrorMessage = $"Y Axis anti ram error {YAntiRam}"; // Pass the error message to the Error form
                        DialogResult result = error.ShowDialog();
                        YAntiRam = YANTIRAMSAVE;
                    }
                    else
                    {
                        YClear = true;
                    }

                    if (ZAntiRam != 0)
                    {
                        Error error = new Error();
                        error.ErrorMessage = $"Z Axis anti ram error {ZAntiRam}"; // Pass the error message to the Error form
                        DialogResult result = error.ShowDialog();
                        ZAntiRam = ZANTIRAMSAVE;
                    }
                    else
                    {
                        ZClear = true;
                    }

                    if (XClear && YClear && ZClear)
                    {
                        AntiRamCheck = false;
                        CodeOutput.Text += $"\r\nG0 {CalculatedOutputAxis}{CalculatedDistanceMovement}";
                    }

                }

            }

            if (WriteType == "G38.2 (Probe)")
            {
                    CodeOutput.Text += $"\r\nG38.2 {CalculatedOutputAxis}{CalculatedDistanceMovement} F{FeedRate}";
                    AntiRamCheck = true;
                    if (CalculatedOutputAxis == "X")
                    {
                        XAntiRam = CalculatedDistanceMovement;
                    }
                    if (CalculatedOutputAxis == "Y")
                    {
                        YAntiRam = CalculatedDistanceMovement;
                    }
                    if (CalculatedOutputAxis == "Z")
                    {
                        ZAntiRam = CalculatedDistanceMovement;
                    }
             
            }

        }

    }
}
