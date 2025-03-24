namespace MCNWSiteGen
{
    partial class SiteInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.txtSiteNumber = new System.Windows.Forms.TextBox();
            this.txtTotalPresses = new System.Windows.Forms.TextBox();
            this.txtConfigVersion = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SITE name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SITE NUMBER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Number of Presses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Configuration Version";
            // 
            // txtSiteName
            // 
            this.txtSiteName.Location = new System.Drawing.Point(167, 12);
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(100, 20);
            this.txtSiteName.TabIndex = 4;
            this.txtSiteName.TextChanged += new System.EventHandler(this.txtSiteName_TextChanged);
            // 
            // txtSiteNumber
            // 
            this.txtSiteNumber.Location = new System.Drawing.Point(167, 60);
            this.txtSiteNumber.MaxLength = 5;
            this.txtSiteNumber.Name = "txtSiteNumber";
            this.txtSiteNumber.Size = new System.Drawing.Size(100, 20);
            this.txtSiteNumber.TabIndex = 5;
            this.txtSiteNumber.TextChanged += new System.EventHandler(this.txtSiteNumber_TextChanged);
            // 
            // txtTotalPresses
            // 
            this.txtTotalPresses.Location = new System.Drawing.Point(167, 105);
            this.txtTotalPresses.MaxLength = 2;
            this.txtTotalPresses.Name = "txtTotalPresses";
            this.txtTotalPresses.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPresses.TabIndex = 6;
            this.txtTotalPresses.TextChanged += new System.EventHandler(this.txtTotalPresses_TextChanged);
            // 
            // txtConfigVersion
            // 
            this.txtConfigVersion.Location = new System.Drawing.Point(167, 152);
            this.txtConfigVersion.MaxLength = 5;
            this.txtConfigVersion.Name = "txtConfigVersion";
            this.txtConfigVersion.Size = new System.Drawing.Size(100, 20);
            this.txtConfigVersion.TabIndex = 7;
            this.txtConfigVersion.TextChanged += new System.EventHandler(this.txtConfigVersion_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.btnOK.Location = new System.Drawing.Point(73, 205);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 51);
            this.btnOK.TabIndex = 8;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(149, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 51);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SiteInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(292, 275);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtConfigVersion);
            this.Controls.Add(this.txtTotalPresses);
            this.Controls.Add(this.txtSiteNumber);
            this.Controls.Add(this.txtSiteName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SiteInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Site Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSiteName;
        private System.Windows.Forms.TextBox txtSiteNumber;
        private System.Windows.Forms.TextBox txtTotalPresses;
        private System.Windows.Forms.TextBox txtConfigVersion;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}