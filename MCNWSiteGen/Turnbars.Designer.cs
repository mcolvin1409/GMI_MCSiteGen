namespace MCNWSiteGen
{
    partial class Turnbars
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
            this.txtTurnBarCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTurnBars = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPredecessor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnInkerNameChange = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlWizardTitle = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlWizardTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTurnBarCount
            // 
            this.txtTurnBarCount.Location = new System.Drawing.Point(126, 57);
            this.txtTurnBarCount.MaxLength = 1;
            this.txtTurnBarCount.Name = "txtTurnBarCount";
            this.txtTurnBarCount.Size = new System.Drawing.Size(100, 20);
            this.txtTurnBarCount.TabIndex = 0;
            this.txtTurnBarCount.TextChanged += new System.EventHandler(this.txtTurnBarCount_TextChanged);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Turnbars";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboTurnBars
            // 
            this.cboTurnBars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboTurnBars.FormattingEnabled = true;
            this.cboTurnBars.Location = new System.Drawing.Point(126, 93);
            this.cboTurnBars.Name = "cboTurnBars";
            this.cboTurnBars.Size = new System.Drawing.Size(100, 80);
            this.cboTurnBars.TabIndex = 2;
            this.cboTurnBars.SelectedIndexChanged += new System.EventHandler(this.cboTurnBars_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(15, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Turn Bar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboPredecessor
            // 
            this.cboPredecessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPredecessor.FormattingEnabled = true;
            this.cboPredecessor.Location = new System.Drawing.Point(126, 185);
            this.cboPredecessor.Name = "cboPredecessor";
            this.cboPredecessor.Size = new System.Drawing.Size(100, 21);
            this.cboPredecessor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(23, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "After Which Unit:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.ForeColor = System.Drawing.Color.White;
            this.chkActive.Location = new System.Drawing.Point(12, 210);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 6;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(126, 239);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Update";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnInkerNameChange
            // 
            this.btnInkerNameChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInkerNameChange.ForeColor = System.Drawing.Color.Black;
            this.btnInkerNameChange.Location = new System.Drawing.Point(232, 93);
            this.btnInkerNameChange.Name = "btnInkerNameChange";
            this.btnInkerNameChange.Size = new System.Drawing.Size(35, 23);
            this.btnInkerNameChange.TabIndex = 25;
            this.btnInkerNameChange.Text = "...";
            this.btnInkerNameChange.UseVisualStyleBackColor = true;
            this.btnInkerNameChange.Click += new System.EventHandler(this.btnInkerNameChange_Click);
            // 
            // button1
            // 
            this.button1.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.button1.Location = new System.Drawing.Point(75, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 51);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(152, 292);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 51);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlWizardTitle
            // 
            this.pnlWizardTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlWizardTitle.Controls.Add(this.label5);
            this.pnlWizardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWizardTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlWizardTitle.Name = "pnlWizardTitle";
            this.pnlWizardTitle.Size = new System.Drawing.Size(292, 31);
            this.pnlWizardTitle.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(92, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Turn bars";
            // 
            // Turnbars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(292, 370);
            this.ControlBox = false;
            this.Controls.Add(this.pnlWizardTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInkerNameChange);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboPredecessor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTurnBars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTurnBarCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Turnbars";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Turnbars_Load);
            this.pnlWizardTitle.ResumeLayout(false);
            this.pnlWizardTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTurnBarCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTurnBars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPredecessor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnInkerNameChange;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlWizardTitle;
        private System.Windows.Forms.Label label5;
    }
}