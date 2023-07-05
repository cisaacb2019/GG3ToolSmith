namespace GG3GrblProbe
{
    partial class Checkpoint
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
            this.AddOne = new System.Windows.Forms.Button();
            this.CurrentStep = new System.Windows.Forms.Label();
            this.Counter = new System.Windows.Forms.Label();
            this.Sub1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "New Checkpoint";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddOne
            // 
            this.AddOne.Location = new System.Drawing.Point(327, 211);
            this.AddOne.Name = "AddOne";
            this.AddOne.Size = new System.Drawing.Size(138, 76);
            this.AddOne.TabIndex = 1;
            this.AddOne.Text = "Add 1";
            this.AddOne.UseVisualStyleBackColor = true;
            this.AddOne.Visible = false;
            this.AddOne.Click += new System.EventHandler(this.button2_Click);
            // 
            // CurrentStep
            // 
            this.CurrentStep.AutoSize = true;
            this.CurrentStep.Location = new System.Drawing.Point(331, 97);
            this.CurrentStep.Name = "CurrentStep";
            this.CurrentStep.Size = new System.Drawing.Size(134, 20);
            this.CurrentStep.TabIndex = 2;
            this.CurrentStep.Text = "Current Step to do:\r\n";
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Counter.Location = new System.Drawing.Point(384, 150);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(27, 31);
            this.Counter.TabIndex = 3;
            this.Counter.Text = "0\r\n";
            // 
            // Sub1
            // 
            this.Sub1.Location = new System.Drawing.Point(327, 293);
            this.Sub1.Name = "Sub1";
            this.Sub1.Size = new System.Drawing.Size(138, 76);
            this.Sub1.TabIndex = 4;
            this.Sub1.Text = "Sub 1";
            this.Sub1.UseVisualStyleBackColor = true;
            this.Sub1.Visible = false;
            this.Sub1.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Load Existing";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(12, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(88, 29);
            this.Home.TabIndex = 40;
            this.Home.Text = "Go Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Checkpoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 387);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Sub1);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.CurrentStep);
            this.Controls.Add(this.AddOne);
            this.Controls.Add(this.button1);
            this.Name = "Checkpoint";
            this.Text = "Checkpoint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button AddOne;
        private Label CurrentStep;
        private Label Counter;
        private Button Sub1;
        private Button button2;
        private Button Home;
    }
}