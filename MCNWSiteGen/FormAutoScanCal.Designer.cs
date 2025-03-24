namespace MCNWSiteGen
{
    partial class FormAutoScanCal
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
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.gpMotorOrServoSettings = new System.Windows.Forms.GroupBox();
            this.checkASC = new System.Windows.Forms.CheckBox();
            this.checkBoxImpositionData = new System.Windows.Forms.CheckBox();
            this.btnImpoPathBrows = new System.Windows.Forms.Button();
            this.textBoxImpo = new System.Windows.Forms.TextBox();
            this.labelImpo = new System.Windows.Forms.Label();
            this.ListViewInkers = new MC3Components.Controls.MC3ListView();
            this.comboBoxWebType = new System.Windows.Forms.ComboBox();
            this.comboBoxScanSweepAdjust = new System.Windows.Forms.ComboBox();
            this.btnCip3ImagesPathBrows = new System.Windows.Forms.Button();
            this.btnCip3PathBrows = new System.Windows.Forms.Button();
            this.textBoxCip3ImagesPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBladeTolerance = new System.Windows.Forms.TextBox();
            this.textBoxCip3Path = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSweepDefault = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEWMAFilterParam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSweepZoneRatio = new System.Windows.Forms.TextBox();
            this.comboEnableLimitCheck = new System.Windows.Forms.ComboBox();
            this.textBoxZoneMargin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxWebType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlWizardTitle = new System.Windows.Forms.Panel();
            this.checkEnabled = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gpMotorOrServoSettings.SuspendLayout();
            this.pnlWizardTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(346, 546);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 51);
            this.btnCancel.TabIndex = 84;
            this.toolTip1.SetToolTip(this.btnCancel, "Cancel changes");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.btnOK.Location = new System.Drawing.Point(263, 546);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 51);
            this.btnOK.TabIndex = 83;
            this.toolTip1.SetToolTip(this.btnOK, "Save changes");
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(262, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(135, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "CIP3 Presetting";
            // 
            // gpMotorOrServoSettings
            // 
            this.gpMotorOrServoSettings.Controls.Add(this.checkBoxImpositionData);
            this.gpMotorOrServoSettings.Controls.Add(this.btnImpoPathBrows);
            this.gpMotorOrServoSettings.Controls.Add(this.textBoxImpo);
            this.gpMotorOrServoSettings.Controls.Add(this.labelImpo);
            this.gpMotorOrServoSettings.Controls.Add(this.ListViewInkers);
            this.gpMotorOrServoSettings.Controls.Add(this.comboBoxWebType);
            this.gpMotorOrServoSettings.Controls.Add(this.comboBoxScanSweepAdjust);
            this.gpMotorOrServoSettings.Controls.Add(this.btnCip3ImagesPathBrows);
            this.gpMotorOrServoSettings.Controls.Add(this.btnCip3PathBrows);
            this.gpMotorOrServoSettings.Controls.Add(this.textBoxCip3ImagesPath);
            this.gpMotorOrServoSettings.Controls.Add(this.label4);
            this.gpMotorOrServoSettings.Controls.Add(this.textBoxBladeTolerance);
            this.gpMotorOrServoSettings.Controls.Add(this.textBoxCip3Path);
            this.gpMotorOrServoSettings.Controls.Add(this.label6);
            this.gpMotorOrServoSettings.Controls.Add(this.label7);
            this.gpMotorOrServoSettings.Controls.Add(this.textBoxSweepDefault);
            this.gpMotorOrServoSettings.Controls.Add(this.label9);
            this.gpMotorOrServoSettings.Controls.Add(this.label10);
            this.gpMotorOrServoSettings.Controls.Add(this.textBoxEWMAFilterParam);
            this.gpMotorOrServoSettings.Controls.Add(this.label5);
            this.gpMotorOrServoSettings.Controls.Add(this.label8);
            this.gpMotorOrServoSettings.Controls.Add(this.textBoxSweepZoneRatio);
            this.gpMotorOrServoSettings.Controls.Add(this.comboEnableLimitCheck);
            this.gpMotorOrServoSettings.Controls.Add(this.textBoxZoneMargin);
            this.gpMotorOrServoSettings.Controls.Add(this.label3);
            this.gpMotorOrServoSettings.Controls.Add(this.label2);
            this.gpMotorOrServoSettings.Controls.Add(this.label1);
            this.gpMotorOrServoSettings.ForeColor = System.Drawing.Color.White;
            this.gpMotorOrServoSettings.Location = new System.Drawing.Point(19, 77);
            this.gpMotorOrServoSettings.Name = "gpMotorOrServoSettings";
            this.gpMotorOrServoSettings.Size = new System.Drawing.Size(677, 449);
            this.gpMotorOrServoSettings.TabIndex = 82;
            this.gpMotorOrServoSettings.TabStop = false;
            this.gpMotorOrServoSettings.Text = "CIP3 Preset and ASC settings - GMINET network";
            // 
            // checkASC
            // 
            this.checkASC.AutoSize = true;
            this.checkASC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkASC.Location = new System.Drawing.Point(223, 54);
            this.checkASC.Name = "checkASC";
            this.checkASC.Size = new System.Drawing.Size(194, 17);
            this.checkASC.TabIndex = 86;
            this.checkASC.Text = "Enable Auto Scan Calibration (ASC)";
            this.toolTip1.SetToolTip(this.checkASC, "Enable Auto Scan Calibration to adjust paper corrections upon ending forms");
            this.checkASC.UseVisualStyleBackColor = true;
            this.checkASC.CheckedChanged += new System.EventHandler( OnASC_CheckedChanged );
            // 
            // checkBoxImpositionData
            // 
            this.checkBoxImpositionData.AutoSize = true;
            this.checkBoxImpositionData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxImpositionData.Location = new System.Drawing.Point(7, 392);
            this.checkBoxImpositionData.Name = "checkBoxImpositionData";
            this.checkBoxImpositionData.Size = new System.Drawing.Size(171, 17);
            this.checkBoxImpositionData.TabIndex = 86;
            this.checkBoxImpositionData.Text = "Enable Use Of Imposition Data";
            this.checkBoxImpositionData.UseVisualStyleBackColor = true;
            this.checkBoxImpositionData.CheckedChanged += new System.EventHandler(this.checkBoxImpositionData_CheckedChanged);
            // 
            // btnImpoPathBrows
            // 
            this.btnImpoPathBrows.Enabled = false;
            this.btnImpoPathBrows.ForeColor = System.Drawing.Color.Black;
            this.btnImpoPathBrows.Location = new System.Drawing.Point(607, 416);
            this.btnImpoPathBrows.Name = "btnImpoPathBrows";
            this.btnImpoPathBrows.Size = new System.Drawing.Size(61, 23);
            this.btnImpoPathBrows.TabIndex = 37;
            this.btnImpoPathBrows.Text = "Browse ..";
            this.btnImpoPathBrows.UseVisualStyleBackColor = true;
            this.btnImpoPathBrows.Click += new System.EventHandler(this.btnImpoPathBrows_Click);
            // 
            // textBoxImpo
            // 
            this.textBoxImpo.Enabled = false;
            this.textBoxImpo.ForeColor = System.Drawing.Color.Black;
            this.textBoxImpo.Location = new System.Drawing.Point(169, 416);
            this.textBoxImpo.MaxLength = 100;
            this.textBoxImpo.Name = "textBoxImpo";
            this.textBoxImpo.Size = new System.Drawing.Size(427, 20);
            this.textBoxImpo.TabIndex = 36;
            this.textBoxImpo.Leave += new System.EventHandler(this.ImpotextBox_Leave);
            // 
            // labelImpo
            // 
            this.labelImpo.Enabled = false;
            this.labelImpo.Location = new System.Drawing.Point(8, 420);
            this.labelImpo.Name = "labelImpo";
            this.labelImpo.Size = new System.Drawing.Size(137, 13);
            this.labelImpo.TabIndex = 35;
            this.labelImpo.Text = "Imposition Data Path";
            this.labelImpo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ListViewInkers
            // 
            this.ListViewInkers.AllowColumnResize = true;
            this.ListViewInkers.AllowMultiselect = false;
            this.ListViewInkers.AlternateBackground = System.Drawing.Color.DarkGreen;
            this.ListViewInkers.AlternatingColors = false;
            this.ListViewInkers.AutoHeight = true;
            this.ListViewInkers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ListViewInkers.BackgroundStretchToFit = true;
            this.ListViewInkers.ControlStyle = MC3Components.Controls.GLControlStyles.Normal;
            this.ListViewInkers.ForeColor = System.Drawing.Color.Black;
            this.ListViewInkers.FullRowSelect = false;
            this.ListViewInkers.GridColor = System.Drawing.Color.LightGray;
            this.ListViewInkers.GridLines = MC3Components.Controls.GLGridLines.gridBoth;
            this.ListViewInkers.GridLineStyle = MC3Components.Controls.GLGridLineStyles.gridSolid;
            this.ListViewInkers.GridTypes = MC3Components.Controls.GLGridTypes.gridOnExists;
            this.ListViewInkers.HeaderHeight = 35;
            this.ListViewInkers.HeaderVisible = true;
            this.ListViewInkers.HeaderWordWrap = true;
            this.ListViewInkers.HotColumnTracking = false;
            this.ListViewInkers.HotItemTracking = false;
            this.ListViewInkers.HotTrackingColor = System.Drawing.Color.LightGray;
            this.ListViewInkers.HoverEvents = false;
            this.ListViewInkers.HoverTime = 1;
            this.ListViewInkers.ImageList = null;
            this.ListViewInkers.ItemHeight = 16;
            this.ListViewInkers.ItemWordWrap = false;
            this.ListViewInkers.Location = new System.Drawing.Point(374, 31);
            this.ListViewInkers.Name = "ListViewInkers";
            this.ListViewInkers.Selectable = true;
            this.ListViewInkers.SelectedTextColor = System.Drawing.Color.White;
            this.ListViewInkers.SelectionColor = System.Drawing.SystemColors.Highlight;
            this.ListViewInkers.ShowBorder = true;
            this.ListViewInkers.ShowFocusRect = false;
            this.ListViewInkers.Size = new System.Drawing.Size(295, 295);
            this.ListViewInkers.SortType = MC3Components.Controls.SortTypes.None;
            this.ListViewInkers.SuperFlatHeaderColor = System.Drawing.Color.White;
            this.ListViewInkers.TabIndex = 34;
            this.ListViewInkers.Text = "mC3ListView1";
            // 
            // comboBoxWebType
            // 
            this.comboBoxWebType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWebType.FormattingEnabled = true;
            this.comboBoxWebType.Items.AddRange(new object[] {
            "SHEETFED",
            "SINGLE_WEB_PRESS",
            "TWO_WEB_SPLIT_PRESS"});
            this.comboBoxWebType.Location = new System.Drawing.Point(512, 596);
            this.comboBoxWebType.Name = "comboBoxWebType";
            this.comboBoxWebType.Size = new System.Drawing.Size(184, 21);
            this.comboBoxWebType.TabIndex = 33;
            this.toolTip1.SetToolTip(this.comboBoxWebType, "Press type for preset (# sides)");
            this.comboBoxWebType.Visible = true;
            this.comboBoxWebType.TextChanged += new System.EventHandler(this.comboBoxWebType_TextChanged);
            // 
            // comboBoxScanSweepAdjust
            // 
            this.comboBoxScanSweepAdjust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScanSweepAdjust.FormattingEnabled = true;
            this.comboBoxScanSweepAdjust.Items.AddRange(new object[] {
            "SCAN_SWEEP_DEFAULT",
            "SCAN_SWEEP_ADJUST",
            "SCAN_SWEEP_RETAIN"});
            this.comboBoxScanSweepAdjust.Location = new System.Drawing.Point(170, 168);
            this.comboBoxScanSweepAdjust.Name = "comboBoxScanSweepAdjust";
            this.comboBoxScanSweepAdjust.Size = new System.Drawing.Size(184, 21);
            this.comboBoxScanSweepAdjust.TabIndex = 32;
            this.toolTip1.SetToolTip(this.comboBoxScanSweepAdjust, "Effect on sweeps for presetting (default, retain, ASC adjusted)");
            this.comboBoxScanSweepAdjust.TextChanged += new System.EventHandler(this.comboBoxScanSweepAdjust_TextChanged);
            // 
            // btnCip3ImagesPathBrows
            // 
            this.btnCip3ImagesPathBrows.ForeColor = System.Drawing.Color.Black;
            this.btnCip3ImagesPathBrows.Location = new System.Drawing.Point(608, 361);
            this.btnCip3ImagesPathBrows.Name = "btnCip3ImagesPathBrows";
            this.btnCip3ImagesPathBrows.Size = new System.Drawing.Size(61, 23);
            this.btnCip3ImagesPathBrows.TabIndex = 31;
            this.btnCip3ImagesPathBrows.Text = "Browse ..";
            this.btnCip3ImagesPathBrows.UseVisualStyleBackColor = true;
            this.btnCip3ImagesPathBrows.Click += new System.EventHandler(this.btnCip3ImagesPathBrows_Click);
            // 
            // btnCip3PathBrows
            // 
            this.btnCip3PathBrows.ForeColor = System.Drawing.Color.Black;
            this.btnCip3PathBrows.Location = new System.Drawing.Point(608, 331);
            this.btnCip3PathBrows.Name = "btnCip3PathBrows";
            this.btnCip3PathBrows.Size = new System.Drawing.Size(61, 23);
            this.btnCip3PathBrows.TabIndex = 30;
            this.btnCip3PathBrows.Text = "Browse ..";
            this.btnCip3PathBrows.UseVisualStyleBackColor = true;
            this.btnCip3PathBrows.Click += new System.EventHandler(this.btnCip3PathBrows_Click);
            // 
            // textBoxCip3ImagesPath
            // 
            this.textBoxCip3ImagesPath.AcceptsReturn = true;
            this.textBoxCip3ImagesPath.ForeColor = System.Drawing.Color.Black;
            this.textBoxCip3ImagesPath.Location = new System.Drawing.Point(170, 363);
            this.textBoxCip3ImagesPath.MaxLength = 100;
            this.textBoxCip3ImagesPath.Name = "textBoxCip3ImagesPath";
            this.textBoxCip3ImagesPath.Size = new System.Drawing.Size(427, 20);
            this.textBoxCip3ImagesPath.TabIndex = 29;
            this.toolTip1.SetToolTip(this.textBoxCip3ImagesPath, "Location of preset images AFTER preset");
            this.textBoxCip3ImagesPath.Leave += new System.EventHandler(this.textBoxCip3ImagesPath_Leave);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "CIP3 Images Path";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxBladeTolerance
            // 
            this.textBoxBladeTolerance.Location = new System.Drawing.Point(170, 289);
            this.textBoxBladeTolerance.MaxLength = 5;
            this.textBoxBladeTolerance.Name = "textBoxBladeTolerance";
            this.textBoxBladeTolerance.Size = new System.Drawing.Size(185, 20);
            this.textBoxBladeTolerance.TabIndex = 27;
            this.toolTip1.SetToolTip(this.textBoxBladeTolerance, "Zone smoothing of preset values");
            this.textBoxBladeTolerance.TextChanged += new System.EventHandler(this.textBoxBladeTolerance_TextChanged);
            this.textBoxBladeTolerance.Leave += new System.EventHandler(this.textBoxBladeTolerance_Leave);
            // 
            // textBoxCip3Path
            // 
            this.textBoxCip3Path.ForeColor = System.Drawing.Color.Black;
            this.textBoxCip3Path.Location = new System.Drawing.Point(170, 331);
            this.textBoxCip3Path.MaxLength = 100;
            this.textBoxCip3Path.Name = "textBoxCip3Path";
            this.textBoxCip3Path.Size = new System.Drawing.Size(427, 20);
            this.textBoxCip3Path.TabIndex = 26;
            this.toolTip1.SetToolTip(this.textBoxCip3Path, "Location of the server preset values and images");
            this.textBoxCip3Path.Leave += new System.EventHandler(this.textBoxCip3Path_Leave);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "CIP3 Path";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Blade Tolerance";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSweepDefault
            // 
            this.textBoxSweepDefault.Location = new System.Drawing.Point(170, 210);
            this.textBoxSweepDefault.MaxLength = 5;
            this.textBoxSweepDefault.Name = "textBoxSweepDefault";
            this.textBoxSweepDefault.Size = new System.Drawing.Size(184, 20);
            this.textBoxSweepDefault.TabIndex = 23;
            this.toolTip1.SetToolTip(this.textBoxSweepDefault, "Default sweep value at time of preset");
            this.textBoxSweepDefault.TextChanged += new System.EventHandler(this.textBoxSweepDefault_TextChanged);
            this.textBoxSweepDefault.Leave += new System.EventHandler(this.textBoxSweepDefault_Leave);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(351, 600);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Web Type";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(9, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Sweep Default";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxEWMAFilterParam
            // 
            this.textBoxEWMAFilterParam.Location = new System.Drawing.Point(170, 122);
            this.textBoxEWMAFilterParam.MaxLength = 5;
            this.textBoxEWMAFilterParam.Name = "textBoxEWMAFilterParam";
            this.textBoxEWMAFilterParam.Size = new System.Drawing.Size(185, 20);
            this.textBoxEWMAFilterParam.TabIndex = 19;
            this.toolTip1.SetToolTip(this.textBoxEWMAFilterParam, "Learning factor (0.0 to 1.0), weight of averaging during ASC (normally 0.5, 0.0 t" +
        "o disable, 1.0 to use last form difference)");
            this.textBoxEWMAFilterParam.TextChanged += new System.EventHandler(this.textBoxEWMAFilterParam_TextChanged);
            this.textBoxEWMAFilterParam.Leave += new System.EventHandler(this.textBoxEWMAFilterParam_Leave);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Scan Sweep Adjust";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "EWMA Filter Param";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSweepZoneRatio
            // 
            this.textBoxSweepZoneRatio.Location = new System.Drawing.Point(170, 31);
            this.textBoxSweepZoneRatio.MaxLength = 5;
            this.textBoxSweepZoneRatio.Name = "textBoxSweepZoneRatio";
            this.textBoxSweepZoneRatio.Size = new System.Drawing.Size(185, 20);
            this.textBoxSweepZoneRatio.TabIndex = 15;
            this.toolTip1.SetToolTip(this.textBoxSweepZoneRatio, "Adjustment to zones when SweepAdjust option used in ASC");
            this.textBoxSweepZoneRatio.TextChanged += new System.EventHandler(this.textBoxSweepZoneRatio_TextChanged);
            this.textBoxSweepZoneRatio.Leave += new System.EventHandler(this.textBoxSweepZoneRatio_Leave);
            // 
            // comboEnableLimitCheck
            // 
            this.comboEnableLimitCheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEnableLimitCheck.FormattingEnabled = true;
            this.comboEnableLimitCheck.Items.AddRange(new object[] {
            "FALSE",
            "TRUE"});
            this.comboEnableLimitCheck.Location = new System.Drawing.Point(170, 249);
            this.comboEnableLimitCheck.Name = "comboEnableLimitCheck";
            this.comboEnableLimitCheck.Size = new System.Drawing.Size(184, 21);
            this.comboEnableLimitCheck.TabIndex = 9;
            this.toolTip1.SetToolTip(this.comboEnableLimitCheck, "Enable for keeping ASC corrections (TRUE will NOT save changes to ASC file)");
            this.comboEnableLimitCheck.TextChanged += new System.EventHandler(this.comboEnableLimitCheck_TextChanged);
            // 
            // textBoxZoneMargin
            // 
            this.textBoxZoneMargin.Location = new System.Drawing.Point(170, 75);
            this.textBoxZoneMargin.MaxLength = 5;
            this.textBoxZoneMargin.Name = "textBoxZoneMargin";
            this.textBoxZoneMargin.Size = new System.Drawing.Size(185, 20);
            this.textBoxZoneMargin.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxZoneMargin, "Number of edges zones are excluded during ASC (0 to 6)");
            this.textBoxZoneMargin.TextChanged += new System.EventHandler(this.textBoxZoneMargin_TextChanged);
            this.textBoxZoneMargin.Leave += new System.EventHandler(this.textBoxZoneMargin_Leave);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enable Limit Check";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zone Margin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sweep Zone Ratio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxWebType
            // 
            //this.comboBoxWebType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            //this.comboBoxWebType.FormattingEnabled = true;
            //this.comboBoxWebType.Items.AddRange(new object[] {
            //"SHEETFED",
            //"SINGLE_WEB_PRESS",
            //"TWO_WEB_SPLIT_PRESS"});
            //this.comboBoxWebType.Location = new System.Drawing.Point(512, 596);
            //this.comboBoxWebType.Name = "comboBoxWebType";
            //this.comboBoxWebType.Size = new System.Drawing.Size(184, 21);
            //this.comboBoxWebType.TabIndex = 33;
            //this.comboBoxWebType.Visible = false;
            //this.comboBoxWebType.TextChanged += new System.EventHandler(this.comboBoxWebType_TextChanged);
            // 
            // label9
            // 
            //this.label9.Location = new System.Drawing.Point(351, 600);
            //this.label9.Name = "label9";
            //this.label9.Size = new System.Drawing.Size(137, 13);
            //this.label9.TabIndex = 21;
            //this.label9.Text = "Web Type";
            //this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //this.label9.Visible = false;
            // 
            // pnlWizardTitle
            // 
            this.pnlWizardTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlWizardTitle.Controls.Add(this.labelTitle);
            this.pnlWizardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWizardTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlWizardTitle.Name = "pnlWizardTitle";
            this.pnlWizardTitle.Size = new System.Drawing.Size(712, 31);
            this.pnlWizardTitle.TabIndex = 81;
            // 
            // checkEnabled
            // 
            this.checkEnabled.AutoSize = true;
            this.checkEnabled.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkEnabled.Location = new System.Drawing.Point(28, 54);
            this.checkEnabled.Name = "checkEnabled";
            this.checkEnabled.Size = new System.Drawing.Size(121, 17);
            this.checkEnabled.TabIndex = 85;
            this.checkEnabled.Text = "Use CIP3 Presetting";
            this.toolTip1.SetToolTip(this.checkEnabled, "Enable CIP3 Presetting for this system");
            this.checkEnabled.UseVisualStyleBackColor = true;
            this.checkEnabled.CheckedChanged += new System.EventHandler(this.checkEnabled_CheckedChanged);
            // 
            // FormAutoScanCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(712, 620);
            this.ControlBox = false;
            this.Controls.Add(this.checkASC);
            this.Controls.Add(this.checkEnabled);
            this.Controls.Add(this.comboBoxWebType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gpMotorOrServoSettings);
            this.Controls.Add(this.pnlWizardTitle);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAutoScanCal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormAutoScanCal_Load);
            this.gpMotorOrServoSettings.ResumeLayout(false);
            this.gpMotorOrServoSettings.PerformLayout();
            this.pnlWizardTitle.ResumeLayout(false);
            this.pnlWizardTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }      

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox gpMotorOrServoSettings;
        private System.Windows.Forms.ComboBox comboEnableLimitCheck;
        private System.Windows.Forms.TextBox textBoxZoneMargin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlWizardTitle;
        private System.Windows.Forms.TextBox textBoxSweepZoneRatio;
        private System.Windows.Forms.TextBox textBoxCip3ImagesPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBladeTolerance;
        private System.Windows.Forms.TextBox textBoxCip3Path;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSweepDefault;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxEWMAFilterParam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCip3ImagesPathBrows;
        private System.Windows.Forms.Button btnCip3PathBrows;
        private System.Windows.Forms.ComboBox comboBoxWebType;
        private System.Windows.Forms.ComboBox comboBoxScanSweepAdjust;
        private System.Windows.Forms.CheckBox checkEnabled;
        private MC3Components.Controls.MC3ListView ListViewInkers;
        private System.Windows.Forms.Button btnImpoPathBrows;
        private System.Windows.Forms.TextBox textBoxImpo;
        private System.Windows.Forms.Label labelImpo;
        private System.Windows.Forms.CheckBox checkBoxImpositionData;
        private System.Windows.Forms.CheckBox checkASC;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}