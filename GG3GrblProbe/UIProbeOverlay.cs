using System;
using System.Drawing;
using System.Windows.Forms;

namespace GG3GrblProbe
{
    public partial class UIProbeOverlay : Form
    {
        private bool isDragging;
        private Point offset;
        private int gridSpacingWidth;
        private int gridSpacingHeight;
        public int MULTIPLIER = 5;

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
            Pen outlinePen = new Pen(Color.Black, 3); // Use a thicker pen for the outline

            // Calculate the grid spacing based on the size of the picture box and the number of divisions
            int divisionsWidth = 241 / MULTIPLIER;
            int divisionsHeight = 85 / MULTIPLIER;
            gridSpacingWidth = pictureBox.Width / divisionsWidth;
            gridSpacingHeight = pictureBox.Height / divisionsHeight;

            // Draw the grid lines
            for (int x = 0; x <= pictureBox.Width; x += gridSpacingWidth)
            {
               // g.DrawLine(gridPen, x, 0, x, pictureBox.Height);
            }

            for (int y = 0; y <= pictureBox.Height; y += gridSpacingHeight)
            {
              //  g.DrawLine(gridPen, 0, y, pictureBox.Width, y);
            }

            // Draw the outline of the PictureBox rectangle
            g.DrawRectangle(outlinePen, 0, 0, pictureBox.Width - 1, pictureBox.Height - 1);

            // Dispose the pens to release resources
            gridPen.Dispose();
            outlinePen.Dispose();
        }

        private void UIProbeOverlay_Load(object sender, EventArgs e)
        {
            // Create a new picture box
            PictureBox pictureBox2 = new PictureBox();

            // Configure the picture box
            pictureBox2.Location = new Point(pictureBox1.Left + 50, pictureBox1.Top + 50); // Set the position of the picture box relative to pictureBox1
            pictureBox2.Size = new Size(400, 100);              // Set the size of the picture box
            pictureBox2.BackColor = Color.White;                // Set the background color of the picture box

            // Add the picture box to the form's controls
            pictureBox1.Controls.Add(pictureBox2); // Add pictureBox2 as a child control of pictureBox1

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
                int newX = (e.X + pictureBox.Left - offset.X) / gridSpacingWidth * gridSpacingWidth;
                int newY = (e.Y + pictureBox.Top - offset.Y) / gridSpacingHeight * gridSpacingHeight;

                // Ensure the new position stays within the boundaries of pictureBox1
                int maxX = pictureBox1.Width - pictureBox.Width;
                int maxY = pictureBox1.Height - pictureBox.Height;
                newX = Math.Max(0, Math.Min(newX, maxX));
                newY = Math.Max(0, Math.Min(newY, maxY));

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (int.TryParse(textBox1.Text, out int multiplier))
                {
                    MULTIPLIER = Math.Min(multiplier, 80); // Limit the value to 80 if it exceeds
                }
                else
                {
                    // Display an error message or perform appropriate error handling
                    MessageBox.Show("Invalid input. Please enter a valid integer.");
                }
            }
        }


    }
}
