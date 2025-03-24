
namespace MCNWSiteGen
{
    partial class frmSPUConfiguration
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
            this.label4 = new System.Windows.Forms.Label();
            this.gpSPUConfig = new System.Windows.Forms.GroupBox();
            this.m_spuConfigListViewCtrl = new MC3Components.Controls.MC3ListView();
            this.butRemove = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.groupBoxMaxInkerPorts = new System.Windows.Forms.GroupBox();
            this.maxFountainPortComboBox = new System.Windows.Forms.ComboBox();
            this.maxInkersPerSPULabel = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlWizardTitle.SuspendLayout();
            this.gpSPUConfig.SuspendLayout();
            this.groupBoxMaxInkerPorts.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWizardTitle
            // 
            this.pnlWizardTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlWizardTitle.Controls.Add(this.label4);
            this.pnlWizardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWizardTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlWizardTitle.Name = "pnlWizardTitle";
            this.pnlWizardTitle.Size = new System.Drawing.Size(717, 31);
            this.pnlWizardTitle.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(228, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "SPU Configuration";
            // 
            // gpSPUConfig
            // 
            this.gpSPUConfig.Controls.Add(this.m_spuConfigListViewCtrl);
            this.gpSPUConfig.Controls.Add(this.butRemove);
            this.gpSPUConfig.Controls.Add(this.butAdd);
            this.gpSPUConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSPUConfig.ForeColor = System.Drawing.Color.White;
            this.gpSPUConfig.Location = new System.Drawing.Point(12, 37);
            this.gpSPUConfig.Name = "gpSPUConfig";
            this.gpSPUConfig.Size = new System.Drawing.Size(681, 287);
            this.gpSPUConfig.TabIndex = 72;
            this.gpSPUConfig.TabStop = false;
            this.gpSPUConfig.Text = "SPU Configurations";
            // 
            // m_spuConfigListViewCtrl
            // 
            this.m_spuConfigListViewCtrl.AllowColumnResize = true;
            this.m_spuConfigListViewCtrl.AllowMultiselect = false;
            this.m_spuConfigListViewCtrl.AlternateBackground = System.Drawing.Color.DarkGreen;
            this.m_spuConfigListViewCtrl.AlternatingColors = false;
            this.m_spuConfigListViewCtrl.AutoHeight = true;
            this.m_spuConfigListViewCtrl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_spuConfigListViewCtrl.BackgroundStretchToFit = true;
            this.m_spuConfigListViewCtrl.ControlStyle = MC3Components.Controls.GLControlStyles.Normal;
            this.m_spuConfigListViewCtrl.ForeColor = System.Drawing.Color.Black;
            this.m_spuConfigListViewCtrl.FullRowSelect = true;
            this.m_spuConfigListViewCtrl.GridColor = System.Drawing.Color.LightGray;
            this.m_spuConfigListViewCtrl.GridLines = MC3Components.Controls.GLGridLines.gridBoth;
            this.m_spuConfigListViewCtrl.GridLineStyle = MC3Components.Controls.GLGridLineStyles.gridSolid;
            this.m_spuConfigListViewCtrl.GridTypes = MC3Components.Controls.GLGridTypes.gridOnExists;
            this.m_spuConfigListViewCtrl.HeaderHeight = 35;
            this.m_spuConfigListViewCtrl.HeaderVisible = true;
            this.m_spuConfigListViewCtrl.HeaderWordWrap = true;
            this.m_spuConfigListViewCtrl.HotColumnTracking = false;
            this.m_spuConfigListViewCtrl.HotItemTracking = false;
            this.m_spuConfigListViewCtrl.HotTrackingColor = System.Drawing.Color.LightGray;
            this.m_spuConfigListViewCtrl.HoverEvents = false;
            this.m_spuConfigListViewCtrl.HoverTime = 1;
            this.m_spuConfigListViewCtrl.ImageList = null;
            this.m_spuConfigListViewCtrl.ItemHeight = 18;
            this.m_spuConfigListViewCtrl.ItemWordWrap = false;
            this.m_spuConfigListViewCtrl.Location = new System.Drawing.Point(6, 21);
            this.m_spuConfigListViewCtrl.Name = "m_spuConfigListViewCtrl";
            this.m_spuConfigListViewCtrl.Selectable = true;
            this.m_spuConfigListViewCtrl.SelectedTextColor = System.Drawing.Color.White;
            this.m_spuConfigListViewCtrl.SelectionColor = System.Drawing.SystemColors.Highlight;
            this.m_spuConfigListViewCtrl.ShowBorder = true;
            this.m_spuConfigListViewCtrl.ShowFocusRect = false;
            this.m_spuConfigListViewCtrl.Size = new System.Drawing.Size(563, 250);
            this.m_spuConfigListViewCtrl.SortType = MC3Components.Controls.SortTypes.None;
            this.m_spuConfigListViewCtrl.SuperFlatHeaderColor = System.Drawing.Color.White;
            this.m_spuConfigListViewCtrl.TabIndex = 55;
            // 
            // butRemove
            // 
            this.butRemove.BackColor = System.Drawing.Color.DimGray;
            this.butRemove.Location = new System.Drawing.Point(582, 141);
            this.butRemove.Name = "butRemove";
            this.butRemove.Size = new System.Drawing.Size(82, 36);
            this.butRemove.TabIndex = 54;
            this.butRemove.Text = "Remove";
            this.butRemove.UseVisualStyleBackColor = false;
            this.butRemove.Click += new System.EventHandler(this.butRemove_Click);
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.DimGray;
            this.butAdd.Location = new System.Drawing.Point(582, 55);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(82, 36);
            this.butAdd.TabIndex = 53;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // groupBoxMaxInkerPorts
            // 
            this.groupBoxMaxInkerPorts.Controls.Add(this.maxFountainPortComboBox);
            this.groupBoxMaxInkerPorts.Controls.Add(this.maxInkersPerSPULabel);
            this.groupBoxMaxInkerPorts.Location = new System.Drawing.Point(12, 329);
            this.groupBoxMaxInkerPorts.Name = "groupBoxMaxInkerPorts";
            this.groupBoxMaxInkerPorts.Size = new System.Drawing.Size(681, 71);
            this.groupBoxMaxInkerPorts.TabIndex = 75;
            this.groupBoxMaxInkerPorts.TabStop = false;
            // 
            // maxFountainPortComboBox
            // 
            this.maxFountainPortComboBox.DisplayMember = "(none)";
            this.maxFountainPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maxFountainPortComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxFountainPortComboBox.FormattingEnabled = true;
            this.maxFountainPortComboBox.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "12"});
            this.maxFountainPortComboBox.Location = new System.Drawing.Point(189, 29);
            this.maxFountainPortComboBox.Name = "maxFountainPortComboBox";
            this.maxFountainPortComboBox.Size = new System.Drawing.Size(83, 23);
            this.maxFountainPortComboBox.TabIndex = 58;
            // 
            // maxInkersPerSPULabel
            // 
            this.maxInkersPerSPULabel.AutoSize = true;
            this.maxInkersPerSPULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxInkersPerSPULabel.ForeColor = System.Drawing.Color.White;
            this.maxInkersPerSPULabel.Location = new System.Drawing.Point(22, 32);
            this.maxInkersPerSPULabel.Name = "maxInkersPerSPULabel";
            this.maxInkersPerSPULabel.Size = new System.Drawing.Size(161, 16);
            this.maxInkersPerSPULabel.TabIndex = 57;
            this.maxInkersPerSPULabel.Text = "Max Fountain ports / SPU:";
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = global::MCNWSiteGen.Properties.Resources.OK48;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(259, 422);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 51);
            this.btnOK.TabIndex = 73;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(446, 422);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 51);
            this.btnCancel.TabIndex = 74;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSPUConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(717, 495);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxMaxInkerPorts);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gpSPUConfig);
            this.Controls.Add(this.pnlWizardTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSPUConfiguration";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.SPUConfigForm_Load);
            this.pnlWizardTitle.ResumeLayout(false);
            this.pnlWizardTitle.PerformLayout();
            this.gpSPUConfig.ResumeLayout(false);
            this.groupBoxMaxInkerPorts.ResumeLayout(false);
            this.groupBoxMaxInkerPorts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWizardTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpSPUConfig;
        private System.Windows.Forms.Button butRemove;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.GroupBox groupBoxMaxInkerPorts;
        private System.Windows.Forms.ComboBox maxFountainPortComboBox;
        private System.Windows.Forms.Label maxInkersPerSPULabel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private MC3Components.Controls.MC3ListView m_spuConfigListViewCtrl;

    }
}