namespace MCNWSiteGen
{
    partial class MercuryAVTPLCConfigVoltagesForm
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
            this.serverOptionsTitlePanel = new System.Windows.Forms.Panel();
            this.m_dlgTitle = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.m_inkerSweepWaterVoltagesListView = new MC3Components.Controls.MC3ListView();
            this.m_inkerSweepWaterVoltagesGroupBox = new System.Windows.Forms.GroupBox();
            this.m_pressSpeedVoltagesGroupBox = new System.Windows.Forms.GroupBox();
            this.m_pressSpeedMaxVoltageUnit = new System.Windows.Forms.Label();
            this.m_pressSpeedMinVoltageUnit = new System.Windows.Forms.Label();
            this.m_pressSpeedMaximumVoltageTextBox = new System.Windows.Forms.TextBox();
            this.m_pressSpeedMaximumVoltageLabel = new System.Windows.Forms.Label();
            this.m_pressSpeedMinVoltageTextBox = new System.Windows.Forms.TextBox();
            this.m_pressSpeedMinVoltageLabel = new System.Windows.Forms.Label();
            this.serverOptionsTitlePanel.SuspendLayout();
            this.m_inkerSweepWaterVoltagesGroupBox.SuspendLayout();
            this.m_pressSpeedVoltagesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverOptionsTitlePanel
            // 
            this.serverOptionsTitlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverOptionsTitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.serverOptionsTitlePanel.Controls.Add(this.m_dlgTitle);
            this.serverOptionsTitlePanel.Location = new System.Drawing.Point(-1, 0);
            this.serverOptionsTitlePanel.Name = "serverOptionsTitlePanel";
            this.serverOptionsTitlePanel.Size = new System.Drawing.Size(795, 34);
            this.serverOptionsTitlePanel.TabIndex = 91;
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
            // btnOK
            // 
            this.btnOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.btnOK.Location = new System.Drawing.Point(598, 485);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 53);
            this.btnOK.TabIndex = 0;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(712, 485);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 53);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // m_inkerSweepWaterVoltagesListView
            // 
            this.m_inkerSweepWaterVoltagesListView.AllowColumnResize = true;
            this.m_inkerSweepWaterVoltagesListView.AllowMultiselect = false;
            this.m_inkerSweepWaterVoltagesListView.AlternateBackground = System.Drawing.Color.DarkGreen;
            this.m_inkerSweepWaterVoltagesListView.AlternatingColors = false;
            this.m_inkerSweepWaterVoltagesListView.AutoHeight = true;
            this.m_inkerSweepWaterVoltagesListView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_inkerSweepWaterVoltagesListView.BackgroundStretchToFit = true;
            this.m_inkerSweepWaterVoltagesListView.ControlStyle = MC3Components.Controls.GLControlStyles.Normal;
            this.m_inkerSweepWaterVoltagesListView.ForeColor = System.Drawing.Color.Black;
            this.m_inkerSweepWaterVoltagesListView.FullRowSelect = true;
            this.m_inkerSweepWaterVoltagesListView.GridColor = System.Drawing.Color.LightGray;
            this.m_inkerSweepWaterVoltagesListView.GridLines = MC3Components.Controls.GLGridLines.gridBoth;
            this.m_inkerSweepWaterVoltagesListView.GridLineStyle = MC3Components.Controls.GLGridLineStyles.gridSolid;
            this.m_inkerSweepWaterVoltagesListView.GridTypes = MC3Components.Controls.GLGridTypes.gridOnExists;
            this.m_inkerSweepWaterVoltagesListView.HeaderHeight = 35;
            this.m_inkerSweepWaterVoltagesListView.HeaderVisible = true;
            this.m_inkerSweepWaterVoltagesListView.HeaderWordWrap = true;
            this.m_inkerSweepWaterVoltagesListView.HotColumnTracking = false;
            this.m_inkerSweepWaterVoltagesListView.HotItemTracking = false;
            this.m_inkerSweepWaterVoltagesListView.HotTrackingColor = System.Drawing.Color.LightGray;
            this.m_inkerSweepWaterVoltagesListView.HoverEvents = false;
            this.m_inkerSweepWaterVoltagesListView.HoverTime = 1;
            this.m_inkerSweepWaterVoltagesListView.ImageList = null;
            this.m_inkerSweepWaterVoltagesListView.ItemHeight = 18;
            this.m_inkerSweepWaterVoltagesListView.ItemWordWrap = false;
            this.m_inkerSweepWaterVoltagesListView.Location = new System.Drawing.Point(6, 19);
            this.m_inkerSweepWaterVoltagesListView.Name = "m_inkerSweepWaterVoltagesListView";
            this.m_inkerSweepWaterVoltagesListView.Selectable = true;
            this.m_inkerSweepWaterVoltagesListView.SelectedTextColor = System.Drawing.Color.White;
            this.m_inkerSweepWaterVoltagesListView.SelectionColor = System.Drawing.SystemColors.Highlight;
            this.m_inkerSweepWaterVoltagesListView.ShowBorder = true;
            this.m_inkerSweepWaterVoltagesListView.ShowFocusRect = false;
            this.m_inkerSweepWaterVoltagesListView.Size = new System.Drawing.Size(756, 305);
            this.m_inkerSweepWaterVoltagesListView.SortType = MC3Components.Controls.SortTypes.None;
            this.m_inkerSweepWaterVoltagesListView.SuperFlatHeaderColor = System.Drawing.Color.White;
            this.m_inkerSweepWaterVoltagesListView.TabIndex = 0;
            // 
            // m_inkerSweepWaterVoltagesGroupBox
            // 
            this.m_inkerSweepWaterVoltagesGroupBox.Controls.Add(this.m_inkerSweepWaterVoltagesListView);
            this.m_inkerSweepWaterVoltagesGroupBox.ForeColor = System.Drawing.Color.White;
            this.m_inkerSweepWaterVoltagesGroupBox.Location = new System.Drawing.Point(10, 139);
            this.m_inkerSweepWaterVoltagesGroupBox.Name = "m_inkerSweepWaterVoltagesGroupBox";
            this.m_inkerSweepWaterVoltagesGroupBox.Size = new System.Drawing.Size(769, 330);
            this.m_inkerSweepWaterVoltagesGroupBox.TabIndex = 4;
            this.m_inkerSweepWaterVoltagesGroupBox.TabStop = false;
            this.m_inkerSweepWaterVoltagesGroupBox.Text = "Voltage Configurations";
            // 
            // m_pressSpeedVoltagesGroupBox
            // 
            this.m_pressSpeedVoltagesGroupBox.Controls.Add(this.m_pressSpeedMaxVoltageUnit);
            this.m_pressSpeedVoltagesGroupBox.Controls.Add(this.m_pressSpeedMinVoltageUnit);
            this.m_pressSpeedVoltagesGroupBox.Controls.Add(this.m_pressSpeedMaximumVoltageTextBox);
            this.m_pressSpeedVoltagesGroupBox.Controls.Add(this.m_pressSpeedMaximumVoltageLabel);
            this.m_pressSpeedVoltagesGroupBox.Controls.Add(this.m_pressSpeedMinVoltageTextBox);
            this.m_pressSpeedVoltagesGroupBox.Controls.Add(this.m_pressSpeedMinVoltageLabel);
            this.m_pressSpeedVoltagesGroupBox.ForeColor = System.Drawing.Color.White;
            this.m_pressSpeedVoltagesGroupBox.Location = new System.Drawing.Point(10, 44);
            this.m_pressSpeedVoltagesGroupBox.Name = "m_pressSpeedVoltagesGroupBox";
            this.m_pressSpeedVoltagesGroupBox.Size = new System.Drawing.Size(769, 89);
            this.m_pressSpeedVoltagesGroupBox.TabIndex = 2;
            this.m_pressSpeedVoltagesGroupBox.TabStop = false;
            this.m_pressSpeedVoltagesGroupBox.Text = "Press Speed Input Voltage";
            // 
            // m_pressSpeedMaxVoltageUnit
            // 
            this.m_pressSpeedMaxVoltageUnit.AutoSize = true;
            this.m_pressSpeedMaxVoltageUnit.Location = new System.Drawing.Point(333, 56);
            this.m_pressSpeedMaxVoltageUnit.Name = "m_pressSpeedMaxVoltageUnit";
            this.m_pressSpeedMaxVoltageUnit.Size = new System.Drawing.Size(56, 13);
            this.m_pressSpeedMaxVoltageUnit.TabIndex = 5;
            this.m_pressSpeedMaxVoltageUnit.Text = "( 0 - 11 V )";
            // 
            // m_pressSpeedMinVoltageUnit
            // 
            this.m_pressSpeedMinVoltageUnit.AutoSize = true;
            this.m_pressSpeedMinVoltageUnit.Location = new System.Drawing.Point(38, 56);
            this.m_pressSpeedMinVoltageUnit.Name = "m_pressSpeedMinVoltageUnit";
            this.m_pressSpeedMinVoltageUnit.Size = new System.Drawing.Size(56, 13);
            this.m_pressSpeedMinVoltageUnit.TabIndex = 4;
            this.m_pressSpeedMinVoltageUnit.Text = "( 0 - 11 V )";
            // 
            // m_pressSpeedMaximumVoltageTextBox
            // 
            this.m_pressSpeedMaximumVoltageTextBox.Location = new System.Drawing.Point(413, 32);
            this.m_pressSpeedMaximumVoltageTextBox.MaxLength = 6;
            this.m_pressSpeedMaximumVoltageTextBox.Name = "m_pressSpeedMaximumVoltageTextBox";
            this.m_pressSpeedMaximumVoltageTextBox.Size = new System.Drawing.Size(127, 20);
            this.m_pressSpeedMaximumVoltageTextBox.TabIndex = 1;
            this.m_pressSpeedMaximumVoltageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_pressSpeedMaximumVoltageTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnMaxValueTextBox_Validating);
            // 
            // m_pressSpeedMaximumVoltageLabel
            // 
            this.m_pressSpeedMaximumVoltageLabel.AutoSize = true;
            this.m_pressSpeedMaximumVoltageLabel.Location = new System.Drawing.Point(333, 35);
            this.m_pressSpeedMaximumVoltageLabel.Name = "m_pressSpeedMaximumVoltageLabel";
            this.m_pressSpeedMaximumVoltageLabel.Size = new System.Drawing.Size(54, 13);
            this.m_pressSpeedMaximumVoltageLabel.TabIndex = 1;
            this.m_pressSpeedMaximumVoltageLabel.Text = "Maximum:";
            // 
            // m_pressSpeedMinVoltageTextBox
            // 
            this.m_pressSpeedMinVoltageTextBox.Location = new System.Drawing.Point(117, 32);
            this.m_pressSpeedMinVoltageTextBox.MaxLength = 6;
            this.m_pressSpeedMinVoltageTextBox.Name = "m_pressSpeedMinVoltageTextBox";
            this.m_pressSpeedMinVoltageTextBox.Size = new System.Drawing.Size(127, 20);
            this.m_pressSpeedMinVoltageTextBox.TabIndex = 0;
            this.m_pressSpeedMinVoltageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_pressSpeedMinVoltageTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnMinValueTextBox_Validating);
            // 
            // m_pressSpeedMinVoltageLabel
            // 
            this.m_pressSpeedMinVoltageLabel.AutoSize = true;
            this.m_pressSpeedMinVoltageLabel.Location = new System.Drawing.Point(37, 35);
            this.m_pressSpeedMinVoltageLabel.Name = "m_pressSpeedMinVoltageLabel";
            this.m_pressSpeedMinVoltageLabel.Size = new System.Drawing.Size(51, 13);
            this.m_pressSpeedMinVoltageLabel.TabIndex = 5;
            this.m_pressSpeedMinVoltageLabel.Text = "Minimum:";
            // 
            // MercuryAVTPLCConfigVoltagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(792, 548);
            this.ControlBox = false;
            this.Controls.Add(this.m_pressSpeedVoltagesGroupBox);
            this.Controls.Add(this.m_inkerSweepWaterVoltagesGroupBox);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.serverOptionsTitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MercuryAVTPLCConfigVoltagesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.MercuryAVTPLCConfigVoltagesForm_Load);
            this.serverOptionsTitlePanel.ResumeLayout(false);
            this.serverOptionsTitlePanel.PerformLayout();
            this.m_inkerSweepWaterVoltagesGroupBox.ResumeLayout(false);
            this.m_pressSpeedVoltagesGroupBox.ResumeLayout(false);
            this.m_pressSpeedVoltagesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel serverOptionsTitlePanel;
        private System.Windows.Forms.Label m_dlgTitle;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private MC3Components.Controls.MC3ListView m_inkerSweepWaterVoltagesListView;
        private System.Windows.Forms.GroupBox m_inkerSweepWaterVoltagesGroupBox;
        private System.Windows.Forms.GroupBox m_pressSpeedVoltagesGroupBox;
        private System.Windows.Forms.TextBox m_pressSpeedMaximumVoltageTextBox;
        private System.Windows.Forms.Label m_pressSpeedMaximumVoltageLabel;
        private System.Windows.Forms.TextBox m_pressSpeedMinVoltageTextBox;
        private System.Windows.Forms.Label m_pressSpeedMinVoltageLabel;
        private System.Windows.Forms.Label m_pressSpeedMaxVoltageUnit;
        private System.Windows.Forms.Label m_pressSpeedMinVoltageUnit;
    }
}