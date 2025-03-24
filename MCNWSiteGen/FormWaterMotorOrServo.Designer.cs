namespace MCNWSiteGen
{
    partial class FormWaterMotorOrServo
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
            this.labelWaterMotorOrServo = new System.Windows.Forms.Label();
            this.pnlWizardTitle = new System.Windows.Forms.Panel();
            this.gpMotorServoSettings = new System.Windows.Forms.GroupBox();
            this.textBoxIncrementalSurge = new System.Windows.Forms.TextBox();
            this.textBoxServoTurns = new System.Windows.Forms.TextBox();
            this.comboUseBank1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboSpecialMapping = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboReversed = new System.Windows.Forms.ComboBox();
            this.txtBoxInitialSurge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnlWizardTitle.SuspendLayout();
            this.gpMotorServoSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWaterMotorOrServo
            // 
            this.labelWaterMotorOrServo.AutoSize = true;
            this.labelWaterMotorOrServo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaterMotorOrServo.ForeColor = System.Drawing.Color.Black;
            this.labelWaterMotorOrServo.Location = new System.Drawing.Point(118, 9);
            this.labelWaterMotorOrServo.Name = "labelWaterMotorOrServo";
            this.labelWaterMotorOrServo.Size = new System.Drawing.Size(108, 20);
            this.labelWaterMotorOrServo.TabIndex = 0;
            this.labelWaterMotorOrServo.Text = "Motor Water";
            // 
            // pnlWizardTitle
            // 
            this.pnlWizardTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlWizardTitle.Controls.Add(this.labelWaterMotorOrServo);
            this.pnlWizardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWizardTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlWizardTitle.Name = "pnlWizardTitle";
            this.pnlWizardTitle.Size = new System.Drawing.Size(370, 31);
            this.pnlWizardTitle.TabIndex = 82;
            // 
            // gpMotorServoSettings
            // 
            this.gpMotorServoSettings.Controls.Add(this.textBoxIncrementalSurge);
            this.gpMotorServoSettings.Controls.Add(this.textBoxServoTurns);
            this.gpMotorServoSettings.Controls.Add(this.comboUseBank1);
            this.gpMotorServoSettings.Controls.Add(this.label7);
            this.gpMotorServoSettings.Controls.Add(this.comboSpecialMapping);
            this.gpMotorServoSettings.Controls.Add(this.label6);
            this.gpMotorServoSettings.Controls.Add(this.comboReversed);
            this.gpMotorServoSettings.Controls.Add(this.txtBoxInitialSurge);
            this.gpMotorServoSettings.Controls.Add(this.label4);
            this.gpMotorServoSettings.Controls.Add(this.label3);
            this.gpMotorServoSettings.Controls.Add(this.label2);
            this.gpMotorServoSettings.Controls.Add(this.label1);
            this.gpMotorServoSettings.ForeColor = System.Drawing.Color.White;
            this.gpMotorServoSettings.Location = new System.Drawing.Point(38, 53);
            this.gpMotorServoSettings.Name = "gpMotorServoSettings";
            this.gpMotorServoSettings.Size = new System.Drawing.Size(287, 276);
            this.gpMotorServoSettings.TabIndex = 83;
            this.gpMotorServoSettings.TabStop = false;
            this.gpMotorServoSettings.Text = "Motor Control";
            // 
            // textBoxIncrementalSurge
            // 
            this.textBoxIncrementalSurge.Location = new System.Drawing.Point(170, 110);
            this.textBoxIncrementalSurge.MaxLength = 3;
            this.textBoxIncrementalSurge.Name = "textBoxIncrementalSurge";
            this.textBoxIncrementalSurge.Size = new System.Drawing.Size(100, 20);
            this.textBoxIncrementalSurge.TabIndex = 16;
            this.textBoxIncrementalSurge.Leave += new System.EventHandler(this.textBoxIncrementalSurge_Leave);
            this.textBoxIncrementalSurge.TextChanged += new System.EventHandler(this.textBoxIncrementalSurge_TextChanged);
            // 
            // textBoxServoTurns
            // 
            this.textBoxServoTurns.Location = new System.Drawing.Point(170, 30);
            this.textBoxServoTurns.MaxLength = 5;
            this.textBoxServoTurns.Name = "textBoxServoTurns";
            this.textBoxServoTurns.Size = new System.Drawing.Size(100, 20);
            this.textBoxServoTurns.TabIndex = 15;
            this.textBoxServoTurns.Leave += new System.EventHandler(this.textBoxServoTurns_Leave);
            this.textBoxServoTurns.TextChanged += new System.EventHandler(this.textBoxServoTurns_TextChanged);
            // 
            // comboUseBank1
            // 
            this.comboUseBank1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUseBank1.FormattingEnabled = true;
            this.comboUseBank1.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboUseBank1.Location = new System.Drawing.Point(170, 230);
            this.comboUseBank1.Name = "comboUseBank1";
            this.comboUseBank1.Size = new System.Drawing.Size(100, 21);
            this.comboUseBank1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Use Bank 1";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboSpecialMapping
            // 
            this.comboSpecialMapping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSpecialMapping.FormattingEnabled = true;
            this.comboSpecialMapping.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboSpecialMapping.Location = new System.Drawing.Point(170, 190);
            this.comboSpecialMapping.Name = "comboSpecialMapping";
            this.comboSpecialMapping.Size = new System.Drawing.Size(100, 21);
            this.comboSpecialMapping.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Special Mapping";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboReversed
            // 
            this.comboReversed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboReversed.FormattingEnabled = true;
            this.comboReversed.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboReversed.Location = new System.Drawing.Point(170, 150);
            this.comboReversed.Name = "comboReversed";
            this.comboReversed.Size = new System.Drawing.Size(100, 21);
            this.comboReversed.TabIndex = 9;
            // 
            // txtBoxInitialSurge
            // 
            this.txtBoxInitialSurge.Location = new System.Drawing.Point(170, 70);
            this.txtBoxInitialSurge.MaxLength = 5;
            this.txtBoxInitialSurge.Name = "txtBoxInitialSurge";
            this.txtBoxInitialSurge.Size = new System.Drawing.Size(100, 20);
            this.txtBoxInitialSurge.TabIndex = 3;
            this.txtBoxInitialSurge.Leave += new System.EventHandler(this.txtBoxInitialSurge_Leave);
            this.txtBoxInitialSurge.TextChanged += new System.EventHandler(this.txtBoxInitialSurge_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reversed";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Incremental Surge";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Servo Turns";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Surge";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(184, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 51);
            this.btnCancel.TabIndex = 85;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.btnOK.Location = new System.Drawing.Point(101, 347);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 51);
            this.btnOK.TabIndex = 84;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormWaterMotorOrServo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(370, 415);
            this.ControlBox = false;
            this.Controls.Add(this.pnlWizardTitle);
            this.Controls.Add(this.gpMotorServoSettings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWaterMotorOrServo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormWaterMotorOrServo_Load);
            this.pnlWizardTitle.ResumeLayout(false);
            this.pnlWizardTitle.PerformLayout();
            this.gpMotorServoSettings.ResumeLayout(false);
            this.gpMotorServoSettings.PerformLayout();
            this.ResumeLayout(false);

        }        

        #endregion

        private System.Windows.Forms.Label labelWaterMotorOrServo;
        private System.Windows.Forms.Panel pnlWizardTitle;
        private System.Windows.Forms.GroupBox gpMotorServoSettings;
        private System.Windows.Forms.TextBox textBoxIncrementalSurge;
        private System.Windows.Forms.TextBox textBoxServoTurns;
        private System.Windows.Forms.ComboBox comboUseBank1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboSpecialMapping;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboReversed;
        private System.Windows.Forms.TextBox txtBoxInitialSurge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}