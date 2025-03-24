namespace MCNWSiteGen
{
    partial class FormSweepMotorServo
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
            this.label5 = new System.Windows.Forms.Label();
            this.pnlWizardTitle = new System.Windows.Forms.Panel();
            this.gpPLCSettings = new System.Windows.Forms.GroupBox();
            this.textServoTurns2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboUseBank1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboOffsetEnabled = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboLowBackLashUsed = new System.Windows.Forms.ComboBox();
            this.cboReversed = new System.Windows.Forms.ComboBox();
            this.cboStepEnabled = new System.Windows.Forms.ComboBox();
            this.txtServoTurns = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxSPU = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.gpSPUConfig = new System.Windows.Forms.GroupBox();
            this.listCOMPorts = new System.Windows.Forms.ListBox();
            this.butDropDown = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cboServoControl = new System.Windows.Forms.ComboBox();
            this.ListBoxServoControl = new MCNWSiteGen.BetterListBox();
            this.pnlWizardTitle.SuspendLayout();
            this.gpPLCSettings.SuspendLayout();
            this.gpSPUConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(215, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Motor Servo Sweep";
            // 
            // pnlWizardTitle
            // 
            this.pnlWizardTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlWizardTitle.Controls.Add(this.label5);
            this.pnlWizardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWizardTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlWizardTitle.Name = "pnlWizardTitle";
            this.pnlWizardTitle.Size = new System.Drawing.Size(583, 31);
            this.pnlWizardTitle.TabIndex = 72;
            // 
            // gpPLCSettings
            // 
            this.gpPLCSettings.Controls.Add(this.textServoTurns2);
            this.gpPLCSettings.Controls.Add(this.label8);
            this.gpPLCSettings.Controls.Add(this.cboUseBank1);
            this.gpPLCSettings.Controls.Add(this.label7);
            this.gpPLCSettings.Controls.Add(this.cboOffsetEnabled);
            this.gpPLCSettings.Controls.Add(this.label6);
            this.gpPLCSettings.Controls.Add(this.cboLowBackLashUsed);
            this.gpPLCSettings.Controls.Add(this.cboReversed);
            this.gpPLCSettings.Controls.Add(this.cboStepEnabled);
            this.gpPLCSettings.Controls.Add(this.txtServoTurns);
            this.gpPLCSettings.Controls.Add(this.label4);
            this.gpPLCSettings.Controls.Add(this.label3);
            this.gpPLCSettings.Controls.Add(this.label2);
            this.gpPLCSettings.Controls.Add(this.label1);
            this.gpPLCSettings.ForeColor = System.Drawing.Color.White;
            this.gpPLCSettings.Location = new System.Drawing.Point(11, 62);
            this.gpPLCSettings.Name = "gpPLCSettings";
            this.gpPLCSettings.Size = new System.Drawing.Size(287, 316);
            this.gpPLCSettings.TabIndex = 73;
            this.gpPLCSettings.TabStop = false;
            this.gpPLCSettings.Text = "Motor Control";
            // 
            // textServoTurns2
            // 
            this.textServoTurns2.Location = new System.Drawing.Point(170, 110);
            this.textServoTurns2.MaxLength = 6;
            this.textServoTurns2.Name = "textServoTurns2";
            this.textServoTurns2.Size = new System.Drawing.Size(100, 20);
            this.textServoTurns2.TabIndex = 16;
            this.textServoTurns2.Leave += new System.EventHandler(this.textServoTurns2_Leave);
            this.textServoTurns2.TextChanged += new System.EventHandler(this.textServoTurns2_TextChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(9, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Turns2 (Servo)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboUseBank1
            // 
            this.cboUseBank1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUseBank1.FormattingEnabled = true;
            this.cboUseBank1.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cboUseBank1.Location = new System.Drawing.Point(170, 270);
            this.cboUseBank1.Name = "cboUseBank1";
            this.cboUseBank1.Size = new System.Drawing.Size(100, 21);
            this.cboUseBank1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Use Bank 1";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboOffsetEnabled
            // 
            this.cboOffsetEnabled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOffsetEnabled.FormattingEnabled = true;
            this.cboOffsetEnabled.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cboOffsetEnabled.Location = new System.Drawing.Point(170, 230);
            this.cboOffsetEnabled.Name = "cboOffsetEnabled";
            this.cboOffsetEnabled.Size = new System.Drawing.Size(100, 21);
            this.cboOffsetEnabled.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Offset Enabled";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboLowBackLashUsed
            // 
            this.cboLowBackLashUsed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLowBackLashUsed.FormattingEnabled = true;
            this.cboLowBackLashUsed.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cboLowBackLashUsed.Location = new System.Drawing.Point(170, 190);
            this.cboLowBackLashUsed.Name = "cboLowBackLashUsed";
            this.cboLowBackLashUsed.Size = new System.Drawing.Size(100, 21);
            this.cboLowBackLashUsed.TabIndex = 10;
            // 
            // cboReversed
            // 
            this.cboReversed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReversed.FormattingEnabled = true;
            this.cboReversed.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cboReversed.Location = new System.Drawing.Point(170, 150);
            this.cboReversed.Name = "cboReversed";
            this.cboReversed.Size = new System.Drawing.Size(100, 21);
            this.cboReversed.TabIndex = 9;
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
            // txtServoTurns
            // 
            this.txtServoTurns.Location = new System.Drawing.Point(170, 70);
            this.txtServoTurns.MaxLength = 4;
            this.txtServoTurns.Name = "txtServoTurns";
            this.txtServoTurns.Size = new System.Drawing.Size(100, 20);
            this.txtServoTurns.TabIndex = 5;
            this.txtServoTurns.Leave += new System.EventHandler(this.txtServoTurns_Leave);
            this.txtServoTurns.TextChanged += new System.EventHandler(this.txtServoTurns_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Low Backlash Used";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 154);
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
            this.label2.Text = "Servo Turns (Motor)";
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
            // listBoxSPU
            // 
            this.listBoxSPU.ColumnWidth = 15;
            this.listBoxSPU.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxSPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSPU.FormattingEnabled = true;
            this.listBoxSPU.ItemHeight = 17;
            this.listBoxSPU.Items.AddRange(new object[] {
            "1483",
            "75.",
            "75.7",
            "85",
            "5",
            "57",
            "7"});
            this.listBoxSPU.Location = new System.Drawing.Point(127, -25);
            this.listBoxSPU.Name = "listBoxSPU";
            this.listBoxSPU.Size = new System.Drawing.Size(140, 21);
            this.listBoxSPU.TabIndex = 52;
            this.listBoxSPU.Visible = false;
            this.listBoxSPU.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxSPU_MouseClick);
            this.listBoxSPU.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxSPU_DrawItem);
            this.listBoxSPU.SelectedIndexChanged += new System.EventHandler(this.listBoxSPU_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(303, 398);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 51);
            this.btnCancel.TabIndex = 75;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.btnOK.Location = new System.Drawing.Point(220, 398);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 51);
            this.btnOK.TabIndex = 74;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gpSPUConfig
            // 
            this.gpSPUConfig.Controls.Add(this.listCOMPorts);
            this.gpSPUConfig.Controls.Add(this.butDropDown);
            this.gpSPUConfig.Controls.Add(this.listBoxSPU);
            this.gpSPUConfig.Controls.Add(this.label9);
            this.gpSPUConfig.Controls.Add(this.label26);
            this.gpSPUConfig.Controls.Add(this.cboServoControl);
            this.gpSPUConfig.Controls.Add(this.ListBoxServoControl);
            this.gpSPUConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSPUConfig.ForeColor = System.Drawing.Color.White;
            this.gpSPUConfig.Location = new System.Drawing.Point(323, 62);
            this.gpSPUConfig.Name = "gpSPUConfig";
            this.gpSPUConfig.Size = new System.Drawing.Size(248, 316);
            this.gpSPUConfig.TabIndex = 76;
            this.gpSPUConfig.TabStop = false;
            this.gpSPUConfig.Text = "Servo Control";
            // 
            // listCOMPorts
            // 
            this.listCOMPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCOMPorts.FormattingEnabled = true;
            this.listCOMPorts.Items.AddRange(new object[] {
            "FALSE",
            "TRUE"});
            this.listCOMPorts.Location = new System.Drawing.Point(117, 281);
            this.listCOMPorts.Name = "listCOMPorts";
            this.listCOMPorts.Size = new System.Drawing.Size(101, 30);
            this.listCOMPorts.TabIndex = 77;
            this.listCOMPorts.Visible = false;
            this.listCOMPorts.SelectedIndexChanged += new System.EventHandler(this.listCOMPorts_SelectedIndexChanged);
            // 
            // butDropDown
            // 
            this.butDropDown.BackColor = System.Drawing.Color.Transparent;
            this.butDropDown.BackgroundImage = global::MCNWSiteGen.Properties.Resources.dropdownarrow;
            this.butDropDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butDropDown.FlatAppearance.BorderSize = 0;
            this.butDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDropDown.ForeColor = System.Drawing.Color.Transparent;
            this.butDropDown.Location = new System.Drawing.Point(224, 288);
            this.butDropDown.Name = "butDropDown";
            this.butDropDown.Size = new System.Drawing.Size(16, 16);
            this.butDropDown.TabIndex = 55;
            this.butDropDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butDropDown.UseVisualStyleBackColor = false;
            this.butDropDown.Visible = false;
            this.butDropDown.Click += new System.EventHandler(this.butDropDown_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "Servo Control";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(28, 33);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(40, 16);
            this.label26.TabIndex = 5;
            this.label26.Text = "Inker ";
            // 
            // cboServoControl
            // 
            this.cboServoControl.BackColor = System.Drawing.Color.White;
            this.cboServoControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServoControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboServoControl.FormattingEnabled = true;
            this.cboServoControl.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cboServoControl.Location = new System.Drawing.Point(6, 288);
            this.cboServoControl.Name = "cboServoControl";
            this.cboServoControl.Size = new System.Drawing.Size(89, 23);
            this.cboServoControl.TabIndex = 3;
            this.cboServoControl.Visible = false;
            // 
            // ListBoxServoControl
            // 
            this.ListBoxServoControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxServoControl.FormattingEnabled = true;
            this.ListBoxServoControl.Location = new System.Drawing.Point(28, 63);
            this.ListBoxServoControl.Name = "ListBoxServoControl";
            this.ListBoxServoControl.ScrollAlwaysVisible = true;
            this.ListBoxServoControl.Size = new System.Drawing.Size(190, 212);
            this.ListBoxServoControl.TabIndex = 78;
            this.ListBoxServoControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxServoControl_MouseClick);
            this.ListBoxServoControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBoxServoControl_DrawItem);
            this.ListBoxServoControl.SelectedIndexChanged += new System.EventHandler(this.ListBoxServoControl_SelectedIndexChanged);
            this.ListBoxServoControl.Scroll += new MCNWSiteGen.BetterListBox.BetterListBoxScrollDelegate(this.betterListBox1_Scroll);
            // 
            // FormSweepMotorServo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(583, 474);
            this.ControlBox = false;
            this.Controls.Add(this.gpSPUConfig);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gpPLCSettings);
            this.Controls.Add(this.pnlWizardTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSweepMotorServo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.formSweepMotorServo_Load);
            this.pnlWizardTitle.ResumeLayout(false);
            this.pnlWizardTitle.PerformLayout();
            this.gpPLCSettings.ResumeLayout(false);
            this.gpPLCSettings.PerformLayout();
            this.gpSPUConfig.ResumeLayout(false);
            this.gpSPUConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlWizardTitle;
        private System.Windows.Forms.GroupBox gpPLCSettings;
        private System.Windows.Forms.ComboBox cboStepEnabled;
        private System.Windows.Forms.TextBox txtServoTurns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox gpSPUConfig;
        private System.Windows.Forms.Button butDropDown;
        private System.Windows.Forms.ListBox listBoxSPU;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cboUseBank1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboOffsetEnabled;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboLowBackLashUsed;
        private System.Windows.Forms.ComboBox cboReversed;
        private System.Windows.Forms.ComboBox cboServoControl;
        private System.Windows.Forms.ListBox listCOMPorts;
        private BetterListBox ListBoxServoControl;
        private System.Windows.Forms.TextBox textServoTurns2;
        private System.Windows.Forms.Label label8;
    }
}