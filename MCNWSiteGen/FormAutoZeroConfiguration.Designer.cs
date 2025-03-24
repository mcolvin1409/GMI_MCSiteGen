namespace MCNWSiteGen
{
    partial class FormAutoZeroConfiguration
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
            this.pnlWizardTitle = new System.Windows.Forms.Panel();
            this.titleAutoZeroConfig = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.checkAutoZero = new System.Windows.Forms.CheckBox();
            this.groupAutoZeroSettings = new System.Windows.Forms.GroupBox();
            this.rangeForFountainClose = new System.Windows.Forms.Label();
            this.textTimeDelayToCloseFountain = new System.Windows.Forms.TextBox();
            this.delayForTransitionToCloseFountain = new System.Windows.Forms.Label();
            this.rangeIdleThreshold = new System.Windows.Forms.Label();
            this.rangeFactorFrequency = new System.Windows.Forms.Label();
            this.rangePollPeriod = new System.Windows.Forms.Label();
            this.rangeTimeDelay = new System.Windows.Forms.Label();
            this.rangeDeviceID = new System.Windows.Forms.Label();
            this.comboDryContactIdleFpm = new System.Windows.Forms.ComboBox();
            this.dryContactIdleState = new System.Windows.Forms.Label();
            this.textIdleThresholdFPM = new System.Windows.Forms.TextBox();
            this.idleThresholdFPM = new System.Windows.Forms.Label();
            this.textFactorFrequency = new System.Windows.Forms.TextBox();
            this.factorFrequency = new System.Windows.Forms.Label();
            this.textPollPeriod = new System.Windows.Forms.TextBox();
            this.pollPeriod = new System.Windows.Forms.Label();
            this.textTimeDelay = new System.Windows.Forms.TextBox();
            this.timeDelay = new System.Windows.Forms.Label();
            this.textDeviceID = new System.Windows.Forms.TextBox();
            this.deviceID = new System.Windows.Forms.Label();
            this.textDeviceIPAddress = new System.Windows.Forms.TextBox();
            this.deviceIPAddress = new System.Windows.Forms.Label();
            this.comboAutoZeroMode = new System.Windows.Forms.ComboBox();
            this.autoZeroMode = new System.Windows.Forms.Label();
            this.groupBoxChannMap = new System.Windows.Forms.GroupBox();
            this.ListViewMapping = new MC3Components.Controls.MC3ListView();
            this.pnlWizardTitle.SuspendLayout();
            this.groupAutoZeroSettings.SuspendLayout();
            this.groupBoxChannMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWizardTitle
            // 
            this.pnlWizardTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlWizardTitle.Controls.Add(this.titleAutoZeroConfig);
            this.pnlWizardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWizardTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlWizardTitle.Name = "pnlWizardTitle";
            this.pnlWizardTitle.Size = new System.Drawing.Size(788, 31);
            this.pnlWizardTitle.TabIndex = 70;
            // 
            // titleAutoZeroConfig
            // 
            this.titleAutoZeroConfig.AutoSize = true;
            this.titleAutoZeroConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleAutoZeroConfig.ForeColor = System.Drawing.Color.Black;
            this.titleAutoZeroConfig.Location = new System.Drawing.Point(125, 6);
            this.titleAutoZeroConfig.Name = "titleAutoZeroConfig";
            this.titleAutoZeroConfig.Size = new System.Drawing.Size(192, 25);
            this.titleAutoZeroConfig.TabIndex = 0;
            this.titleAutoZeroConfig.Text = "Auto Zero Settings";
            this.titleAutoZeroConfig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(258, 523);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 51);
            this.btnCancel.TabIndex = 72;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.btnOK.Location = new System.Drawing.Point(95, 523);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 51);
            this.btnOK.TabIndex = 71;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // checkAutoZero
            // 
            this.checkAutoZero.AutoSize = true;
            this.checkAutoZero.ForeColor = System.Drawing.Color.White;
            this.checkAutoZero.Location = new System.Drawing.Point(15, 40);
            this.checkAutoZero.Name = "checkAutoZero";
            this.checkAutoZero.Size = new System.Drawing.Size(126, 22);
            this.checkAutoZero.TabIndex = 73;
            this.checkAutoZero.Text = "Use Auto Zero";
            this.checkAutoZero.UseVisualStyleBackColor = true;
            this.checkAutoZero.CheckedChanged += new System.EventHandler(this.checkAutoZero_CheckedChanged);
            // 
            // groupAutoZeroSettings
            // 
            this.groupAutoZeroSettings.Controls.Add(this.rangeForFountainClose);
            this.groupAutoZeroSettings.Controls.Add(this.textTimeDelayToCloseFountain);
            this.groupAutoZeroSettings.Controls.Add(this.delayForTransitionToCloseFountain);
            this.groupAutoZeroSettings.Controls.Add(this.rangeIdleThreshold);
            this.groupAutoZeroSettings.Controls.Add(this.rangeFactorFrequency);
            this.groupAutoZeroSettings.Controls.Add(this.rangePollPeriod);
            this.groupAutoZeroSettings.Controls.Add(this.rangeTimeDelay);
            this.groupAutoZeroSettings.Controls.Add(this.rangeDeviceID);
            this.groupAutoZeroSettings.Controls.Add(this.comboDryContactIdleFpm);
            this.groupAutoZeroSettings.Controls.Add(this.dryContactIdleState);
            this.groupAutoZeroSettings.Controls.Add(this.textIdleThresholdFPM);
            this.groupAutoZeroSettings.Controls.Add(this.idleThresholdFPM);
            this.groupAutoZeroSettings.Controls.Add(this.textFactorFrequency);
            this.groupAutoZeroSettings.Controls.Add(this.factorFrequency);
            this.groupAutoZeroSettings.Controls.Add(this.textPollPeriod);
            this.groupAutoZeroSettings.Controls.Add(this.pollPeriod);
            this.groupAutoZeroSettings.Controls.Add(this.textTimeDelay);
            this.groupAutoZeroSettings.Controls.Add(this.timeDelay);
            this.groupAutoZeroSettings.Controls.Add(this.textDeviceID);
            this.groupAutoZeroSettings.Controls.Add(this.deviceID);
            this.groupAutoZeroSettings.Controls.Add(this.textDeviceIPAddress);
            this.groupAutoZeroSettings.Controls.Add(this.deviceIPAddress);
            this.groupAutoZeroSettings.Controls.Add(this.comboAutoZeroMode);
            this.groupAutoZeroSettings.Controls.Add(this.autoZeroMode);
            this.groupAutoZeroSettings.ForeColor = System.Drawing.Color.White;
            this.groupAutoZeroSettings.Location = new System.Drawing.Point(16, 65);
            this.groupAutoZeroSettings.Name = "groupAutoZeroSettings";
            this.groupAutoZeroSettings.Size = new System.Drawing.Size(375, 433);
            this.groupAutoZeroSettings.TabIndex = 74;
            this.groupAutoZeroSettings.TabStop = false;
            this.groupAutoZeroSettings.Text = "Auto Zero Settings";
            // 
            // rangeForFountainClose
            // 
            this.rangeForFountainClose.AutoSize = true;
            this.rangeForFountainClose.Location = new System.Drawing.Point(18, 356);
            this.rangeForFountainClose.Name = "rangeForFountainClose";
            this.rangeForFountainClose.Size = new System.Drawing.Size(103, 18);
            this.rangeForFountainClose.TabIndex = 23;
            this.rangeForFountainClose.Text = "( 0 to 600000 )";
            // 
            // textTimeDelayToCloseFountain
            // 
            this.textTimeDelayToCloseFountain.Location = new System.Drawing.Point(183, 328);
            this.textTimeDelayToCloseFountain.MaxLength = 6;
            this.textTimeDelayToCloseFountain.Name = "textTimeDelayToCloseFountain";
            this.textTimeDelayToCloseFountain.Size = new System.Drawing.Size(121, 24);
            this.textTimeDelayToCloseFountain.TabIndex = 15;
            this.textTimeDelayToCloseFountain.TextChanged += new System.EventHandler(this.textTimeDelayToCloseFountain_TextChanged);
            // 
            // delayForTransitionToCloseFountain
            // 
            this.delayForTransitionToCloseFountain.AutoEllipsis = true;
            this.delayForTransitionToCloseFountain.Location = new System.Drawing.Point(16, 323);
            this.delayForTransitionToCloseFountain.Name = "delayForTransitionToCloseFountain";
            this.delayForTransitionToCloseFountain.Size = new System.Drawing.Size(141, 33);
            this.delayForTransitionToCloseFountain.TabIndex = 14;
            this.delayForTransitionToCloseFountain.Text = "Delay for Transition to Fountain Close (msec)";
            // 
            // rangeIdleThreshold
            // 
            this.rangeIdleThreshold.AutoSize = true;
            this.rangeIdleThreshold.Location = new System.Drawing.Point(16, 298);
            this.rangeIdleThreshold.Name = "rangeIdleThreshold";
            this.rangeIdleThreshold.Size = new System.Drawing.Size(79, 18);
            this.rangeIdleThreshold.TabIndex = 20;
            this.rangeIdleThreshold.Text = "( 0 - 1000 )";
            // 
            // rangeFactorFrequency
            // 
            this.rangeFactorFrequency.AutoSize = true;
            this.rangeFactorFrequency.Location = new System.Drawing.Point(16, 258);
            this.rangeFactorFrequency.Name = "rangeFactorFrequency";
            this.rangeFactorFrequency.Size = new System.Drawing.Size(87, 18);
            this.rangeFactorFrequency.TabIndex = 19;
            this.rangeFactorFrequency.Text = "( 0 - 10000 )";
            // 
            // rangePollPeriod
            // 
            this.rangePollPeriod.AutoSize = true;
            this.rangePollPeriod.Location = new System.Drawing.Point(16, 214);
            this.rangePollPeriod.Name = "rangePollPeriod";
            this.rangePollPeriod.Size = new System.Drawing.Size(87, 18);
            this.rangePollPeriod.TabIndex = 18;
            this.rangePollPeriod.Text = "( 0 - 10000 )";
            // 
            // rangeTimeDelay
            // 
            this.rangeTimeDelay.AutoSize = true;
            this.rangeTimeDelay.Location = new System.Drawing.Point(16, 168);
            this.rangeTimeDelay.Name = "rangeTimeDelay";
            this.rangeTimeDelay.Size = new System.Drawing.Size(87, 18);
            this.rangeTimeDelay.TabIndex = 17;
            this.rangeTimeDelay.Text = "( 0 - 10000 )";
            // 
            // rangeDeviceID
            // 
            this.rangeDeviceID.AutoSize = true;
            this.rangeDeviceID.Location = new System.Drawing.Point(18, 122);
            this.rangeDeviceID.Name = "rangeDeviceID";
            this.rangeDeviceID.Size = new System.Drawing.Size(63, 18);
            this.rangeDeviceID.TabIndex = 16;
            this.rangeDeviceID.Text = "( 0 - 10 )";
            // 
            // comboDryContactIdleFpm
            // 
            this.comboDryContactIdleFpm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDryContactIdleFpm.FormattingEnabled = true;
            this.comboDryContactIdleFpm.ItemHeight = 18;
            this.comboDryContactIdleFpm.Items.AddRange(new object[] {
            "OPEN",
            "CLOSED"});
            this.comboDryContactIdleFpm.Location = new System.Drawing.Point(183, 384);
            this.comboDryContactIdleFpm.Name = "comboDryContactIdleFpm";
            this.comboDryContactIdleFpm.Size = new System.Drawing.Size(121, 26);
            this.comboDryContactIdleFpm.TabIndex = 17;
            // 
            // dryContactIdleState
            // 
            this.dryContactIdleState.AutoSize = true;
            this.dryContactIdleState.Location = new System.Drawing.Point(16, 385);
            this.dryContactIdleState.Name = "dryContactIdleState";
            this.dryContactIdleState.Size = new System.Drawing.Size(187, 18);
            this.dryContactIdleState.TabIndex = 16;
            this.dryContactIdleState.Text = "Press IDLE on Dry Contact";
            // 
            // textIdleThresholdFPM
            // 
            this.textIdleThresholdFPM.Location = new System.Drawing.Point(183, 282);
            this.textIdleThresholdFPM.MaxLength = 4;
            this.textIdleThresholdFPM.Name = "textIdleThresholdFPM";
            this.textIdleThresholdFPM.Size = new System.Drawing.Size(121, 24);
            this.textIdleThresholdFPM.TabIndex = 13;
            this.textIdleThresholdFPM.TextChanged += new System.EventHandler(this.textIdleThresholdFPM_TextChanged);
            // 
            // idleThresholdFPM
            // 
            this.idleThresholdFPM.AutoSize = true;
            this.idleThresholdFPM.Location = new System.Drawing.Point(16, 283);
            this.idleThresholdFPM.Name = "idleThresholdFPM";
            this.idleThresholdFPM.Size = new System.Drawing.Size(136, 18);
            this.idleThresholdFPM.TabIndex = 12;
            this.idleThresholdFPM.Text = "Idle Threshold FPM";
            // 
            // textFactorFrequency
            // 
            this.textFactorFrequency.Location = new System.Drawing.Point(183, 243);
            this.textFactorFrequency.MaxLength = 5;
            this.textFactorFrequency.Name = "textFactorFrequency";
            this.textFactorFrequency.Size = new System.Drawing.Size(121, 24);
            this.textFactorFrequency.TabIndex = 11;
            this.textFactorFrequency.TextChanged += new System.EventHandler(this.textFactorFrequency_TextChanged);
            // 
            // factorFrequency
            // 
            this.factorFrequency.AutoSize = true;
            this.factorFrequency.Location = new System.Drawing.Point(16, 243);
            this.factorFrequency.Name = "factorFrequency";
            this.factorFrequency.Size = new System.Drawing.Size(124, 18);
            this.factorFrequency.TabIndex = 10;
            this.factorFrequency.Text = "Factor Frequency";
            // 
            // textPollPeriod
            // 
            this.textPollPeriod.Location = new System.Drawing.Point(183, 198);
            this.textPollPeriod.MaxLength = 5;
            this.textPollPeriod.Name = "textPollPeriod";
            this.textPollPeriod.Size = new System.Drawing.Size(121, 24);
            this.textPollPeriod.TabIndex = 9;
            this.textPollPeriod.TextChanged += new System.EventHandler(this.textPollPeriod_TextChanged);
            // 
            // pollPeriod
            // 
            this.pollPeriod.AutoSize = true;
            this.pollPeriod.Location = new System.Drawing.Point(16, 199);
            this.pollPeriod.Name = "pollPeriod";
            this.pollPeriod.Size = new System.Drawing.Size(139, 18);
            this.pollPeriod.TabIndex = 8;
            this.pollPeriod.Text = "Poll Period ( msec )";
            // 
            // textTimeDelay
            // 
            this.textTimeDelay.Location = new System.Drawing.Point(183, 152);
            this.textTimeDelay.MaxLength = 5;
            this.textTimeDelay.Name = "textTimeDelay";
            this.textTimeDelay.Size = new System.Drawing.Size(121, 24);
            this.textTimeDelay.TabIndex = 7;
            this.textTimeDelay.TextChanged += new System.EventHandler(this.textTimeDelay_TextChanged);
            // 
            // timeDelay
            // 
            this.timeDelay.AutoSize = true;
            this.timeDelay.Location = new System.Drawing.Point(16, 152);
            this.timeDelay.Name = "timeDelay";
            this.timeDelay.Size = new System.Drawing.Size(141, 18);
            this.timeDelay.TabIndex = 6;
            this.timeDelay.Text = "Time Delay ( msec )";
            // 
            // textDeviceID
            // 
            this.textDeviceID.Location = new System.Drawing.Point(183, 111);
            this.textDeviceID.MaxLength = 2;
            this.textDeviceID.Name = "textDeviceID";
            this.textDeviceID.Size = new System.Drawing.Size(121, 24);
            this.textDeviceID.TabIndex = 5;
            this.textDeviceID.TextChanged += new System.EventHandler(this.textDeviceID_TextChanged);
            // 
            // deviceID
            // 
            this.deviceID.AutoSize = true;
            this.deviceID.Location = new System.Drawing.Point(16, 107);
            this.deviceID.Name = "deviceID";
            this.deviceID.Size = new System.Drawing.Size(71, 18);
            this.deviceID.TabIndex = 4;
            this.deviceID.Text = "Device ID";
            // 
            // textDeviceIPAddress
            // 
            this.textDeviceIPAddress.Location = new System.Drawing.Point(183, 71);
            this.textDeviceIPAddress.MaxLength = 15;
            this.textDeviceIPAddress.Name = "textDeviceIPAddress";
            this.textDeviceIPAddress.Size = new System.Drawing.Size(121, 24);
            this.textDeviceIPAddress.TabIndex = 3;
            this.textDeviceIPAddress.TextChanged += new System.EventHandler(this.textDeviceIPAddress_TextChanged);
            // 
            // deviceIPAddress
            // 
            this.deviceIPAddress.AutoSize = true;
            this.deviceIPAddress.Location = new System.Drawing.Point(16, 72);
            this.deviceIPAddress.Name = "deviceIPAddress";
            this.deviceIPAddress.Size = new System.Drawing.Size(164, 18);
            this.deviceIPAddress.TabIndex = 2;
            this.deviceIPAddress.Text = "PRESSNET IP Address";
            // 
            // comboAutoZeroMode
            // 
            this.comboAutoZeroMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAutoZeroMode.FormattingEnabled = true;
            this.comboAutoZeroMode.Items.AddRange(new object[] {
            "DRY CONTACT",
            "FREQUENCY",
            "DRY CONTACT + FREQUENCY"});
            this.comboAutoZeroMode.Location = new System.Drawing.Point(183, 34);
            this.comboAutoZeroMode.Name = "comboAutoZeroMode";
            this.comboAutoZeroMode.Size = new System.Drawing.Size(179, 26);
            this.comboAutoZeroMode.TabIndex = 1;
            // 
            // autoZeroMode
            // 
            this.autoZeroMode.AutoSize = true;
            this.autoZeroMode.Location = new System.Drawing.Point(16, 37);
            this.autoZeroMode.Name = "autoZeroMode";
            this.autoZeroMode.Size = new System.Drawing.Size(46, 18);
            this.autoZeroMode.TabIndex = 0;
            this.autoZeroMode.Text = "Mode";
            // 
            // groupBoxChannMap
            // 
            this.groupBoxChannMap.Controls.Add(this.ListViewMapping);
            this.groupBoxChannMap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChannMap.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxChannMap.Location = new System.Drawing.Point(429, 67);
            this.groupBoxChannMap.Name = "groupBoxChannMap";
            this.groupBoxChannMap.Size = new System.Drawing.Size(340, 431);
            this.groupBoxChannMap.TabIndex = 75;
            this.groupBoxChannMap.TabStop = false;
            this.groupBoxChannMap.Text = "Channel Mapping";
            // 
            // ListViewMapping
            // 
            this.ListViewMapping.AllowColumnResize = true;
            this.ListViewMapping.AllowMultiselect = false;
            this.ListViewMapping.AlternateBackground = System.Drawing.Color.DarkGreen;
            this.ListViewMapping.AlternatingColors = false;
            this.ListViewMapping.AutoHeight = true;
            this.ListViewMapping.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ListViewMapping.BackgroundStretchToFit = true;
            this.ListViewMapping.ControlStyle = MC3Components.Controls.GLControlStyles.Normal;
            this.ListViewMapping.ForeColor = System.Drawing.Color.Black;
            this.ListViewMapping.FullRowSelect = false;
            this.ListViewMapping.GridColor = System.Drawing.Color.LightGray;
            this.ListViewMapping.GridLines = MC3Components.Controls.GLGridLines.gridBoth;
            this.ListViewMapping.GridLineStyle = MC3Components.Controls.GLGridLineStyles.gridSolid;
            this.ListViewMapping.GridTypes = MC3Components.Controls.GLGridTypes.gridOnExists;
            this.ListViewMapping.HeaderHeight = 35;
            this.ListViewMapping.HeaderVisible = true;
            this.ListViewMapping.HeaderWordWrap = true;
            this.ListViewMapping.HotColumnTracking = false;
            this.ListViewMapping.HotItemTracking = false;
            this.ListViewMapping.HotTrackingColor = System.Drawing.Color.LightGray;
            this.ListViewMapping.HoverEvents = false;
            this.ListViewMapping.HoverTime = 1;
            this.ListViewMapping.ImageList = null;
            this.ListViewMapping.ItemHeight = 16;
            this.ListViewMapping.ItemWordWrap = false;
            this.ListViewMapping.Location = new System.Drawing.Point(22, 69);
            this.ListViewMapping.Name = "ListViewMapping";
            this.ListViewMapping.Selectable = true;
            this.ListViewMapping.SelectedTextColor = System.Drawing.Color.White;
            this.ListViewMapping.SelectionColor = System.Drawing.SystemColors.Highlight;
            this.ListViewMapping.ShowBorder = true;
            this.ListViewMapping.ShowFocusRect = false;
            this.ListViewMapping.Size = new System.Drawing.Size(295, 295);
            this.ListViewMapping.SortType = MC3Components.Controls.SortTypes.None;
            this.ListViewMapping.SuperFlatHeaderColor = System.Drawing.Color.White;
            this.ListViewMapping.TabIndex = 35;
            this.ListViewMapping.Text = "mC3ListView1";
            // 
            // FormAutoZeroConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(788, 590);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxChannMap);
            this.Controls.Add(this.checkAutoZero);
            this.Controls.Add(this.groupAutoZeroSettings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pnlWizardTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAutoZeroConfiguration";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormAutoZeroConfiguration_Load);
            this.pnlWizardTitle.ResumeLayout(false);
            this.pnlWizardTitle.PerformLayout();
            this.groupAutoZeroSettings.ResumeLayout(false);
            this.groupAutoZeroSettings.PerformLayout();
            this.groupBoxChannMap.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlWizardTitle;
        private System.Windows.Forms.Label titleAutoZeroConfig;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox checkAutoZero;
        private System.Windows.Forms.GroupBox groupAutoZeroSettings;
        private System.Windows.Forms.Label autoZeroMode;
        private System.Windows.Forms.Label deviceIPAddress;
        private System.Windows.Forms.ComboBox comboAutoZeroMode;
        private System.Windows.Forms.TextBox textIdleThresholdFPM;
        private System.Windows.Forms.Label idleThresholdFPM;
        private System.Windows.Forms.TextBox textFactorFrequency;
        private System.Windows.Forms.Label factorFrequency;
        private System.Windows.Forms.TextBox textPollPeriod;
        private System.Windows.Forms.Label pollPeriod;
        private System.Windows.Forms.TextBox textTimeDelay;
        private System.Windows.Forms.Label timeDelay;
        private System.Windows.Forms.TextBox textDeviceID;
        private System.Windows.Forms.Label deviceID;
        private System.Windows.Forms.TextBox textDeviceIPAddress;
        private System.Windows.Forms.Label dryContactIdleState;
        private System.Windows.Forms.ComboBox comboDryContactIdleFpm;
        private System.Windows.Forms.Label rangeIdleThreshold;
        private System.Windows.Forms.Label rangeFactorFrequency;
        private System.Windows.Forms.Label rangePollPeriod;
        private System.Windows.Forms.Label rangeTimeDelay;
        private System.Windows.Forms.Label rangeDeviceID;
        private System.Windows.Forms.Label delayForTransitionToCloseFountain;
        private System.Windows.Forms.Label rangeForFountainClose;
        private System.Windows.Forms.TextBox textTimeDelayToCloseFountain;
        private System.Windows.Forms.GroupBox groupBoxChannMap;
        private MC3Components.Controls.MC3ListView ListViewMapping;//WI30488
    }
}