namespace MCNWSiteGen
{
    partial class MercuryAVTPLCInkerOptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.m_dlgTitle = new System.Windows.Forms.Label();
            this.m_titlePanel = new System.Windows.Forms.Panel();
            this.m_formTitle = new System.Windows.Forms.Label();
            this.m_optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.m_adjustOptionLabel = new System.Windows.Forms.Label();
            this.m_enableDigitalControlCancelCheckBox = new System.Windows.Forms.CheckBox();
            this.m_hardwareInterfaceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.m_rampCurveParamsGroupBox = new System.Windows.Forms.GroupBox();
            this.m_motorClampMaxTextBox = new System.Windows.Forms.TextBox();
            this.m_motorClampMinTextBox = new System.Windows.Forms.TextBox();
            this.m_motorClampMaxUnits = new System.Windows.Forms.Label();
            this.m_motorClampMinUnits = new System.Windows.Forms.Label();
            this.m_motorClampMaxLabel = new System.Windows.Forms.Label();
            this.m_motorClampMinLabel = new System.Windows.Forms.Label();
            this.m_baseCurveMaxTextBox = new System.Windows.Forms.TextBox();
            this.m_speedInfluenceTextBox = new System.Windows.Forms.TextBox();
            this.m_baseCurveMaxUnits = new System.Windows.Forms.Label();
            this.m_inkerSpeedInfluenceUnits = new System.Windows.Forms.Label();
            this.m_baseCurveMaxLabel = new System.Windows.Forms.Label();
            this.m_speedInfluenceLabel = new System.Windows.Forms.Label();
            this.m_titlePanel.SuspendLayout();
            this.m_optionsGroupBox.SuspendLayout();
            this.m_rampCurveParamsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.btnOK.Location = new System.Drawing.Point(323, 282);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 53);
            this.btnOK.TabIndex = 6;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(429, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 53);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // m_dlgTitle
            // 
            this.m_dlgTitle.AutoSize = true;
            this.m_dlgTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.m_dlgTitle.Location = new System.Drawing.Point(280, 6);
            this.m_dlgTitle.Name = "m_dlgTitle";
            this.m_dlgTitle.Size = new System.Drawing.Size(281, 20);
            this.m_dlgTitle.TabIndex = 0;
            this.m_dlgTitle.Text = "Voltages - AVT PLC Configuration";
            this.m_dlgTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // m_titlePanel
            // 
            this.m_titlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.m_titlePanel.Controls.Add(this.m_formTitle);
            this.m_titlePanel.Location = new System.Drawing.Point(0, 0);
            this.m_titlePanel.Name = "m_titlePanel";
            this.m_titlePanel.Size = new System.Drawing.Size(495, 34);
            this.m_titlePanel.TabIndex = 94;
            // 
            // m_formTitle
            // 
            this.m_formTitle.AutoSize = true;
            this.m_formTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.m_formTitle.Location = new System.Drawing.Point(182, 6);
            this.m_formTitle.Name = "m_formTitle";
            this.m_formTitle.Size = new System.Drawing.Size(117, 20);
            this.m_formTitle.TabIndex = 0;
            this.m_formTitle.Text = "Inker Options";
            this.m_formTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // m_optionsGroupBox
            // 
            this.m_optionsGroupBox.Controls.Add(this.m_adjustOptionLabel);
            this.m_optionsGroupBox.Controls.Add(this.m_enableDigitalControlCancelCheckBox);
            this.m_optionsGroupBox.Controls.Add(this.m_hardwareInterfaceTypeComboBox);
            this.m_optionsGroupBox.ForeColor = System.Drawing.Color.White;
            this.m_optionsGroupBox.Location = new System.Drawing.Point(4, 35);
            this.m_optionsGroupBox.Name = "m_optionsGroupBox";
            this.m_optionsGroupBox.Size = new System.Drawing.Size(487, 93);
            this.m_optionsGroupBox.TabIndex = 95;
            this.m_optionsGroupBox.TabStop = false;
            this.m_optionsGroupBox.Text = "Adjustment Options";
            // 
            // m_adjustOptionLabel
            // 
            this.m_adjustOptionLabel.AutoSize = true;
            this.m_adjustOptionLabel.Location = new System.Drawing.Point(16, 22);
            this.m_adjustOptionLabel.Name = "m_adjustOptionLabel";
            this.m_adjustOptionLabel.Size = new System.Drawing.Size(128, 13);
            this.m_adjustOptionLabel.TabIndex = 2;
            this.m_adjustOptionLabel.Text = "Hardware Interface Type:";
            // 
            // m_enableDigitalControlCancelCheckBox
            // 
            this.m_enableDigitalControlCancelCheckBox.AutoSize = true;
            this.m_enableDigitalControlCancelCheckBox.Location = new System.Drawing.Point(198, 59);
            this.m_enableDigitalControlCancelCheckBox.Name = "m_enableDigitalControlCancelCheckBox";
            this.m_enableDigitalControlCancelCheckBox.Size = new System.Drawing.Size(207, 17);
            this.m_enableDigitalControlCancelCheckBox.TabIndex = 1;
            this.m_enableDigitalControlCancelCheckBox.Text = "Enable Digital Control Cancel on Client";
            this.m_enableDigitalControlCancelCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_hardwareInterfaceTypeComboBox
            // 
            this.m_hardwareInterfaceTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_hardwareInterfaceTypeComboBox.FormattingEnabled = true;
            this.m_hardwareInterfaceTypeComboBox.Items.AddRange(new object[] {
            "Digital controls only (up/down)",
            "Digital controls (up/down) with pot feedback",
            "Analog output (0 to 10 VDC)"});
            this.m_hardwareInterfaceTypeComboBox.Location = new System.Drawing.Point(197, 19);
            this.m_hardwareInterfaceTypeComboBox.Name = "m_hardwareInterfaceTypeComboBox";
            this.m_hardwareInterfaceTypeComboBox.Size = new System.Drawing.Size(282, 21);
            this.m_hardwareInterfaceTypeComboBox.TabIndex = 0;
            this.m_hardwareInterfaceTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.OnHardwareInterfaceTypeComboBox_SelectedIndexChanged);
            // 
            // m_rampCurveParamsGroupBox
            // 
            this.m_rampCurveParamsGroupBox.Controls.Add(this.m_motorClampMaxTextBox);
            this.m_rampCurveParamsGroupBox.Controls.Add(this.m_motorClampMinTextBox);
            this.m_rampCurveParamsGroupBox.Controls.Add(this.m_motorClampMaxUnits);
            this.m_rampCurveParamsGroupBox.Controls.Add(this.m_motorClampMinUnits);
            this.m_rampCurveParamsGroupBox.Controls.Add(this.m_motorClampMaxLabel);
            this.m_rampCurveParamsGroupBox.Controls.Add(this.m_motorClampMinLabel);
            this.m_rampCurveParamsGroupBox.Controls.Add(this.m_baseCurveMaxTextBox);
            this.m_rampCurveParamsGroupBox.Controls.Add(this.m_speedInfluenceTextBox);
            this.m_rampCurveParamsGroupBox.Controls.Add(this.m_baseCurveMaxUnits);
            this.m_rampCurveParamsGroupBox.Controls.Add(this.m_inkerSpeedInfluenceUnits);
            this.m_rampCurveParamsGroupBox.Controls.Add(this.m_baseCurveMaxLabel);
            this.m_rampCurveParamsGroupBox.Controls.Add(this.m_speedInfluenceLabel);
            this.m_rampCurveParamsGroupBox.ForeColor = System.Drawing.Color.White;
            this.m_rampCurveParamsGroupBox.Location = new System.Drawing.Point(4, 134);
            this.m_rampCurveParamsGroupBox.Name = "m_rampCurveParamsGroupBox";
            this.m_rampCurveParamsGroupBox.Size = new System.Drawing.Size(487, 139);
            this.m_rampCurveParamsGroupBox.TabIndex = 96;
            this.m_rampCurveParamsGroupBox.TabStop = false;
            this.m_rampCurveParamsGroupBox.Text = "Ramp Curve Parameters";
            // 
            // m_motorClampMaxTextBox
            // 
            this.m_motorClampMaxTextBox.Location = new System.Drawing.Point(364, 86);
            this.m_motorClampMaxTextBox.MaxLength = 3;
            this.m_motorClampMaxTextBox.Name = "m_motorClampMaxTextBox";
            this.m_motorClampMaxTextBox.Size = new System.Drawing.Size(107, 20);
            this.m_motorClampMaxTextBox.TabIndex = 5;
            this.m_motorClampMaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_motorClampMaxTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnMotorClampMaxTextBox_Validating);
            // 
            // m_motorClampMinTextBox
            // 
            this.m_motorClampMinTextBox.Location = new System.Drawing.Point(364, 33);
            this.m_motorClampMinTextBox.MaxLength = 3;
            this.m_motorClampMinTextBox.Name = "m_motorClampMinTextBox";
            this.m_motorClampMinTextBox.Size = new System.Drawing.Size(107, 20);
            this.m_motorClampMinTextBox.TabIndex = 4;
            this.m_motorClampMinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_motorClampMinTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnMotorClampMinTextBox_Validating);
            // 
            // m_motorClampMaxUnits
            // 
            this.m_motorClampMaxUnits.AutoSize = true;
            this.m_motorClampMaxUnits.Location = new System.Drawing.Point(270, 102);
            this.m_motorClampMaxUnits.Name = "m_motorClampMaxUnits";
            this.m_motorClampMaxUnits.Size = new System.Drawing.Size(60, 13);
            this.m_motorClampMaxUnits.TabIndex = 104;
            this.m_motorClampMaxUnits.Text = "( 0 - 100% )";
            // 
            // m_motorClampMinUnits
            // 
            this.m_motorClampMinUnits.AutoSize = true;
            this.m_motorClampMinUnits.Location = new System.Drawing.Point(270, 47);
            this.m_motorClampMinUnits.Name = "m_motorClampMinUnits";
            this.m_motorClampMinUnits.Size = new System.Drawing.Size(60, 13);
            this.m_motorClampMinUnits.TabIndex = 103;
            this.m_motorClampMinUnits.Text = "( 0 - 100% )";
            // 
            // m_motorClampMaxLabel
            // 
            this.m_motorClampMaxLabel.AutoSize = true;
            this.m_motorClampMaxLabel.Location = new System.Drawing.Point(256, 83);
            this.m_motorClampMaxLabel.Name = "m_motorClampMaxLabel";
            this.m_motorClampMaxLabel.Size = new System.Drawing.Size(92, 13);
            this.m_motorClampMaxLabel.TabIndex = 102;
            this.m_motorClampMaxLabel.Text = "Motor Clamp Max:";
            // 
            // m_motorClampMinLabel
            // 
            this.m_motorClampMinLabel.AutoSize = true;
            this.m_motorClampMinLabel.Location = new System.Drawing.Point(256, 30);
            this.m_motorClampMinLabel.Name = "m_motorClampMinLabel";
            this.m_motorClampMinLabel.Size = new System.Drawing.Size(89, 13);
            this.m_motorClampMinLabel.TabIndex = 101;
            this.m_motorClampMinLabel.Text = "Motor Clamp Min:";
            // 
            // m_baseCurveMaxTextBox
            // 
            this.m_baseCurveMaxTextBox.Location = new System.Drawing.Point(121, 86);
            this.m_baseCurveMaxTextBox.MaxLength = 3;
            this.m_baseCurveMaxTextBox.Name = "m_baseCurveMaxTextBox";
            this.m_baseCurveMaxTextBox.Size = new System.Drawing.Size(107, 20);
            this.m_baseCurveMaxTextBox.TabIndex = 3;
            this.m_baseCurveMaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_baseCurveMaxTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnBaseCurveMaxTextBox_Validating);
            // 
            // m_speedInfluenceTextBox
            // 
            this.m_speedInfluenceTextBox.Location = new System.Drawing.Point(121, 33);
            this.m_speedInfluenceTextBox.MaxLength = 3;
            this.m_speedInfluenceTextBox.Name = "m_speedInfluenceTextBox";
            this.m_speedInfluenceTextBox.Size = new System.Drawing.Size(107, 20);
            this.m_speedInfluenceTextBox.TabIndex = 2;
            this.m_speedInfluenceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_speedInfluenceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnSpeedInfluenceTextBox_Validating);
            // 
            // m_baseCurveMaxUnits
            // 
            this.m_baseCurveMaxUnits.AutoSize = true;
            this.m_baseCurveMaxUnits.Location = new System.Drawing.Point(27, 102);
            this.m_baseCurveMaxUnits.Name = "m_baseCurveMaxUnits";
            this.m_baseCurveMaxUnits.Size = new System.Drawing.Size(60, 13);
            this.m_baseCurveMaxUnits.TabIndex = 98;
            this.m_baseCurveMaxUnits.Text = "( 0 - 100% )";
            // 
            // m_inkerSpeedInfluenceUnits
            // 
            this.m_inkerSpeedInfluenceUnits.AutoSize = true;
            this.m_inkerSpeedInfluenceUnits.Location = new System.Drawing.Point(27, 47);
            this.m_inkerSpeedInfluenceUnits.Name = "m_inkerSpeedInfluenceUnits";
            this.m_inkerSpeedInfluenceUnits.Size = new System.Drawing.Size(60, 13);
            this.m_inkerSpeedInfluenceUnits.TabIndex = 97;
            this.m_inkerSpeedInfluenceUnits.Text = "( 0 - 100% )";
            // 
            // m_baseCurveMaxLabel
            // 
            this.m_baseCurveMaxLabel.AutoSize = true;
            this.m_baseCurveMaxLabel.Location = new System.Drawing.Point(13, 83);
            this.m_baseCurveMaxLabel.Name = "m_baseCurveMaxLabel";
            this.m_baseCurveMaxLabel.Size = new System.Drawing.Size(88, 13);
            this.m_baseCurveMaxLabel.TabIndex = 1;
            this.m_baseCurveMaxLabel.Text = "Base Curve Max:";
            // 
            // m_speedInfluenceLabel
            // 
            this.m_speedInfluenceLabel.AutoSize = true;
            this.m_speedInfluenceLabel.Location = new System.Drawing.Point(13, 30);
            this.m_speedInfluenceLabel.Name = "m_speedInfluenceLabel";
            this.m_speedInfluenceLabel.Size = new System.Drawing.Size(88, 13);
            this.m_speedInfluenceLabel.TabIndex = 0;
            this.m_speedInfluenceLabel.Text = "Speed Influence:";
            // 
            // MercuryAVTPLCInkerOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(495, 347);
            this.ControlBox = false;
            this.Controls.Add(this.m_rampCurveParamsGroupBox);
            this.Controls.Add(this.m_optionsGroupBox);
            this.Controls.Add(this.m_titlePanel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MercuryAVTPLCInkerOptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.MercuryAVTPLCInkerOptionsForm_Load);
            this.m_titlePanel.ResumeLayout(false);
            this.m_titlePanel.PerformLayout();
            this.m_optionsGroupBox.ResumeLayout(false);
            this.m_optionsGroupBox.PerformLayout();
            this.m_rampCurveParamsGroupBox.ResumeLayout(false);
            this.m_rampCurveParamsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;        
        private System.Windows.Forms.Label m_dlgTitle;
        private System.Windows.Forms.Panel m_titlePanel;
        private System.Windows.Forms.Label m_formTitle;
        private System.Windows.Forms.GroupBox m_optionsGroupBox;
        private System.Windows.Forms.Label m_adjustOptionLabel;
        private System.Windows.Forms.CheckBox m_enableDigitalControlCancelCheckBox;
        private System.Windows.Forms.ComboBox m_hardwareInterfaceTypeComboBox;
        private System.Windows.Forms.GroupBox m_rampCurveParamsGroupBox;
        private System.Windows.Forms.Label m_baseCurveMaxLabel;
        private System.Windows.Forms.Label m_speedInfluenceLabel;
        private System.Windows.Forms.Label m_baseCurveMaxUnits;
        private System.Windows.Forms.Label m_inkerSpeedInfluenceUnits;
        private System.Windows.Forms.TextBox m_motorClampMaxTextBox;
        private System.Windows.Forms.TextBox m_motorClampMinTextBox;
        private System.Windows.Forms.Label m_motorClampMaxUnits;
        private System.Windows.Forms.Label m_motorClampMinUnits;
        private System.Windows.Forms.Label m_motorClampMaxLabel;
        private System.Windows.Forms.Label m_motorClampMinLabel;
        private System.Windows.Forms.TextBox m_baseCurveMaxTextBox;
        private System.Windows.Forms.TextBox m_speedInfluenceTextBox;
    }
}