namespace MCNWSiteGen
{
    partial class PressInformation
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
            this.txtPressWidth = new System.Windows.Forms.TextBox();
            this.txtPressName = new System.Windows.Forms.TextBox();
            this.txtPressType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.comboBoxPressType = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkCms = new System.Windows.Forms.CheckBox();
            this.chkInches = new System.Windows.Forms.CheckBox();
            this.chkMM = new System.Windows.Forms.CheckBox();
            this.lblUnits = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPressWidth
            // 
            this.txtPressWidth.Location = new System.Drawing.Point(102, 105);
            this.txtPressWidth.MaxLength = 5;
            this.txtPressWidth.Name = "txtPressWidth";
            this.txtPressWidth.Size = new System.Drawing.Size(198, 20);
            this.txtPressWidth.TabIndex = 15;
            this.txtPressWidth.TextChanged += new System.EventHandler(this.txtPressWidth_TextChanged);
            // 
            // txtPressName
            // 
            this.txtPressName.Location = new System.Drawing.Point(102, 60);
            this.txtPressName.Name = "txtPressName";
            this.txtPressName.Size = new System.Drawing.Size(198, 20);
            this.txtPressName.TabIndex = 14;
            this.txtPressName.TextChanged += new System.EventHandler(this.txtPressName_TextChanged);
            // 
            // txtPressType
            // 
            this.txtPressType.Location = new System.Drawing.Point(102, 34);
            this.txtPressType.Name = "txtPressType";
            this.txtPressType.ReadOnly = true;
            this.txtPressType.Size = new System.Drawing.Size(177, 20);
            this.txtPressType.TabIndex = 13;
            this.txtPressType.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Press Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Press Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Press Type";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(200, 313);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 51);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.btnOK.Location = new System.Drawing.Point(121, 313);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 51);
            this.btnOK.TabIndex = 17;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // comboBoxPressType
            // 
            this.comboBoxPressType.FormattingEnabled = true;
            this.comboBoxPressType.Items.AddRange(new object[] {
            "Unitized Web Press Without Turnbar",
            "Unitized Web Press With Turnbar",
            "Sheet fed Press",
            "Single Web Press",
            "Dual Web Press",
            "Newspaper Press",
            "Unknown Press Type"});
            this.comboBoxPressType.Location = new System.Drawing.Point(102, 11);
            this.comboBoxPressType.Name = "comboBoxPressType";
            this.comboBoxPressType.Size = new System.Drawing.Size(198, 21);
            this.comboBoxPressType.TabIndex = 19;
            this.comboBoxPressType.SelectedIndexChanged += new System.EventHandler(this.comboBoxPressType_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkCms);
            this.groupBox5.Controls.Add(this.chkInches);
            this.groupBox5.Controls.Add(this.chkMM);
            this.groupBox5.Location = new System.Drawing.Point(23, 170);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(306, 85);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Unit of measurement";
            // 
            // chkCms
            // 
            this.chkCms.AutoSize = true;
            this.chkCms.Checked = true;
            this.chkCms.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCms.Location = new System.Drawing.Point(123, 43);
            this.chkCms.Name = "chkCms";
            this.chkCms.Size = new System.Drawing.Size(45, 17);
            this.chkCms.TabIndex = 2;
            this.chkCms.Text = "cms";
            this.chkCms.UseVisualStyleBackColor = true;
            this.chkCms.CheckedChanged += new System.EventHandler(this.chkCms_CheckedChanged);
            // 
            // chkInches
            // 
            this.chkInches.AutoSize = true;
            this.chkInches.Location = new System.Drawing.Point(202, 43);
            this.chkInches.Name = "chkInches";
            this.chkInches.Size = new System.Drawing.Size(57, 17);
            this.chkInches.TabIndex = 1;
            this.chkInches.Text = "inches";
            this.chkInches.UseVisualStyleBackColor = true;
            this.chkInches.CheckedChanged += new System.EventHandler(this.chkInches_CheckedChanged);
            // 
            // chkMM
            // 
            this.chkMM.AutoSize = true;
            this.chkMM.Location = new System.Drawing.Point(47, 43);
            this.chkMM.Name = "chkMM";
            this.chkMM.Size = new System.Drawing.Size(42, 17);
            this.chkMM.TabIndex = 0;
            this.chkMM.Text = "mm";
            this.chkMM.UseVisualStyleBackColor = true;
            this.chkMM.CheckedChanged += new System.EventHandler(this.chkMM_CheckedChanged);
            // 
            // lblUnits
            // 
            this.lblUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnits.ForeColor = System.Drawing.Color.White;
            this.lblUnits.Location = new System.Drawing.Point(314, 104);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(100, 23);
            this.lblUnits.TabIndex = 21;
            this.lblUnits.Text = "cm";
            // 
            // PressInformation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(359, 389);
            this.ControlBox = false;
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.comboBoxPressType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPressWidth);
            this.Controls.Add(this.txtPressName);
            this.Controls.Add(this.txtPressType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(0, 61);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PressInformation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Press Information";
            this.Load += new System.EventHandler(this.PressInformation_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtPressWidth;
        private System.Windows.Forms.TextBox txtPressName;
        private System.Windows.Forms.TextBox txtPressType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboBoxPressType;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkCms;
        private System.Windows.Forms.CheckBox chkInches;
        private System.Windows.Forms.CheckBox chkMM;
        private System.Windows.Forms.Label lblUnits;
    }
}