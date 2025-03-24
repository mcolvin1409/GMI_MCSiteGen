namespace MCNWSiteGen
{
    partial class FormSweepMotorOrServoCtrl
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
            this.comboUserBank1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboOffsetEnabled = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboLowBacklashUsed = new System.Windows.Forms.ComboBox();
            this.comboReversed = new System.Windows.Forms.ComboBox();
            this.txtServoTurns = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboStepEnabled = new System.Windows.Forms.ComboBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.gpMotorOrServoSettings = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlWizardTitle = new System.Windows.Forms.Panel();
            this.gpMotorOrServoSettings.SuspendLayout();
            this.pnlWizardTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboUserBank1
            // 
            this.comboUserBank1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUserBank1.FormattingEnabled = true;
            this.comboUserBank1.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboUserBank1.Location = new System.Drawing.Point(170, 230);
            this.comboUserBank1.Name = "comboUserBank1";
            this.comboUserBank1.Size = new System.Drawing.Size(100, 21);
            this.comboUserBank1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Use Bank 1";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboOffsetEnabled
            // 
            this.comboOffsetEnabled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOffsetEnabled.FormattingEnabled = true;
            this.comboOffsetEnabled.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboOffsetEnabled.Location = new System.Drawing.Point(170, 190);
            this.comboOffsetEnabled.Name = "comboOffsetEnabled";
            this.comboOffsetEnabled.Size = new System.Drawing.Size(100, 21);
            this.comboOffsetEnabled.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Offset Enabled";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboLowBacklashUsed
            // 
            this.comboLowBacklashUsed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLowBacklashUsed.FormattingEnabled = true;
            this.comboLowBacklashUsed.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboLowBacklashUsed.Location = new System.Drawing.Point(170, 150);
            this.comboLowBacklashUsed.Name = "comboLowBacklashUsed";
            this.comboLowBacklashUsed.Size = new System.Drawing.Size(100, 21);
            this.comboLowBacklashUsed.TabIndex = 10;
            // 
            // comboReversed
            // 
            this.comboReversed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboReversed.FormattingEnabled = true;
            this.comboReversed.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboReversed.Location = new System.Drawing.Point(170, 110);
            this.comboReversed.Name = "comboReversed";
            this.comboReversed.Size = new System.Drawing.Size(100, 21);
            this.comboReversed.TabIndex = 9;
            // 
            // txtServoTurns
            // 
            this.txtServoTurns.Location = new System.Drawing.Point(170, 70);
            this.txtServoTurns.MaxLength = 5;
            this.txtServoTurns.Name = "txtServoTurns";
            this.txtServoTurns.Size = new System.Drawing.Size(100, 20);
            this.txtServoTurns.TabIndex = 5;
            this.txtServoTurns.Leave += new System.EventHandler(this.txtServoTurns_Leave);
            this.txtServoTurns.TextChanged += new System.EventHandler(this.txtServoTurns_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Low Backlash Used";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboStepEnabled
            // 
            this.cboStepEnabled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStepEnabled.FormattingEnabled = true;
            this.cboStepEnabled.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cboStepEnabled.Location = new System.Drawing.Point(170, 30);
            this.cboStepEnabled.Name = "cboStepEnabled";
            this.cboStepEnabled.Size = new System.Drawing.Size(100, 21);
            this.cboStepEnabled.TabIndex = 8;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(137, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(114, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Motor Sweep";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(215, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 51);
            this.btnCancel.TabIndex = 80;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.btnOK.Location = new System.Drawing.Point(132, 345);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 51);
            this.btnOK.TabIndex = 79;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gpMotorOrServoSettings
            // 
            this.gpMotorOrServoSettings.Controls.Add(this.comboUserBank1);
            this.gpMotorOrServoSettings.Controls.Add(this.label7);
            this.gpMotorOrServoSettings.Controls.Add(this.comboOffsetEnabled);
            this.gpMotorOrServoSettings.Controls.Add(this.label6);
            this.gpMotorOrServoSettings.Controls.Add(this.comboLowBacklashUsed);
            this.gpMotorOrServoSettings.Controls.Add(this.comboReversed);
            this.gpMotorOrServoSettings.Controls.Add(this.cboStepEnabled);
            this.gpMotorOrServoSettings.Controls.Add(this.txtServoTurns);
            this.gpMotorOrServoSettings.Controls.Add(this.label4);
            this.gpMotorOrServoSettings.Controls.Add(this.label3);
            this.gpMotorOrServoSettings.Controls.Add(this.label2);
            this.gpMotorOrServoSettings.Controls.Add(this.label1);
            this.gpMotorOrServoSettings.ForeColor = System.Drawing.Color.White;
            this.gpMotorOrServoSettings.Location = new System.Drawing.Point(45, 51);
            this.gpMotorOrServoSettings.Name = "gpMotorOrServoSettings";
            this.gpMotorOrServoSettings.Size = new System.Drawing.Size(310, 276);
            this.gpMotorOrServoSettings.TabIndex = 78;
            this.gpMotorOrServoSettings.TabStop = false;
            this.gpMotorOrServoSettings.Text = "Motor Control";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reversed";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Servo Turns";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Step Enabled";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlWizardTitle
            // 
            this.pnlWizardTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlWizardTitle.Controls.Add(this.labelTitle);
            this.pnlWizardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWizardTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlWizardTitle.Name = "pnlWizardTitle";
            this.pnlWizardTitle.Size = new System.Drawing.Size(408, 31);
            this.pnlWizardTitle.TabIndex = 77;
            // 
            // FormSweepMotorOrServoCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(408, 415);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gpMotorOrServoSettings);
            this.Controls.Add(this.pnlWizardTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSweepMotorOrServoCtrl";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormSweepMotorOrServoCtrl_Load);
            this.gpMotorOrServoSettings.ResumeLayout(false);
            this.gpMotorOrServoSettings.PerformLayout();
            this.pnlWizardTitle.ResumeLayout(false);
            this.pnlWizardTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboUserBank1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboOffsetEnabled;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboLowBacklashUsed;
        private System.Windows.Forms.ComboBox comboReversed;
        private System.Windows.Forms.TextBox txtServoTurns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboStepEnabled;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox gpMotorOrServoSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlWizardTitle;
    }
}