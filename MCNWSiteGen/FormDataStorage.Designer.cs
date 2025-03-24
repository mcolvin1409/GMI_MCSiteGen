namespace MCNWSiteGen
{
    partial class FormDataStorage
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxStandardPath = new System.Windows.Forms.TextBox();
            this.textBoxNetworkPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStandardPathBrows = new System.Windows.Forms.Button();
            this.btnNetworkPathBrows = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(334, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 51);
            this.btnCancel.TabIndex = 88;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-11, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 51);
            this.panel1.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(236, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Storage Paths";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxStandardPath);
            this.groupBox1.Controls.Add(this.textBoxNetworkPath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnStandardPathBrows);
            this.groupBox1.Controls.Add(this.btnNetworkPathBrows);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Location = new System.Drawing.Point(31, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 162);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration - LOCAL or GMINET network";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.SystemColors.Menu;
            this.label6.Location = new System.Drawing.Point(8, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 26);
            this.label6.TabIndex = 40;
            this.label6.Text = "Standard Form Storage Path";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxStandardPath
            // 
            this.textBoxStandardPath.CausesValidation = false;
            this.textBoxStandardPath.ForeColor = System.Drawing.Color.Black;
            this.textBoxStandardPath.HideSelection = false;
            this.textBoxStandardPath.Location = new System.Drawing.Point(119, 42);
            this.textBoxStandardPath.MaxLength = 100;
            this.textBoxStandardPath.Name = "textBoxStandardPath";
            this.textBoxStandardPath.Size = new System.Drawing.Size(328, 20);
            this.textBoxStandardPath.TabIndex = 36;
            this.textBoxStandardPath.TextChanged += new System.EventHandler(this.OnStandardPath_TextChanged);
            this.textBoxStandardPath.Leave += new System.EventHandler(this.OnTextBoxStandardPath_Leave);
            // 
            // textBoxNetworkPath
            // 
            this.textBoxNetworkPath.ForeColor = System.Drawing.Color.Black;
            this.textBoxNetworkPath.Location = new System.Drawing.Point(119, 100);
            this.textBoxNetworkPath.MaxLength = 100;
            this.textBoxNetworkPath.Name = "textBoxNetworkPath";
            this.textBoxNetworkPath.Size = new System.Drawing.Size(328, 20);
            this.textBoxNetworkPath.TabIndex = 37;
            this.textBoxNetworkPath.TextChanged += new System.EventHandler(this.OnNetworkPath_TextChanged);
            this.textBoxNetworkPath.Leave += new System.EventHandler(this.OnTextBoxNetworkPath_Leave);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(14, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 32);
            this.label2.TabIndex = 41;
            this.label2.Text = "Network Form Storage Path";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStandardPathBrows
            // 
            this.btnStandardPathBrows.ForeColor = System.Drawing.Color.Black;
            this.btnStandardPathBrows.Location = new System.Drawing.Point(479, 41);
            this.btnStandardPathBrows.Name = "btnStandardPathBrows";
            this.btnStandardPathBrows.Size = new System.Drawing.Size(61, 23);
            this.btnStandardPathBrows.TabIndex = 38;
            this.btnStandardPathBrows.Text = "Browse ..";
            this.btnStandardPathBrows.UseVisualStyleBackColor = true;
            this.btnStandardPathBrows.Click += new System.EventHandler(this.btnStandardPathBrows_Click);
            // 
            // btnNetworkPathBrows
            // 
            this.btnNetworkPathBrows.ForeColor = System.Drawing.Color.Black;
            this.btnNetworkPathBrows.Location = new System.Drawing.Point(480, 98);
            this.btnNetworkPathBrows.Name = "btnNetworkPathBrows";
            this.btnNetworkPathBrows.Size = new System.Drawing.Size(61, 23);
            this.btnNetworkPathBrows.TabIndex = 39;
            this.btnNetworkPathBrows.Text = "Browse ..";
            this.btnNetworkPathBrows.UseVisualStyleBackColor = true;
            this.btnNetworkPathBrows.Click += new System.EventHandler(this.btnNetworkPathBrows_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Image = global::MCNWSiteGen.Properties.Resources.OK48;
            this.btnOK.Location = new System.Drawing.Point(229, 258);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 51);
            this.btnOK.TabIndex = 84;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormDataStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(636, 337);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDataStorage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormDataStorage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxStandardPath;
        private System.Windows.Forms.TextBox textBoxNetworkPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStandardPathBrows;
        private System.Windows.Forms.Button btnNetworkPathBrows;
        private System.Windows.Forms.Button btnOK;
    }
}