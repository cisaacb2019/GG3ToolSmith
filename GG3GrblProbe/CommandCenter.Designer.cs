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
            this.SuspendLayout();
            // 
            // buttonDetect
            // 
            this.buttonDetect.Location = new System.Drawing.Point(344, 680);
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
            this.label2.Location = new System.Drawing.Point(14, 574);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Command:";
            // 
            // CommandSend
            // 
            this.CommandSend.Location = new System.Drawing.Point(101, 554);
            this.CommandSend.Name = "CommandSend";
            this.CommandSend.Size = new System.Drawing.Size(592, 120);
            this.CommandSend.TabIndex = 4;
            this.CommandSend.Text = "";
            // 
            // CommandCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 722);
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
    }
}