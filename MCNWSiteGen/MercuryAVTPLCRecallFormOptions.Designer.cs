namespace MCNWSiteGen
{
    partial class MercuryAVTPLCRecallFormOptions
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
            this.m_titlePanel = new System.Windows.Forms.Panel();
            this.m_formTitle = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.m_sweepParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.m_sweepDuctorSettingParamCheckBox = new System.Windows.Forms.CheckBox();
            this.m_sweepFunctionSettingParamCheckBox = new System.Windows.Forms.CheckBox();
            this.m_sweepTrimParamCheckBox = new System.Windows.Forms.CheckBox();
            this.m_waterParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.m_waterFunctionSettingParamCheckBox = new System.Windows.Forms.CheckBox();
            this.m_waterTrimParamCheckBox = new System.Windows.Forms.CheckBox();
            this.m_titlePanel.SuspendLayout();
            this.m_sweepParametersGroupBox.SuspendLayout();
            this.m_waterParametersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_titlePanel
            // 
            this.m_titlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.m_titlePanel.Controls.Add(this.m_formTitle);
            this.m_titlePanel.Location = new System.Drawing.Point(0, 0);
            this.m_titlePanel.Name = "m_titlePanel";
            this.m_titlePanel.Size = new System.Drawing.Size(489, 34);
            this.m_titlePanel.TabIndex = 95;
            // 
            // m_formTitle
            // 
            this.m_formTitle.AutoSize = true;
            this.m_formTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.m_formTitle.Location = new System.Drawing.Point(159, 6);
            this.m_formTitle.Name = "m_formTitle";
            this.m_formTitle.Size = new System.Drawing.Size(172, 20);
            this.m_formTitle.TabIndex = 0;
            this.m_formTitle.Text = "Recall Form Options";
            this.m_formTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOK
            // 
            this.btnOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.btnOK.Location = new System.Drawing.Point(319, 263);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 53);
            this.btnOK.TabIndex = 96;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.OnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(416, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 53);
            this.btnCancel.TabIndex = 97;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.OnCancel_Click);
            // 
            // m_sweepParametersGroupBox
            // 
            this.m_sweepParametersGroupBox.Controls.Add(this.m_sweepDuctorSettingParamCheckBox);
            this.m_sweepParametersGroupBox.Controls.Add(this.m_sweepFunctionSettingParamCheckBox);
            this.m_sweepParametersGroupBox.Controls.Add(this.m_sweepTrimParamCheckBox);
            this.m_sweepParametersGroupBox.ForeColor = System.Drawing.Color.White;
            this.m_sweepParametersGroupBox.Location = new System.Drawing.Point(3, 45);
            this.m_sweepParametersGroupBox.Name = "m_sweepParametersGroupBox";
            this.m_sweepParametersGroupBox.Size = new System.Drawing.Size(234, 200);
            this.m_sweepParametersGroupBox.TabIndex = 98;
            this.m_sweepParametersGroupBox.TabStop = false;
            this.m_sweepParametersGroupBox.Text = "Sweep Parameters";
            // 
            // m_sweepDuctorSettingParamCheckBox
            // 
            this.m_sweepDuctorSettingParamCheckBox.AutoSize = true;
            this.m_sweepDuctorSettingParamCheckBox.Location = new System.Drawing.Point(26, 140);
            this.m_sweepDuctorSettingParamCheckBox.Name = "m_sweepDuctorSettingParamCheckBox";
            this.m_sweepDuctorSettingParamCheckBox.Size = new System.Drawing.Size(136, 17);
            this.m_sweepDuctorSettingParamCheckBox.TabIndex = 2;
            this.m_sweepDuctorSettingParamCheckBox.Text = "Ductor Hold Off Setting";
            this.m_sweepDuctorSettingParamCheckBox.UseVisualStyleBackColor = true;
            this.m_sweepDuctorSettingParamCheckBox.CheckedChanged += new System.EventHandler(this.OnSweepDuctorSettingParamCheckBox_CheckedChanged);
            // 
            // m_sweepFunctionSettingParamCheckBox
            // 
            this.m_sweepFunctionSettingParamCheckBox.AutoSize = true;
            this.m_sweepFunctionSettingParamCheckBox.Location = new System.Drawing.Point(26, 94);
            this.m_sweepFunctionSettingParamCheckBox.Name = "m_sweepFunctionSettingParamCheckBox";
            this.m_sweepFunctionSettingParamCheckBox.Size = new System.Drawing.Size(103, 17);
            this.m_sweepFunctionSettingParamCheckBox.TabIndex = 1;
            this.m_sweepFunctionSettingParamCheckBox.Text = "Function Setting";
            this.m_sweepFunctionSettingParamCheckBox.UseVisualStyleBackColor = true;
            this.m_sweepFunctionSettingParamCheckBox.CheckedChanged += new System.EventHandler(this.OnSweepFunctionSettingParamCheckBox_CheckedChanged);
            // 
            // m_sweepTrimParamCheckBox
            // 
            this.m_sweepTrimParamCheckBox.AutoSize = true;
            this.m_sweepTrimParamCheckBox.Location = new System.Drawing.Point(26, 48);
            this.m_sweepTrimParamCheckBox.Name = "m_sweepTrimParamCheckBox";
            this.m_sweepTrimParamCheckBox.Size = new System.Drawing.Size(76, 17);
            this.m_sweepTrimParamCheckBox.TabIndex = 0;
            this.m_sweepTrimParamCheckBox.Text = "Trim Value";
            this.m_sweepTrimParamCheckBox.UseVisualStyleBackColor = true;
            this.m_sweepTrimParamCheckBox.CheckedChanged += new System.EventHandler(this.OnSweepTrimParamCheckBox_CheckedChanged);
            // 
            // m_waterParametersGroupBox
            // 
            this.m_waterParametersGroupBox.Controls.Add(this.m_waterFunctionSettingParamCheckBox);
            this.m_waterParametersGroupBox.Controls.Add(this.m_waterTrimParamCheckBox);
            this.m_waterParametersGroupBox.ForeColor = System.Drawing.Color.White;
            this.m_waterParametersGroupBox.Location = new System.Drawing.Point(245, 45);
            this.m_waterParametersGroupBox.Name = "m_waterParametersGroupBox";
            this.m_waterParametersGroupBox.Size = new System.Drawing.Size(234, 200);
            this.m_waterParametersGroupBox.TabIndex = 99;
            this.m_waterParametersGroupBox.TabStop = false;
            this.m_waterParametersGroupBox.Text = "Water Parameters";
            // 
            // m_waterFunctionSettingParamCheckBox
            // 
            this.m_waterFunctionSettingParamCheckBox.AutoSize = true;
            this.m_waterFunctionSettingParamCheckBox.Location = new System.Drawing.Point(34, 94);
            this.m_waterFunctionSettingParamCheckBox.Name = "m_waterFunctionSettingParamCheckBox";
            this.m_waterFunctionSettingParamCheckBox.Size = new System.Drawing.Size(103, 17);
            this.m_waterFunctionSettingParamCheckBox.TabIndex = 2;
            this.m_waterFunctionSettingParamCheckBox.Text = "Function Setting";
            this.m_waterFunctionSettingParamCheckBox.UseVisualStyleBackColor = true;
            this.m_waterFunctionSettingParamCheckBox.CheckedChanged += new System.EventHandler(this.OnWaterFunctionSettingParamCheckBox_CheckedChanged);
            // 
            // m_waterTrimParamCheckBox
            // 
            this.m_waterTrimParamCheckBox.AutoSize = true;
            this.m_waterTrimParamCheckBox.Location = new System.Drawing.Point(34, 48);
            this.m_waterTrimParamCheckBox.Name = "m_waterTrimParamCheckBox";
            this.m_waterTrimParamCheckBox.Size = new System.Drawing.Size(76, 17);
            this.m_waterTrimParamCheckBox.TabIndex = 1;
            this.m_waterTrimParamCheckBox.Text = "Trim Value";
            this.m_waterTrimParamCheckBox.UseVisualStyleBackColor = true;
            this.m_waterTrimParamCheckBox.CheckedChanged += new System.EventHandler(this.OnWaterTrimParamCheckBox_CheckedChanged);
            // 
            // MercuryAVTPLCRecallFormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(489, 329);
            this.ControlBox = false;
            this.Controls.Add(this.m_waterParametersGroupBox);
            this.Controls.Add(this.m_sweepParametersGroupBox);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.m_titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MercuryAVTPLCRecallFormOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.MercuryAVTPLCRecallFormOptions_Load);
            this.m_titlePanel.ResumeLayout(false);
            this.m_titlePanel.PerformLayout();
            this.m_sweepParametersGroupBox.ResumeLayout(false);
            this.m_sweepParametersGroupBox.PerformLayout();
            this.m_waterParametersGroupBox.ResumeLayout(false);
            this.m_waterParametersGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel m_titlePanel;
        private System.Windows.Forms.Label m_formTitle;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox m_sweepParametersGroupBox;
        private System.Windows.Forms.GroupBox m_waterParametersGroupBox;
        private System.Windows.Forms.CheckBox m_sweepDuctorSettingParamCheckBox;
        private System.Windows.Forms.CheckBox m_sweepFunctionSettingParamCheckBox;
        private System.Windows.Forms.CheckBox m_sweepTrimParamCheckBox;
        private System.Windows.Forms.CheckBox m_waterFunctionSettingParamCheckBox;
        private System.Windows.Forms.CheckBox m_waterTrimParamCheckBox;
    }
}