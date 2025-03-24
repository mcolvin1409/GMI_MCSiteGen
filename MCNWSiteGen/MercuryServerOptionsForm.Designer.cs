namespace MCNWSiteGen
{
    partial class MercuryServerOptionsForm
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
            this.m_fixComPortsOption = new System.Windows.Forms.CheckBox();
            this.m_spuNoStressOption = new System.Windows.Forms.CheckBox();
            this.m_cpuAffinityOption = new System.Windows.Forms.CheckBox();
            this.m_spu3DebugOption = new System.Windows.Forms.CheckBox();
            this.m_fullSimulationOption = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
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
            this.serverOptionsTitlePanel.Size = new System.Drawing.Size(400, 51);
            this.serverOptionsTitlePanel.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(102, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mercury Server Options";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_fixComPortsOption);
            this.groupBox1.Controls.Add(this.m_spuNoStressOption);
            this.groupBox1.Controls.Add(this.m_cpuAffinityOption);
            this.groupBox1.Controls.Add(this.m_spu3DebugOption);
            this.groupBox1.Controls.Add(this.m_fullSimulationOption);
            this.groupBox1.Location = new System.Drawing.Point(5, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 325);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            // 
            // m_fixComPortsOption
            // 
            this.m_fixComPortsOption.ForeColor = System.Drawing.Color.White;
            this.m_fixComPortsOption.Location = new System.Drawing.Point(19, 252);
            this.m_fixComPortsOption.Name = "m_fixComPortsOption";
            this.m_fixComPortsOption.Size = new System.Drawing.Size(359, 37);
            this.m_fixComPortsOption.TabIndex = 5;
            this.m_fixComPortsOption.Text = "Fix COM Ports ( Recommended to select this option if 9 or more COM ports are conf" +
    "igured. Applicable to Serial interface only )";
            this.m_fixComPortsOption.UseVisualStyleBackColor = true;
            // 
            // m_spuNoStressOption
            // 
            this.m_spuNoStressOption.ForeColor = System.Drawing.Color.White;
            this.m_spuNoStressOption.Location = new System.Drawing.Point(19, 136);
            this.m_spuNoStressOption.Name = "m_spuNoStressOption";
            this.m_spuNoStressOption.Size = new System.Drawing.Size(357, 48);
            this.m_spuNoStressOption.TabIndex = 3;
            this.m_spuNoStressOption.Text = "No Stress on SPU ( Recommended to select this option if Advantech PCB is used. Th" +
    "is would allow only one port operation at any given time per SPU. Applicable to " +
    "Serial interface only )";
            this.m_spuNoStressOption.UseVisualStyleBackColor = true;
            // 
            // m_cpuAffinityOption
            // 
            this.m_cpuAffinityOption.ForeColor = System.Drawing.Color.White;
            this.m_cpuAffinityOption.Location = new System.Drawing.Point(19, 70);
            this.m_cpuAffinityOption.Name = "m_cpuAffinityOption";
            this.m_cpuAffinityOption.Size = new System.Drawing.Size(354, 50);
            this.m_cpuAffinityOption.TabIndex = 2;
            this.m_cpuAffinityOption.Text = "CPU Affinity ( Recommended to select this option if more than 4 SPUs are configur" +
    "ed. Applicable to Serial interface only )";
            this.m_cpuAffinityOption.UseVisualStyleBackColor = true;
            // 
            // m_spu3DebugOption
            // 
            this.m_spu3DebugOption.ForeColor = System.Drawing.Color.White;
            this.m_spu3DebugOption.Location = new System.Drawing.Point(19, 200);
            this.m_spu3DebugOption.Name = "m_spu3DebugOption";
            this.m_spu3DebugOption.Size = new System.Drawing.Size(341, 36);
            this.m_spu3DebugOption.TabIndex = 1;
            this.m_spu3DebugOption.Text = "SPU3 Debug ( Select this option to receive debug data from SPU3. Applicable to Se" +
    "rial interface only )";
            this.m_spu3DebugOption.UseVisualStyleBackColor = true;
            // 
            // m_fullSimulationOption
            // 
            this.m_fullSimulationOption.ForeColor = System.Drawing.Color.White;
            this.m_fullSimulationOption.Location = new System.Drawing.Point(19, 30);
            this.m_fullSimulationOption.Name = "m_fullSimulationOption";
            this.m_fullSimulationOption.Size = new System.Drawing.Size(354, 24);
            this.m_fullSimulationOption.TabIndex = 0;
            this.m_fullSimulationOption.Text = "Full Simulation ( Applicable to Serial interface only )";
            this.m_fullSimulationOption.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.btnOK.Location = new System.Drawing.Point(86, 404);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 53);
            this.btnOK.TabIndex = 92;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(258, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 53);
            this.btnCancel.TabIndex = 93;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MercuryServerOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(402, 473);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.serverOptionsTitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MercuryServerOptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.MercuryServerOptionsForm_Load);
            this.serverOptionsTitlePanel.ResumeLayout(false);
            this.serverOptionsTitlePanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel serverOptionsTitlePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox m_fixComPortsOption;
        private System.Windows.Forms.CheckBox m_spuNoStressOption;
        private System.Windows.Forms.CheckBox m_cpuAffinityOption;
        private System.Windows.Forms.CheckBox m_spu3DebugOption;
        private System.Windows.Forms.CheckBox m_fullSimulationOption;
    }
}