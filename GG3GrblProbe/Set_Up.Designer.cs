namespace GG3GrblProbe
{
    partial class Set_Up
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
            this.label1 = new System.Windows.Forms.Label();
            this.StartWcs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartYInput = new System.Windows.Forms.TextBox();
            this.StartZInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StartXInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CclampYes = new System.Windows.Forms.CheckBox();
            this.CclampNo = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.AdditionalOffset = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ProbeWcs = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.GenerateProbeX = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.GenerateProbeZ = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.GenerateProbeY = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.StockSizeX = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.StockSizeZ = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.StockSizeY = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.GenerateProbe = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.DistanceInput = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.SafeMovementInput = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.ToolSizeInput = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.ToolLengthInput = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.DefaultInput = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.ToolPercentageInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "WCS:";
            // 
            // StartWcs
            // 
            this.StartWcs.FormattingEnabled = true;
            this.StartWcs.Items.AddRange(new object[] {
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.StartWcs.Location = new System.Drawing.Point(89, 16);
            this.StartWcs.Name = "StartWcs";
            this.StartWcs.Size = new System.Drawing.Size(151, 28);
            this.StartWcs.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Pos.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(129, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y";
            // 
            // StartYInput
            // 
            this.StartYInput.Location = new System.Drawing.Point(164, 67);
            this.StartYInput.Name = "StartYInput";
            this.StartYInput.Size = new System.Drawing.Size(50, 27);
            this.StartYInput.TabIndex = 4;
            this.StartYInput.TextChanged += new System.EventHandler(this.StartYInput_TextChanged);
            // 
            // StartZInput
            // 
            this.StartZInput.Location = new System.Drawing.Point(258, 68);
            this.StartZInput.Name = "StartZInput";
            this.StartZInput.Size = new System.Drawing.Size(50, 27);
            this.StartZInput.TabIndex = 6;
            this.StartZInput.TextChanged += new System.EventHandler(this.StartZInput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(223, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "Z";
            // 
            // StartXInput
            // 
            this.StartXInput.Location = new System.Drawing.Point(358, 69);
            this.StartXInput.Name = "StartXInput";
            this.StartXInput.Size = new System.Drawing.Size(50, 27);
            this.StartXInput.TabIndex = 8;
            this.StartXInput.TextChanged += new System.EventHandler(this.StartXInput_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(323, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 35);
            this.label5.TabIndex = 7;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 35);
            this.label6.TabIndex = 9;
            this.label6.Text = "C-Clamp Offset";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(223, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 35);
            this.label8.TabIndex = 11;
            // 
            // CclampYes
            // 
            this.CclampYes.AutoSize = true;
            this.CclampYes.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CclampYes.Location = new System.Drawing.Point(203, 108);
            this.CclampYes.Name = "CclampYes";
            this.CclampYes.Size = new System.Drawing.Size(51, 39);
            this.CclampYes.TabIndex = 12;
            this.CclampYes.Text = "Y";
            this.CclampYes.UseVisualStyleBackColor = true;
            // 
            // CclampNo
            // 
            this.CclampNo.AutoSize = true;
            this.CclampNo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CclampNo.Location = new System.Drawing.Point(260, 108);
            this.CclampNo.Name = "CclampNo";
            this.CclampNo.Size = new System.Drawing.Size(56, 39);
            this.CclampNo.TabIndex = 13;
            this.CclampNo.Text = "N";
            this.CclampNo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(435, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "Generate Align";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 35);
            this.label9.TabIndex = 15;
            this.label9.Text = "Additional Offset";
            // 
            // AdditionalOffset
            // 
            this.AdditionalOffset.Location = new System.Drawing.Point(232, 167);
            this.AdditionalOffset.Name = "AdditionalOffset";
            this.AdditionalOffset.Size = new System.Drawing.Size(50, 27);
            this.AdditionalOffset.TabIndex = 16;
            this.AdditionalOffset.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(220, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "-";
            // 
            // ProbeWcs
            // 
            this.ProbeWcs.FormattingEnabled = true;
            this.ProbeWcs.Items.AddRange(new object[] {
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.ProbeWcs.Location = new System.Drawing.Point(150, 272);
            this.ProbeWcs.Name = "ProbeWcs";
            this.ProbeWcs.Size = new System.Drawing.Size(151, 28);
            this.ProbeWcs.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(12, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 35);
            this.label11.TabIndex = 18;
            this.label11.Text = "ProbeWCS:";
            // 
            // GenerateProbeX
            // 
            this.GenerateProbeX.Location = new System.Drawing.Point(371, 323);
            this.GenerateProbeX.Name = "GenerateProbeX";
            this.GenerateProbeX.Size = new System.Drawing.Size(50, 27);
            this.GenerateProbeX.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(335, 315);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 35);
            this.label12.TabIndex = 25;
            this.label12.Text = "X";
            // 
            // GenerateProbeZ
            // 
            this.GenerateProbeZ.Location = new System.Drawing.Point(270, 322);
            this.GenerateProbeZ.Name = "GenerateProbeZ";
            this.GenerateProbeZ.Size = new System.Drawing.Size(50, 27);
            this.GenerateProbeZ.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(235, 314);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 35);
            this.label13.TabIndex = 23;
            this.label13.Text = "Z";
            // 
            // GenerateProbeY
            // 
            this.GenerateProbeY.Location = new System.Drawing.Point(176, 321);
            this.GenerateProbeY.Name = "GenerateProbeY";
            this.GenerateProbeY.Size = new System.Drawing.Size(50, 27);
            this.GenerateProbeY.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(141, 313);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 35);
            this.label14.TabIndex = 21;
            this.label14.Text = "Y";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(11, 315);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 35);
            this.label15.TabIndex = 20;
            this.label15.Text = "Start Pos.";
            // 
            // StockSizeX
            // 
            this.StockSizeX.Location = new System.Drawing.Point(371, 372);
            this.StockSizeX.Name = "StockSizeX";
            this.StockSizeX.Size = new System.Drawing.Size(50, 27);
            this.StockSizeX.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(335, 364);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 35);
            this.label16.TabIndex = 32;
            this.label16.Text = "X";
            // 
            // StockSizeZ
            // 
            this.StockSizeZ.Location = new System.Drawing.Point(270, 371);
            this.StockSizeZ.Name = "StockSizeZ";
            this.StockSizeZ.Size = new System.Drawing.Size(50, 27);
            this.StockSizeZ.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(235, 363);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 35);
            this.label17.TabIndex = 30;
            this.label17.Text = "Z";
            // 
            // StockSizeY
            // 
            this.StockSizeY.Location = new System.Drawing.Point(176, 370);
            this.StockSizeY.Name = "StockSizeY";
            this.StockSizeY.Size = new System.Drawing.Size(50, 27);
            this.StockSizeY.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(141, 362);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 35);
            this.label18.TabIndex = 28;
            this.label18.Text = "Y";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(11, 364);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 35);
            this.label19.TabIndex = 27;
            this.label19.Text = "Stock Size";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(371, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 25);
            this.button2.TabIndex = 35;
            this.button2.Text = "Help";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GenerateProbe
            // 
            this.GenerateProbe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenerateProbe.Location = new System.Drawing.Point(12, 808);
            this.GenerateProbe.Name = "GenerateProbe";
            this.GenerateProbe.Size = new System.Drawing.Size(435, 43);
            this.GenerateProbe.TabIndex = 37;
            this.GenerateProbe.Text = "Generate Probe";
            this.GenerateProbe.UseVisualStyleBackColor = true;
            this.GenerateProbe.Click += new System.EventHandler(this.GenerateProbe_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 419);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(283, 20);
            this.label21.TabIndex = 38;
            this.label21.Text = "When looking at the machine the stock is:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(220, 451);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(103, 20);
            this.label22.TabIndex = 39;
            this.label22.Text = "of the spindle.";
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(12, 442);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(94, 29);
            this.LeftButton.TabIndex = 40;
            this.LeftButton.Text = "Left";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(120, 442);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(94, 29);
            this.RightButton.TabIndex = 41;
            this.RightButton.Text = "Right";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(12, 487);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(269, 35);
            this.label23.TabIndex = 42;
            this.label23.Text = "Distance From Spindle:";
            // 
            // DistanceInput
            // 
            this.DistanceInput.Location = new System.Drawing.Point(287, 492);
            this.DistanceInput.Name = "DistanceInput";
            this.DistanceInput.Size = new System.Drawing.Size(50, 27);
            this.DistanceInput.TabIndex = 43;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(335, 499);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 20);
            this.label24.TabIndex = 44;
            this.label24.Text = "mm.";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(12, 537);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(175, 35);
            this.label25.TabIndex = 45;
            this.label25.Text = "Probe Method";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Center"});
            this.comboBox2.Location = new System.Drawing.Point(193, 544);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 46;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(12, 587);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(284, 35);
            this.label20.TabIndex = 47;
            this.label20.Text = "Safe Movement Amount";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(350, 602);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 20);
            this.label26.TabIndex = 49;
            this.label26.Text = "mm.";
            // 
            // SafeMovementInput
            // 
            this.SafeMovementInput.Location = new System.Drawing.Point(302, 595);
            this.SafeMovementInput.Name = "SafeMovementInput";
            this.SafeMovementInput.Size = new System.Drawing.Size(50, 27);
            this.SafeMovementInput.TabIndex = 48;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(12, 637);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(171, 35);
            this.label27.TabIndex = 50;
            this.label27.Text = "Tool Diameter";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(232, 649);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(38, 20);
            this.label28.TabIndex = 52;
            this.label28.Text = "mm.";
            // 
            // ToolSizeInput
            // 
            this.ToolSizeInput.Location = new System.Drawing.Point(184, 642);
            this.ToolSizeInput.Name = "ToolSizeInput";
            this.ToolSizeInput.Size = new System.Drawing.Size(50, 27);
            this.ToolSizeInput.TabIndex = 51;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label29.Location = new System.Drawing.Point(12, 687);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(145, 35);
            this.label29.TabIndex = 53;
            this.label29.Text = "Tool Length";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(203, 699);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(38, 20);
            this.label30.TabIndex = 55;
            this.label30.Text = "mm.";
            // 
            // ToolLengthInput
            // 
            this.ToolLengthInput.Location = new System.Drawing.Point(155, 692);
            this.ToolLengthInput.Name = "ToolLengthInput";
            this.ToolLengthInput.Size = new System.Drawing.Size(50, 27);
            this.ToolLengthInput.TabIndex = 54;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label31.Location = new System.Drawing.Point(12, 737);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(192, 35);
            this.label31.TabIndex = 56;
            this.label31.Text = "Tool Percentage";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(211, 752);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(0, 20);
            this.label32.TabIndex = 57;
            // 
            // DefaultInput
            // 
            this.DefaultInput.Location = new System.Drawing.Point(210, 745);
            this.DefaultInput.Name = "DefaultInput";
            this.DefaultInput.Size = new System.Drawing.Size(94, 29);
            this.DefaultInput.TabIndex = 58;
            this.DefaultInput.Text = "Default";
            this.DefaultInput.UseVisualStyleBackColor = true;
            this.DefaultInput.Click += new System.EventHandler(this.DefaultInput_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(386, 752);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(21, 20);
            this.label33.TabIndex = 60;
            this.label33.Text = "%";
            // 
            // ToolPercentageInput
            // 
            this.ToolPercentageInput.Location = new System.Drawing.Point(338, 745);
            this.ToolPercentageInput.Name = "ToolPercentageInput";
            this.ToolPercentageInput.Size = new System.Drawing.Size(50, 27);
            this.ToolPercentageInput.TabIndex = 59;
            this.ToolPercentageInput.TextChanged += new System.EventHandler(this.ToolPercentageInput_TextChanged);
            // 
            // Set_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 863);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.ToolPercentageInput);
            this.Controls.Add(this.DefaultInput);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.ToolLengthInput);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.ToolSizeInput);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.SafeMovementInput);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.DistanceInput);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.GenerateProbe);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.StockSizeX);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.StockSizeZ);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.StockSizeY);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.GenerateProbeX);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.GenerateProbeZ);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.GenerateProbeY);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ProbeWcs);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AdditionalOffset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CclampNo);
            this.Controls.Add(this.CclampYes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StartXInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StartZInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StartYInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartWcs);
            this.Controls.Add(this.label1);
            this.Name = "Set_Up";
            this.Load += new System.EventHandler(this.Set_Up_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox StartWcs;
        private Label label2;
        private Label label3;
        private TextBox StartYInput;
        private TextBox StartZInput;
        private Label label4;
        private TextBox StartXInput;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private CheckBox CclampYes;
        private CheckBox CclampNo;
        private Button button1;
        private Label label9;
        private TextBox AdditionalOffset;
        private Label label10;
        private ComboBox ProbeWcs;
        private Label label11;
        private TextBox GenerateProbeX;
        private Label label12;
        private TextBox GenerateProbeZ;
        private Label label13;
        private TextBox GenerateProbeY;
        private Label label14;
        private Label label15;
        private TextBox StockSizeX;
        private Label label16;
        private TextBox StockSizeZ;
        private Label label17;
        private TextBox StockSizeY;
        private Label label18;
        private Label label19;
        private Button button2;
        private Button GenerateProbe;
        private Label label21;
        private Label label22;
        private Button LeftButton;
        private Button RightButton;
        private Label label23;
        private TextBox DistanceInput;
        private Label label24;
        private Label label25;
        private ComboBox comboBox2;
        private Label label20;
        private Label label26;
        private TextBox SafeMovementInput;
        private Label label27;
        private Label label28;
        private TextBox ToolSizeInput;
        private Label label29;
        private Label label30;
        private TextBox ToolLengthInput;
        private Label label31;
        private Label label32;
        private Button DefaultInput;
        private Label label33;
        private TextBox ToolPercentageInput;
    }
}