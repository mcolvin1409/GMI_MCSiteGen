namespace MCNWSiteGen
{
    partial class FormWaterMotorServo
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
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gpSPUConfig = new System.Windows.Forms.GroupBox();
            this.listCOMPorts = new System.Windows.Forms.ListBox();
            this.butDropDown = new System.Windows.Forms.Button();
            this.cboServoControl = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboSpecialMapping = new System.Windows.Forms.ComboBox();
            this.pnlWizardTitle = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboUseBank1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboReversed = new System.Windows.Forms.ComboBox();
            this.txtBoxInitialSurge = new System.Windows.Forms.TextBox();
            this.gpPLCSettings = new System.Windows.Forms.GroupBox();
            this.textTurns2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxIncrementalSurge = new System.Windows.Forms.TextBox();
            this.textBoxMotorTurns = new System.Windows.Forms.TextBox();
            this.ListBoxServoControl = new MCNWSiteGen.BetterListBox();
            this.gpSPUConfig.SuspendLayout();
            this.pnlWizardTitle.SuspendLayout();
            this.gpPLCSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "Servo Control";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Servo Turns(Motor)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Surge";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(37, 33);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(37, 16);
            this.label26.TabIndex = 5;
            this.label26.Text = "Inker";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Incremental Surge";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(327, 417);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 51);
            this.btnCancel.TabIndex = 80;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gpSPUConfig
            // 
            this.gpSPUConfig.Controls.Add(this.listCOMPorts);
            this.gpSPUConfig.Controls.Add(this.butDropDown);
            this.gpSPUConfig.Controls.Add(this.cboServoControl);
            this.gpSPUConfig.Controls.Add(this.ListBoxServoControl);
            this.gpSPUConfig.Controls.Add(this.label9);
            this.gpSPUConfig.Controls.Add(this.label26);
            this.gpSPUConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSPUConfig.ForeColor = System.Drawing.Color.White;
            this.gpSPUConfig.Location = new System.Drawing.Point(327, 60);
            this.gpSPUConfig.Name = "gpSPUConfig";
            this.gpSPUConfig.Size = new System.Drawing.Size(265, 324);
            this.gpSPUConfig.TabIndex = 81;
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
            this.listCOMPorts.Location = new System.Drawing.Point(117, 276);
            this.listCOMPorts.Name = "listCOMPorts";
            this.listCOMPorts.Size = new System.Drawing.Size(101, 30);
            this.listCOMPorts.TabIndex = 81;
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
            this.butDropDown.Location = new System.Drawing.Point(243, 290);
            this.butDropDown.Name = "butDropDown";
            this.butDropDown.Size = new System.Drawing.Size(16, 16);
            this.butDropDown.TabIndex = 80;
            this.butDropDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butDropDown.UseVisualStyleBackColor = false;
            this.butDropDown.Visible = false;
            this.butDropDown.Click += new System.EventHandler(this.butDropDown_Click);
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
            this.cboServoControl.Location = new System.Drawing.Point(6, 283);
            this.cboServoControl.Name = "cboServoControl";
            this.cboServoControl.Size = new System.Drawing.Size(89, 23);
            this.cboServoControl.TabIndex = 79;
            this.cboServoControl.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.btnOK.Location = new System.Drawing.Point(244, 417);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 51);
            this.btnOK.TabIndex = 79;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reversed";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // comboSpecialMapping
            // 
            this.comboSpecialMapping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSpecialMapping.FormattingEnabled = true;
            this.comboSpecialMapping.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboSpecialMapping.Location = new System.Drawing.Point(170, 230);
            this.comboSpecialMapping.Name = "comboSpecialMapping";
            this.comboSpecialMapping.Size = new System.Drawing.Size(100, 21);
            this.comboSpecialMapping.TabIndex = 12;
            // 
            // pnlWizardTitle
            // 
            this.pnlWizardTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlWizardTitle.Controls.Add(this.label5);
            this.pnlWizardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWizardTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlWizardTitle.Name = "pnlWizardTitle";
            this.pnlWizardTitle.Size = new System.Drawing.Size(610, 31);
            this.pnlWizardTitle.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(215, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Motor Servo Water";
            // 
            // comboUseBank1
            // 
            this.comboUseBank1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUseBank1.FormattingEnabled = true;
            this.comboUseBank1.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboUseBank1.Location = new System.Drawing.Point(170, 270);
            this.comboUseBank1.Name = "comboUseBank1";
            this.comboUseBank1.Size = new System.Drawing.Size(100, 21);
            this.comboUseBank1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Special Mapping";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboReversed
            // 
            this.comboReversed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboReversed.FormattingEnabled = true;
            this.comboReversed.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboReversed.Location = new System.Drawing.Point(170, 190);
            this.comboReversed.Name = "comboReversed";
            this.comboReversed.Size = new System.Drawing.Size(100, 21);
            this.comboReversed.TabIndex = 9;
            // 
            // txtBoxInitialSurge
            // 
            this.txtBoxInitialSurge.Location = new System.Drawing.Point(170, 110);
            this.txtBoxInitialSurge.MaxLength = 2;
            this.txtBoxInitialSurge.Name = "txtBoxInitialSurge";
            this.txtBoxInitialSurge.Size = new System.Drawing.Size(100, 20);
            this.txtBoxInitialSurge.TabIndex = 5;
            this.txtBoxInitialSurge.Leave += new System.EventHandler(this.txtBoxInitialSurge_Leave);
            this.txtBoxInitialSurge.TextChanged += new System.EventHandler(this.txtBoxInitialSurge_TextChanged);
            // 
            // gpPLCSettings
            // 
            this.gpPLCSettings.Controls.Add(this.textTurns2);
            this.gpPLCSettings.Controls.Add(this.label8);
            this.gpPLCSettings.Controls.Add(this.textBoxIncrementalSurge);
            this.gpPLCSettings.Controls.Add(this.textBoxMotorTurns);
            this.gpPLCSettings.Controls.Add(this.comboUseBank1);
            this.gpPLCSettings.Controls.Add(this.label7);
            this.gpPLCSettings.Controls.Add(this.comboSpecialMapping);
            this.gpPLCSettings.Controls.Add(this.label6);
            this.gpPLCSettings.Controls.Add(this.comboReversed);
            this.gpPLCSettings.Controls.Add(this.txtBoxInitialSurge);
            this.gpPLCSettings.Controls.Add(this.label4);
            this.gpPLCSettings.Controls.Add(this.label3);
            this.gpPLCSettings.Controls.Add(this.label2);
            this.gpPLCSettings.Controls.Add(this.label1);
            this.gpPLCSettings.ForeColor = System.Drawing.Color.White;
            this.gpPLCSettings.Location = new System.Drawing.Point(15, 60);
            this.gpPLCSettings.Name = "gpPLCSettings";
            this.gpPLCSettings.Size = new System.Drawing.Size(287, 324);
            this.gpPLCSettings.TabIndex = 78;
            this.gpPLCSettings.TabStop = false;
            this.gpPLCSettings.Text = "Motor Control";
            // 
            // textTurns2
            // 
            this.textTurns2.Location = new System.Drawing.Point(170, 70);
            this.textTurns2.MaxLength = 5;
            this.textTurns2.Name = "textTurns2";
            this.textTurns2.Size = new System.Drawing.Size(100, 20);
            this.textTurns2.TabIndex = 18;
            this.textTurns2.Leave += new System.EventHandler(this.textTurns2_Leave);
            this.textTurns2.TextChanged += new System.EventHandler(this.textTurns2_TextChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Turns2 (Servo)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxIncrementalSurge
            // 
            this.textBoxIncrementalSurge.Location = new System.Drawing.Point(170, 150);
            this.textBoxIncrementalSurge.MaxLength = 2;
            this.textBoxIncrementalSurge.Name = "textBoxIncrementalSurge";
            this.textBoxIncrementalSurge.Size = new System.Drawing.Size(100, 20);
            this.textBoxIncrementalSurge.TabIndex = 16;
            this.textBoxIncrementalSurge.Leave += new System.EventHandler(this.textBoxIncrementalSurge_Leave);
            this.textBoxIncrementalSurge.TextChanged += new System.EventHandler(this.textBoxIncrementalSurge_TextChanged);
            // 
            // textBoxMotorTurns
            // 
            this.textBoxMotorTurns.Location = new System.Drawing.Point(170, 30);
            this.textBoxMotorTurns.MaxLength = 4;
            this.textBoxMotorTurns.Name = "textBoxMotorTurns";
            this.textBoxMotorTurns.Size = new System.Drawing.Size(100, 20);
            this.textBoxMotorTurns.TabIndex = 15;
            this.textBoxMotorTurns.Leave += new System.EventHandler(this.textBoxMotorTurns_Leave);
            this.textBoxMotorTurns.TextChanged += new System.EventHandler(this.textBoxMotorTurns_TextChanged);
            // 
            // ListBoxServoControl
            // 
            this.ListBoxServoControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxServoControl.FormattingEnabled = true;
            this.ListBoxServoControl.Location = new System.Drawing.Point(37, 58);
            this.ListBoxServoControl.Name = "ListBoxServoControl";
            this.ListBoxServoControl.ScrollAlwaysVisible = true;
            this.ListBoxServoControl.Size = new System.Drawing.Size(190, 212);
            this.ListBoxServoControl.TabIndex = 82;
            this.ListBoxServoControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxServoControl_MouseClick);
            this.ListBoxServoControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBoxServoControl_DrawItem);
            this.ListBoxServoControl.SelectedIndexChanged += new System.EventHandler(this.ListBoxServoControl_SelectedIndexChanged);
            this.ListBoxServoControl.Scroll += new MCNWSiteGen.BetterListBox.BetterListBoxScrollDelegate(this.ListBoxServoControl_Scroll);
            // 
            // FormWaterMotorServo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(610, 494);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gpSPUConfig);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pnlWizardTitle);
            this.Controls.Add(this.gpPLCSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWaterMotorServo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormWaterMotorServo_Load);
            this.gpSPUConfig.ResumeLayout(false);
            this.gpSPUConfig.PerformLayout();
            this.pnlWizardTitle.ResumeLayout(false);
            this.pnlWizardTitle.PerformLayout();
            this.gpPLCSettings.ResumeLayout(false);
            this.gpPLCSettings.PerformLayout();
            this.ResumeLayout(false);

        }        

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gpSPUConfig;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboSpecialMapping;
        private System.Windows.Forms.Panel pnlWizardTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboUseBank1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboReversed;
        private System.Windows.Forms.TextBox txtBoxInitialSurge;
        private System.Windows.Forms.GroupBox gpPLCSettings;
        private System.Windows.Forms.TextBox textBoxIncrementalSurge;
        private System.Windows.Forms.TextBox textBoxMotorTurns;
        private System.Windows.Forms.TextBox textTurns2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listCOMPorts;
        private System.Windows.Forms.Button butDropDown;
        private System.Windows.Forms.ComboBox cboServoControl;
        private BetterListBox ListBoxServoControl;
    }
}