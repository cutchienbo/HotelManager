namespace GUI.ChildForms
{
    partial class FormConfig
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
            this.lblCheckInTime = new System.Windows.Forms.Label();
            this.lblCheckOutTime = new System.Windows.Forms.Label();
            this.lblCheckinTimeValue = new System.Windows.Forms.Label();
            this.lblCheckoutTimeValue = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.grpConfigInfo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numCheckoutMinute = new System.Windows.Forms.NumericUpDown();
            this.numCheckinMinute = new System.Windows.Forms.NumericUpDown();
            this.numCheckoutHour = new System.Windows.Forms.NumericUpDown();
            this.numCheckinHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpConfigInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckoutMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckinMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckoutHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckinHour)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCheckInTime
            // 
            this.lblCheckInTime.AutoSize = true;
            this.lblCheckInTime.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInTime.ForeColor = System.Drawing.Color.White;
            this.lblCheckInTime.Location = new System.Drawing.Point(23, 49);
            this.lblCheckInTime.Name = "lblCheckInTime";
            this.lblCheckInTime.Size = new System.Drawing.Size(122, 19);
            this.lblCheckInTime.TabIndex = 0;
            this.lblCheckInTime.Text = "Check-in time:";
            // 
            // lblCheckOutTime
            // 
            this.lblCheckOutTime.AutoSize = true;
            this.lblCheckOutTime.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOutTime.ForeColor = System.Drawing.Color.White;
            this.lblCheckOutTime.Location = new System.Drawing.Point(23, 94);
            this.lblCheckOutTime.Name = "lblCheckOutTime";
            this.lblCheckOutTime.Size = new System.Drawing.Size(134, 19);
            this.lblCheckOutTime.TabIndex = 1;
            this.lblCheckOutTime.Text = "Check-out time:";
            // 
            // lblCheckinTimeValue
            // 
            this.lblCheckinTimeValue.AutoSize = true;
            this.lblCheckinTimeValue.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckinTimeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lblCheckinTimeValue.Location = new System.Drawing.Point(184, 49);
            this.lblCheckinTimeValue.Name = "lblCheckinTimeValue";
            this.lblCheckinTimeValue.Size = new System.Drawing.Size(0, 19);
            this.lblCheckinTimeValue.TabIndex = 2;
            // 
            // lblCheckoutTimeValue
            // 
            this.lblCheckoutTimeValue.AutoSize = true;
            this.lblCheckoutTimeValue.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckoutTimeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lblCheckoutTimeValue.Location = new System.Drawing.Point(184, 94);
            this.lblCheckoutTimeValue.Name = "lblCheckoutTimeValue";
            this.lblCheckoutTimeValue.Size = new System.Drawing.Size(0, 19);
            this.lblCheckoutTimeValue.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 571);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // grpConfigInfo
            // 
            this.grpConfigInfo.Controls.Add(this.lblCheckInTime);
            this.grpConfigInfo.Controls.Add(this.lblCheckOutTime);
            this.grpConfigInfo.Controls.Add(this.lblCheckinTimeValue);
            this.grpConfigInfo.Controls.Add(this.lblCheckoutTimeValue);
            this.grpConfigInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConfigInfo.ForeColor = System.Drawing.Color.White;
            this.grpConfigInfo.Location = new System.Drawing.Point(23, 20);
            this.grpConfigInfo.Name = "grpConfigInfo";
            this.grpConfigInfo.Size = new System.Drawing.Size(428, 199);
            this.grpConfigInfo.TabIndex = 7;
            this.grpConfigInfo.TabStop = false;
            this.grpConfigInfo.Text = "Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numCheckoutMinute);
            this.groupBox1.Controls.Add(this.numCheckinMinute);
            this.groupBox1.Controls.Add(this.numCheckoutHour);
            this.groupBox1.Controls.Add(this.numCheckinHour);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(472, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 199);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 30;
            this.btnSave.Location = new System.Drawing.Point(368, 135);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 46);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // numCheckoutMinute
            // 
            this.numCheckoutMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.numCheckoutMinute.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCheckoutMinute.ForeColor = System.Drawing.Color.White;
            this.numCheckoutMinute.Location = new System.Drawing.Point(285, 92);
            this.numCheckoutMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numCheckoutMinute.Name = "numCheckoutMinute";
            this.numCheckoutMinute.Size = new System.Drawing.Size(77, 27);
            this.numCheckoutMinute.TabIndex = 5;
            this.numCheckoutMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numCheckinMinute
            // 
            this.numCheckinMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.numCheckinMinute.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCheckinMinute.ForeColor = System.Drawing.Color.White;
            this.numCheckinMinute.Location = new System.Drawing.Point(285, 47);
            this.numCheckinMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numCheckinMinute.Name = "numCheckinMinute";
            this.numCheckinMinute.Size = new System.Drawing.Size(77, 27);
            this.numCheckinMinute.TabIndex = 4;
            this.numCheckinMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numCheckoutHour
            // 
            this.numCheckoutHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.numCheckoutHour.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCheckoutHour.ForeColor = System.Drawing.Color.White;
            this.numCheckoutHour.Location = new System.Drawing.Point(185, 92);
            this.numCheckoutHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numCheckoutHour.Name = "numCheckoutHour";
            this.numCheckoutHour.Size = new System.Drawing.Size(77, 27);
            this.numCheckoutHour.TabIndex = 3;
            this.numCheckoutHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numCheckinHour
            // 
            this.numCheckinHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.numCheckinHour.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCheckinHour.ForeColor = System.Drawing.Color.White;
            this.numCheckinHour.Location = new System.Drawing.Point(185, 47);
            this.numCheckinHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numCheckinHour.Name = "numCheckinHour";
            this.numCheckinHour.Size = new System.Drawing.Size(77, 27);
            this.numCheckinHour.TabIndex = 2;
            this.numCheckinHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check-in time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Check-out time:";
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1003, 571);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpConfigInfo);
            this.Controls.Add(this.splitter1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConfig";
            this.Text = "FomConfig";
            this.grpConfigInfo.ResumeLayout(false);
            this.grpConfigInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckoutMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckinMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckoutHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckinHour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCheckInTime;
        private System.Windows.Forms.Label lblCheckOutTime;
        private System.Windows.Forms.Label lblCheckinTimeValue;
        private System.Windows.Forms.Label lblCheckoutTimeValue;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox grpConfigInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCheckoutMinute;
        private System.Windows.Forms.NumericUpDown numCheckinMinute;
        private System.Windows.Forms.NumericUpDown numCheckoutHour;
        private System.Windows.Forms.NumericUpDown numCheckinHour;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}