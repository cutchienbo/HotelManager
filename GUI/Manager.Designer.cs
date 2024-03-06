namespace GUI
{
    partial class Manager
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
            this.panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.radClose = new System.Windows.Forms.RadioButton();
            this.radMaxsize = new System.Windows.Forms.RadioButton();
            this.radMinisize = new System.Windows.Forms.RadioButton();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AllowDrop = true;
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMain.AutoScroll = true;
            this.panelMain.AutoScrollMargin = new System.Drawing.Size(5, 0);
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.panelMain.Location = new System.Drawing.Point(0, 100);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(225, 723);
            this.panelMain.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.radMaxsize);
            this.panel1.Controls.Add(this.radMinisize);
            this.panel1.Controls.Add(this.radClose);
            this.panel1.Location = new System.Drawing.Point(224, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 99);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 99);
            this.panel2.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lblName.Location = new System.Drawing.Point(12, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 24);
            this.lblName.TabIndex = 1;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // radClose
            // 
            this.radClose.AutoSize = true;
            this.radClose.Location = new System.Drawing.Point(1204, 10);
            this.radClose.Name = "radClose";
            this.radClose.Size = new System.Drawing.Size(17, 16);
            this.radClose.TabIndex = 6;
            this.radClose.TabStop = true;
            this.radClose.UseVisualStyleBackColor = true;
            this.radClose.CheckedChanged += new System.EventHandler(this.radClose_CheckedChanged);
            // 
            // radMaxsize
            // 
            this.radMaxsize.AutoSize = true;
            this.radMaxsize.Enabled = false;
            this.radMaxsize.Location = new System.Drawing.Point(1181, 10);
            this.radMaxsize.Name = "radMaxsize";
            this.radMaxsize.Size = new System.Drawing.Size(17, 16);
            this.radMaxsize.TabIndex = 7;
            this.radMaxsize.TabStop = true;
            this.radMaxsize.UseVisualStyleBackColor = true;
            // 
            // radMinisize
            // 
            this.radMinisize.AutoSize = true;
            this.radMinisize.Location = new System.Drawing.Point(1158, 10);
            this.radMinisize.Name = "radMinisize";
            this.radMinisize.Size = new System.Drawing.Size(17, 16);
            this.radMinisize.TabIndex = 8;
            this.radMinisize.TabStop = true;
            this.radMinisize.UseVisualStyleBackColor = true;
            this.radMinisize.CheckedChanged += new System.EventHandler(this.radMinisize_CheckedChanged);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.Location = new System.Drawing.Point(228, 100);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1228, 723);
            this.panelChildForm.TabIndex = 6;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1457, 820);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton radMaxsize;
        private System.Windows.Forms.RadioButton radMinisize;
        private System.Windows.Forms.RadioButton radClose;
        private System.Windows.Forms.Panel panelChildForm;
    }
}