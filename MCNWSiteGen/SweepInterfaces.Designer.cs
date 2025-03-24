namespace MCNWSiteGen
{
    partial class SweepInterfaces
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
            this.radioSWEEPMTR = new System.Windows.Forms.RadioButton();
            this.radioServoSweeps = new System.Windows.Forms.RadioButton();
            this.radioBoth = new System.Windows.Forms.RadioButton();
            this.radioPLC = new System.Windows.Forms.RadioButton();
            this.radioPCU = new System.Windows.Forms.RadioButton();
            this.radioGOSS = new System.Windows.Forms.RadioButton();
            this.radioParlMotor = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnConfigure = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlWizardTitle = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.ConfigureSweepControl = new System.Windows.Forms.CheckBox();
            this.m_plcTypeComboBox = new System.Windows.Forms.ComboBox();
            this.pnlWizardTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioSWEEPMTR
            // 
            this.radioSWEEPMTR.AutoSize = true;
            this.radioSWEEPMTR.ForeColor = System.Drawing.Color.Transparent;
            this.radioSWEEPMTR.Location = new System.Drawing.Point(85, 81);
            this.radioSWEEPMTR.Name = "radioSWEEPMTR";
            this.radioSWEEPMTR.Size = new System.Drawing.Size(88, 17);
            this.radioSWEEPMTR.TabIndex = 0;
            this.radioSWEEPMTR.TabStop = true;
            this.radioSWEEPMTR.Text = "Motor Sweep";
            this.radioSWEEPMTR.UseVisualStyleBackColor = true;
            this.radioSWEEPMTR.CheckedChanged += new System.EventHandler(this.Sweep_ConfigChanged);
            // 
            // radioServoSweeps
            // 
            this.radioServoSweeps.AutoSize = true;
            this.radioServoSweeps.ForeColor = System.Drawing.Color.Transparent;
            this.radioServoSweeps.Location = new System.Drawing.Point(85, 115);
            this.radioServoSweeps.Name = "radioServoSweeps";
            this.radioServoSweeps.Size = new System.Drawing.Size(94, 17);
            this.radioServoSweeps.TabIndex = 1;
            this.radioServoSweeps.TabStop = true;
            this.radioServoSweeps.Text = "Servo Sweeps";
            this.radioServoSweeps.UseVisualStyleBackColor = true;
            this.radioServoSweeps.CheckedChanged += new System.EventHandler(this.Sweep_ConfigChanged);
            // 
            // radioBoth
            // 
            this.radioBoth.AutoSize = true;
            this.radioBoth.ForeColor = System.Drawing.Color.Transparent;
            this.radioBoth.Location = new System.Drawing.Point(85, 149);
            this.radioBoth.Name = "radioBoth";
            this.radioBoth.Size = new System.Drawing.Size(117, 17);
            this.radioBoth.TabIndex = 2;
            this.radioBoth.TabStop = true;
            this.radioBoth.Text = "Both Configurations";
            this.radioBoth.UseVisualStyleBackColor = true;
            this.radioBoth.CheckedChanged += new System.EventHandler(this.Sweep_ConfigChanged);
            // 
            // radioPLC
            // 
            this.radioPLC.AutoSize = true;
            this.radioPLC.ForeColor = System.Drawing.Color.Transparent;
            this.radioPLC.Location = new System.Drawing.Point(85, 187);
            this.radioPLC.Name = "radioPLC";
            this.radioPLC.Size = new System.Drawing.Size(81, 17);
            this.radioPLC.TabIndex = 3;
            this.radioPLC.TabStop = true;
            this.radioPLC.Text = "PLC Sweep";
            this.radioPLC.UseVisualStyleBackColor = true;
            this.radioPLC.CheckedChanged += new System.EventHandler(this.Sweep_ConfigChanged);
            // 
            // radioPCU
            // 
            this.radioPCU.AutoSize = true;
            this.radioPCU.ForeColor = System.Drawing.Color.Transparent;
            this.radioPCU.Location = new System.Drawing.Point(85, 226);
            this.radioPCU.Name = "radioPCU";
            this.radioPCU.Size = new System.Drawing.Size(83, 17);
            this.radioPCU.TabIndex = 4;
            this.radioPCU.TabStop = true;
            this.radioPCU.Text = "PCU Sweep";
            this.radioPCU.UseVisualStyleBackColor = true;
            this.radioPCU.CheckedChanged += new System.EventHandler(this.Sweep_ConfigChanged);
            // 
            // radioGOSS
            // 
            this.radioGOSS.AutoSize = true;
            this.radioGOSS.Enabled = false;
            this.radioGOSS.ForeColor = System.Drawing.Color.Transparent;
            this.radioGOSS.Location = new System.Drawing.Point(85, 263);
            this.radioGOSS.Name = "radioGOSS";
            this.radioGOSS.Size = new System.Drawing.Size(91, 17);
            this.radioGOSS.TabIndex = 5;
            this.radioGOSS.TabStop = true;
            this.radioGOSS.Text = "GOSS Sweep";
            this.radioGOSS.UseVisualStyleBackColor = true;
            this.radioGOSS.CheckedChanged += new System.EventHandler(this.Sweep_ConfigChanged);
            // 
            // radioParlMotor
            // 
            this.radioParlMotor.AutoSize = true;
            this.radioParlMotor.Enabled = false;
            this.radioParlMotor.ForeColor = System.Drawing.Color.Transparent;
            this.radioParlMotor.Location = new System.Drawing.Point(84, 300);
            this.radioParlMotor.Name = "radioParlMotor";
            this.radioParlMotor.Size = new System.Drawing.Size(76, 17);
            this.radioParlMotor.TabIndex = 6;
            this.radioParlMotor.TabStop = true;
            this.radioParlMotor.Text = "Parl. Motor";
            this.radioParlMotor.UseVisualStyleBackColor = true;
            this.radioParlMotor.CheckedChanged += new System.EventHandler(this.Sweep_ConfigChanged);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.btnOK.Location = new System.Drawing.Point(61, 391);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 51);
            this.btnOK.TabIndex = 7;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnConfigure
            // 
            this.btnConfigure.Location = new System.Drawing.Point(56, 349);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(75, 23);
            this.btnConfigure.TabIndex = 8;
            this.btnConfigure.Text = "Configure";
            this.btnConfigure.UseVisualStyleBackColor = true;
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(140, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 51);
            this.btnCancel.TabIndex = 19;
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
            this.pnlWizardTitle.Size = new System.Drawing.Size(300, 31);
            this.pnlWizardTitle.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(71, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sweep Interface";
            // 
            // buttonClear
            // 
            this.buttonClear.Enabled = false;
            this.buttonClear.Location = new System.Drawing.Point(137, 349);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 73;
            this.buttonClear.Text = "Change";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // ConfigureSweepControl
            // 
            this.ConfigureSweepControl.AutoSize = true;
            this.ConfigureSweepControl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ConfigureSweepControl.Location = new System.Drawing.Point(40, 48);
            this.ConfigureSweepControl.Name = "ConfigureSweepControl";
            this.ConfigureSweepControl.Size = new System.Drawing.Size(143, 17);
            this.ConfigureSweepControl.TabIndex = 87;
            this.ConfigureSweepControl.Text = "Configure Sweep Control";
            this.ConfigureSweepControl.UseVisualStyleBackColor = true;
            this.ConfigureSweepControl.CheckedChanged += new System.EventHandler(this.Sweep_ConfigChanged);
            // 
            // m_plcTypeComboBox
            // 
            this.m_plcTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_plcTypeComboBox.FormattingEnabled = true;
            this.m_plcTypeComboBox.Items.AddRange(new object[] {
            "Nilpeter",
            "Crabtree",
            "Digital to Analog",
            "Ragsdale",
            "Allen Bradley",
            "HO + Motor",
            "HO + D to A",
            "Texas Instruments",
            "AVT PLC"});
            this.m_plcTypeComboBox.Location = new System.Drawing.Point(168, 186);
            this.m_plcTypeComboBox.Name = "m_plcTypeComboBox";
            this.m_plcTypeComboBox.Size = new System.Drawing.Size(117, 21);
            this.m_plcTypeComboBox.TabIndex = 88;
            this.m_plcTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.OnPLCTypeComboBox_SelectedIndexChanged);
            // 
            // SweepInterfaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(300, 461);
            this.ControlBox = false;
            this.Controls.Add(this.m_plcTypeComboBox);
            this.Controls.Add(this.ConfigureSweepControl);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.pnlWizardTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfigure);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.radioParlMotor);
            this.Controls.Add(this.radioGOSS);
            this.Controls.Add(this.radioPCU);
            this.Controls.Add(this.radioPLC);
            this.Controls.Add(this.radioBoth);
            this.Controls.Add(this.radioServoSweeps);
            this.Controls.Add(this.radioSWEEPMTR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SweepInterfaces";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.SweepInterface_Load);
            this.pnlWizardTitle.ResumeLayout(false);
            this.pnlWizardTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioSWEEPMTR;
        private System.Windows.Forms.RadioButton radioServoSweeps;
        private System.Windows.Forms.RadioButton radioBoth;
        private System.Windows.Forms.RadioButton radioPLC;
        private System.Windows.Forms.RadioButton radioPCU;
        private System.Windows.Forms.RadioButton radioGOSS;
        private System.Windows.Forms.RadioButton radioParlMotor;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnConfigure;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlWizardTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.CheckBox ConfigureSweepControl;
        private System.Windows.Forms.ComboBox m_plcTypeComboBox;
    }
}