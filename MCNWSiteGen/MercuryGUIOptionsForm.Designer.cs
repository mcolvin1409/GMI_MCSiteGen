namespace MCNWSiteGen
{
    partial class MercuryGUIOptionsForm
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
            if (disposing && ( components != null ))
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_saveAndUndoWaterConsoleSettings = new System.Windows.Forms.CheckBox();
            this.m_saveAndUndoSweepConsoleSettings = new System.Windows.Forms.CheckBox();
            this.m_defaultThumbnailSizeCB = new System.Windows.Forms.ComboBox();
            this.m_defaultThumbnailSizeLabel = new System.Windows.Forms.Label();
            this.m_invertPresetProfileOption = new System.Windows.Forms.CheckBox();
            this.m_removalOfRunButtonOption = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.m_autoRunDelayTimeTextBox = new System.Windows.Forms.TextBox();
            this.autoRunDelayTimeLabel = new System.Windows.Forms.Label();
            this.serverOptionsTitlePanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverOptionsTitlePanel
            // 
            this.serverOptionsTitlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverOptionsTitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.serverOptionsTitlePanel.Controls.Add(this.label1);
            this.serverOptionsTitlePanel.Location = new System.Drawing.Point(1, 1);
            this.serverOptionsTitlePanel.Name = "serverOptionsTitlePanel";
            this.serverOptionsTitlePanel.Size = new System.Drawing.Size(346, 51);
            this.serverOptionsTitlePanel.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(90, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mercury GUI Options";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.autoRunDelayTimeLabel);
            this.groupBox1.Controls.Add(this.m_autoRunDelayTimeTextBox);
            this.groupBox1.Controls.Add(this.m_saveAndUndoWaterConsoleSettings);
            this.groupBox1.Controls.Add(this.m_saveAndUndoSweepConsoleSettings);
            this.groupBox1.Controls.Add(this.m_defaultThumbnailSizeCB);
            this.groupBox1.Controls.Add(this.m_defaultThumbnailSizeLabel);
            this.groupBox1.Controls.Add(this.m_invertPresetProfileOption);
            this.groupBox1.Controls.Add(this.m_removalOfRunButtonOption);
            this.groupBox1.Location = new System.Drawing.Point(5, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 241);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            // 
            // m_saveAndUndoWaterConsoleSettings
            // 
            this.m_saveAndUndoWaterConsoleSettings.ForeColor = System.Drawing.Color.White;
            this.m_saveAndUndoWaterConsoleSettings.Location = new System.Drawing.Point(52, 156);
            this.m_saveAndUndoWaterConsoleSettings.Name = "m_saveAndUndoWaterConsoleSettings";
            this.m_saveAndUndoWaterConsoleSettings.Size = new System.Drawing.Size(246, 24);
            this.m_saveAndUndoWaterConsoleSettings.TabIndex = 6;
            this.m_saveAndUndoWaterConsoleSettings.Text = "Save and Undo Water Console Settings";
            this.m_saveAndUndoWaterConsoleSettings.UseVisualStyleBackColor = true;
            // 
            // m_saveAndUndoSweepConsoleSettings
            // 
            this.m_saveAndUndoSweepConsoleSettings.ForeColor = System.Drawing.Color.White;
            this.m_saveAndUndoSweepConsoleSettings.Location = new System.Drawing.Point(52, 119);
            this.m_saveAndUndoSweepConsoleSettings.Name = "m_saveAndUndoSweepConsoleSettings";
            this.m_saveAndUndoSweepConsoleSettings.Size = new System.Drawing.Size(246, 24);
            this.m_saveAndUndoSweepConsoleSettings.TabIndex = 5;
            this.m_saveAndUndoSweepConsoleSettings.Text = "Save and Undo Sweep Console Settings";
            this.m_saveAndUndoSweepConsoleSettings.UseVisualStyleBackColor = true;
            // 
            // m_defaultThumbnailSizeCB
            // 
            this.m_defaultThumbnailSizeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_defaultThumbnailSizeCB.FormattingEnabled = true;
            this.m_defaultThumbnailSizeCB.Items.AddRange(new object[] {
            "50",
            "75",
            "100",
            "125",
            "150",
            "175",
            "200",
            "225",
            "250",
            "275",
            "300",
            "325",
            "350",
            "375",
            "400",
            "425",
            "450",
            "475",
            "500"});
            this.m_defaultThumbnailSizeCB.Location = new System.Drawing.Point(169, 196);
            this.m_defaultThumbnailSizeCB.Name = "m_defaultThumbnailSizeCB";
            this.m_defaultThumbnailSizeCB.Size = new System.Drawing.Size(74, 21);
            this.m_defaultThumbnailSizeCB.TabIndex = 4;
            // 
            // m_defaultThumbnailSizeLabel
            // 
            this.m_defaultThumbnailSizeLabel.ForeColor = System.Drawing.Color.White;
            this.m_defaultThumbnailSizeLabel.Location = new System.Drawing.Point(52, 199);
            this.m_defaultThumbnailSizeLabel.Name = "m_defaultThumbnailSizeLabel";
            this.m_defaultThumbnailSizeLabel.Size = new System.Drawing.Size(117, 19);
            this.m_defaultThumbnailSizeLabel.TabIndex = 3;
            this.m_defaultThumbnailSizeLabel.Text = "Default Thumbnail Size";
            // 
            // m_invertPresetProfileOption
            // 
            this.m_invertPresetProfileOption.ForeColor = System.Drawing.Color.White;
            this.m_invertPresetProfileOption.Location = new System.Drawing.Point(52, 84);
            this.m_invertPresetProfileOption.Name = "m_invertPresetProfileOption";
            this.m_invertPresetProfileOption.Size = new System.Drawing.Size(246, 24);
            this.m_invertPresetProfileOption.TabIndex = 2;
            this.m_invertPresetProfileOption.Text = "Show Invert Preset Profile button";
            this.m_invertPresetProfileOption.UseVisualStyleBackColor = true;
            // 
            // m_removalOfRunButtonOption
            // 
            this.m_removalOfRunButtonOption.ForeColor = System.Drawing.Color.White;
            this.m_removalOfRunButtonOption.Location = new System.Drawing.Point(52, 23);
            this.m_removalOfRunButtonOption.Name = "m_removalOfRunButtonOption";
            this.m_removalOfRunButtonOption.Size = new System.Drawing.Size(264, 24);
            this.m_removalOfRunButtonOption.TabIndex = 0;
            this.m_removalOfRunButtonOption.Text = "Show Disable RUN button requirement";
            this.m_removalOfRunButtonOption.UseVisualStyleBackColor = true;
            this.m_removalOfRunButtonOption.CheckedChanged += new System.EventHandler(this.OnRemovalOfRunButtonOption_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.btnOK.Location = new System.Drawing.Point(58, 325);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 53);
            this.btnOK.TabIndex = 92;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(230, 325);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 53);
            this.btnCancel.TabIndex = 93;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // m_autoRunDelayTimeTextBox
            // 
            this.m_autoRunDelayTimeTextBox.Enabled = false;
            this.m_autoRunDelayTimeTextBox.Location = new System.Drawing.Point(236, 50);
            this.m_autoRunDelayTimeTextBox.MaxLength = 3;
            this.m_autoRunDelayTimeTextBox.Name = "m_autoRunDelayTimeTextBox";
            this.m_autoRunDelayTimeTextBox.Size = new System.Drawing.Size(73, 20);
            this.m_autoRunDelayTimeTextBox.TabIndex = 7;
            this.m_autoRunDelayTimeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnAutoRunDelayTimeTextBox_Validating);
            // 
            // autoRunDelayTimeLabel
            // 
            this.autoRunDelayTimeLabel.AutoSize = true;
            this.autoRunDelayTimeLabel.Enabled = false;
            this.autoRunDelayTimeLabel.ForeColor = System.Drawing.Color.White;
            this.autoRunDelayTimeLabel.Location = new System.Drawing.Point(70, 53);
            this.autoRunDelayTimeLabel.Name = "autoRunDelayTimeLabel";
            this.autoRunDelayTimeLabel.Size = new System.Drawing.Size(160, 13);
            this.autoRunDelayTimeLabel.TabIndex = 8;
            this.autoRunDelayTimeLabel.Text = "Response Delay Time (seconds)";
            // 
            // MercuryGUIOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(348, 399);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.serverOptionsTitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MercuryGUIOptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.MercuryServerOptionsForm_Load);
            this.serverOptionsTitlePanel.ResumeLayout(false);
            this.serverOptionsTitlePanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel serverOptionsTitlePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox m_invertPresetProfileOption;
        private System.Windows.Forms.CheckBox m_removalOfRunButtonOption;
        private System.Windows.Forms.ComboBox m_defaultThumbnailSizeCB;
        private System.Windows.Forms.Label m_defaultThumbnailSizeLabel;
        private System.Windows.Forms.CheckBox m_saveAndUndoWaterConsoleSettings;
        private System.Windows.Forms.CheckBox m_saveAndUndoSweepConsoleSettings;
        private System.Windows.Forms.Label autoRunDelayTimeLabel;
        private System.Windows.Forms.TextBox m_autoRunDelayTimeTextBox;
    }
}