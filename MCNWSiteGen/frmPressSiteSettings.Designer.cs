namespace MCNWSiteGen
{
    partial class frmPressSiteSettings
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
            this.txtBackOffInPulses = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtServoPulsesAtZoneZero = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDefaultOffset = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkMeterRoller = new System.Windows.Forms.CheckBox();
            this.chkBladeComp = new System.Windows.Forms.CheckBox();
            this.chkNONFS = new System.Windows.Forms.CheckBox();
            this.chkType2 = new System.Windows.Forms.CheckBox();
            this.chkType1 = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtMaxNeighborKeyDelta = new System.Windows.Forms.TextBox();
            this.txtBladeStiffness = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlWizardTitle = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.checkAutoZero = new System.Windows.Forms.CheckBox();
            this.NonLinearGroupBox = new System.Windows.Forms.GroupBox();
            this.pnlWizardTitle.SuspendLayout();
            this.NonLinearGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(184, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 51);
            this.btnCancel.TabIndex = 68;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBackOffInPulses
            // 
            this.txtBackOffInPulses.Location = new System.Drawing.Point(196, 327);
            this.txtBackOffInPulses.MaxLength = 5;
            this.txtBackOffInPulses.Name = "txtBackOffInPulses";
            this.txtBackOffInPulses.Size = new System.Drawing.Size(116, 21);
            this.txtBackOffInPulses.TabIndex = 57;
            this.txtBackOffInPulses.TextChanged += new System.EventHandler(this.txtBackOffInPulses_TextChanged);
            // 
            // label13
            // 
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(21, 327);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 15);
            this.label13.TabIndex = 67;
            this.label13.Text = "Press Zero BackOff in pulses";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtServoPulsesAtZoneZero
            // 
            this.txtServoPulsesAtZoneZero.Location = new System.Drawing.Point(196, 291);
            this.txtServoPulsesAtZoneZero.MaxLength = 5;
            this.txtServoPulsesAtZoneZero.Name = "txtServoPulsesAtZoneZero";
            this.txtServoPulsesAtZoneZero.Size = new System.Drawing.Size(116, 21);
            this.txtServoPulsesAtZoneZero.TabIndex = 56;
            this.txtServoPulsesAtZoneZero.TextChanged += new System.EventHandler(this.txtServoPulsesAtZoneZero_TextChanged);
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(-3, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 29);
            this.label12.TabIndex = 66;
            this.label12.Text = "Servo Pulses for Zone at Zero";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDefaultOffset
            // 
            this.txtDefaultOffset.Location = new System.Drawing.Point(196, 256);
            this.txtDefaultOffset.MaxLength = 5;
            this.txtDefaultOffset.Name = "txtDefaultOffset";
            this.txtDefaultOffset.Size = new System.Drawing.Size(116, 21);
            this.txtDefaultOffset.TabIndex = 54;
            this.txtDefaultOffset.TextChanged += new System.EventHandler(this.txtDefaultOffset_TextChanged);
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(21, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 15);
            this.label11.TabIndex = 65;
            this.label11.Text = "Default Offset";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkMeterRoller
            // 
            this.chkMeterRoller.AutoSize = true;
            this.chkMeterRoller.BackColor = System.Drawing.Color.Transparent;
            this.chkMeterRoller.ForeColor = System.Drawing.Color.White;
            this.chkMeterRoller.Location = new System.Drawing.Point(196, 228);
            this.chkMeterRoller.Name = "chkMeterRoller";
            this.chkMeterRoller.Size = new System.Drawing.Size(148, 19);
            this.chkMeterRoller.TabIndex = 46;
            this.chkMeterRoller.Text = "Metering Roller  Offset";
            this.chkMeterRoller.UseVisualStyleBackColor = false;
            this.chkMeterRoller.CheckedChanged += new System.EventHandler(this.chkMeterRoller_CheckedChanged);
            // 
            // chkBladeComp
            // 
            this.chkBladeComp.AutoSize = true;
            this.chkBladeComp.BackColor = System.Drawing.Color.Transparent;
            this.chkBladeComp.ForeColor = System.Drawing.Color.White;
            this.chkBladeComp.Location = new System.Drawing.Point(196, 199);
            this.chkBladeComp.Name = "chkBladeComp";
            this.chkBladeComp.Size = new System.Drawing.Size(141, 19);
            this.chkBladeComp.TabIndex = 45;
            this.chkBladeComp.Text = "Blade Compensation";
            this.chkBladeComp.UseVisualStyleBackColor = false;
            this.chkBladeComp.CheckedChanged += new System.EventHandler(this.chkBladeComp_CheckedChanged);
            // 
            // chkNONFS
            // 
            this.chkNONFS.AutoSize = true;
            this.chkNONFS.BackColor = System.Drawing.Color.Transparent;
            this.chkNONFS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkNONFS.Location = new System.Drawing.Point(168, 31);
            this.chkNONFS.Name = "chkNONFS";
            this.chkNONFS.Size = new System.Drawing.Size(71, 19);
            this.chkNONFS.TabIndex = 44;
            this.chkNONFS.Text = "NO NFS";
            this.chkNONFS.UseVisualStyleBackColor = false;
            this.chkNONFS.CheckedChanged += new System.EventHandler(this.chkNONFS_CheckedChanged);
            // 
            // chkType2
            // 
            this.chkType2.AutoSize = true;
            this.chkType2.BackColor = System.Drawing.Color.Transparent;
            this.chkType2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkType2.Location = new System.Drawing.Point(98, 31);
            this.chkType2.Name = "chkType2";
            this.chkType2.Size = new System.Drawing.Size(62, 19);
            this.chkType2.TabIndex = 43;
            this.chkType2.Text = "Type 2";
            this.chkType2.UseVisualStyleBackColor = false;
            this.chkType2.CheckedChanged += new System.EventHandler(this.chkType2_CheckedChanged);
            // 
            // chkType1
            // 
            this.chkType1.AutoSize = true;
            this.chkType1.BackColor = System.Drawing.Color.Transparent;
            this.chkType1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkType1.Location = new System.Drawing.Point(28, 31);
            this.chkType1.Name = "chkType1";
            this.chkType1.Size = new System.Drawing.Size(62, 19);
            this.chkType1.TabIndex = 42;
            this.chkType1.Text = "Type 1";
            this.chkType1.UseVisualStyleBackColor = false;
            this.chkType1.CheckedChanged += new System.EventHandler(this.chkType1_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.btnOK.Location = new System.Drawing.Point(92, 404);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 51);
            this.btnOK.TabIndex = 58;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtMaxNeighborKeyDelta
            // 
            this.txtMaxNeighborKeyDelta.Location = new System.Drawing.Point(196, 76);
            this.txtMaxNeighborKeyDelta.MaxLength = 5;
            this.txtMaxNeighborKeyDelta.Name = "txtMaxNeighborKeyDelta";
            this.txtMaxNeighborKeyDelta.Size = new System.Drawing.Size(116, 21);
            this.txtMaxNeighborKeyDelta.TabIndex = 40;
            this.txtMaxNeighborKeyDelta.TextChanged += new System.EventHandler(this.txtMaxNeighborKeyDelta_TextChanged);
            // 
            // txtBladeStiffness
            // 
            this.txtBladeStiffness.Location = new System.Drawing.Point(196, 43);
            this.txtBladeStiffness.MaxLength = 5;
            this.txtBladeStiffness.Name = "txtBladeStiffness";
            this.txtBladeStiffness.Size = new System.Drawing.Size(116, 21);
            this.txtBladeStiffness.TabIndex = 39;
            this.txtBladeStiffness.TextChanged += new System.EventHandler(this.txtBladeStiffness_TextChanged);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "Max Neighbouring Key Delta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 15);
            this.label1.TabIndex = 48;
            this.label1.Text = "Blade Stiffness";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlWizardTitle
            // 
            this.pnlWizardTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlWizardTitle.Controls.Add(this.label4);
            this.pnlWizardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWizardTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlWizardTitle.Name = "pnlWizardTitle";
            this.pnlWizardTitle.Size = new System.Drawing.Size(372, 31);
            this.pnlWizardTitle.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(88, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Press Site Settings";
            // 
            // checkAutoZero
            // 
            this.checkAutoZero.AutoSize = true;
            this.checkAutoZero.BackColor = System.Drawing.Color.Gray;
            this.checkAutoZero.ForeColor = System.Drawing.Color.White;
            this.checkAutoZero.Location = new System.Drawing.Point(196, 363);
            this.checkAutoZero.Name = "checkAutoZero";
            this.checkAutoZero.Size = new System.Drawing.Size(140, 19);
            this.checkAutoZero.TabIndex = 71;
            this.checkAutoZero.Text = "Auto Zero Calibration";
            this.checkAutoZero.UseVisualStyleBackColor = false;
            this.checkAutoZero.CheckedChanged += new System.EventHandler(this.checkAutoZero_CheckedChanged);
            // 
            // NonLinearGroupBox
            // 
            this.NonLinearGroupBox.BackColor = System.Drawing.Color.Gray;
            this.NonLinearGroupBox.Controls.Add(this.chkType1);
            this.NonLinearGroupBox.Controls.Add(this.chkType2);
            this.NonLinearGroupBox.Controls.Add(this.chkNONFS);
            this.NonLinearGroupBox.Location = new System.Drawing.Point(42, 112);
            this.NonLinearGroupBox.Name = "NonLinearGroupBox";
            this.NonLinearGroupBox.Size = new System.Drawing.Size(270, 72);
            this.NonLinearGroupBox.TabIndex = 72;
            this.NonLinearGroupBox.TabStop = false;
            this.NonLinearGroupBox.Text = "NonLinear";
            // 
            // frmPressSiteSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(372, 491);
            this.ControlBox = false;
            this.Controls.Add(this.NonLinearGroupBox);
            this.Controls.Add(this.checkAutoZero);
            this.Controls.Add(this.pnlWizardTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBackOffInPulses);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtServoPulsesAtZoneZero);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDefaultOffset);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chkMeterRoller);
            this.Controls.Add(this.chkBladeComp);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtMaxNeighborKeyDelta);
            this.Controls.Add(this.txtBladeStiffness);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPressSiteSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmPressSiteSettings_Load);
            this.pnlWizardTitle.ResumeLayout(false);
            this.pnlWizardTitle.PerformLayout();
            this.NonLinearGroupBox.ResumeLayout(false);
            this.NonLinearGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBackOffInPulses;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtServoPulsesAtZoneZero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDefaultOffset;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkMeterRoller;
        private System.Windows.Forms.CheckBox chkBladeComp;
        private System.Windows.Forms.CheckBox chkNONFS;
        private System.Windows.Forms.CheckBox chkType2;
        private System.Windows.Forms.CheckBox chkType1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtMaxNeighborKeyDelta;
        private System.Windows.Forms.TextBox txtBladeStiffness;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlWizardTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkAutoZero;
        private System.Windows.Forms.GroupBox NonLinearGroupBox;

    }
}