namespace GG3GrblProbe
{
    partial class AnyCrypt
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
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.decrypt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(117, 101);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(319, 29);
            this.Start.TabIndex = 0;
            this.Start.Text = "Select file:";
            this.Start.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(0, 0);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(75, 23);
            this.decrypt.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 80);
            this.label2.TabIndex = 2;
            this.label2.Text = "Below is used to encrypt and decrypt .dd files, notice do not do anything if it i" +
    "s not allowed in your provenance.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(12, 6);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(88, 29);
            this.Home.TabIndex = 39;
            this.Home.Text = "Go Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // AnyCrypt
            // 
            this.ClientSize = new System.Drawing.Size(320, 265);
            this.ControlBox = false;
            this.Controls.Add(this.Home);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AnyCrypt";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Start;
        private Label label1;
        private Button decrypt;
        private Button button1;
        private Button button2;
        private Label label2;
        private Button Home;
    }
}