namespace GG3GrblProbe
{
    partial class ManifestCreator
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
            this.JobNameInput = new System.Windows.Forms.TextBox();
            this.jobNameWrite = new System.Windows.Forms.Button();
            this.jobTextInput = new System.Windows.Forms.TextBox();
            this.JobTextWrite = new System.Windows.Forms.Button();
            this.stepNameInput = new System.Windows.Forms.TextBox();
            this.stepNameWrite = new System.Windows.Forms.Button();
            this.StepTextInput = new System.Windows.Forms.TextBox();
            this.StepTextWrite = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.FolderNameText = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.stepGcodeSelect = new System.Windows.Forms.Button();
            this.WriteStepGcode = new System.Windows.Forms.Button();
            this.OutputCode = new System.Windows.Forms.RichTextBox();
            this.SaveOutput = new System.Windows.Forms.Button();
            this.AdvSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JobNameInput
            // 
            this.JobNameInput.BackColor = System.Drawing.Color.Aquamarine;
            this.JobNameInput.Location = new System.Drawing.Point(12, 36);
            this.JobNameInput.Name = "JobNameInput";
            this.JobNameInput.Size = new System.Drawing.Size(776, 27);
            this.JobNameInput.TabIndex = 0;
            this.JobNameInput.Text = "Enter Job Name:";
            this.JobNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.JobNameInput.Visible = false;
            // 
            // jobNameWrite
            // 
            this.jobNameWrite.BackColor = System.Drawing.Color.Aquamarine;
            this.jobNameWrite.Location = new System.Drawing.Point(12, 69);
            this.jobNameWrite.Name = "jobNameWrite";
            this.jobNameWrite.Size = new System.Drawing.Size(776, 29);
            this.jobNameWrite.TabIndex = 1;
            this.jobNameWrite.Text = "Write:";
            this.jobNameWrite.UseVisualStyleBackColor = false;
            this.jobNameWrite.Visible = false;
            this.jobNameWrite.Click += new System.EventHandler(this.jobNameWrite_Click);
            // 
            // jobTextInput
            // 
            this.jobTextInput.Location = new System.Drawing.Point(12, 104);
            this.jobTextInput.Name = "jobTextInput";
            this.jobTextInput.Size = new System.Drawing.Size(776, 27);
            this.jobTextInput.TabIndex = 2;
            this.jobTextInput.Text = "Enter Job Text:";
            this.jobTextInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.jobTextInput.Visible = false;
            // 
            // JobTextWrite
            // 
            this.JobTextWrite.Location = new System.Drawing.Point(12, 137);
            this.JobTextWrite.Name = "JobTextWrite";
            this.JobTextWrite.Size = new System.Drawing.Size(776, 29);
            this.JobTextWrite.TabIndex = 3;
            this.JobTextWrite.Text = "Write:";
            this.JobTextWrite.UseVisualStyleBackColor = true;
            this.JobTextWrite.Visible = false;
            this.JobTextWrite.Click += new System.EventHandler(this.JobTextWrite_Click);
            // 
            // stepNameInput
            // 
            this.stepNameInput.Location = new System.Drawing.Point(12, 172);
            this.stepNameInput.Name = "stepNameInput";
            this.stepNameInput.Size = new System.Drawing.Size(776, 27);
            this.stepNameInput.TabIndex = 4;
            this.stepNameInput.Text = "Enter Step Name:";
            this.stepNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stepNameInput.Visible = false;
            // 
            // stepNameWrite
            // 
            this.stepNameWrite.Location = new System.Drawing.Point(12, 205);
            this.stepNameWrite.Name = "stepNameWrite";
            this.stepNameWrite.Size = new System.Drawing.Size(776, 29);
            this.stepNameWrite.TabIndex = 5;
            this.stepNameWrite.Text = "Write:";
            this.stepNameWrite.UseVisualStyleBackColor = true;
            this.stepNameWrite.Visible = false;
            this.stepNameWrite.Click += new System.EventHandler(this.stepNameWrite_Click);
            // 
            // StepTextInput
            // 
            this.StepTextInput.Location = new System.Drawing.Point(12, 240);
            this.StepTextInput.Name = "StepTextInput";
            this.StepTextInput.Size = new System.Drawing.Size(776, 27);
            this.StepTextInput.TabIndex = 6;
            this.StepTextInput.Text = "Enter Step Text:";
            this.StepTextInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StepTextInput.Visible = false;
            // 
            // StepTextWrite
            // 
            this.StepTextWrite.Location = new System.Drawing.Point(12, 273);
            this.StepTextWrite.Name = "StepTextWrite";
            this.StepTextWrite.Size = new System.Drawing.Size(776, 29);
            this.StepTextWrite.TabIndex = 7;
            this.StepTextWrite.Text = "Write:";
            this.StepTextWrite.UseVisualStyleBackColor = true;
            this.StepTextWrite.Visible = false;
            this.StepTextWrite.Click += new System.EventHandler(this.StepTextWrite_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(12, 160);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(776, 85);
            this.button5.TabIndex = 8;
            this.button5.Text = "Create Save Location:";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FolderNameText
            // 
            this.FolderNameText.Location = new System.Drawing.Point(12, 127);
            this.FolderNameText.Name = "FolderNameText";
            this.FolderNameText.Size = new System.Drawing.Size(776, 27);
            this.FolderNameText.TabIndex = 9;
            this.FolderNameText.Text = "Enter New Folder Name:";
            this.FolderNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(12, 36);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(776, 85);
            this.button6.TabIndex = 10;
            this.button6.Text = "Select Existing Folder:";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // stepGcodeSelect
            // 
            this.stepGcodeSelect.Location = new System.Drawing.Point(12, 308);
            this.stepGcodeSelect.Name = "stepGcodeSelect";
            this.stepGcodeSelect.Size = new System.Drawing.Size(776, 29);
            this.stepGcodeSelect.TabIndex = 11;
            this.stepGcodeSelect.Text = "Select Step Gcode:";
            this.stepGcodeSelect.UseVisualStyleBackColor = true;
            this.stepGcodeSelect.Visible = false;
            this.stepGcodeSelect.Click += new System.EventHandler(this.stepGcodeSelect_Click);
            // 
            // WriteStepGcode
            // 
            this.WriteStepGcode.Location = new System.Drawing.Point(12, 343);
            this.WriteStepGcode.Name = "WriteStepGcode";
            this.WriteStepGcode.Size = new System.Drawing.Size(776, 29);
            this.WriteStepGcode.TabIndex = 12;
            this.WriteStepGcode.Text = "Write:";
            this.WriteStepGcode.UseVisualStyleBackColor = true;
            this.WriteStepGcode.Visible = false;
            this.WriteStepGcode.Click += new System.EventHandler(this.WriteStepGcode_Click);
            // 
            // OutputCode
            // 
            this.OutputCode.Location = new System.Drawing.Point(12, 406);
            this.OutputCode.Name = "OutputCode";
            this.OutputCode.Size = new System.Drawing.Size(776, 381);
            this.OutputCode.TabIndex = 13;
            this.OutputCode.Text = "";
            this.OutputCode.Visible = false;
            this.OutputCode.TextChanged += new System.EventHandler(this.OutputCode_TextChanged);
            // 
            // SaveOutput
            // 
            this.SaveOutput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveOutput.Location = new System.Drawing.Point(12, 793);
            this.SaveOutput.Name = "SaveOutput";
            this.SaveOutput.Size = new System.Drawing.Size(776, 69);
            this.SaveOutput.TabIndex = 14;
            this.SaveOutput.Text = "Save Manifest:";
            this.SaveOutput.UseVisualStyleBackColor = true;
            this.SaveOutput.Visible = false;
            this.SaveOutput.Click += new System.EventHandler(this.SaveOutput_Click);
            // 
            // AdvSettings
            // 
            this.AdvSettings.Location = new System.Drawing.Point(12, 1);
            this.AdvSettings.Name = "AdvSettings";
            this.AdvSettings.Size = new System.Drawing.Size(193, 29);
            this.AdvSettings.TabIndex = 15;
            this.AdvSettings.Text = "Advanced Settings:";
            this.AdvSettings.UseVisualStyleBackColor = true;
            this.AdvSettings.Visible = false;
            this.AdvSettings.Click += new System.EventHandler(this.AdvSettings_Click);
            // 
            // ManifestCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 874);
            this.Controls.Add(this.AdvSettings);
            this.Controls.Add(this.SaveOutput);
            this.Controls.Add(this.OutputCode);
            this.Controls.Add(this.WriteStepGcode);
            this.Controls.Add(this.stepGcodeSelect);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.FolderNameText);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.StepTextWrite);
            this.Controls.Add(this.StepTextInput);
            this.Controls.Add(this.stepNameWrite);
            this.Controls.Add(this.stepNameInput);
            this.Controls.Add(this.JobTextWrite);
            this.Controls.Add(this.jobTextInput);
            this.Controls.Add(this.jobNameWrite);
            this.Controls.Add(this.JobNameInput);
            this.Name = "ManifestCreator";
            this.Text = "ManifestCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox JobNameInput;
        private Button jobNameWrite;
        private TextBox jobTextInput;
        private Button JobTextWrite;
        private TextBox stepNameInput;
        private Button stepNameWrite;
        private TextBox StepTextInput;
        private Button StepTextWrite;
        private Button button5;
        private TextBox FolderNameText;
        private Button button6;
        private Button stepGcodeSelect;
        private Button WriteStepGcode;
        private RichTextBox OutputCode;
        private Button SaveOutput;
        private Button AdvSettings;
    }
}