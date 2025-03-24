namespace MCNWSiteGen
{
    partial class frmOCUSettings
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.txtMinVal = new System.Windows.Forms.TextBox();
            this.txtZoneWidth = new System.Windows.Forms.TextBox();
            this.txtNumOfZones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlWizardTitle = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlWizardTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.btnOK.Location = new System.Drawing.Point(83, 258);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 51);
            this.btnOK.TabIndex = 17;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Location = new System.Drawing.Point(167, 205);
            this.txtMaxValue.MaxLength = 5;
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(100, 20);
            this.txtMaxValue.TabIndex = 16;
            this.txtMaxValue.TextChanged += new System.EventHandler(this.txtMaxValue_TextChanged);
            // 
            // txtMinVal
            // 
            this.txtMinVal.Location = new System.Drawing.Point(167, 158);
            this.txtMinVal.MaxLength = 5;
            this.txtMinVal.Name = "txtMinVal";
            this.txtMinVal.Size = new System.Drawing.Size(100, 20);
            this.txtMinVal.TabIndex = 15;
            this.txtMinVal.TextChanged += new System.EventHandler(this.txtMinVal_TextChanged);
            // 
            // txtZoneWidth
            // 
            this.txtZoneWidth.Location = new System.Drawing.Point(167, 113);
            this.txtZoneWidth.MaxLength = 10;
            this.txtZoneWidth.Name = "txtZoneWidth";
            this.txtZoneWidth.Size = new System.Drawing.Size(100, 20);
            this.txtZoneWidth.TabIndex = 14;
            this.txtZoneWidth.TextChanged += new System.EventHandler(this.txtZoneWidth_TextChanged);
            // 
            // txtNumOfZones
            // 
            this.txtNumOfZones.Location = new System.Drawing.Point(167, 65);
            this.txtNumOfZones.MaxLength = 5;
            this.txtNumOfZones.Name = "txtNumOfZones";
            this.txtNumOfZones.Size = new System.Drawing.Size(100, 20);
            this.txtNumOfZones.TabIndex = 13;
            this.txtNumOfZones.TextChanged += new System.EventHandler(this.txtNumOfZones_TextChanged);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Max Value";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Min Value";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Zone Width in CM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number of Zones On OCU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(169, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 51);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlWizardTitle
            // 
            this.pnlWizardTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlWizardTitle.Controls.Add(this.label6);
            this.pnlWizardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWizardTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlWizardTitle.Name = "pnlWizardTitle";
            this.pnlWizardTitle.Size = new System.Drawing.Size(312, 31);
            this.pnlWizardTitle.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(93, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "OCU Settings";
            // 
            // frmOCUSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(312, 340);
            this.ControlBox = false;
            this.Controls.Add(this.pnlWizardTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtMaxValue);
            this.Controls.Add(this.txtMinVal);
            this.Controls.Add(this.txtZoneWidth);
            this.Controls.Add(this.txtNumOfZones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(19, 214);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOCUSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmOCUSettings_Load);
            this.pnlWizardTitle.ResumeLayout(false);
            this.pnlWizardTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.TextBox txtMinVal;
        private System.Windows.Forms.TextBox txtZoneWidth;
        private System.Windows.Forms.TextBox txtNumOfZones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlWizardTitle;
        private System.Windows.Forms.Label label6;
    }
}