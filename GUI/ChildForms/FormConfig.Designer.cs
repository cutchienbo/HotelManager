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
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numCheckoutMinute = new System.Windows.Forms.NumericUpDown();
            this.numCheckinMinute = new System.Windows.Forms.NumericUpDown();
            this.numCheckoutHour = new System.Windows.Forms.NumericUpDown();
            this.numCheckinHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.lblCheckInTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lblCheckInTime.Location = new System.Drawing.Point(57, 69);
            this.lblCheckInTime.Name = "lblCheckInTime";
            this.lblCheckInTime.Size = new System.Drawing.Size(122, 19);
            this.lblCheckInTime.TabIndex = 0;
            this.lblCheckInTime.Text = "Check-in time:";
            this.lblCheckInTime.Click += new System.EventHandler(this.lblCheckInTime_Click);
            // 
            // lblCheckOutTime
            // 
            this.lblCheckOutTime.AutoSize = true;
            this.lblCheckOutTime.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOutTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lblCheckOutTime.Location = new System.Drawing.Point(57, 114);
            this.lblCheckOutTime.Name = "lblCheckOutTime";
            this.lblCheckOutTime.Size = new System.Drawing.Size(134, 19);
            this.lblCheckOutTime.TabIndex = 1;
            this.lblCheckOutTime.Text = "Check-out time:";
            // 
            // lblCheckinTimeValue
            // 
            this.lblCheckinTimeValue.AutoSize = true;
            this.lblCheckinTimeValue.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckinTimeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lblCheckinTimeValue.Location = new System.Drawing.Point(197, 69);
            this.lblCheckinTimeValue.Name = "lblCheckinTimeValue";
            this.lblCheckinTimeValue.Size = new System.Drawing.Size(36, 19);
            this.lblCheckinTimeValue.TabIndex = 2;
            this.lblCheckinTimeValue.Text = "123";
            // 
            // lblCheckoutTimeValue
            // 
            this.lblCheckoutTimeValue.AutoSize = true;
            this.lblCheckoutTimeValue.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckoutTimeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lblCheckoutTimeValue.Location = new System.Drawing.Point(197, 114);
            this.lblCheckoutTimeValue.Name = "lblCheckoutTimeValue";
            this.lblCheckoutTimeValue.Size = new System.Drawing.Size(36, 19);
            this.lblCheckoutTimeValue.TabIndex = 3;
            this.lblCheckoutTimeValue.Text = "123";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 716);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(97)))));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(97)))));
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 30;
            this.btnSave.Location = new System.Drawing.Point(644, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(181, 46);
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
            this.label4.Location = new System.Drawing.Point(727, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(727, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // numCheckoutMinute
            // 
            this.numCheckoutMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.numCheckoutMinute.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCheckoutMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.numCheckoutMinute.Location = new System.Drawing.Point(748, 112);
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
            this.numCheckinMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.numCheckinMinute.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCheckinMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.numCheckinMinute.Location = new System.Drawing.Point(748, 67);
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
            this.numCheckoutHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.numCheckoutHour.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCheckoutHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.numCheckoutHour.Location = new System.Drawing.Point(644, 112);
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
            this.numCheckinHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.numCheckinHour.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCheckinHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.numCheckinHour.Location = new System.Drawing.Point(644, 67);
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
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(491, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check-in time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(491, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Check-out time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(97)))));
            this.label5.Location = new System.Drawing.Point(25, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Info:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(97)))));
            this.label6.Location = new System.Drawing.Point(435, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Config:";
            // 
            // FormConfig
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(226)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(921, 716);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCheckoutTimeValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCheckinTimeValue);
            this.Controls.Add(this.numCheckoutMinute);
            this.Controls.Add(this.lblCheckOutTime);
            this.Controls.Add(this.numCheckoutHour);
            this.Controls.Add(this.numCheckinMinute);
            this.Controls.Add(this.lblCheckInTime);
            this.Controls.Add(this.numCheckinHour);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConfig";
            this.Text = "FomConfig";
            ((System.ComponentModel.ISupportInitialize)(this.numCheckoutMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckinMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckoutHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckinHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCheckInTime;
        private System.Windows.Forms.Label lblCheckOutTime;
        private System.Windows.Forms.Label lblCheckinTimeValue;
        private System.Windows.Forms.Label lblCheckoutTimeValue;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCheckoutMinute;
        private System.Windows.Forms.NumericUpDown numCheckinMinute;
        private System.Windows.Forms.NumericUpDown numCheckoutHour;
        private System.Windows.Forms.NumericUpDown numCheckinHour;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}