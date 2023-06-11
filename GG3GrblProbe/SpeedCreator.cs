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
        public int PageNum = 1;
        public int MaxPageCount = 2;
        public SpeedCreator()
        {
            InitializeComponent();
            PageSwap(PageNum);
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

        private void SaveOffsetButton_Click(object sender, EventArgs e)
        {
            double SaveOffsetWCS = Convert.ToDouble(SAVEOFFSETWCS.Text) - 53;
            double ToolDiam = Convert.ToDouble(ToolDiameter.Text);
            double calcToolDiam = 0;
            
            if (AutoHalfCheck.Checked)
            {
                calcToolDiam = ToolDiam / 2;
            }
            else
            {
                calcToolDiam = ToolDiam;
            }

            CodeOutput.Text += $"\r\nG10 P{SaveOffsetWCS} L20{calcToolDiam}";
        }

        private void CenterFind_Click(object sender, EventArgs e)
        {
            string Axis = CenterAxis.Text;
            string wcs1 = WCSCENTER1.Text;
            string wcs2 = WCSCENTER2.Text;
            string savewcs = WCSSAVE.Text;
            CodeOutput.Text += $"\r\nM100 {wcs1} {Axis} {wcs2} {Axis} {savewcs} {Axis}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TolAxis = TolerenceAxis.Text;
            string TolWCS1 = TolerenceWCS1.Text;
            string TolWCS2 = TolerenceWcs2.Text;
            string Tolwcs3 = TolerenceWcs3.Text;
            string Tolerence = TolerenceText.Text;
            CodeOutput.Text += $"\r\n";
        }

        private void Expand_Click(object sender, EventArgs e)
        {
            PageNum += 1;
            if (PageNum <= MaxPageCount)
            {
                PageSwap(PageNum);
            }
            else
            {
                PageNum = MaxPageCount;
            }
        }

        private void CTAxis_Click(object sender, EventArgs e)
        {

        }









        private void PageSwap(int PageNumber)
        {
            if (PageNumber == 1)
            {
                //Page1//
                UnitsLabel.Visible = true;
                UnitsComboBox.Visible = true;
                UnitsButton.Visible = true;
                WCSLabel.Visible = true;
                WCSComboBox.Visible = true;
                WCSButton.Visible = true;
                Imlabel.Visible = true;
                IncrementalModeTrue.Visible = true;
                IncrementalModeFalse.Visible = true;
                SpindleSpeedLabel.Visible = true;
                SpindleSpeedInput.Visible = true;
                SpindleSpeedButton.Visible = true;
                SaveOffsetLabel.Visible = true;
                SOWCS.Visible = true;
                SAVEOFFSETWCS.Visible = true;
                ToolDiamLabel.Visible = true;
                ToolDiameter.Visible = true;
                AutoHalfLabel.Visible = true;
                AutoHalfCheck.Visible = true;
                SaveOffsetButton.Visible = true;
                DistanceLabel.Visible = true;
                DistanceInput.Visible = true;
                ToTheLabel.Visible = true;
                Leftminus.Visible = true;
                Rightplus.Visible = true;
                Upminus.Visible = true;
                Downplus.Visible = true;
                Forwardminus.Visible = true;
                Forwardplus.Visible = true;
                MovementTypeLabel.Visible = true;
                MovementBox.Visible = true;
                FeedSpeedLabel.Visible = true;
                MovementButton1.Visible = true;
                FeedSpeed.Visible = true;
                MovementButton2.Visible = true;
                FindCenterLabel.Visible = true;
                CenterAxisLabel.Visible = true;
                CenterAxis.Visible = true;
                FCWCS1.Visible = true;
                WCSCENTER1.Visible = true;
                FCWCS2.Visible = true;
                WCSCENTER2.Visible = true;
                SaveToLabel.Visible = true;
                WCSSAVE.Visible = true;
                CenterFind.Visible = true;
                CalcTolerenceLabel.Visible = true;
                CTAxis.Visible = true;
                TolerenceAxis.Visible = true;
                TWCS1.Visible = true;
                TolerenceWCS1.Visible = true;
                TWCS2.Visible = true;
                TolerenceWcs2.Visible = true;
                TWCS3.Visible = true;
                TolerenceWcs3.Visible = true;
                TolerenceLabel.Visible = true;
                TolerenceText.Visible = true;
                TolerenceButton.Visible = true;
                //Page2//
                WaitDwellLabel.Visible = false;
                WaitDwellInput.Visible = false;
                WaitDwellButton.Visible = false;
                FeedLabel.Visible = false;
                FeedInputPG.Visible = false;
                FeedWriteButton.Visible = false;
                EnableSpindle.Visible = false;
                DisableSpindle.Visible = false;
                HomeAxis.Visible = false;
                AutoLevel.Visible = false;
            }
            if (PageNum == 2)
            {
                //Page1//
                UnitsLabel.Visible = false;
                UnitsComboBox.Visible = false;
                UnitsButton.Visible = false;
                WCSLabel.Visible = false;
                WCSComboBox.Visible = false;
                WCSButton.Visible = false;
                Imlabel.Visible = false;
                IncrementalModeTrue.Visible = false;
                IncrementalModeFalse.Visible = false;
                SaveOffsetLabel.Visible = false;
                SOWCS.Visible = false;
                SAVEOFFSETWCS.Visible = false;
                ToolDiamLabel.Visible = false;
                ToolDiameter.Visible = false;
                AutoHalfLabel.Visible = false;
                AutoHalfCheck.Visible = false;
                SaveOffsetButton.Visible = false;
                DistanceLabel.Visible = false;
                DistanceInput.Visible = false;
                ToTheLabel.Visible = false;
                Leftminus.Visible = false;
                Rightplus.Visible = false;
                Upminus.Visible = false;
                Downplus.Visible = false;
                Forwardminus.Visible = false;
                Forwardplus.Visible = false;
                MovementTypeLabel.Visible = false;
                MovementBox.Visible = false;
                FeedSpeedLabel.Visible = false;
                MovementButton1.Visible = false;
                FeedSpeed.Visible = false;
                MovementButton2.Visible = false;
                FindCenterLabel.Visible = false;
                CenterAxisLabel.Visible = false;
                CenterAxis.Visible = false;
                FCWCS1.Visible = false;
                WCSCENTER1.Visible = false;
                FCWCS2.Visible = false;
                WCSCENTER2.Visible = false;
                SaveToLabel.Visible = false;
                WCSSAVE.Visible = false;
                CenterFind.Visible = false;
                CalcTolerenceLabel.Visible = false;
                CTAxis.Visible = false;
                TolerenceAxis.Visible = false;
                TWCS1.Visible = false;
                TolerenceWCS1.Visible = false;
                TWCS2.Visible = false;
                TolerenceWcs2.Visible = false;
                TWCS3.Visible = false;
                TolerenceWcs3.Visible = false;
                TolerenceLabel.Visible = false;
                TolerenceText.Visible = false;
                TolerenceButton.Visible = false;
                //Page2//
                WaitDwellLabel.Visible = true;
                WaitDwellInput.Visible = true;
                WaitDwellButton.Visible = true;
                FeedLabel.Visible = true;
                FeedInputPG.Visible = true;
                FeedWriteButton.Visible = true;
                EnableSpindle.Visible = true;
                DisableSpindle.Visible = true;
                HomeAxis.Visible = true;
                AutoLevel.Visible = true;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            PageNum -= 1;
            if (PageNum >= 1)
            {
                PageSwap(PageNum);
            }
            else
            {
                PageNum = 1;
            }
        }

        private void WaitDwellButton_Click(object sender, EventArgs e)
        {
            string WaitDwell = WaitDwellInput.Text;
            CodeOutput.Text += $"\r\nG4 P{WaitDwell}";
        }

        private void FeedWriteButton_Click(object sender, EventArgs e)
        {
            string feed = FeedInputPG.Text;
            CodeOutput.Text += $"\r\nF{feed}";
        }

        private void EnableSpindle_Click(object sender, EventArgs e)
        {
            CodeOutput.Text += $"\r\nS0 M3";
        }

        private void DisableSpindle_Click(object sender, EventArgs e)
        {
            CodeOutput.Text += $"\r\nS0 M5";
        }

        private void HomeAxis_Click(object sender, EventArgs e)
        {
            CodeOutput.Text += "\r\n$H";
        }

        private void AutoLevel_Click(object sender, EventArgs e)
        {
            CodeOutput.Text += "\r\n$L";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
