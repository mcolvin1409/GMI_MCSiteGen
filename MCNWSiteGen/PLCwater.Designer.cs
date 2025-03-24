namespace MCNWSiteGen
{
    partial class PLCwater
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
        /// MarkC MT 16792 6/20/11 Add PLC DtoA Sweep and Water control
		/// MarkC WI 193061 8/19/19 use the AVTPLC input methods for input
        /// </summary>
        private void InitializeComponent()
        {
            this.checkEnabled = new System.Windows.Forms.CheckBox();
            this.gpPLCSettings = new System.Windows.Forms.GroupBox();
            this.txtWaterStartupVolt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtWaterStartSpeedMax = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtWaterStartSpeedMin = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtWaterOutputMin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWaterDivisor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSweepDivisor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSampleTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboPLCList = new System.Windows.Forms.ComboBox();
            this.cboCommPorts = new System.Windows.Forms.ComboBox();
            this.txtTachPulses = new System.Windows.Forms.TextBox();
            this.txtMechDelay = new System.Windows.Forms.TextBox();
            this.txtWashCycle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlWizardTitle = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.gpABPLCSettings = new System.Windows.Forms.GroupBox();
            this.txtABPOLLRATE = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cboABPOLLType = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cboABPLCMapType = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cboABPLCMod = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtABPLCFilename = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtABPLCASNode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cboDH_Baud = new System.Windows.Forms.ComboBox();
            this.cboABType = new System.Windows.Forms.ComboBox();
            this.txtABPLCNode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gpPLCSettings.SuspendLayout();
            this.pnlWizardTitle.SuspendLayout();
            this.gpABPLCSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkEnabled
            // 
            this.checkEnabled.AutoSize = true;
            this.checkEnabled.ForeColor = System.Drawing.Color.Transparent;
            this.checkEnabled.Location = new System.Drawing.Point(12, 36);
            this.checkEnabled.Name = "checkEnabled";
            this.checkEnabled.Size = new System.Drawing.Size(51, 17);
            this.checkEnabled.TabIndex = 0;
            this.checkEnabled.Text = "Used";
            this.checkEnabled.UseVisualStyleBackColor = true;
            this.checkEnabled.CheckedChanged += new System.EventHandler(this.checkEnabled_CheckedChanged);
            // 
            // gpPLCSettings
            // 
            this.gpPLCSettings.Controls.Add(this.txtWaterStartupVolt);
            this.gpPLCSettings.Controls.Add(this.label13);
            this.gpPLCSettings.Controls.Add(this.txtWaterStartSpeedMax);
            this.gpPLCSettings.Controls.Add(this.label11);
            this.gpPLCSettings.Controls.Add(this.txtWaterStartSpeedMin);
            this.gpPLCSettings.Controls.Add(this.label12);
            this.gpPLCSettings.Controls.Add(this.txtWaterOutputMin);
            this.gpPLCSettings.Controls.Add(this.label10);
            this.gpPLCSettings.Controls.Add(this.txtWaterDivisor);
            this.gpPLCSettings.Controls.Add(this.label9);
            this.gpPLCSettings.Controls.Add(this.txtSweepDivisor);
            this.gpPLCSettings.Controls.Add(this.label8);
            this.gpPLCSettings.Controls.Add(this.txtSampleTime);
            this.gpPLCSettings.Controls.Add(this.label7);
            this.gpPLCSettings.Controls.Add(this.label6);
            this.gpPLCSettings.Controls.Add(this.cboPLCList);
            this.gpPLCSettings.Controls.Add(this.cboCommPorts);
            this.gpPLCSettings.Controls.Add(this.txtTachPulses);
            this.gpPLCSettings.Controls.Add(this.txtMechDelay);
            this.gpPLCSettings.Controls.Add(this.txtWashCycle);
            this.gpPLCSettings.Controls.Add(this.label4);
            this.gpPLCSettings.Controls.Add(this.label3);
            this.gpPLCSettings.Controls.Add(this.label2);
            this.gpPLCSettings.Controls.Add(this.label1);
            this.gpPLCSettings.Enabled = false;
            this.gpPLCSettings.ForeColor = System.Drawing.Color.White;
            this.gpPLCSettings.Location = new System.Drawing.Point(12, 52);
            this.gpPLCSettings.Name = "gpPLCSettings";
            this.gpPLCSettings.Size = new System.Drawing.Size(350, 400);
            this.gpPLCSettings.TabIndex = 1;
            this.gpPLCSettings.TabStop = false;
            this.gpPLCSettings.Text = "PLC Water Settings";
            // 
            // txtWaterStartupVolt
            // 
            this.txtWaterStartupVolt.Location = new System.Drawing.Point(222, 313);
            this.txtWaterStartupVolt.MaxLength = 5;
            this.txtWaterStartupVolt.Name = "txtWaterStartupVolt";
            this.txtWaterStartupVolt.Size = new System.Drawing.Size(100, 20);
            this.txtWaterStartupVolt.TabIndex = 11;
            this.txtWaterStartupVolt.Validating += new System.ComponentModel.CancelEventHandler(this.txtWaterStartupVolt_Validating);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 312);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(192, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Water Startup Voltage (0 to 2000)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWaterStartSpeedMax
            // 
            this.txtWaterStartSpeedMax.Location = new System.Drawing.Point(222, 287);
            this.txtWaterStartSpeedMax.MaxLength = 5;
            this.txtWaterStartSpeedMax.Name = "txtWaterStartSpeedMax";
            this.txtWaterStartSpeedMax.Size = new System.Drawing.Size(100, 20);
            this.txtWaterStartSpeedMax.TabIndex = 10;
            this.txtWaterStartSpeedMax.Validating += new System.ComponentModel.CancelEventHandler(this.txtWaterStartSpeedMax_Validating);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Water Start Speed Maximum";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWaterStartSpeedMin
            // 
            this.txtWaterStartSpeedMin.Location = new System.Drawing.Point(223, 259);
            this.txtWaterStartSpeedMin.MaxLength = 5;
            this.txtWaterStartSpeedMin.Name = "txtWaterStartSpeedMin";
            this.txtWaterStartSpeedMin.Size = new System.Drawing.Size(100, 20);
            this.txtWaterStartSpeedMin.TabIndex = 9;
            this.txtWaterStartSpeedMin.Validating += new System.ComponentModel.CancelEventHandler(this.txtWaterStartSpeedMin_Validating);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(7, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Water Start Speed Minimum";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWaterOutputMin
            // 
            this.txtWaterOutputMin.Location = new System.Drawing.Point(221, 232);
            this.txtWaterOutputMin.MaxLength = 5;
            this.txtWaterOutputMin.Name = "txtWaterOutputMin";
            this.txtWaterOutputMin.Size = new System.Drawing.Size(100, 20);
            this.txtWaterOutputMin.TabIndex = 8;
            this.txtWaterOutputMin.Validating += new System.ComponentModel.CancelEventHandler(this.txtWaterOutputMin_Validating);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(5, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Water Output Minimum";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWaterDivisor
            // 
            this.txtWaterDivisor.Location = new System.Drawing.Point(222, 204);
            this.txtWaterDivisor.MaxLength = 5;
            this.txtWaterDivisor.Name = "txtWaterDivisor";
            this.txtWaterDivisor.Size = new System.Drawing.Size(100, 20);
            this.txtWaterDivisor.TabIndex = 7;
            this.txtWaterDivisor.Validating += new System.ComponentModel.CancelEventHandler(this.txtWaterDivisor_Validating);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Water Divisor";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSweepDivisor
            // 
            this.txtSweepDivisor.Location = new System.Drawing.Point(222, 176);
            this.txtSweepDivisor.MaxLength = 5;
            this.txtSweepDivisor.Name = "txtSweepDivisor";
            this.txtSweepDivisor.Size = new System.Drawing.Size(100, 20);
            this.txtSweepDivisor.TabIndex = 6;
            this.txtSweepDivisor.Validating += new System.ComponentModel.CancelEventHandler(this.txtSweepDivisor_Validating);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Sweep Divisor";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSampleTime
            // 
            this.txtSampleTime.Location = new System.Drawing.Point(222, 148);
            this.txtSampleTime.MaxLength = 5;
            this.txtSampleTime.Name = "txtSampleTime";
            this.txtSampleTime.Size = new System.Drawing.Size(100, 20);
            this.txtSampleTime.TabIndex = 5;
            this.txtSampleTime.Validating += new System.ComponentModel.CancelEventHandler(this.txtSampleTime_Validating);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sample Time (ms)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(72, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "PLC Type";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboPLCList
            // 
            this.cboPLCList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPLCList.FormattingEnabled = true;
            this.cboPLCList.Items.AddRange(new object[] {
            "Nilpeter",
            "Crabtree",
            "Digital to Analog",
            "Ragsdale",
            "Allen Bradley"});
            this.cboPLCList.Location = new System.Drawing.Point(222, 6);
            this.cboPLCList.Name = "cboPLCList";
            this.cboPLCList.Size = new System.Drawing.Size(100, 21);
            this.cboPLCList.TabIndex = 0;
            // 
            // cboCommPorts
            // 
            this.cboCommPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCommPorts.FormattingEnabled = true;
            this.cboCommPorts.Location = new System.Drawing.Point(222, 35);
            this.cboCommPorts.Name = "cboCommPorts";
            this.cboCommPorts.Size = new System.Drawing.Size(100, 21);
            this.cboCommPorts.TabIndex = 1;
            // 
            // txtTachPulses
            // 
            this.txtTachPulses.Location = new System.Drawing.Point(222, 120);
            this.txtTachPulses.MaxLength = 5;
            this.txtTachPulses.Name = "txtTachPulses";
            this.txtTachPulses.Size = new System.Drawing.Size(100, 20);
            this.txtTachPulses.TabIndex = 4;
            this.txtTachPulses.Validating += new System.ComponentModel.CancelEventHandler(this.txtTachPulses_Validating);
            // 
            // txtMechDelay
            // 
            this.txtMechDelay.Location = new System.Drawing.Point(222, 92);
            this.txtMechDelay.MaxLength = 5;
            this.txtMechDelay.Name = "txtMechDelay";
            this.txtMechDelay.Size = new System.Drawing.Size(100, 20);
            this.txtMechDelay.TabIndex = 3;
            this.txtMechDelay.Validating += new System.ComponentModel.CancelEventHandler(this.txtMechDelay_Validating);
            // 
            // txtWashCycle
            // 
            this.txtWashCycle.Location = new System.Drawing.Point(222, 64);
            this.txtWashCycle.MaxLength = 5;
            this.txtWashCycle.Name = "txtWashCycle";
            this.txtWashCycle.Size = new System.Drawing.Size(100, 20);
            this.txtWashCycle.TabIndex = 2;
            this.txtWashCycle.Validating += new System.ComponentModel.CancelEventHandler(this.txtWashCycle_Validating);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tach pulse per execution cycle.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mechanical Delay(in ms)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wash Cycle Time(in tenth of a Second)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comm Port.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOK
            // 
            this.btnOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.btnOK.Location = new System.Drawing.Point(437, 415);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 51);
            this.btnOK.TabIndex = 19;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(544, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 51);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlWizardTitle
            // 
            this.pnlWizardTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlWizardTitle.Controls.Add(this.label5);
            this.pnlWizardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWizardTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlWizardTitle.Name = "pnlWizardTitle";
            this.pnlWizardTitle.Size = new System.Drawing.Size(673, 31);
            this.pnlWizardTitle.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(126, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "PLC Water";
            // 
            // gpABPLCSettings
            // 
            this.gpABPLCSettings.Controls.Add(this.txtABPOLLRATE);
            this.gpABPLCSettings.Controls.Add(this.label22);
            this.gpABPLCSettings.Controls.Add(this.cboABPOLLType);
            this.gpABPLCSettings.Controls.Add(this.label21);
            this.gpABPLCSettings.Controls.Add(this.cboABPLCMapType);
            this.gpABPLCSettings.Controls.Add(this.label20);
            this.gpABPLCSettings.Controls.Add(this.label19);
            this.gpABPLCSettings.Controls.Add(this.cboABPLCMod);
            this.gpABPLCSettings.Controls.Add(this.label18);
            this.gpABPLCSettings.Controls.Add(this.txtABPLCFilename);
            this.gpABPLCSettings.Controls.Add(this.label17);
            this.gpABPLCSettings.Controls.Add(this.txtABPLCASNode);
            this.gpABPLCSettings.Controls.Add(this.label16);
            this.gpABPLCSettings.Controls.Add(this.label15);
            this.gpABPLCSettings.Controls.Add(this.cboDH_Baud);
            this.gpABPLCSettings.Controls.Add(this.cboABType);
            this.gpABPLCSettings.Controls.Add(this.txtABPLCNode);
            this.gpABPLCSettings.Controls.Add(this.label14);
            this.gpABPLCSettings.ForeColor = System.Drawing.Color.White;
            this.gpABPLCSettings.Location = new System.Drawing.Point(377, 58);
            this.gpABPLCSettings.Name = "gpABPLCSettings";
            this.gpABPLCSettings.Size = new System.Drawing.Size(274, 335);
            this.gpABPLCSettings.TabIndex = 73;
            this.gpABPLCSettings.TabStop = false;
            this.gpABPLCSettings.Text = "Allen Bradley PLC Settings";
            // 
            // txtABPOLLRATE
            // 
            this.txtABPOLLRATE.Location = new System.Drawing.Point(148, 260);
            this.txtABPOLLRATE.Name = "txtABPOLLRATE";
            this.txtABPOLLRATE.Size = new System.Drawing.Size(100, 20);
            this.txtABPOLLRATE.TabIndex = 22;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(23, 260);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(112, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "AB PLC Poll Rate (ms)";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboABPOLLType
            // 
            this.cboABPOLLType.FormattingEnabled = true;
            this.cboABPOLLType.Items.AddRange(new object[] {
            "PLC Page",
            "Fountain"});
            this.cboABPOLLType.Location = new System.Drawing.Point(147, 232);
            this.cboABPOLLType.Name = "cboABPOLLType";
            this.cboABPOLLType.Size = new System.Drawing.Size(121, 21);
            this.cboABPOLLType.TabIndex = 20;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(44, 232);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "AB PLC Poll Type";
            // 
            // cboABPLCMapType
            // 
            this.cboABPLCMapType.FormattingEnabled = true;
            this.cboABPLCMapType.Items.AddRange(new object[] {
            "BakerPerkinsPLC3",
            "BakerPerkinsPLC5",
            "GMI_STD_SLC5",
            "GMI_STD_PLC5",
            "Goss_PLC5",
            "Goss_SLC504",
            "Goss_Cxxx_PLC5",
            "HANTSCHO_MRKx"});
            this.cboABPLCMapType.Location = new System.Drawing.Point(147, 202);
            this.cboABPLCMapType.Name = "cboABPLCMapType";
            this.cboABPLCMapType.Size = new System.Drawing.Size(121, 21);
            this.cboABPLCMapType.TabIndex = 18;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(6, 202);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(129, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "AB PLC Map Type";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(6, 175);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(129, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "AB PLC Modify Mode";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboABPLCMod
            // 
            this.cboABPLCMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboABPLCMod.FormattingEnabled = true;
            this.cboABPLCMod.Items.AddRange(new object[] {
            "Direct",
            "Nudge"});
            this.cboABPLCMod.Location = new System.Drawing.Point(149, 174);
            this.cboABPLCMod.Name = "cboABPLCMod";
            this.cboABPLCMod.Size = new System.Drawing.Size(121, 21);
            this.cboABPLCMod.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(6, 148);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "AB PLC Filename";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtABPLCFilename
            // 
            this.txtABPLCFilename.Location = new System.Drawing.Point(149, 146);
            this.txtABPLCFilename.Name = "txtABPLCFilename";
            this.txtABPLCFilename.Size = new System.Drawing.Size(100, 20);
            this.txtABPLCFilename.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(6, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "App Server node index";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtABPLCASNode
            // 
            this.txtABPLCASNode.Location = new System.Drawing.Point(149, 118);
            this.txtABPLCASNode.Name = "txtABPLCASNode";
            this.txtABPLCASNode.Size = new System.Drawing.Size(100, 20);
            this.txtABPLCASNode.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(6, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "AB PLC node index";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(6, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "AB PLC Baud Rate";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboDH_Baud
            // 
            this.cboDH_Baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDH_Baud.FormattingEnabled = true;
            this.cboDH_Baud.Items.AddRange(new object[] {
            "57600",
            "115200",
            "230400"});
            this.cboDH_Baud.Location = new System.Drawing.Point(149, 61);
            this.cboDH_Baud.Name = "cboDH_Baud";
            this.cboDH_Baud.Size = new System.Drawing.Size(121, 21);
            this.cboDH_Baud.TabIndex = 13;
            // 
            // cboABType
            // 
            this.cboABType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboABType.FormattingEnabled = true;
            this.cboABType.Items.AddRange(new object[] {
            "None",
            "PLC/3",
            "PLC/5",
            "SLC/504",
            "ControlLogix"});
            this.cboABType.Location = new System.Drawing.Point(149, 32);
            this.cboABType.Name = "cboABType";
            this.cboABType.Size = new System.Drawing.Size(121, 21);
            this.cboABType.TabIndex = 12;
            // 
            // txtABPLCNode
            // 
            this.txtABPLCNode.Location = new System.Drawing.Point(149, 90);
            this.txtABPLCNode.MaxLength = 5;
            this.txtABPLCNode.Name = "txtABPLCNode";
            this.txtABPLCNode.Size = new System.Drawing.Size(100, 20);
            this.txtABPLCNode.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(6, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "AB PLC Type";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PLCwater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(673, 478);
            this.ControlBox = false;
            this.Controls.Add(this.gpABPLCSettings);
            this.Controls.Add(this.pnlWizardTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gpPLCSettings);
            this.Controls.Add(this.checkEnabled);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PLCwater";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.PLCwater_Load);
            this.gpPLCSettings.ResumeLayout(false);
            this.gpPLCSettings.PerformLayout();
            this.pnlWizardTitle.ResumeLayout(false);
            this.pnlWizardTitle.PerformLayout();
            this.gpABPLCSettings.ResumeLayout(false);
            this.gpABPLCSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkEnabled;
        private System.Windows.Forms.GroupBox gpPLCSettings;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTachPulses;
        private System.Windows.Forms.TextBox txtMechDelay;
        private System.Windows.Forms.TextBox txtWashCycle;
        private System.Windows.Forms.ComboBox cboCommPorts;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlWizardTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboPLCList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWaterStartSpeedMax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtWaterStartSpeedMin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtWaterOutputMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWaterDivisor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSweepDivisor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSampleTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWaterStartupVolt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gpABPLCSettings;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cboABPLCMod;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtABPLCFilename;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtABPLCASNode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboDH_Baud;
        private System.Windows.Forms.ComboBox cboABType;
        private System.Windows.Forms.TextBox txtABPLCNode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboABPLCMapType;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cboABPOLLType;
        private System.Windows.Forms.TextBox txtABPOLLRATE;
        private System.Windows.Forms.Label label22;
    }
}