namespace GG3GrblProbe
{
    partial class SpeedCreator
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
            this.CodeOutput = new System.Windows.Forms.RichTextBox();
            this.DistanceInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UnitsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WCSComboBox = new System.Windows.Forms.ComboBox();
            this.IncrementalModeFalse = new System.Windows.Forms.Button();
            this.IncrementalModeTrue = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SpindleSpeedInput = new System.Windows.Forms.TextBox();
            this.Leftminus = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Rightplus = new System.Windows.Forms.Button();
            this.Upminus = new System.Windows.Forms.Button();
            this.Downplus = new System.Windows.Forms.Button();
            this.Forwardplus = new System.Windows.Forms.Button();
            this.Forwardminus = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.MovementBox = new System.Windows.Forms.ComboBox();
            this.UnitsButton = new System.Windows.Forms.Button();
            this.WCSButton = new System.Windows.Forms.Button();
            this.SpindleSpeedButton = new System.Windows.Forms.Button();
            this.MovementButton1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FeedSpeedLabel = new System.Windows.Forms.Label();
            this.FeedSpeed = new System.Windows.Forms.TextBox();
            this.MovementButton2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CodeOutput
            // 
            this.CodeOutput.Location = new System.Drawing.Point(12, 339);
            this.CodeOutput.Name = "CodeOutput";
            this.CodeOutput.Size = new System.Drawing.Size(1071, 293);
            this.CodeOutput.TabIndex = 0;
            this.CodeOutput.Text = "";
            // 
            // DistanceInput
            // 
            this.DistanceInput.Location = new System.Drawing.Point(99, 148);
            this.DistanceInput.Name = "DistanceInput";
            this.DistanceInput.Size = new System.Drawing.Size(125, 27);
            this.DistanceInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Distance:";
            // 
            // UnitsComboBox
            // 
            this.UnitsComboBox.FormattingEnabled = true;
            this.UnitsComboBox.Items.AddRange(new object[] {
            "Inches",
            "Millimeters"});
            this.UnitsComboBox.Location = new System.Drawing.Point(87, 12);
            this.UnitsComboBox.Name = "UnitsComboBox";
            this.UnitsComboBox.Size = new System.Drawing.Size(125, 28);
            this.UnitsComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Units:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "WCS:";
            // 
            // WCSComboBox
            // 
            this.WCSComboBox.FormattingEnabled = true;
            this.WCSComboBox.Items.AddRange(new object[] {
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.WCSComboBox.Location = new System.Drawing.Point(87, 46);
            this.WCSComboBox.Name = "WCSComboBox";
            this.WCSComboBox.Size = new System.Drawing.Size(125, 28);
            this.WCSComboBox.TabIndex = 5;
            // 
            // IncrementalModeFalse
            // 
            this.IncrementalModeFalse.Location = new System.Drawing.Point(257, 80);
            this.IncrementalModeFalse.Name = "IncrementalModeFalse";
            this.IncrementalModeFalse.Size = new System.Drawing.Size(94, 29);
            this.IncrementalModeFalse.TabIndex = 7;
            this.IncrementalModeFalse.Text = "False";
            this.IncrementalModeFalse.UseVisualStyleBackColor = true;
            this.IncrementalModeFalse.Click += new System.EventHandler(this.IncrementalModeFalse_Click);
            // 
            // IncrementalModeTrue
            // 
            this.IncrementalModeTrue.Location = new System.Drawing.Point(157, 80);
            this.IncrementalModeTrue.Name = "IncrementalModeTrue";
            this.IncrementalModeTrue.Size = new System.Drawing.Size(94, 29);
            this.IncrementalModeTrue.TabIndex = 8;
            this.IncrementalModeTrue.Text = "True";
            this.IncrementalModeTrue.UseVisualStyleBackColor = true;
            this.IncrementalModeTrue.Click += new System.EventHandler(this.IncrementalModeTrue_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Incremental Mode:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Spindle Speed:";
            // 
            // SpindleSpeedInput
            // 
            this.SpindleSpeedInput.Location = new System.Drawing.Point(136, 115);
            this.SpindleSpeedInput.Name = "SpindleSpeedInput";
            this.SpindleSpeedInput.Size = new System.Drawing.Size(125, 27);
            this.SpindleSpeedInput.TabIndex = 10;
            // 
            // Leftminus
            // 
            this.Leftminus.Location = new System.Drawing.Point(286, 148);
            this.Leftminus.Name = "Leftminus";
            this.Leftminus.Size = new System.Drawing.Size(132, 29);
            this.Leftminus.TabIndex = 12;
            this.Leftminus.Tag = "[\"Left\",\"-1\"]";
            this.Leftminus.Text = "Left (y-)";
            this.Leftminus.UseVisualStyleBackColor = true;
            this.Leftminus.Click += new System.EventHandler(this.Leftminus_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "To the";
            // 
            // Rightplus
            // 
            this.Rightplus.Location = new System.Drawing.Point(424, 148);
            this.Rightplus.Name = "Rightplus";
            this.Rightplus.Size = new System.Drawing.Size(132, 29);
            this.Rightplus.TabIndex = 14;
            this.Rightplus.Tag = "[Right,1]";
            this.Rightplus.Text = "Right (y+)";
            this.Rightplus.UseVisualStyleBackColor = true;
            this.Rightplus.Click += new System.EventHandler(this.Rightplus_Click);
            // 
            // Upminus
            // 
            this.Upminus.Location = new System.Drawing.Point(562, 148);
            this.Upminus.Name = "Upminus";
            this.Upminus.Size = new System.Drawing.Size(132, 29);
            this.Upminus.TabIndex = 15;
            this.Upminus.Tag = "-1";
            this.Upminus.Text = "Up (x-)";
            this.Upminus.UseVisualStyleBackColor = true;
            this.Upminus.Click += new System.EventHandler(this.Upminus_Click);
            // 
            // Downplus
            // 
            this.Downplus.Location = new System.Drawing.Point(700, 148);
            this.Downplus.Name = "Downplus";
            this.Downplus.Size = new System.Drawing.Size(132, 29);
            this.Downplus.TabIndex = 16;
            this.Downplus.Tag = "1";
            this.Downplus.Text = "Down (x+)";
            this.Downplus.UseVisualStyleBackColor = true;
            this.Downplus.Click += new System.EventHandler(this.Downplus_Click);
            // 
            // Forwardplus
            // 
            this.Forwardplus.Location = new System.Drawing.Point(976, 148);
            this.Forwardplus.Name = "Forwardplus";
            this.Forwardplus.Size = new System.Drawing.Size(132, 29);
            this.Forwardplus.TabIndex = 18;
            this.Forwardplus.Tag = "1";
            this.Forwardplus.Text = "Backward (z+)";
            this.Forwardplus.UseVisualStyleBackColor = true;
            this.Forwardplus.Click += new System.EventHandler(this.Forwardplus_Click);
            // 
            // Forwardminus
            // 
            this.Forwardminus.Location = new System.Drawing.Point(838, 148);
            this.Forwardminus.Name = "Forwardminus";
            this.Forwardminus.Size = new System.Drawing.Size(132, 29);
            this.Forwardminus.TabIndex = 17;
            this.Forwardminus.Tag = "-1";
            this.Forwardminus.Text = "Forward (z-)";
            this.Forwardminus.UseVisualStyleBackColor = true;
            this.Forwardminus.Click += new System.EventHandler(this.Forwardminus_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Movement Type:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // MovementBox
            // 
            this.MovementBox.FormattingEnabled = true;
            this.MovementBox.Items.AddRange(new object[] {
            "G0 (Instant)",
            "G38.2 (Probe)"});
            this.MovementBox.Location = new System.Drawing.Point(148, 185);
            this.MovementBox.Name = "MovementBox";
            this.MovementBox.Size = new System.Drawing.Size(125, 28);
            this.MovementBox.TabIndex = 20;
            this.MovementBox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // UnitsButton
            // 
            this.UnitsButton.Location = new System.Drawing.Point(218, 11);
            this.UnitsButton.Name = "UnitsButton";
            this.UnitsButton.Size = new System.Drawing.Size(94, 29);
            this.UnitsButton.TabIndex = 21;
            this.UnitsButton.Text = "Write";
            this.UnitsButton.UseVisualStyleBackColor = true;
            this.UnitsButton.Click += new System.EventHandler(this.button9_Click);
            // 
            // WCSButton
            // 
            this.WCSButton.Location = new System.Drawing.Point(218, 45);
            this.WCSButton.Name = "WCSButton";
            this.WCSButton.Size = new System.Drawing.Size(94, 29);
            this.WCSButton.TabIndex = 22;
            this.WCSButton.Text = "Write";
            this.WCSButton.UseVisualStyleBackColor = true;
            this.WCSButton.Click += new System.EventHandler(this.WCSButton_Click);
            // 
            // SpindleSpeedButton
            // 
            this.SpindleSpeedButton.Location = new System.Drawing.Point(267, 115);
            this.SpindleSpeedButton.Name = "SpindleSpeedButton";
            this.SpindleSpeedButton.Size = new System.Drawing.Size(94, 29);
            this.SpindleSpeedButton.TabIndex = 23;
            this.SpindleSpeedButton.Text = "Write";
            this.SpindleSpeedButton.UseVisualStyleBackColor = true;
            this.SpindleSpeedButton.Click += new System.EventHandler(this.SpindleSpeedButton_Click);
            // 
            // MovementButton1
            // 
            this.MovementButton1.Location = new System.Drawing.Point(286, 184);
            this.MovementButton1.Name = "MovementButton1";
            this.MovementButton1.Size = new System.Drawing.Size(94, 29);
            this.MovementButton1.TabIndex = 24;
            this.MovementButton1.Text = "Write";
            this.MovementButton1.UseVisualStyleBackColor = true;
            this.MovementButton1.Visible = false;
            this.MovementButton1.Click += new System.EventHandler(this.MovementButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(1009, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 25);
            this.button2.TabIndex = 36;
            this.button2.Text = "Help";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FeedSpeedLabel
            // 
            this.FeedSpeedLabel.AutoSize = true;
            this.FeedSpeedLabel.Location = new System.Drawing.Point(279, 188);
            this.FeedSpeedLabel.Name = "FeedSpeedLabel";
            this.FeedSpeedLabel.Size = new System.Drawing.Size(90, 20);
            this.FeedSpeedLabel.TabIndex = 37;
            this.FeedSpeedLabel.Text = "Feed Speed:";
            this.FeedSpeedLabel.Visible = false;
            // 
            // FeedSpeed
            // 
            this.FeedSpeed.Location = new System.Drawing.Point(375, 186);
            this.FeedSpeed.Name = "FeedSpeed";
            this.FeedSpeed.Size = new System.Drawing.Size(125, 27);
            this.FeedSpeed.TabIndex = 38;
            this.FeedSpeed.Text = "30";
            this.FeedSpeed.Visible = false;
            // 
            // MovementButton2
            // 
            this.MovementButton2.Location = new System.Drawing.Point(506, 184);
            this.MovementButton2.Name = "MovementButton2";
            this.MovementButton2.Size = new System.Drawing.Size(94, 29);
            this.MovementButton2.TabIndex = 39;
            this.MovementButton2.Text = "Write";
            this.MovementButton2.UseVisualStyleBackColor = true;
            this.MovementButton2.Visible = false;
            this.MovementButton2.Click += new System.EventHandler(this.MovementButton2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Save Offset:";
            // 
            // SpeedCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 703);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MovementButton2);
            this.Controls.Add(this.FeedSpeed);
            this.Controls.Add(this.FeedSpeedLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MovementButton1);
            this.Controls.Add(this.SpindleSpeedButton);
            this.Controls.Add(this.WCSButton);
            this.Controls.Add(this.UnitsButton);
            this.Controls.Add(this.MovementBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Forwardplus);
            this.Controls.Add(this.Forwardminus);
            this.Controls.Add(this.Downplus);
            this.Controls.Add(this.Upminus);
            this.Controls.Add(this.Rightplus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Leftminus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SpindleSpeedInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IncrementalModeTrue);
            this.Controls.Add(this.IncrementalModeFalse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WCSComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UnitsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DistanceInput);
            this.Controls.Add(this.CodeOutput);
            this.Name = "SpeedCreator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SpeedCreator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox CodeOutput;
        private TextBox DistanceInput;
        private Label label1;
        private ComboBox UnitsComboBox;
        private Label label2;
        private Label label3;
        private ComboBox WCSComboBox;
        private Button IncrementalModeFalse;
        private Button IncrementalModeTrue;
        private Label label4;
        private Label label5;
        private TextBox SpindleSpeedInput;
        private Button Leftminus;
        private Label label6;
        private Button Rightplus;
        private Button Upminus;
        private Button Downplus;
        private Button Forwardplus;
        private Button Forwardminus;
        private Label label7;
        private ComboBox MovementBox;
        private Button UnitsButton;
        private Button WCSButton;
        private Button SpindleSpeedButton;
        private Button MovementButton1;
        private Button button2;
        private Label FeedSpeedLabel;
        private TextBox FeedSpeed;
        private Button MovementButton2;
        private Label label8;
    }
}