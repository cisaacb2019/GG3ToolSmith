namespace GG3GrblProbe
{
    partial class CommandCenter
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
            this.buttonDetect = new System.Windows.Forms.Button();
            this.comboBoxPortList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CommandSend = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.IncrementButton = new System.Windows.Forms.Button();
            this.ContinuousButton = new System.Windows.Forms.Button();
            this.IncrementMovement = new System.Windows.Forms.TextBox();
            this.mmlabel = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.DISPLAYOUTPUTTEXT = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDetect
            // 
            this.buttonDetect.Location = new System.Drawing.Point(288, 381);
            this.buttonDetect.Name = "buttonDetect";
            this.buttonDetect.Size = new System.Drawing.Size(129, 29);
            this.buttonDetect.TabIndex = 0;
            this.buttonDetect.Text = "Send Command:";
            this.buttonDetect.UseVisualStyleBackColor = true;
            this.buttonDetect.Click += new System.EventHandler(this.buttonDetect_Click_1);
            // 
            // comboBoxPortList
            // 
            this.comboBoxPortList.FormattingEnabled = true;
            this.comboBoxPortList.Location = new System.Drawing.Point(93, 12);
            this.comboBoxPortList.Name = "comboBoxPortList";
            this.comboBoxPortList.Size = new System.Drawing.Size(151, 28);
            this.comboBoxPortList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port/Com:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Command:";
            // 
            // CommandSend
            // 
            this.CommandSend.Location = new System.Drawing.Point(94, 255);
            this.CommandSend.Name = "CommandSend";
            this.CommandSend.Size = new System.Drawing.Size(592, 120);
            this.CommandSend.TabIndex = 4;
            this.CommandSend.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(204, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 85);
            this.button1.TabIndex = 5;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(414, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 85);
            this.button2.TabIndex = 6;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(304, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 85);
            this.button3.TabIndex = 7;
            this.button3.Text = "Up";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(304, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 85);
            this.button4.TabIndex = 8;
            this.button4.Text = "Down";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(514, 53);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 85);
            this.button5.TabIndex = 9;
            this.button5.Text = "Z-Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(514, 144);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 85);
            this.button6.TabIndex = 10;
            this.button6.Text = "Z-Forw";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // IncrementButton
            // 
            this.IncrementButton.BackColor = System.Drawing.Color.LightGreen;
            this.IncrementButton.Location = new System.Drawing.Point(12, 53);
            this.IncrementButton.Name = "IncrementButton";
            this.IncrementButton.Size = new System.Drawing.Size(94, 29);
            this.IncrementButton.TabIndex = 11;
            this.IncrementButton.Text = "Increment";
            this.IncrementButton.UseVisualStyleBackColor = false;
            this.IncrementButton.Click += new System.EventHandler(this.IncrementButton_Click);
            // 
            // ContinuousButton
            // 
            this.ContinuousButton.BackColor = System.Drawing.Color.LightGray;
            this.ContinuousButton.Location = new System.Drawing.Point(12, 88);
            this.ContinuousButton.Name = "ContinuousButton";
            this.ContinuousButton.Size = new System.Drawing.Size(94, 29);
            this.ContinuousButton.TabIndex = 12;
            this.ContinuousButton.Text = "continuous";
            this.ContinuousButton.UseVisualStyleBackColor = false;
            this.ContinuousButton.Click += new System.EventHandler(this.ContinuousButton_Click);
            // 
            // IncrementMovement
            // 
            this.IncrementMovement.Location = new System.Drawing.Point(112, 55);
            this.IncrementMovement.Name = "IncrementMovement";
            this.IncrementMovement.Size = new System.Drawing.Size(86, 27);
            this.IncrementMovement.TabIndex = 13;
            this.IncrementMovement.Text = "5";
            // 
            // mmlabel
            // 
            this.mmlabel.AutoSize = true;
            this.mmlabel.Location = new System.Drawing.Point(204, 58);
            this.mmlabel.Name = "mmlabel";
            this.mmlabel.Size = new System.Drawing.Size(38, 20);
            this.mmlabel.TabIndex = 14;
            this.mmlabel.Text = "mm.";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(250, 11);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 29);
            this.button7.TabIndex = 15;
            this.button7.Text = "Refresh";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(593, 394);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 29);
            this.button8.TabIndex = 16;
            this.button8.Text = "ADV:";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // DISPLAYOUTPUTTEXT
            // 
            this.DISPLAYOUTPUTTEXT.Location = new System.Drawing.Point(862, 255);
            this.DISPLAYOUTPUTTEXT.Name = "DISPLAYOUTPUTTEXT";
            this.DISPLAYOUTPUTTEXT.Size = new System.Drawing.Size(592, 120);
            this.DISPLAYOUTPUTTEXT.TabIndex = 17;
            this.DISPLAYOUTPUTTEXT.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(789, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "OUTPUT:";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(862, 381);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(129, 29);
            this.button9.TabIndex = 19;
            this.button9.Text = "Reset Output:";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1325, 381);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(129, 29);
            this.button10.TabIndex = 20;
            this.button10.Text = "Save:";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // CommandCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 424);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DISPLAYOUTPUTTEXT);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.mmlabel);
            this.Controls.Add(this.IncrementMovement);
            this.Controls.Add(this.ContinuousButton);
            this.Controls.Add(this.IncrementButton);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CommandSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPortList);
            this.Controls.Add(this.buttonDetect);
            this.Name = "CommandCenter";
            this.Text = "CommandCenter";
            this.Load += new System.EventHandler(this.CommandCenter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonDetect;
        private ComboBox comboBoxPortList;
        private Label label1;
        private Label label2;
        private RichTextBox CommandSend;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button IncrementButton;
        private Button ContinuousButton;
        private TextBox IncrementMovement;
        private Label mmlabel;
        private Button button7;
        private Button button8;
        private RichTextBox DISPLAYOUTPUTTEXT;
        private Label label3;
        private Button button9;
        private Button button10;
    }
}