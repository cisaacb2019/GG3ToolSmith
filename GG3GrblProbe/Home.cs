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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Set_Up setup = new Set_Up();
            setup.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SpeedCreator speed = new SpeedCreator();
            speed.Show();
            this.Hide();
        }

        private void CheckPoint_Click(object sender, EventArgs e)
        {
            ManifestCreator checkpoint = new ManifestCreator();
            checkpoint.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ddcompress compressor = new ddcompress();
            compressor.Show();
            this.Hide();
        }

        private void CommandCenter_Click(object sender, EventArgs e)
        {
            CommandCenter commandcenter = new CommandCenter();
            commandcenter.Show();
            this.Hide();
        }
    }
}
