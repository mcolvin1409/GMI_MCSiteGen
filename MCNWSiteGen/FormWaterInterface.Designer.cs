namespace MCNWSiteGen
{
    partial class FormWaterInterface
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfigure = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.radioParlMotor = new System.Windows.Forms.RadioButton();
            this.radioGOSS = new System.Windows.Forms.RadioButton();
            this.pnlWizardTitle = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.radioPCU = new System.Windows.Forms.RadioButton();
            this.radioPLC = new System.Windows.Forms.RadioButton();
            this.radioBothServoMotor = new System.Windows.Forms.RadioButton();
            this.radioServoWater = new System.Windows.Forms.RadioButton();
            this.radioMotorWater = new System.Windows.Forms.RadioButton();
            this.buttonClear = new System.Windows.Forms.Button();
            this.ConfigureWaterControl = new System.Windows.Forms.CheckBox();
            this.m_plcTypeComboBox = new System.Windows.Forms.ComboBox();
            this.pnlWizardTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(140, 389);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 51);
            this.btnCancel.TabIndex = 82;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfigure
            // 
            this.btnConfigure.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfigure.Location = new System.Drawing.Point(59, 345);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(75, 23);
            this.btnConfigure.TabIndex = 81;
            this.btnConfigure.Text = "Configure";
            this.btnConfigure.UseVisualStyleBackColor = true;
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.btnOK.Location = new System.Drawing.Point(61, 389);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 51);
            this.btnOK.TabIndex = 80;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // radioParlMotor
            // 
            this.radioParlMotor.AutoSize = true;
            this.radioParlMotor.Enabled = false;
            this.radioParlMotor.ForeColor = System.Drawing.Color.Transparent;
            this.radioParlMotor.Location = new System.Drawing.Point(86, 305);
            this.radioParlMotor.Name = "radioParlMotor";
            this.radioParlMotor.Size = new System.Drawing.Size(78, 17);
            this.radioParlMotor.TabIndex = 79;
            this.radioParlMotor.TabStop = true;
            this.radioParlMotor.Text = "Parl. Water";
            this.radioParlMotor.UseVisualStyleBackColor = true;
            this.radioParlMotor.CheckedChanged += new System.EventHandler(this.Water_ConfigChanged);
            // 
            // radioGOSS
            // 
            this.radioGOSS.AutoSize = true;
            this.radioGOSS.Enabled = false;
            this.radioGOSS.ForeColor = System.Drawing.Color.Transparent;
            this.radioGOSS.Location = new System.Drawing.Point(85, 268);
            this.radioGOSS.Name = "radioGOSS";
            this.radioGOSS.Size = new System.Drawing.Size(87, 17);
            this.radioGOSS.TabIndex = 78;
            this.radioGOSS.TabStop = true;
            this.radioGOSS.Text = "GOSS Water";
            this.radioGOSS.UseVisualStyleBackColor = true;
            this.radioGOSS.CheckedChanged += new System.EventHandler(this.Water_ConfigChanged);
            // 
            // pnlWizardTitle
            // 
            this.pnlWizardTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlWizardTitle.Controls.Add(this.label5);
            this.pnlWizardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWizardTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlWizardTitle.Name = "pnlWizardTitle";
            this.pnlWizardTitle.Size = new System.Drawing.Size(299, 31);
            this.pnlWizardTitle.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(71, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Water Interface";
            // 
            // radioPCU
            // 
            this.radioPCU.AutoSize = true;
            this.radioPCU.Enabled = false;
            this.radioPCU.ForeColor = System.Drawing.Color.Transparent;
            this.radioPCU.Location = new System.Drawing.Point(85, 231);
            this.radioPCU.Name = "radioPCU";
            this.radioPCU.Size = new System.Drawing.Size(79, 17);
            this.radioPCU.TabIndex = 77;
            this.radioPCU.TabStop = true;
            this.radioPCU.Text = "PCU Water";
            this.radioPCU.UseVisualStyleBackColor = true;
            this.radioPCU.CheckedChanged += new System.EventHandler(this.Water_ConfigChanged);
            // 
            // radioPLC
            // 
            this.radioPLC.AutoSize = true;
            this.radioPLC.ForeColor = System.Drawing.Color.Transparent;
            this.radioPLC.Location = new System.Drawing.Point(85, 192);
            this.radioPLC.Name = "radioPLC";
            this.radioPLC.Size = new System.Drawing.Size(77, 17);
            this.radioPLC.TabIndex = 76;
            this.radioPLC.TabStop = true;
            this.radioPLC.Text = "PLC Water";
            this.radioPLC.UseVisualStyleBackColor = true;
            this.radioPLC.CheckedChanged += new System.EventHandler(this.Water_ConfigChanged);
            // 
            // radioBothServoMotor
            // 
            this.radioBothServoMotor.AutoSize = true;
            this.radioBothServoMotor.ForeColor = System.Drawing.Color.Transparent;
            this.radioBothServoMotor.Location = new System.Drawing.Point(85, 153);
            this.radioBothServoMotor.Name = "radioBothServoMotor";
            this.radioBothServoMotor.Size = new System.Drawing.Size(117, 17);
            this.radioBothServoMotor.TabIndex = 75;
            this.radioBothServoMotor.TabStop = true;
            this.radioBothServoMotor.Text = "Both Configurations";
            this.radioBothServoMotor.UseVisualStyleBackColor = true;
            this.radioBothServoMotor.CheckedChanged += new System.EventHandler(this.Water_ConfigChanged);
            // 
            // radioServoWater
            // 
            this.radioServoWater.AutoSize = true;
            this.radioServoWater.ForeColor = System.Drawing.Color.Transparent;
            this.radioServoWater.Location = new System.Drawing.Point(85, 120);
            this.radioServoWater.Name = "radioServoWater";
            this.radioServoWater.Size = new System.Drawing.Size(85, 17);
            this.radioServoWater.TabIndex = 74;
            this.radioServoWater.TabStop = true;
            this.radioServoWater.Text = "Servo Water";
            this.radioServoWater.UseVisualStyleBackColor = true;
            this.radioServoWater.CheckedChanged += new System.EventHandler(this.Water_ConfigChanged);
            // 
            // radioMotorWater
            // 
            this.radioMotorWater.AutoSize = true;
            this.radioMotorWater.ForeColor = System.Drawing.Color.Transparent;
            this.radioMotorWater.Location = new System.Drawing.Point(85, 86);
            this.radioMotorWater.Name = "radioMotorWater";
            this.radioMotorWater.Size = new System.Drawing.Size(84, 17);
            this.radioMotorWater.TabIndex = 73;
            this.radioMotorWater.TabStop = true;
            this.radioMotorWater.Text = "Motor Water";
            this.radioMotorWater.UseVisualStyleBackColor = true;
            this.radioMotorWater.CheckedChanged += new System.EventHandler(this.Water_ConfigChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Enabled = false;
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonClear.Location = new System.Drawing.Point(140, 345);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 84;
            this.buttonClear.Text = "Change";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // ConfigureWaterControl
            // 
            this.ConfigureWaterControl.AutoSize = true;
            this.ConfigureWaterControl.Location = new System.Drawing.Point(57, 54);
            this.ConfigureWaterControl.Name = "ConfigureWaterControl";
            this.ConfigureWaterControl.Size = new System.Drawing.Size(139, 17);
            this.ConfigureWaterControl.TabIndex = 86;
            this.ConfigureWaterControl.Text = "Configure Water Control";
            this.ConfigureWaterControl.UseVisualStyleBackColor = true;
            this.ConfigureWaterControl.CheckedChanged += new System.EventHandler(this.Water_ConfigChanged);
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
            "AVT PLC"});
            this.m_plcTypeComboBox.Location = new System.Drawing.Point(168, 188);
            this.m_plcTypeComboBox.Name = "m_plcTypeComboBox";
            this.m_plcTypeComboBox.Size = new System.Drawing.Size(119, 21);
            this.m_plcTypeComboBox.TabIndex = 90;
            this.m_plcTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.OnPLCTypeComboBox_SelectedIndexChanged);
            // 
            // FormWaterInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(299, 462);
            this.ControlBox = false;
            this.Controls.Add(this.m_plcTypeComboBox);
            this.Controls.Add(this.ConfigureWaterControl);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfigure);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.radioParlMotor);
            this.Controls.Add(this.radioGOSS);
            this.Controls.Add(this.pnlWizardTitle);
            this.Controls.Add(this.radioPCU);
            this.Controls.Add(this.radioPLC);
            this.Controls.Add(this.radioBothServoMotor);
            this.Controls.Add(this.radioServoWater);
            this.Controls.Add(this.radioMotorWater);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWaterInterface";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormWaterInterface_Load);
            this.pnlWizardTitle.ResumeLayout(false);
            this.pnlWizardTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfigure;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton radioParlMotor;
        private System.Windows.Forms.RadioButton radioGOSS;
        private System.Windows.Forms.Panel pnlWizardTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioPCU;
        private System.Windows.Forms.RadioButton radioPLC;
        private System.Windows.Forms.RadioButton radioBothServoMotor;
        private System.Windows.Forms.RadioButton radioServoWater;
        private System.Windows.Forms.RadioButton radioMotorWater;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.CheckBox ConfigureWaterControl;
        private System.Windows.Forms.ComboBox m_plcTypeComboBox;

    }
}