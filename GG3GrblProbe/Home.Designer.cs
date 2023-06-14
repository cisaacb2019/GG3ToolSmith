namespace GG3GrblProbe
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CheckPoint = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Stock Align/Probe Generator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 72);
            this.button2.TabIndex = 1;
            this.button2.Text = "Speed Creator";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CheckPoint
            // 
            this.CheckPoint.Location = new System.Drawing.Point(428, 36);
            this.CheckPoint.Name = "CheckPoint";
            this.CheckPoint.Size = new System.Drawing.Size(202, 72);
            this.CheckPoint.TabIndex = 2;
            this.CheckPoint.Text = "Manifest Creator";
            this.CheckPoint.UseVisualStyleBackColor = true;
            this.CheckPoint.Click += new System.EventHandler(this.CheckPoint_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 72);
            this.button3.TabIndex = 3;
            this.button3.Text = "DD Compressor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CheckPoint);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button CheckPoint;
        private Button button3;
    }
}