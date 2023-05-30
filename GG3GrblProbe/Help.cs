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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Header.Text = "Start WCS";
            Description.Text = "Start WCS is the start work cordinate system of the\r\nmachine, general use set to 54";
            BestDrawingEver.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Header.Text = "Start Pos.";
            Description.Text = "Start Position is the position you want to align the \r\nstock with.";
            BestDrawingEver.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Header.Text = "C-Clamp Offset";
            Description.Text = "C-Clamp Offset is if you are using the\r\nstandard C-Clamps for the gg3, this will\r\nauto calculate the height.";
            BestDrawingEver.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Header.Text = "Additional Offset";
            Description.Text = "Additional Offset is needed if there is an additional jig \r\non the x axis in the clamps or overall jig height.";
            BestDrawingEver.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Header.Text = "Generate Align";
            Description.Text = "Generate Align is used when all information is filled out\r\nand ready to save to a file for alignment.";
            BestDrawingEver.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Header.Text = "Probe WCS";
            Description.Text = "Probe WCS is the WCS you would like to save \r\n the probe offsets to, if you don't know what this is google is your friend.";
            BestDrawingEver.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Header.Text = "Start POS.";
            Description.Text = "Start POS. is the start position of where the bit is aligned.";
            BestDrawingEver.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Header.Text = "Stock Size";
            Description.Text = "Stock Size is the size of the material used for milling.";
            BestDrawingEver.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Header.Text = "Left Or Right";
            Description.Text = "Left or Right is used when facing the machine, \r\nnot the bit itself used to calculate movement.";
            BestDrawingEver.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Header.Text = "Distance From Spindle";
            Description.Text = "Distance from spindle is the amount\r\n to travel to hit the stock.";
            BestDrawingEver.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Header.Text = "Probe Method";
            Description.Text = "Probe Method is where you want the spindle to probe, \r\n note at this time there is only center that probes \r\n the center of the bar on each.";
            BestDrawingEver.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Header.Text = "Safe Movement Amount";
            Description.Text = "Safe Movement Amount, is the additional amount \r\nyou want the spindle to move away from the stock in any axis.";
            BestDrawingEver.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Header.Text = "Tool Diameter";
            Description.Text = "Tool Diameter is the overall diameter of the \r\ntool used, will automatically divide by 2";
            BestDrawingEver.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Header.Text = "Tool Length";
            Description.Text = "Tool Length is the overall length\r\nof the tool used.";
            BestDrawingEver.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Header.Text = "Tool Percentage";
            Description.Text = "Tool Percentage is the overall percentage of tool used.\r\nUsed to calculate movement default is 80.";
            BestDrawingEver.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Header.Text = "Generate Probe";
            Description.Text = "Generate Probe creates the probe file.";
            BestDrawingEver.Visible = false;
        }

        private void BestDrawingEver_Click(object sender, EventArgs e)
        {

        }
    }
}
