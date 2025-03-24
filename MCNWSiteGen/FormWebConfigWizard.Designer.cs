namespace MCNWSiteGen
{
    partial class FormWebConfigWizard
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxMaxWebs = new System.Windows.Forms.GroupBox();
            this.textBoxNumOfWebs = new System.Windows.Forms.TextBox();
            this.labelMaxWebs = new System.Windows.Forms.Label();
            this.groupBoxAirbarConfig = new System.Windows.Forms.GroupBox();
            this.textBoxNumOfAirbars = new System.Windows.Forms.TextBox();
            this.labelMaxAirbars = new System.Windows.Forms.Label();
            this.labelAfterWhichUnit = new System.Windows.Forms.Label();
            this.labelAirbarList = new System.Windows.Forms.Label();
            this.comboBoxWhichUnit = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.listBoxAirbarList = new System.Windows.Forms.ListBox();
            this.pnlWizardTitle.SuspendLayout();
            this.groupBoxMaxWebs.SuspendLayout();
            this.groupBoxAirbarConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWizardTitle
            // 
            this.pnlWizardTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlWizardTitle.Controls.Add(this.labelTitle);
            this.pnlWizardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWizardTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlWizardTitle.Name = "pnlWizardTitle";
            this.pnlWizardTitle.Size = new System.Drawing.Size(435, 36);
            this.pnlWizardTitle.TabIndex = 74;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(117, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(201, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Multi Web Configuration";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.buttonCancel.Location = new System.Drawing.Point(273, 486);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(68, 59);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.buttonOK.Location = new System.Drawing.Point(94, 486);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(68, 59);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBoxMaxWebs
            // 
            this.groupBoxMaxWebs.Controls.Add(this.textBoxNumOfWebs);
            this.groupBoxMaxWebs.Controls.Add(this.labelMaxWebs);
            this.groupBoxMaxWebs.Location = new System.Drawing.Point(19, 53);
            this.groupBoxMaxWebs.Name = "groupBoxMaxWebs";
            this.groupBoxMaxWebs.Size = new System.Drawing.Size(393, 74);
            this.groupBoxMaxWebs.TabIndex = 0;
            this.groupBoxMaxWebs.TabStop = false;
            // 
            // textBoxNumOfWebs
            // 
            this.textBoxNumOfWebs.Location = new System.Drawing.Point(153, 28);
            this.textBoxNumOfWebs.Name = "textBoxNumOfWebs";
            this.textBoxNumOfWebs.Size = new System.Drawing.Size(170, 21);
            this.textBoxNumOfWebs.TabIndex = 0;
            this.textBoxNumOfWebs.Text = "2";
            this.textBoxNumOfWebs.TextChanged += new System.EventHandler(this.textBoxMaxWebs_TextChanged);
            // 
            // labelMaxWebs
            // 
            this.labelMaxWebs.ForeColor = System.Drawing.Color.White;
            this.labelMaxWebs.Location = new System.Drawing.Point(34, 31);
            this.labelMaxWebs.Name = "labelMaxWebs";
            this.labelMaxWebs.Size = new System.Drawing.Size(112, 20);
            this.labelMaxWebs.TabIndex = 0;
            this.labelMaxWebs.Text = "Number of Webs";
            // 
            // groupBoxAirbarConfig
            // 
            this.groupBoxAirbarConfig.Controls.Add(this.textBoxNumOfAirbars);
            this.groupBoxAirbarConfig.Controls.Add(this.labelMaxAirbars);
            this.groupBoxAirbarConfig.Controls.Add(this.labelAfterWhichUnit);
            this.groupBoxAirbarConfig.Controls.Add(this.labelAirbarList);
            this.groupBoxAirbarConfig.Controls.Add(this.comboBoxWhichUnit);
            this.groupBoxAirbarConfig.Controls.Add(this.buttonUpdate);
            this.groupBoxAirbarConfig.Controls.Add(this.listBoxAirbarList);
            this.groupBoxAirbarConfig.ForeColor = System.Drawing.Color.White;
            this.groupBoxAirbarConfig.Location = new System.Drawing.Point(19, 134);
            this.groupBoxAirbarConfig.Name = "groupBoxAirbarConfig";
            this.groupBoxAirbarConfig.Size = new System.Drawing.Size(393, 320);
            this.groupBoxAirbarConfig.TabIndex = 1;
            this.groupBoxAirbarConfig.TabStop = false;
            this.groupBoxAirbarConfig.Text = "Configure Airbars";
            // 
            // textBoxNumOfAirbars
            // 
            this.textBoxNumOfAirbars.Location = new System.Drawing.Point(153, 29);
            this.textBoxNumOfAirbars.Name = "textBoxNumOfAirbars";
            this.textBoxNumOfAirbars.Size = new System.Drawing.Size(170, 21);
            this.textBoxNumOfAirbars.TabIndex = 0;
            this.textBoxNumOfAirbars.Text = "1";
            this.textBoxNumOfAirbars.TextChanged += new System.EventHandler(this.NumberOfAirbarsChanged);
            // 
            // labelMaxAirbars
            // 
            this.labelMaxAirbars.ForeColor = System.Drawing.Color.White;
            this.labelMaxAirbars.Location = new System.Drawing.Point(34, 33);
            this.labelMaxAirbars.Name = "labelMaxAirbars";
            this.labelMaxAirbars.Size = new System.Drawing.Size(112, 20);
            this.labelMaxAirbars.TabIndex = 5;
            this.labelMaxAirbars.Text = "Number of Airbars";
            // 
            // labelAfterWhichUnit
            // 
            this.labelAfterWhichUnit.ForeColor = System.Drawing.Color.White;
            this.labelAfterWhichUnit.Location = new System.Drawing.Point(34, 207);
            this.labelAfterWhichUnit.Name = "labelAfterWhichUnit";
            this.labelAfterWhichUnit.Size = new System.Drawing.Size(112, 20);
            this.labelAfterWhichUnit.TabIndex = 4;
            this.labelAfterWhichUnit.Text = "After which Unit?";
            // 
            // labelAirbarList
            // 
            this.labelAirbarList.ForeColor = System.Drawing.Color.White;
            this.labelAirbarList.Location = new System.Drawing.Point(34, 70);
            this.labelAirbarList.Name = "labelAirbarList";
            this.labelAirbarList.Size = new System.Drawing.Size(103, 17);
            this.labelAirbarList.TabIndex = 3;
            this.labelAirbarList.Text = "Airbar List";
            // 
            // comboBoxWhichUnit
            // 
            this.comboBoxWhichUnit.DropDownHeight = 100;
            this.comboBoxWhichUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWhichUnit.FormattingEnabled = true;
            this.comboBoxWhichUnit.IntegralHeight = false;
            this.comboBoxWhichUnit.Location = new System.Drawing.Point(153, 202);
            this.comboBoxWhichUnit.Name = "comboBoxWhichUnit";
            this.comboBoxWhichUnit.Size = new System.Drawing.Size(170, 23);
            this.comboBoxWhichUnit.TabIndex = 2;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdate.Location = new System.Drawing.Point(153, 252);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(170, 36);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // listBoxAirbarList
            // 
            this.listBoxAirbarList.FormattingEnabled = true;
            this.listBoxAirbarList.ItemHeight = 15;
            this.listBoxAirbarList.Location = new System.Drawing.Point(153, 70);
            this.listBoxAirbarList.Name = "listBoxAirbarList";
            this.listBoxAirbarList.Size = new System.Drawing.Size(170, 109);
            this.listBoxAirbarList.TabIndex = 1;
            this.listBoxAirbarList.SelectedIndexChanged += new System.EventHandler(this.AirbarList_SelectedIndexChanged);
            // 
            // FormWebConfigWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(435, 568);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxAirbarConfig);
            this.Controls.Add(this.groupBoxMaxWebs);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.pnlWizardTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWebConfigWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormWebConfigWizard_Load);
            this.pnlWizardTitle.ResumeLayout(false);
            this.pnlWizardTitle.PerformLayout();
            this.groupBoxMaxWebs.ResumeLayout(false);
            this.groupBoxMaxWebs.PerformLayout();
            this.groupBoxAirbarConfig.ResumeLayout(false);
            this.groupBoxAirbarConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWizardTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBoxMaxWebs;
        private System.Windows.Forms.GroupBox groupBoxAirbarConfig;
        private System.Windows.Forms.Label labelMaxWebs;
        private System.Windows.Forms.ComboBox comboBoxWhichUnit;
        private System.Windows.Forms.ListBox listBoxAirbarList;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxNumOfWebs;
        private System.Windows.Forms.Label labelAfterWhichUnit;
        private System.Windows.Forms.Label labelAirbarList;
        private System.Windows.Forms.TextBox textBoxNumOfAirbars;
        private System.Windows.Forms.Label labelMaxAirbars;
    }
}