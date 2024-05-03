namespace GUI.ChildForms.HotelChildForm
{
    partial class AddUserForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAddressError = new System.Windows.Forms.Label();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblFullNameError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtIdCode = new System.Windows.Forms.TextBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblIdCode = new System.Windows.Forms.Label();
            this.cbbRoomNumber = new System.Windows.Forms.ComboBox();
            this.btnAddUser = new FontAwesome.Sharp.IconButton();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.lblIdCodeError = new System.Windows.Forms.Label();
            this.lblPhoneNumberError = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(97)))));
            this.lblTitle.Location = new System.Drawing.Point(354, 24);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(115, 27);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Add User";
            // 
            // lblAddressError
            // 
            this.lblAddressError.AutoSize = true;
            this.lblAddressError.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressError.ForeColor = System.Drawing.Color.Red;
            this.lblAddressError.Location = new System.Drawing.Point(337, 406);
            this.lblAddressError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressError.Name = "lblAddressError";
            this.lblAddressError.Size = new System.Drawing.Size(0, 17);
            this.lblAddressError.TabIndex = 112;
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailError.ForeColor = System.Drawing.Color.Red;
            this.lblEmailError.Location = new System.Drawing.Point(646, 306);
            this.lblEmailError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(0, 17);
            this.lblEmailError.TabIndex = 111;
            // 
            // lblFullNameError
            // 
            this.lblFullNameError.AutoSize = true;
            this.lblFullNameError.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNameError.ForeColor = System.Drawing.Color.Red;
            this.lblFullNameError.Location = new System.Drawing.Point(337, 306);
            this.lblFullNameError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullNameError.Name = "lblFullNameError";
            this.lblFullNameError.Size = new System.Drawing.Size(0, 17);
            this.lblFullNameError.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(22, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 108;
            this.label1.Text = "Customer info:";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.txtAddress.Location = new System.Drawing.Point(339, 378);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(562, 23);
            this.txtAddress.TabIndex = 107;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lblAddress.Location = new System.Drawing.Point(336, 355);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 19);
            this.lblAddress.TabIndex = 106;
            this.lblAddress.Text = "Address:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.txtEmail.Location = new System.Drawing.Point(649, 278);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(254, 23);
            this.txtEmail.TabIndex = 105;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lblEmail.Location = new System.Drawing.Point(646, 255);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 19);
            this.lblEmail.TabIndex = 104;
            this.lblEmail.Text = "Email:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(24, 378);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(253, 23);
            this.txtPhoneNumber.TabIndex = 103;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lblPhoneNumber.Location = new System.Drawing.Point(19, 355);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(130, 19);
            this.lblPhoneNumber.TabIndex = 102;
            this.lblPhoneNumber.Text = "Phone number:";
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.txtFullName.Location = new System.Drawing.Point(339, 278);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(254, 23);
            this.txtFullName.TabIndex = 101;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lblFullName.Location = new System.Drawing.Point(336, 255);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(90, 19);
            this.lblFullName.TabIndex = 100;
            this.lblFullName.Text = "Full name:";
            // 
            // txtIdCode
            // 
            this.txtIdCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.txtIdCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.txtIdCode.Location = new System.Drawing.Point(24, 278);
            this.txtIdCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtIdCode.Name = "txtIdCode";
            this.txtIdCode.Size = new System.Drawing.Size(254, 23);
            this.txtIdCode.TabIndex = 99;
            this.txtIdCode.TextChanged += new System.EventHandler(this.txtIdCode_TextChanged);
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lblRoomNumber.Location = new System.Drawing.Point(22, 88);
            this.lblRoomNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(126, 19);
            this.lblRoomNumber.TabIndex = 93;
            this.lblRoomNumber.Text = "Room number:";
            // 
            // lblIdCode
            // 
            this.lblIdCode.AutoSize = true;
            this.lblIdCode.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lblIdCode.Location = new System.Drawing.Point(22, 255);
            this.lblIdCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdCode.Name = "lblIdCode";
            this.lblIdCode.Size = new System.Drawing.Size(72, 19);
            this.lblIdCode.TabIndex = 113;
            this.lblIdCode.Text = "Id code:";
            // 
            // cbbRoomNumber
            // 
            this.cbbRoomNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.cbbRoomNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbRoomNumber.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbRoomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.cbbRoomNumber.FormattingEnabled = true;
            this.cbbRoomNumber.Items.AddRange(new object[] {
            ""});
            this.cbbRoomNumber.Location = new System.Drawing.Point(26, 112);
            this.cbbRoomNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbbRoomNumber.Name = "cbbRoomNumber";
            this.cbbRoomNumber.Size = new System.Drawing.Size(250, 27);
            this.cbbRoomNumber.TabIndex = 114;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(97)))));
            this.btnAddUser.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(97)))));
            this.btnAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddUser.IconSize = 30;
            this.btnAddUser.Location = new System.Drawing.Point(714, 474);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(189, 71);
            this.btnAddUser.TabIndex = 109;
            this.btnAddUser.Text = "Add user";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(226)))), ((int)(((byte)(220)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(97)))));
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.btnBack.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(97)))));
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 25;
            this.btnBack.Location = new System.Drawing.Point(7, 24);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(33, 31);
            this.btnBack.TabIndex = 6;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblIdCodeError
            // 
            this.lblIdCodeError.AutoSize = true;
            this.lblIdCodeError.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCodeError.ForeColor = System.Drawing.Color.Red;
            this.lblIdCodeError.Location = new System.Drawing.Point(22, 304);
            this.lblIdCodeError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdCodeError.Name = "lblIdCodeError";
            this.lblIdCodeError.Size = new System.Drawing.Size(0, 16);
            this.lblIdCodeError.TabIndex = 115;
            // 
            // lblPhoneNumberError
            // 
            this.lblPhoneNumberError.AutoSize = true;
            this.lblPhoneNumberError.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumberError.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneNumberError.Location = new System.Drawing.Point(24, 406);
            this.lblPhoneNumberError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumberError.Name = "lblPhoneNumberError";
            this.lblPhoneNumberError.Size = new System.Drawing.Size(0, 16);
            this.lblPhoneNumberError.TabIndex = 116;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.ForeColor = System.Drawing.Color.Lime;
            this.lblLog.Location = new System.Drawing.Point(23, 474);
            this.lblLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(14, 19);
            this.lblLog.TabIndex = 117;
            this.lblLog.Text = "\\";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(226)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(921, 565);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblPhoneNumberError);
            this.Controls.Add(this.lblIdCodeError);
            this.Controls.Add(this.cbbRoomNumber);
            this.Controls.Add(this.lblIdCode);
            this.Controls.Add(this.lblAddressError);
            this.Controls.Add(this.lblEmailError);
            this.Controls.Add(this.lblFullNameError);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtIdCode);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.Label lblAddressError;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblFullNameError;
        private FontAwesome.Sharp.IconButton btnAddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtIdCode;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblIdCode;
        private System.Windows.Forms.ComboBox cbbRoomNumber;
        private System.Windows.Forms.Label lblIdCodeError;
        private System.Windows.Forms.Label lblPhoneNumberError;
        private System.Windows.Forms.Label lblLog;
    }
}