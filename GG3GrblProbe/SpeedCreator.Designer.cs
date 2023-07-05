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
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.UnitsComboBox = new System.Windows.Forms.ComboBox();
            this.UnitsLabel = new System.Windows.Forms.Label();
            this.WCSLabel = new System.Windows.Forms.Label();
            this.WCSComboBox = new System.Windows.Forms.ComboBox();
            this.IncrementalModeFalse = new System.Windows.Forms.Button();
            this.IncrementalModeTrue = new System.Windows.Forms.Button();
            this.Imlabel = new System.Windows.Forms.Label();
            this.SpindleSpeedLabel = new System.Windows.Forms.Label();
            this.SpindleSpeedInput = new System.Windows.Forms.TextBox();
            this.Leftminus = new System.Windows.Forms.Button();
            this.ToTheLabel = new System.Windows.Forms.Label();
            this.Rightplus = new System.Windows.Forms.Button();
            this.Upminus = new System.Windows.Forms.Button();
            this.Downplus = new System.Windows.Forms.Button();
            this.Forwardplus = new System.Windows.Forms.Button();
            this.Forwardminus = new System.Windows.Forms.Button();
            this.MovementTypeLabel = new System.Windows.Forms.Label();
            this.MovementBox = new System.Windows.Forms.ComboBox();
            this.UnitsButton = new System.Windows.Forms.Button();
            this.WCSButton = new System.Windows.Forms.Button();
            this.SpindleSpeedButton = new System.Windows.Forms.Button();
            this.MovementButton1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FeedSpeedLabel = new System.Windows.Forms.Label();
            this.FeedSpeed = new System.Windows.Forms.TextBox();
            this.MovementButton2 = new System.Windows.Forms.Button();
            this.SaveOffsetLabel = new System.Windows.Forms.Label();
            this.SAVEOFFSETWCS = new System.Windows.Forms.ComboBox();
            this.SOWCS = new System.Windows.Forms.Label();
            this.SaveOffsetButton = new System.Windows.Forms.Button();
            this.ToolDiamLabel = new System.Windows.Forms.Label();
            this.ToolDiameter = new System.Windows.Forms.TextBox();
            this.AutoHalfLabel = new System.Windows.Forms.Label();
            this.AutoHalfCheck = new System.Windows.Forms.CheckBox();
            this.FindCenterLabel = new System.Windows.Forms.Label();
            this.CenterAxisLabel = new System.Windows.Forms.Label();
            this.CenterAxis = new System.Windows.Forms.ComboBox();
            this.FCWCS1 = new System.Windows.Forms.Label();
            this.WCSCENTER1 = new System.Windows.Forms.ComboBox();
            this.WCSCENTER2 = new System.Windows.Forms.ComboBox();
            this.FCWCS2 = new System.Windows.Forms.Label();
            this.WCSSAVE = new System.Windows.Forms.ComboBox();
            this.SaveToLabel = new System.Windows.Forms.Label();
            this.CenterFind = new System.Windows.Forms.Button();
            this.CalcTolerenceLabel = new System.Windows.Forms.Label();
            this.TolerenceButton = new System.Windows.Forms.Button();
            this.TolerenceWcs3 = new System.Windows.Forms.ComboBox();
            this.TWCS3 = new System.Windows.Forms.Label();
            this.TolerenceWcs2 = new System.Windows.Forms.ComboBox();
            this.TWCS2 = new System.Windows.Forms.Label();
            this.TolerenceWCS1 = new System.Windows.Forms.ComboBox();
            this.TWCS1 = new System.Windows.Forms.Label();
            this.TolerenceAxis = new System.Windows.Forms.ComboBox();
            this.CTAxis = new System.Windows.Forms.Label();
            this.TolerenceLabel = new System.Windows.Forms.Label();
            this.TolerenceText = new System.Windows.Forms.TextBox();
            this.Forward = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.FeedInputPG = new System.Windows.Forms.TextBox();
            this.FeedWriteButton = new System.Windows.Forms.Button();
            this.FeedLabel = new System.Windows.Forms.Label();
            this.AutoLevel = new System.Windows.Forms.Button();
            this.HomeAxis = new System.Windows.Forms.Button();
            this.DisableSpindle = new System.Windows.Forms.Button();
            this.EnableSpindle = new System.Windows.Forms.Button();
            this.WaitDwellInput = new System.Windows.Forms.TextBox();
            this.WaitDwellButton = new System.Windows.Forms.Button();
            this.WaitDwellLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.YesDelete = new System.Windows.Forms.Button();
            this.NoSaveMe = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CodeOutput
            // 
            this.CodeOutput.Location = new System.Drawing.Point(35, 339);
            this.CodeOutput.Name = "CodeOutput";
            this.CodeOutput.Size = new System.Drawing.Size(1088, 293);
            this.CodeOutput.TabIndex = 0;
            this.CodeOutput.Text = "";
            // 
            // DistanceInput
            // 
            this.DistanceInput.Location = new System.Drawing.Point(100, 183);
            this.DistanceInput.Name = "DistanceInput";
            this.DistanceInput.Size = new System.Drawing.Size(125, 27);
            this.DistanceInput.TabIndex = 1;
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Location = new System.Drawing.Point(25, 183);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(69, 20);
            this.DistanceLabel.TabIndex = 2;
            this.DistanceLabel.Text = "Distance:";
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
            this.UnitsComboBox.Visible = false;
            // 
            // UnitsLabel
            // 
            this.UnitsLabel.AutoSize = true;
            this.UnitsLabel.Location = new System.Drawing.Point(22, 15);
            this.UnitsLabel.Name = "UnitsLabel";
            this.UnitsLabel.Size = new System.Drawing.Size(45, 20);
            this.UnitsLabel.TabIndex = 4;
            this.UnitsLabel.Text = "Units:";
            this.UnitsLabel.Visible = false;
            // 
            // WCSLabel
            // 
            this.WCSLabel.AutoSize = true;
            this.WCSLabel.Location = new System.Drawing.Point(22, 49);
            this.WCSLabel.Name = "WCSLabel";
            this.WCSLabel.Size = new System.Drawing.Size(43, 20);
            this.WCSLabel.TabIndex = 6;
            this.WCSLabel.Text = "WCS:";
            this.WCSLabel.Visible = false;
            // 
            // WCSComboBox
            // 
            this.WCSComboBox.FormattingEnabled = true;
            this.WCSComboBox.Items.AddRange(new object[] {
            "53",
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
            // Imlabel
            // 
            this.Imlabel.AutoSize = true;
            this.Imlabel.Location = new System.Drawing.Point(22, 84);
            this.Imlabel.Name = "Imlabel";
            this.Imlabel.Size = new System.Drawing.Size(133, 20);
            this.Imlabel.TabIndex = 9;
            this.Imlabel.Text = "Incremental Mode:";
            // 
            // SpindleSpeedLabel
            // 
            this.SpindleSpeedLabel.AutoSize = true;
            this.SpindleSpeedLabel.Location = new System.Drawing.Point(22, 118);
            this.SpindleSpeedLabel.Name = "SpindleSpeedLabel";
            this.SpindleSpeedLabel.Size = new System.Drawing.Size(108, 20);
            this.SpindleSpeedLabel.TabIndex = 11;
            this.SpindleSpeedLabel.Text = "Spindle Speed:";
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
            this.Leftminus.Location = new System.Drawing.Point(287, 183);
            this.Leftminus.Name = "Leftminus";
            this.Leftminus.Size = new System.Drawing.Size(132, 29);
            this.Leftminus.TabIndex = 12;
            this.Leftminus.Tag = "[\"Left\",\"-1\"]";
            this.Leftminus.Text = "Left (y-)";
            this.Leftminus.UseVisualStyleBackColor = true;
            this.Leftminus.Click += new System.EventHandler(this.Leftminus_Click);
            // 
            // ToTheLabel
            // 
            this.ToTheLabel.AutoSize = true;
            this.ToTheLabel.Location = new System.Drawing.Point(231, 190);
            this.ToTheLabel.Name = "ToTheLabel";
            this.ToTheLabel.Size = new System.Drawing.Size(50, 20);
            this.ToTheLabel.TabIndex = 13;
            this.ToTheLabel.Text = "To the";
            // 
            // Rightplus
            // 
            this.Rightplus.Location = new System.Drawing.Point(425, 183);
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
            this.Upminus.Location = new System.Drawing.Point(563, 183);
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
            this.Downplus.Location = new System.Drawing.Point(701, 183);
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
            this.Forwardplus.Location = new System.Drawing.Point(977, 183);
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
            this.Forwardminus.Location = new System.Drawing.Point(839, 183);
            this.Forwardminus.Name = "Forwardminus";
            this.Forwardminus.Size = new System.Drawing.Size(132, 29);
            this.Forwardminus.TabIndex = 17;
            this.Forwardminus.Tag = "-1";
            this.Forwardminus.Text = "Forward (z-)";
            this.Forwardminus.UseVisualStyleBackColor = true;
            this.Forwardminus.Click += new System.EventHandler(this.Forwardminus_Click);
            // 
            // MovementTypeLabel
            // 
            this.MovementTypeLabel.AutoSize = true;
            this.MovementTypeLabel.Location = new System.Drawing.Point(25, 223);
            this.MovementTypeLabel.Name = "MovementTypeLabel";
            this.MovementTypeLabel.Size = new System.Drawing.Size(118, 20);
            this.MovementTypeLabel.TabIndex = 19;
            this.MovementTypeLabel.Text = "Movement Type:";
            this.MovementTypeLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // MovementBox
            // 
            this.MovementBox.FormattingEnabled = true;
            this.MovementBox.Items.AddRange(new object[] {
            "G0 (Instant)",
            "G38.2 (Probe)"});
            this.MovementBox.Location = new System.Drawing.Point(149, 220);
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
            this.UnitsButton.Visible = false;
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
            this.MovementButton1.Location = new System.Drawing.Point(287, 219);
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
            this.button2.Location = new System.Drawing.Point(1054, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 25);
            this.button2.TabIndex = 36;
            this.button2.Text = "Help";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FeedSpeedLabel
            // 
            this.FeedSpeedLabel.AutoSize = true;
            this.FeedSpeedLabel.Location = new System.Drawing.Point(280, 223);
            this.FeedSpeedLabel.Name = "FeedSpeedLabel";
            this.FeedSpeedLabel.Size = new System.Drawing.Size(90, 20);
            this.FeedSpeedLabel.TabIndex = 37;
            this.FeedSpeedLabel.Text = "Feed Speed:";
            this.FeedSpeedLabel.Visible = false;
            // 
            // FeedSpeed
            // 
            this.FeedSpeed.Location = new System.Drawing.Point(376, 221);
            this.FeedSpeed.Name = "FeedSpeed";
            this.FeedSpeed.Size = new System.Drawing.Size(125, 27);
            this.FeedSpeed.TabIndex = 38;
            this.FeedSpeed.Text = "30";
            this.FeedSpeed.Visible = false;
            // 
            // MovementButton2
            // 
            this.MovementButton2.Location = new System.Drawing.Point(507, 219);
            this.MovementButton2.Name = "MovementButton2";
            this.MovementButton2.Size = new System.Drawing.Size(94, 29);
            this.MovementButton2.TabIndex = 39;
            this.MovementButton2.Text = "Write";
            this.MovementButton2.UseVisualStyleBackColor = true;
            this.MovementButton2.Visible = false;
            this.MovementButton2.Click += new System.EventHandler(this.MovementButton2_Click);
            // 
            // SaveOffsetLabel
            // 
            this.SaveOffsetLabel.AutoSize = true;
            this.SaveOffsetLabel.Location = new System.Drawing.Point(25, 152);
            this.SaveOffsetLabel.Name = "SaveOffsetLabel";
            this.SaveOffsetLabel.Size = new System.Drawing.Size(87, 20);
            this.SaveOffsetLabel.TabIndex = 40;
            this.SaveOffsetLabel.Text = "Save Offset:";
            // 
            // SAVEOFFSETWCS
            // 
            this.SAVEOFFSETWCS.FormattingEnabled = true;
            this.SAVEOFFSETWCS.Items.AddRange(new object[] {
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.SAVEOFFSETWCS.Location = new System.Drawing.Point(167, 149);
            this.SAVEOFFSETWCS.Name = "SAVEOFFSETWCS";
            this.SAVEOFFSETWCS.Size = new System.Drawing.Size(125, 28);
            this.SAVEOFFSETWCS.TabIndex = 41;
            // 
            // SOWCS
            // 
            this.SOWCS.AutoSize = true;
            this.SOWCS.Location = new System.Drawing.Point(118, 152);
            this.SOWCS.Name = "SOWCS";
            this.SOWCS.Size = new System.Drawing.Size(43, 20);
            this.SOWCS.TabIndex = 42;
            this.SOWCS.Text = "WCS:";
            // 
            // SaveOffsetButton
            // 
            this.SaveOffsetButton.Location = new System.Drawing.Point(739, 151);
            this.SaveOffsetButton.Name = "SaveOffsetButton";
            this.SaveOffsetButton.Size = new System.Drawing.Size(94, 29);
            this.SaveOffsetButton.TabIndex = 43;
            this.SaveOffsetButton.Text = "Write";
            this.SaveOffsetButton.UseVisualStyleBackColor = true;
            this.SaveOffsetButton.Visible = false;
            this.SaveOffsetButton.Click += new System.EventHandler(this.SaveOffsetButton_Click);
            // 
            // ToolDiamLabel
            // 
            this.ToolDiamLabel.AutoSize = true;
            this.ToolDiamLabel.Location = new System.Drawing.Point(298, 152);
            this.ToolDiamLabel.Name = "ToolDiamLabel";
            this.ToolDiamLabel.Size = new System.Drawing.Size(107, 20);
            this.ToolDiamLabel.TabIndex = 44;
            this.ToolDiamLabel.Text = "Tool Diameter:";
            // 
            // ToolDiameter
            // 
            this.ToolDiameter.Location = new System.Drawing.Point(411, 152);
            this.ToolDiameter.Name = "ToolDiameter";
            this.ToolDiameter.Size = new System.Drawing.Size(125, 27);
            this.ToolDiameter.TabIndex = 45;
            // 
            // AutoHalfLabel
            // 
            this.AutoHalfLabel.AutoSize = true;
            this.AutoHalfLabel.Location = new System.Drawing.Point(542, 155);
            this.AutoHalfLabel.Name = "AutoHalfLabel";
            this.AutoHalfLabel.Size = new System.Drawing.Size(138, 20);
            this.AutoHalfLabel.TabIndex = 46;
            this.AutoHalfLabel.Text = "AutoHalfDiameter?";
            // 
            // AutoHalfCheck
            // 
            this.AutoHalfCheck.AutoSize = true;
            this.AutoHalfCheck.Checked = true;
            this.AutoHalfCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoHalfCheck.Location = new System.Drawing.Point(686, 155);
            this.AutoHalfCheck.Name = "AutoHalfCheck";
            this.AutoHalfCheck.Size = new System.Drawing.Size(39, 24);
            this.AutoHalfCheck.TabIndex = 47;
            this.AutoHalfCheck.Text = "Y";
            this.AutoHalfCheck.UseVisualStyleBackColor = true;
            // 
            // FindCenterLabel
            // 
            this.FindCenterLabel.AutoSize = true;
            this.FindCenterLabel.Location = new System.Drawing.Point(23, 263);
            this.FindCenterLabel.Name = "FindCenterLabel";
            this.FindCenterLabel.Size = new System.Drawing.Size(87, 20);
            this.FindCenterLabel.TabIndex = 48;
            this.FindCenterLabel.Text = "Find Center:";
            // 
            // CenterAxisLabel
            // 
            this.CenterAxisLabel.AutoSize = true;
            this.CenterAxisLabel.Location = new System.Drawing.Point(116, 263);
            this.CenterAxisLabel.Name = "CenterAxisLabel";
            this.CenterAxisLabel.Size = new System.Drawing.Size(39, 20);
            this.CenterAxisLabel.TabIndex = 49;
            this.CenterAxisLabel.Text = "Axis:";
            // 
            // CenterAxis
            // 
            this.CenterAxis.FormattingEnabled = true;
            this.CenterAxis.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.CenterAxis.Location = new System.Drawing.Point(161, 260);
            this.CenterAxis.Name = "CenterAxis";
            this.CenterAxis.Size = new System.Drawing.Size(125, 28);
            this.CenterAxis.TabIndex = 50;
            // 
            // FCWCS1
            // 
            this.FCWCS1.AutoSize = true;
            this.FCWCS1.Location = new System.Drawing.Point(292, 263);
            this.FCWCS1.Name = "FCWCS1";
            this.FCWCS1.Size = new System.Drawing.Size(55, 20);
            this.FCWCS1.TabIndex = 51;
            this.FCWCS1.Text = "WCS 1:";
            // 
            // WCSCENTER1
            // 
            this.WCSCENTER1.FormattingEnabled = true;
            this.WCSCENTER1.Items.AddRange(new object[] {
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.WCSCENTER1.Location = new System.Drawing.Point(353, 260);
            this.WCSCENTER1.Name = "WCSCENTER1";
            this.WCSCENTER1.Size = new System.Drawing.Size(125, 28);
            this.WCSCENTER1.TabIndex = 52;
            // 
            // WCSCENTER2
            // 
            this.WCSCENTER2.FormattingEnabled = true;
            this.WCSCENTER2.Items.AddRange(new object[] {
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.WCSCENTER2.Location = new System.Drawing.Point(555, 260);
            this.WCSCENTER2.Name = "WCSCENTER2";
            this.WCSCENTER2.Size = new System.Drawing.Size(125, 28);
            this.WCSCENTER2.TabIndex = 54;
            // 
            // FCWCS2
            // 
            this.FCWCS2.AutoSize = true;
            this.FCWCS2.Location = new System.Drawing.Point(494, 263);
            this.FCWCS2.Name = "FCWCS2";
            this.FCWCS2.Size = new System.Drawing.Size(55, 20);
            this.FCWCS2.TabIndex = 53;
            this.FCWCS2.Text = "WCS 2:";
            // 
            // WCSSAVE
            // 
            this.WCSSAVE.FormattingEnabled = true;
            this.WCSSAVE.Items.AddRange(new object[] {
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.WCSSAVE.Location = new System.Drawing.Point(757, 260);
            this.WCSSAVE.Name = "WCSSAVE";
            this.WCSSAVE.Size = new System.Drawing.Size(125, 28);
            this.WCSSAVE.TabIndex = 56;
            // 
            // SaveToLabel
            // 
            this.SaveToLabel.AutoSize = true;
            this.SaveToLabel.Location = new System.Drawing.Point(688, 263);
            this.SaveToLabel.Name = "SaveToLabel";
            this.SaveToLabel.Size = new System.Drawing.Size(63, 20);
            this.SaveToLabel.TabIndex = 55;
            this.SaveToLabel.Text = "Save To:";
            // 
            // CenterFind
            // 
            this.CenterFind.Location = new System.Drawing.Point(888, 260);
            this.CenterFind.Name = "CenterFind";
            this.CenterFind.Size = new System.Drawing.Size(94, 29);
            this.CenterFind.TabIndex = 57;
            this.CenterFind.Text = "Write";
            this.CenterFind.UseVisualStyleBackColor = true;
            this.CenterFind.Visible = false;
            this.CenterFind.Click += new System.EventHandler(this.CenterFind_Click);
            // 
            // CalcTolerenceLabel
            // 
            this.CalcTolerenceLabel.AutoSize = true;
            this.CalcTolerenceLabel.Location = new System.Drawing.Point(25, 303);
            this.CalcTolerenceLabel.Name = "CalcTolerenceLabel";
            this.CalcTolerenceLabel.Size = new System.Drawing.Size(108, 20);
            this.CalcTolerenceLabel.TabIndex = 58;
            this.CalcTolerenceLabel.Text = "Calc Tolerence:";
            // 
            // TolerenceButton
            // 
            this.TolerenceButton.Location = new System.Drawing.Point(1056, 302);
            this.TolerenceButton.Name = "TolerenceButton";
            this.TolerenceButton.Size = new System.Drawing.Size(94, 29);
            this.TolerenceButton.TabIndex = 67;
            this.TolerenceButton.Text = "Write";
            this.TolerenceButton.UseVisualStyleBackColor = true;
            this.TolerenceButton.Visible = false;
            this.TolerenceButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TolerenceWcs3
            // 
            this.TolerenceWcs3.FormattingEnabled = true;
            this.TolerenceWcs3.Items.AddRange(new object[] {
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.TolerenceWcs3.Location = new System.Drawing.Point(757, 303);
            this.TolerenceWcs3.Name = "TolerenceWcs3";
            this.TolerenceWcs3.Size = new System.Drawing.Size(125, 28);
            this.TolerenceWcs3.TabIndex = 66;
            // 
            // TWCS3
            // 
            this.TWCS3.AutoSize = true;
            this.TWCS3.Location = new System.Drawing.Point(697, 306);
            this.TWCS3.Name = "TWCS3";
            this.TWCS3.Size = new System.Drawing.Size(51, 20);
            this.TWCS3.TabIndex = 65;
            this.TWCS3.Text = "WCS:3";
            // 
            // TolerenceWcs2
            // 
            this.TolerenceWcs2.FormattingEnabled = true;
            this.TolerenceWcs2.Items.AddRange(new object[] {
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.TolerenceWcs2.Location = new System.Drawing.Point(566, 303);
            this.TolerenceWcs2.Name = "TolerenceWcs2";
            this.TolerenceWcs2.Size = new System.Drawing.Size(125, 28);
            this.TolerenceWcs2.TabIndex = 64;
            // 
            // TWCS2
            // 
            this.TWCS2.AutoSize = true;
            this.TWCS2.Location = new System.Drawing.Point(505, 306);
            this.TWCS2.Name = "TWCS2";
            this.TWCS2.Size = new System.Drawing.Size(55, 20);
            this.TWCS2.TabIndex = 63;
            this.TWCS2.Text = "WCS 2:";
            // 
            // TolerenceWCS1
            // 
            this.TolerenceWCS1.FormattingEnabled = true;
            this.TolerenceWCS1.Items.AddRange(new object[] {
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.TolerenceWCS1.Location = new System.Drawing.Point(374, 303);
            this.TolerenceWCS1.Name = "TolerenceWCS1";
            this.TolerenceWCS1.Size = new System.Drawing.Size(125, 28);
            this.TolerenceWCS1.TabIndex = 62;
            // 
            // TWCS1
            // 
            this.TWCS1.AutoSize = true;
            this.TWCS1.Location = new System.Drawing.Point(313, 306);
            this.TWCS1.Name = "TWCS1";
            this.TWCS1.Size = new System.Drawing.Size(55, 20);
            this.TWCS1.TabIndex = 61;
            this.TWCS1.Text = "WCS 1:";
            // 
            // TolerenceAxis
            // 
            this.TolerenceAxis.FormattingEnabled = true;
            this.TolerenceAxis.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.TolerenceAxis.Location = new System.Drawing.Point(182, 303);
            this.TolerenceAxis.Name = "TolerenceAxis";
            this.TolerenceAxis.Size = new System.Drawing.Size(125, 28);
            this.TolerenceAxis.TabIndex = 60;
            // 
            // CTAxis
            // 
            this.CTAxis.AutoSize = true;
            this.CTAxis.Location = new System.Drawing.Point(137, 306);
            this.CTAxis.Name = "CTAxis";
            this.CTAxis.Size = new System.Drawing.Size(39, 20);
            this.CTAxis.TabIndex = 59;
            this.CTAxis.Text = "Axis:";
            this.CTAxis.Click += new System.EventHandler(this.CTAxis_Click);
            // 
            // TolerenceLabel
            // 
            this.TolerenceLabel.AutoSize = true;
            this.TolerenceLabel.Location = new System.Drawing.Point(888, 306);
            this.TolerenceLabel.Name = "TolerenceLabel";
            this.TolerenceLabel.Size = new System.Drawing.Size(76, 20);
            this.TolerenceLabel.TabIndex = 68;
            this.TolerenceLabel.Text = "Tolerence:";
            // 
            // TolerenceText
            // 
            this.TolerenceText.Location = new System.Drawing.Point(968, 302);
            this.TolerenceText.Name = "TolerenceText";
            this.TolerenceText.Size = new System.Drawing.Size(81, 27);
            this.TolerenceText.TabIndex = 69;
            // 
            // Forward
            // 
            this.Forward.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Forward.Location = new System.Drawing.Point(1129, 411);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(33, 130);
            this.Forward.TabIndex = 70;
            this.Forward.Text = ">";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.Expand_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Back.Location = new System.Drawing.Point(0, 411);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(33, 130);
            this.Back.TabIndex = 71;
            this.Back.Text = "<";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // FeedInputPG
            // 
            this.FeedInputPG.Location = new System.Drawing.Point(72, 46);
            this.FeedInputPG.Name = "FeedInputPG";
            this.FeedInputPG.Size = new System.Drawing.Size(125, 27);
            this.FeedInputPG.TabIndex = 90;
            // 
            // FeedWriteButton
            // 
            this.FeedWriteButton.Location = new System.Drawing.Point(203, 44);
            this.FeedWriteButton.Name = "FeedWriteButton";
            this.FeedWriteButton.Size = new System.Drawing.Size(94, 29);
            this.FeedWriteButton.TabIndex = 89;
            this.FeedWriteButton.Text = "Write";
            this.FeedWriteButton.UseVisualStyleBackColor = true;
            this.FeedWriteButton.Visible = false;
            this.FeedWriteButton.Click += new System.EventHandler(this.FeedWriteButton_Click);
            // 
            // FeedLabel
            // 
            this.FeedLabel.AutoSize = true;
            this.FeedLabel.Location = new System.Drawing.Point(22, 48);
            this.FeedLabel.Name = "FeedLabel";
            this.FeedLabel.Size = new System.Drawing.Size(44, 20);
            this.FeedLabel.TabIndex = 88;
            this.FeedLabel.Text = "Feed:";
            this.FeedLabel.Visible = false;
            // 
            // AutoLevel
            // 
            this.AutoLevel.Location = new System.Drawing.Point(430, 82);
            this.AutoLevel.Name = "AutoLevel";
            this.AutoLevel.Size = new System.Drawing.Size(130, 29);
            this.AutoLevel.TabIndex = 87;
            this.AutoLevel.Text = "Auto Level";
            this.AutoLevel.UseVisualStyleBackColor = true;
            this.AutoLevel.Click += new System.EventHandler(this.AutoLevel_Click);
            // 
            // HomeAxis
            // 
            this.HomeAxis.Location = new System.Drawing.Point(294, 82);
            this.HomeAxis.Name = "HomeAxis";
            this.HomeAxis.Size = new System.Drawing.Size(130, 29);
            this.HomeAxis.TabIndex = 86;
            this.HomeAxis.Text = "Home Axis";
            this.HomeAxis.UseVisualStyleBackColor = true;
            this.HomeAxis.Click += new System.EventHandler(this.HomeAxis_Click);
            // 
            // DisableSpindle
            // 
            this.DisableSpindle.Location = new System.Drawing.Point(158, 82);
            this.DisableSpindle.Name = "DisableSpindle";
            this.DisableSpindle.Size = new System.Drawing.Size(130, 29);
            this.DisableSpindle.TabIndex = 85;
            this.DisableSpindle.Text = "Disable Spindle";
            this.DisableSpindle.UseVisualStyleBackColor = true;
            this.DisableSpindle.Click += new System.EventHandler(this.DisableSpindle_Click);
            // 
            // EnableSpindle
            // 
            this.EnableSpindle.Location = new System.Drawing.Point(22, 82);
            this.EnableSpindle.Name = "EnableSpindle";
            this.EnableSpindle.Size = new System.Drawing.Size(130, 29);
            this.EnableSpindle.TabIndex = 84;
            this.EnableSpindle.Text = "Enable Spindle";
            this.EnableSpindle.UseVisualStyleBackColor = true;
            this.EnableSpindle.Click += new System.EventHandler(this.EnableSpindle_Click);
            // 
            // WaitDwellInput
            // 
            this.WaitDwellInput.Location = new System.Drawing.Point(111, 9);
            this.WaitDwellInput.Name = "WaitDwellInput";
            this.WaitDwellInput.Size = new System.Drawing.Size(125, 27);
            this.WaitDwellInput.TabIndex = 83;
            // 
            // WaitDwellButton
            // 
            this.WaitDwellButton.Location = new System.Drawing.Point(242, 11);
            this.WaitDwellButton.Name = "WaitDwellButton";
            this.WaitDwellButton.Size = new System.Drawing.Size(94, 29);
            this.WaitDwellButton.TabIndex = 81;
            this.WaitDwellButton.Text = "Write";
            this.WaitDwellButton.UseVisualStyleBackColor = true;
            this.WaitDwellButton.Visible = false;
            this.WaitDwellButton.Click += new System.EventHandler(this.WaitDwellButton_Click);
            // 
            // WaitDwellLabel
            // 
            this.WaitDwellLabel.AutoSize = true;
            this.WaitDwellLabel.Location = new System.Drawing.Point(22, 15);
            this.WaitDwellLabel.Name = "WaitDwellLabel";
            this.WaitDwellLabel.Size = new System.Drawing.Size(83, 20);
            this.WaitDwellLabel.TabIndex = 80;
            this.WaitDwellLabel.Text = "Wait/Dwell";
            this.WaitDwellLabel.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(35, 647);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1088, 44);
            this.button1.TabIndex = 91;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(1029, 339);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 29);
            this.Delete.TabIndex = 92;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // YesDelete
            // 
            this.YesDelete.BackColor = System.Drawing.Color.LightGreen;
            this.YesDelete.Location = new System.Drawing.Point(35, 339);
            this.YesDelete.Name = "YesDelete";
            this.YesDelete.Size = new System.Drawing.Size(94, 29);
            this.YesDelete.TabIndex = 93;
            this.YesDelete.Text = "Yes";
            this.YesDelete.UseVisualStyleBackColor = false;
            this.YesDelete.Visible = false;
            this.YesDelete.Click += new System.EventHandler(this.YesDelete_Click);
            // 
            // NoSaveMe
            // 
            this.NoSaveMe.BackColor = System.Drawing.Color.LightCoral;
            this.NoSaveMe.Location = new System.Drawing.Point(1029, 603);
            this.NoSaveMe.Name = "NoSaveMe";
            this.NoSaveMe.Size = new System.Drawing.Size(94, 29);
            this.NoSaveMe.TabIndex = 94;
            this.NoSaveMe.Text = "No";
            this.NoSaveMe.UseVisualStyleBackColor = false;
            this.NoSaveMe.Visible = false;
            this.NoSaveMe.Click += new System.EventHandler(this.NoSaveMe_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(960, 7);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(88, 29);
            this.Home.TabIndex = 95;
            this.Home.Text = "Go Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // SpeedCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 703);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.NoSaveMe);
            this.Controls.Add(this.YesDelete);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FeedInputPG);
            this.Controls.Add(this.FeedWriteButton);
            this.Controls.Add(this.FeedLabel);
            this.Controls.Add(this.AutoLevel);
            this.Controls.Add(this.HomeAxis);
            this.Controls.Add(this.DisableSpindle);
            this.Controls.Add(this.EnableSpindle);
            this.Controls.Add(this.WaitDwellInput);
            this.Controls.Add(this.WaitDwellButton);
            this.Controls.Add(this.WaitDwellLabel);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.TolerenceText);
            this.Controls.Add(this.TolerenceLabel);
            this.Controls.Add(this.TolerenceButton);
            this.Controls.Add(this.TolerenceWcs3);
            this.Controls.Add(this.TWCS3);
            this.Controls.Add(this.TolerenceWcs2);
            this.Controls.Add(this.TWCS2);
            this.Controls.Add(this.TolerenceWCS1);
            this.Controls.Add(this.TWCS1);
            this.Controls.Add(this.TolerenceAxis);
            this.Controls.Add(this.CTAxis);
            this.Controls.Add(this.CalcTolerenceLabel);
            this.Controls.Add(this.CenterFind);
            this.Controls.Add(this.WCSSAVE);
            this.Controls.Add(this.SaveToLabel);
            this.Controls.Add(this.WCSCENTER2);
            this.Controls.Add(this.FCWCS2);
            this.Controls.Add(this.WCSCENTER1);
            this.Controls.Add(this.FCWCS1);
            this.Controls.Add(this.CenterAxis);
            this.Controls.Add(this.CenterAxisLabel);
            this.Controls.Add(this.FindCenterLabel);
            this.Controls.Add(this.AutoHalfCheck);
            this.Controls.Add(this.AutoHalfLabel);
            this.Controls.Add(this.ToolDiameter);
            this.Controls.Add(this.ToolDiamLabel);
            this.Controls.Add(this.SaveOffsetButton);
            this.Controls.Add(this.SOWCS);
            this.Controls.Add(this.SAVEOFFSETWCS);
            this.Controls.Add(this.SaveOffsetLabel);
            this.Controls.Add(this.MovementButton2);
            this.Controls.Add(this.FeedSpeed);
            this.Controls.Add(this.FeedSpeedLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MovementButton1);
            this.Controls.Add(this.SpindleSpeedButton);
            this.Controls.Add(this.WCSButton);
            this.Controls.Add(this.UnitsButton);
            this.Controls.Add(this.MovementBox);
            this.Controls.Add(this.MovementTypeLabel);
            this.Controls.Add(this.Forwardplus);
            this.Controls.Add(this.Forwardminus);
            this.Controls.Add(this.Downplus);
            this.Controls.Add(this.Upminus);
            this.Controls.Add(this.Rightplus);
            this.Controls.Add(this.ToTheLabel);
            this.Controls.Add(this.Leftminus);
            this.Controls.Add(this.SpindleSpeedLabel);
            this.Controls.Add(this.SpindleSpeedInput);
            this.Controls.Add(this.Imlabel);
            this.Controls.Add(this.IncrementalModeTrue);
            this.Controls.Add(this.IncrementalModeFalse);
            this.Controls.Add(this.WCSLabel);
            this.Controls.Add(this.WCSComboBox);
            this.Controls.Add(this.UnitsLabel);
            this.Controls.Add(this.UnitsComboBox);
            this.Controls.Add(this.DistanceLabel);
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
        private Label DistanceLabel;
        private ComboBox UnitsComboBox;
        private Label UnitsLabel;
        private Label WCSLabel;
        private ComboBox WCSComboBox;
        private Button IncrementalModeFalse;
        private Button IncrementalModeTrue;
        private Label Imlabel;
        private Label SpindleSpeedLabel;
        private TextBox SpindleSpeedInput;
        private Button Leftminus;
        private Label ToTheLabel;
        private Button Rightplus;
        private Button Upminus;
        private Button Downplus;
        private Button Forwardplus;
        private Button Forwardminus;
        private Label MovementTypeLabel;
        private ComboBox MovementBox;
        private Button UnitsButton;
        private Button WCSButton;
        private Button SpindleSpeedButton;
        private Button MovementButton1;
        private Button button2;
        private Label FeedSpeedLabel;
        private TextBox FeedSpeed;
        private Button MovementButton2;
        private Label SaveOffsetLabel;
        private ComboBox SAVEOFFSETWCS;
        private Label SOWCS;
        private Button SaveOffsetButton;
        private Label ToolDiamLabel;
        private TextBox ToolDiameter;
        private Label AutoHalfLabel;
        private CheckBox AutoHalfCheck;
        private Label FindCenterLabel;
        private Label CenterAxisLabel;
        private ComboBox CenterAxis;
        private Label FCWCS1;
        private ComboBox WCSCENTER1;
        private ComboBox WCSCENTER2;
        private Label FCWCS2;
        private ComboBox WCSSAVE;
        private Label SaveToLabel;
        private Button CenterFind;
        private Label CalcTolerenceLabel;
        private Button TolerenceButton;
        private ComboBox TolerenceWcs3;
        private Label TWCS3;
        private ComboBox TolerenceWcs2;
        private Label TWCS2;
        private ComboBox TolerenceWCS1;
        private Label TWCS1;
        private ComboBox TolerenceAxis;
        private Label CTAxis;
        private Label TolerenceLabel;
        private TextBox TolerenceText;
        private Button Forward;
        private Button Back;
        private TextBox FeedInputPG;
        private Button FeedWriteButton;
        private Label FeedLabel;
        private Button AutoLevel;
        private Button HomeAxis;
        private Button DisableSpindle;
        private Button EnableSpindle;
        private TextBox WaitDwellInput;
        private Button WaitDwellButton;
        private Label WaitDwellLabel;
        private Button button1;
        private Button Delete;
        private Button YesDelete;
        private Button NoSaveMe;
        private Button Home;
    }
}