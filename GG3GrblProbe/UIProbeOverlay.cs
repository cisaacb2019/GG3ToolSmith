using System;
using System.Drawing;
using System.Windows.Forms;

namespace GG3GrblProbe
{
    public partial class UIProbeOverlay : Form
    {
        private bool isDragging;
        private Point offset;
        private int gridSpacing;

        public UIProbeOverlay()
        {
            InitializeComponent();
            pictureBox1.Paint += pictureBox1_Paint;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            Graphics g = e.Graphics;
            Pen gridPen = new Pen(Color.LightGray, 1);

            // Calculate the grid spacing based on the size of the picture box and the number of divisions
            int divisions = 10;
            gridSpacing = pictureBox.Width / divisions;

            // Draw vertical lines
            for (int x = 0; x <= pictureBox.Width; x += gridSpacing)
            {
                g.DrawLine(gridPen, x, 0, x, pictureBox.Height);
            }

            // Draw horizontal lines
            for (int y = 0; y <= pictureBox.Height; y += gridSpacing)
            {
                g.DrawLine(gridPen, 0, y, pictureBox.Width, y);
            }
        }

        private void UIProbeOverlay_Load(object sender, EventArgs e)
        {
            // Create a new picture box
            PictureBox pictureBox2 = new PictureBox();

            // Configure the picture box
            pictureBox2.Location = new Point(50, 50);           // Set the position of the picture box
            pictureBox2.Size = new Size(200, 100);              // Set the size of the picture box
            pictureBox2.BackColor = Color.White;                // Set the background color of the picture box

            // Add the picture box to the form's controls
            Controls.Add(pictureBox2);

            // Bring pictureBox2 to the front
            pictureBox2.BringToFront();

            // Subscribe to the Paint event of pictureBox2
            pictureBox2.Paint += pictureBox2_Paint;

            // Subscribe to the MouseDown, MouseMove, and MouseUp events of pictureBox2
            pictureBox2.MouseDown += pictureBox2_MouseDown;
            pictureBox2.MouseMove += pictureBox2_MouseMove;
            pictureBox2.MouseUp += pictureBox2_MouseUp;
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            Graphics g = e.Graphics;
            Pen metalPen = new Pen(Color.Gray, 3);

            // Calculate the position and size of the metal bar
            int barX = 0;                               // Set the X-coordinate of the metal bar
            int barY = 0;                               // Set the Y-coordinate of the metal bar
            int barWidth = pictureBox.Width - 1;        // Set the width of the metal bar to match the picture box
            int barHeight = pictureBox.Height - 1;      // Set the height of the metal bar to match the picture box

            // Draw the metal bar
            g.DrawRectangle(metalPen, barX, barY, barWidth, barHeight);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            offset = e.Location;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                PictureBox pictureBox = (PictureBox)sender;

                // Calculate the new position of pictureBox2 aligned to the grid
                int newX = (e.X + pictureBox.Left - offset.X) / gridSpacing * gridSpacing;
                int newY = (e.Y + pictureBox.Top - offset.Y) / gridSpacing * gridSpacing;

                pictureBox.Location = new Point(newX, newY);
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Handle the click event for pictureBox1
        }
    }
}
