namespace MCNWSiteGen
{
    partial class ClientDataPath
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientDataPath));
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClientConfigPathBrows = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_logFilePathBrowse = new System.Windows.Forms.Button();
            this.m_logFilePathTextBox = new System.Windows.Forms.TextBox();
            this.m_logFilePathLabel = new System.Windows.Forms.Label();
            this.buttonKeyboardLayouts = new System.Windows.Forms.Button();
            this.txtKeyboardLayouts = new System.Windows.Forms.TextBox();
            this.lblKeyboardLayouts = new System.Windows.Forms.Label();
            this.buttonHelpBrowse = new System.Windows.Forms.Button();
            this.textHelpPath = new System.Windows.Forms.TextBox();
            this.labelHelpPath = new System.Windows.Forms.Label();
            this.textClientConfig = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.Menu;
            this.label5.Location = new System.Drawing.Point(29, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 34);
            this.label5.TabIndex = 89;
            this.label5.Text = "Active Options File Path";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::MCNWSiteGen.Properties.Resources.cancel48;
            this.btnCancel.Location = new System.Drawing.Point(479, 385);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 63);
            this.btnCancel.TabIndex = 91;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(325, 385);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 63);
            this.btnOK.TabIndex = 90;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClientConfigPathBrows
            // 
            this.btnClientConfigPathBrows.ForeColor = System.Drawing.Color.Black;
            this.btnClientConfigPathBrows.Location = new System.Drawing.Point(715, 144);
            this.btnClientConfigPathBrows.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClientConfigPathBrows.Name = "btnClientConfigPathBrows";
            this.btnClientConfigPathBrows.Size = new System.Drawing.Size(81, 28);
            this.btnClientConfigPathBrows.TabIndex = 88;
            this.btnClientConfigPathBrows.Text = "Browse ..";
            this.btnClientConfigPathBrows.UseVisualStyleBackColor = true;
            this.btnClientConfigPathBrows.Click += new System.EventHandler(this.btnClientConfigPathBrows_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_logFilePathBrowse);
            this.groupBox1.Controls.Add(this.m_logFilePathTextBox);
            this.groupBox1.Controls.Add(this.m_logFilePathLabel);
            this.groupBox1.Controls.Add(this.buttonKeyboardLayouts);
            this.groupBox1.Controls.Add(this.txtKeyboardLayouts);
            this.groupBox1.Controls.Add(this.lblKeyboardLayouts);
            this.groupBox1.Controls.Add(this.buttonHelpBrowse);
            this.groupBox1.Controls.Add(this.textHelpPath);
            this.groupBox1.Controls.Add(this.labelHelpPath);
            this.groupBox1.Controls.Add(this.textClientConfig);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Location = new System.Drawing.Point(16, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(820, 258);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Path Settings - LOCAL";
            // 
            // m_logFilePathBrowse
            // 
            this.m_logFilePathBrowse.ForeColor = System.Drawing.Color.Black;
            this.m_logFilePathBrowse.Location = new System.Drawing.Point(699, 192);
            this.m_logFilePathBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_logFilePathBrowse.Name = "m_logFilePathBrowse";
            this.m_logFilePathBrowse.Size = new System.Drawing.Size(81, 28);
            this.m_logFilePathBrowse.TabIndex = 95;
            this.m_logFilePathBrowse.Text = "Browse ..";
            this.m_logFilePathBrowse.UseVisualStyleBackColor = true;
            this.m_logFilePathBrowse.Click += new System.EventHandler(this.OnLogFilesPathBrowseClick);
            // 
            // m_logFilePathTextBox
            // 
            this.m_logFilePathTextBox.Location = new System.Drawing.Point(199, 192);
            this.m_logFilePathTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_logFilePathTextBox.Name = "m_logFilePathTextBox";
            this.m_logFilePathTextBox.Size = new System.Drawing.Size(456, 22);
            this.m_logFilePathTextBox.TabIndex = 94;
            this.m_logFilePathTextBox.Leave += new System.EventHandler(this.OnLogFilePathTextBox_Leave);
            // 
            // m_logFilePathLabel
            // 
            this.m_logFilePathLabel.Location = new System.Drawing.Point(49, 196);
            this.m_logFilePathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_logFilePathLabel.Name = "m_logFilePathLabel";
            this.m_logFilePathLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.m_logFilePathLabel.Size = new System.Drawing.Size(133, 28);
            this.m_logFilePathLabel.TabIndex = 93;
            this.m_logFilePathLabel.Text = "Log File(s) Path";
            // 
            // buttonKeyboardLayouts
            // 
            this.buttonKeyboardLayouts.ForeColor = System.Drawing.Color.Black;
            this.buttonKeyboardLayouts.Location = new System.Drawing.Point(699, 138);
            this.buttonKeyboardLayouts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonKeyboardLayouts.Name = "buttonKeyboardLayouts";
            this.buttonKeyboardLayouts.Size = new System.Drawing.Size(81, 28);
            this.buttonKeyboardLayouts.TabIndex = 92;
            this.buttonKeyboardLayouts.Text = "Browse ..";
            this.buttonKeyboardLayouts.UseVisualStyleBackColor = true;
            this.buttonKeyboardLayouts.Click += new System.EventHandler(this.buttonKeyboardLayouts_Click);
            // 
            // txtKeyboardLayouts
            // 
            this.txtKeyboardLayouts.BackColor = System.Drawing.SystemColors.Control;
            this.txtKeyboardLayouts.Location = new System.Drawing.Point(199, 140);
            this.txtKeyboardLayouts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKeyboardLayouts.Name = "txtKeyboardLayouts";
            this.txtKeyboardLayouts.Size = new System.Drawing.Size(456, 22);
            this.txtKeyboardLayouts.TabIndex = 91;
            // 
            // lblKeyboardLayouts
            // 
            this.lblKeyboardLayouts.AutoSize = true;
            this.lblKeyboardLayouts.Location = new System.Drawing.Point(52, 144);
            this.lblKeyboardLayouts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKeyboardLayouts.Name = "lblKeyboardLayouts";
            this.lblKeyboardLayouts.Size = new System.Drawing.Size(127, 17);
            this.lblKeyboardLayouts.TabIndex = 90;
            this.lblKeyboardLayouts.Text = "Keyboard Layouts:";
            // 
            // buttonHelpBrowse
            // 
            this.buttonHelpBrowse.ForeColor = System.Drawing.Color.Black;
            this.buttonHelpBrowse.Location = new System.Drawing.Point(699, 86);
            this.buttonHelpBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonHelpBrowse.Name = "buttonHelpBrowse";
            this.buttonHelpBrowse.Size = new System.Drawing.Size(81, 28);
            this.buttonHelpBrowse.TabIndex = 89;
            this.buttonHelpBrowse.Text = "Browse ..";
            this.buttonHelpBrowse.UseVisualStyleBackColor = true;
            this.buttonHelpBrowse.Click += new System.EventHandler(this.buttonHelpBrowse_Click);
            // 
            // textHelpPath
            // 
            this.textHelpPath.BackColor = System.Drawing.SystemColors.Control;
            this.textHelpPath.Location = new System.Drawing.Point(199, 89);
            this.textHelpPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textHelpPath.Name = "textHelpPath";
            this.textHelpPath.Size = new System.Drawing.Size(456, 22);
            this.textHelpPath.TabIndex = 2;
            // 
            // labelHelpPath
            // 
            this.labelHelpPath.AutoSize = true;
            this.labelHelpPath.Location = new System.Drawing.Point(67, 92);
            this.labelHelpPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHelpPath.Name = "labelHelpPath";
            this.labelHelpPath.Size = new System.Drawing.Size(113, 17);
            this.labelHelpPath.TabIndex = 1;
            this.labelHelpPath.Text = "Help File(s) Path";
            // 
            // textClientConfig
            // 
            this.textClientConfig.Location = new System.Drawing.Point(199, 42);
            this.textClientConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textClientConfig.Name = "textClientConfig";
            this.textClientConfig.Size = new System.Drawing.Size(456, 22);
            this.textClientConfig.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(323, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Path Configuration";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 50);
            this.panel1.TabIndex = 93;
            // 
            // ClientDataPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(875, 464);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClientConfigPathBrows);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientDataPath";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ClientDataPath_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClientConfigPathBrows;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textClientConfig;
        private System.Windows.Forms.Button buttonHelpBrowse;
        private System.Windows.Forms.TextBox textHelpPath;
        private System.Windows.Forms.Label labelHelpPath;
        private System.Windows.Forms.Button buttonKeyboardLayouts;
        private System.Windows.Forms.TextBox txtKeyboardLayouts;
        private System.Windows.Forms.Label lblKeyboardLayouts;
        private System.Windows.Forms.Button m_logFilePathBrowse;
        private System.Windows.Forms.TextBox m_logFilePathTextBox;
        private System.Windows.Forms.Label m_logFilePathLabel;

    }
}