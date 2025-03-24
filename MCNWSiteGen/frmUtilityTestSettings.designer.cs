namespace MCNWSiteGen
{
    partial class frmUtilityTestSettings
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
            this.utilityTestType = new System.Windows.Forms.Label();
            this.textTotalUnitstoTest = new System.Windows.Forms.TextBox();
            this.textBoxTotalSPUsToTest = new System.Windows.Forms.TextBox();
            this.textTotalServostoTest = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnlWizardTitle = new System.Windows.Forms.Panel();
            this.labeltitle = new System.Windows.Forms.Label();
            this.labelUnitsSweeps = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelServoPorts = new System.Windows.Forms.Label();
            this.labelOpenKeysSweep = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboCloseKeysUpTo = new System.Windows.Forms.ComboBox();
            this.comboTimeDelay = new System.Windows.Forms.ComboBox();
            this.comboLooptype = new System.Windows.Forms.ComboBox();
            this.comboOpenKeysUpTo = new System.Windows.Forms.ComboBox();
            this.textNumberOfCycles = new System.Windows.Forms.TextBox();
            this.lbPercentag = new System.Windows.Forms.Label();
            this.tbOpenUpTo = new System.Windows.Forms.TextBox();
            this.pnlWizardTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // utilityTestType
            // 
            this.utilityTestType.AutoSize = true;
            this.utilityTestType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilityTestType.ForeColor = System.Drawing.Color.Black;
            this.utilityTestType.Location = new System.Drawing.Point(88, 6);
            this.utilityTestType.Name = "utilityTestType";
            this.utilityTestType.Size = new System.Drawing.Size(159, 20);
            this.utilityTestType.TabIndex = 0;
            this.utilityTestType.Text = "Auto Test Settings";
            // 
            // textTotalUnitstoTest
            // 
            this.textTotalUnitstoTest.Location = new System.Drawing.Point(180, 81);
            this.textTotalUnitstoTest.MaxLength = 2;
            this.textTotalUnitstoTest.Name = "textTotalUnitstoTest";
            this.textTotalUnitstoTest.Size = new System.Drawing.Size(116, 21);
            this.textTotalUnitstoTest.TabIndex = 71;
            this.textTotalUnitstoTest.Text = "1";
            this.textTotalUnitstoTest.TextChanged += new System.EventHandler(this.textTotalUnitstoTest_TextChanged);
            this.textTotalUnitstoTest.Leave += new System.EventHandler(this.textTotalUnitstoTest_Leave);
            // 
            // textBoxTotalSPUsToTest
            // 
            this.textBoxTotalSPUsToTest.Location = new System.Drawing.Point(180, 46);
            this.textBoxTotalSPUsToTest.MaxLength = 1;
            this.textBoxTotalSPUsToTest.Name = "textBoxTotalSPUsToTest";
            this.textBoxTotalSPUsToTest.Size = new System.Drawing.Size(116, 21);
            this.textBoxTotalSPUsToTest.TabIndex = 70;
            this.textBoxTotalSPUsToTest.Text = "1";
            this.textBoxTotalSPUsToTest.TextChanged += new System.EventHandler(this.textBoxTotalSPUsToTest_TextChanged);
            this.textBoxTotalSPUsToTest.Leave += new System.EventHandler(this.textBoxTotalSPUsToTest_Leave);
            // 
            // textTotalServostoTest
            // 
            this.textTotalServostoTest.Location = new System.Drawing.Point(180, 118);
            this.textTotalServostoTest.MaxLength = 2;
            this.textTotalServostoTest.Name = "textTotalServostoTest";
            this.textTotalServostoTest.Size = new System.Drawing.Size(116, 21);
            this.textTotalServostoTest.TabIndex = 72;
            this.textTotalServostoTest.Text = "16";
            this.textTotalServostoTest.TextChanged += new System.EventHandler(this.textTotalServostoTest_TextChanged);
            this.textTotalServostoTest.Leave += new System.EventHandler(this.textTotalServostoTest_Leave);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(180, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 51);
            this.btnCancel.TabIndex = 74;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.btnOK.Location = new System.Drawing.Point(88, 368);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 51);
            this.btnOK.TabIndex = 73;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pnlWizardTitle
            // 
            this.pnlWizardTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlWizardTitle.Controls.Add(this.labeltitle);
            this.pnlWizardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWizardTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlWizardTitle.Name = "pnlWizardTitle";
            this.pnlWizardTitle.Size = new System.Drawing.Size(333, 31);
            this.pnlWizardTitle.TabIndex = 75;
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.Color.Black;
            this.labeltitle.Location = new System.Drawing.Point(88, 6);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(159, 20);
            this.labeltitle.TabIndex = 0;
            this.labeltitle.Text = "Auto Test Settings";
            // 
            // labelUnitsSweeps
            // 
            this.labelUnitsSweeps.ForeColor = System.Drawing.Color.White;
            this.labelUnitsSweeps.Location = new System.Drawing.Point(-3, 81);
            this.labelUnitsSweeps.Name = "labelUnitsSweeps";
            this.labelUnitsSweeps.Size = new System.Drawing.Size(163, 15);
            this.labelUnitsSweeps.TabIndex = 82;
            this.labelUnitsSweeps.Text = "Total Units to Test";
            this.labelUnitsSweeps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 15);
            this.label1.TabIndex = 81;
            this.label1.Text = "Total SPUs To Test";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-3, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 15);
            this.label3.TabIndex = 84;
            this.label3.Text = "Close Keys Up to";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelServoPorts
            // 
            this.labelServoPorts.ForeColor = System.Drawing.Color.White;
            this.labelServoPorts.Location = new System.Drawing.Point(-3, 124);
            this.labelServoPorts.Name = "labelServoPorts";
            this.labelServoPorts.Size = new System.Drawing.Size(163, 15);
            this.labelServoPorts.TabIndex = 83;
            this.labelServoPorts.Text = "Total Servos Per Unit";
            this.labelServoPorts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOpenKeysSweep
            // 
            this.labelOpenKeysSweep.ForeColor = System.Drawing.Color.White;
            this.labelOpenKeysSweep.Location = new System.Drawing.Point(-3, 303);
            this.labelOpenKeysSweep.Name = "labelOpenKeysSweep";
            this.labelOpenKeysSweep.Size = new System.Drawing.Size(163, 15);
            this.labelOpenKeysSweep.TabIndex = 88;
            this.labelOpenKeysSweep.Text = "Open Keys Up To";
            this.labelOpenKeysSweep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-3, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 15);
            this.label7.TabIndex = 87;
            this.label7.Text = "Loop type";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-3, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 15);
            this.label8.TabIndex = 86;
            this.label8.Text = "Number Of Cycles";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(-3, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 15);
            this.label9.TabIndex = 85;
            this.label9.Text = "Time Delay";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboCloseKeysUpTo
            // 
            this.comboCloseKeysUpTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCloseKeysUpTo.FormattingEnabled = true;
            this.comboCloseKeysUpTo.Items.AddRange(new object[] {
            "0",
            "0.1",
            "0.3"});
            this.comboCloseKeysUpTo.Location = new System.Drawing.Point(180, 153);
            this.comboCloseKeysUpTo.Name = "comboCloseKeysUpTo";
            this.comboCloseKeysUpTo.Size = new System.Drawing.Size(116, 23);
            this.comboCloseKeysUpTo.TabIndex = 89;
            this.comboCloseKeysUpTo.SelectedIndexChanged += new System.EventHandler(this.comboCloseKeysUpTo_SelectedIndexChanged);
            // 
            // comboTimeDelay
            // 
            this.comboTimeDelay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTimeDelay.FormattingEnabled = true;
            this.comboTimeDelay.Items.AddRange(new object[] {
            "1",
            "30",
            "60"});
            this.comboTimeDelay.Location = new System.Drawing.Point(180, 193);
            this.comboTimeDelay.Name = "comboTimeDelay";
            this.comboTimeDelay.Size = new System.Drawing.Size(116, 23);
            this.comboTimeDelay.TabIndex = 90;
            this.comboTimeDelay.SelectedIndexChanged += new System.EventHandler(this.comboTimeDelay_SelectedIndexChanged);
            // 
            // comboLooptype
            // 
            this.comboLooptype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLooptype.FormattingEnabled = true;
            this.comboLooptype.Items.AddRange(new object[] {
            "Sequential",
            "Simultaneous"});
            this.comboLooptype.Location = new System.Drawing.Point(180, 268);
            this.comboLooptype.Name = "comboLooptype";
            this.comboLooptype.Size = new System.Drawing.Size(116, 23);
            this.comboLooptype.TabIndex = 91;
            this.comboLooptype.SelectedIndexChanged += new System.EventHandler(this.comboLooptype_SelectedIndexChanged);
            // 
            // comboOpenKeysUpTo
            // 
            this.comboOpenKeysUpTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOpenKeysUpTo.FormattingEnabled = true;
            this.comboOpenKeysUpTo.Items.AddRange(new object[] {
            "630",
            "1000",
            "2982"});
            this.comboOpenKeysUpTo.Location = new System.Drawing.Point(180, 303);
            this.comboOpenKeysUpTo.Name = "comboOpenKeysUpTo";
            this.comboOpenKeysUpTo.Size = new System.Drawing.Size(116, 23);
            this.comboOpenKeysUpTo.TabIndex = 92;
            this.comboOpenKeysUpTo.SelectedIndexChanged += new System.EventHandler(this.comboOpenKeysUpTo_SelectedIndexChanged);
            // 
            // textNumberOfCycles
            // 
            this.textNumberOfCycles.Location = new System.Drawing.Point(180, 228);
            this.textNumberOfCycles.MaxLength = 3;
            this.textNumberOfCycles.Name = "textNumberOfCycles";
            this.textNumberOfCycles.Size = new System.Drawing.Size(116, 21);
            this.textNumberOfCycles.TabIndex = 94;
            this.textNumberOfCycles.Text = "1";
            this.textNumberOfCycles.TextChanged += new System.EventHandler(this.textNumberOfCycles_TextChanged);
            this.textNumberOfCycles.Leave += new System.EventHandler(this.textNumberOfCycles_Leave);
            // 
            // lbPercentag
            // 
            this.lbPercentag.ForeColor = System.Drawing.Color.White;
            this.lbPercentag.Location = new System.Drawing.Point(-2, 318);
            this.lbPercentag.Name = "lbPercentag";
            this.lbPercentag.Size = new System.Drawing.Size(163, 15);
            this.lbPercentag.TabIndex = 95;
            this.lbPercentag.Text = "( 0 - 99 %  )";
            this.lbPercentag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPercentag.Visible = false;
            // 
            // tbOpenUpTo
            // 
            this.tbOpenUpTo.Location = new System.Drawing.Point(180, 303);
            this.tbOpenUpTo.MaxLength = 2;
            this.tbOpenUpTo.Name = "tbOpenUpTo";
            this.tbOpenUpTo.Size = new System.Drawing.Size(116, 21);
            this.tbOpenUpTo.TabIndex = 96;
            this.tbOpenUpTo.Text = "1";
            this.tbOpenUpTo.Visible = false;
            this.tbOpenUpTo.TextChanged += new System.EventHandler(this.tbOpenUpTo_TextChanged);
            this.tbOpenUpTo.Leave += new System.EventHandler(this.tbOpenUpTo_Leave);
            // 
            // frmUtilityTestSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(333, 442);
            this.ControlBox = false;
            this.Controls.Add(this.tbOpenUpTo);
            this.Controls.Add(this.lbPercentag);
            this.Controls.Add(this.textNumberOfCycles);
            this.Controls.Add(this.comboOpenKeysUpTo);
            this.Controls.Add(this.comboLooptype);
            this.Controls.Add(this.comboTimeDelay);
            this.Controls.Add(this.comboCloseKeysUpTo);
            this.Controls.Add(this.labelOpenKeysSweep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelServoPorts);
            this.Controls.Add(this.labelUnitsSweeps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlWizardTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textTotalServostoTest);
            this.Controls.Add(this.textTotalUnitstoTest);
            this.Controls.Add(this.textBoxTotalSPUsToTest);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUtilityTestSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmUtilityTestSettings_Load);
            this.pnlWizardTitle.ResumeLayout(false);
            this.pnlWizardTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.Button btnCancel;
        //private System.Windows.Forms.TextBox txtBackOffInPulses;
        //private System.Windows.Forms.TextBox txtServoPulsesAtZoneZero;
        //private System.Windows.Forms.Label label12;
        //private System.Windows.Forms.TextBox txtDefaultOffset;
        //private System.Windows.Forms.Label label11;
        //private System.Windows.Forms.Label label7;
        //private System.Windows.Forms.Label label6;
        //private System.Windows.Forms.Button btnOK;
        //private System.Windows.Forms.TextBox txtMaxNeighborKeyDelta;
        //private System.Windows.Forms.TextBox txtBladeStiffness;
        //private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Panel pnlWizardTitle;
        private System.Windows.Forms.Label utilityTestType;
        private System.Windows.Forms.TextBox textTotalUnitstoTest;
        private System.Windows.Forms.TextBox textBoxTotalSPUsToTest;
        private System.Windows.Forms.TextBox textTotalServostoTest;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel pnlWizardTitle;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Label labelUnitsSweeps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelServoPorts;
        private System.Windows.Forms.Label labelOpenKeysSweep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboCloseKeysUpTo;
        private System.Windows.Forms.ComboBox comboTimeDelay;
        private System.Windows.Forms.ComboBox comboLooptype;
        private System.Windows.Forms.ComboBox comboOpenKeysUpTo;
        private System.Windows.Forms.TextBox textNumberOfCycles;
        private System.Windows.Forms.Label lbPercentag;
        private System.Windows.Forms.TextBox tbOpenUpTo;
        //private System.Windows.Forms.Label label4;

    }
}