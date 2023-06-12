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
            this.SelectFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectFile
            // 
            this.SelectFile.Location = new System.Drawing.Point(12, 12);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(259, 49);
            this.SelectFile.TabIndex = 0;
            this.SelectFile.Text = "Select file to split";
            this.SelectFile.UseVisualStyleBackColor = true;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // Checkpoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.SelectFile);
            this.Name = "Checkpoint";
            this.Text = "Checkpoint";
            this.ResumeLayout(false);

        }

        #endregion

        private Button SelectFile;
    }
}