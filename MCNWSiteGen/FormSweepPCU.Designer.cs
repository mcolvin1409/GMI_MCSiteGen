namespace MCNWSiteGen
{
    partial class FormSweepPCU
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
            this.txtDistNudge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.gpPCUSettings = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlWizardTitle = new System.Windows.Forms.Panel();
            this.txtPulseWidth = new System.Windows.Forms.TextBox();
            this.txtMaxStalls = new System.Windows.Forms.TextBox();
            this.txtTolerance = new System.Windows.Forms.TextBox();
            this.gpPCUSettings.SuspendLayout();
            this.pnlWizardTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDistNudge
            // 
            this.txtDistNudge.Location = new System.Drawing.Point(170, 70);
            this.txtDistNudge.MaxLength = 5;
            this.txtDistNudge.Name = "txtDistNudge";
            this.txtDistNudge.Size = new System.Drawing.Size(100, 20);
            this.txtDistNudge.TabIndex = 2;
            this.txtDistNudge.TextChanged += new System.EventHandler(this.txtDistNudge_TextChanged);
            this.txtDistNudge.Leave += new System.EventHandler(this.txtDistNudge_Leave);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tolerance";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(137, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(104, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "PCU Sweep";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(215, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 51);
            this.btnCancel.TabIndex = 80;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.btnOK.Location = new System.Drawing.Point(132, 280);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 51);
            this.btnOK.TabIndex = 79;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gpPCUSettings
            // 
            this.gpPCUSettings.Controls.Add(this.txtTolerance);
            this.gpPCUSettings.Controls.Add(this.txtMaxStalls);
            this.gpPCUSettings.Controls.Add(this.txtPulseWidth);
            this.gpPCUSettings.Controls.Add(this.txtDistNudge);
            this.gpPCUSettings.Controls.Add(this.label4);
            this.gpPCUSettings.Controls.Add(this.label3);
            this.gpPCUSettings.Controls.Add(this.label2);
            this.gpPCUSettings.Controls.Add(this.label1);
            this.gpPCUSettings.ForeColor = System.Drawing.Color.White;
            this.gpPCUSettings.Location = new System.Drawing.Point(45, 51);
            this.gpPCUSettings.Name = "gpPCUSettings";
            this.gpPCUSettings.Size = new System.Drawing.Size(310, 206);
            this.gpPCUSettings.TabIndex = 78;
            this.gpPCUSettings.TabStop = false;
            this.gpPCUSettings.Text = "PCU Settings";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max Stalls";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distance to Nudge";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pulse Width (ms)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlWizardTitle
            // 
            this.pnlWizardTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlWizardTitle.Controls.Add(this.labelTitle);
            this.pnlWizardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWizardTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlWizardTitle.Name = "pnlWizardTitle";
            this.pnlWizardTitle.Size = new System.Drawing.Size(403, 31);
            this.pnlWizardTitle.TabIndex = 77;
            // 
            // txtPulseWidth
            // 
            this.txtPulseWidth.Location = new System.Drawing.Point(170, 34);
            this.txtPulseWidth.MaxLength = 5;
            this.txtPulseWidth.Name = "txtPulseWidth";
            this.txtPulseWidth.Size = new System.Drawing.Size(100, 20);
            this.txtPulseWidth.TabIndex = 1;
            this.txtPulseWidth.TextChanged += new System.EventHandler(this.txtPulseWidth_TextChanged);
            this.txtPulseWidth.Leave += new System.EventHandler(this.txtPulseWidth_Leave);
            // 
            // txtMaxStalls
            // 
            this.txtMaxStalls.Location = new System.Drawing.Point(170, 111);
            this.txtMaxStalls.MaxLength = 5;
            this.txtMaxStalls.Name = "txtMaxStalls";
            this.txtMaxStalls.Size = new System.Drawing.Size(100, 20);
            this.txtMaxStalls.TabIndex = 3;
            this.txtMaxStalls.TextChanged += new System.EventHandler(this.txtMaxStalls_TextChanged);
            this.txtMaxStalls.Leave += new System.EventHandler(this.txtMaxStalls_Leave);
            // 
            // txtTolerance
            // 
            this.txtTolerance.Location = new System.Drawing.Point(170, 147);
            this.txtTolerance.MaxLength = 5;
            this.txtTolerance.Name = "txtTolerance";
            this.txtTolerance.Size = new System.Drawing.Size(100, 20);
            this.txtTolerance.TabIndex = 4;
            this.txtTolerance.TextChanged += new System.EventHandler(this.txtTolerance_TextChanged);
            this.txtTolerance.Leave += new System.EventHandler(this.txtTolerance_Leave);
            // 
            // FormSweepPCUCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(403, 367);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gpPCUSettings);
            this.Controls.Add(this.pnlWizardTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSweepPCUCtrl";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormSweepPCU_Load);
            this.gpPCUSettings.ResumeLayout(false);
            this.gpPCUSettings.PerformLayout();
            this.pnlWizardTitle.ResumeLayout(false);
            this.pnlWizardTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDistNudge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox gpPCUSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlWizardTitle;
        private System.Windows.Forms.TextBox txtPulseWidth;
        private System.Windows.Forms.TextBox txtMaxStalls;
        private System.Windows.Forms.TextBox txtTolerance;
    }
}