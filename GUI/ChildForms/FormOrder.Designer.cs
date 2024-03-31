namespace GUI.ChildForms
{
    partial class FormOrder
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
            this.lstUsers = new System.Windows.Forms.ListView();
            this.orderIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderRoomId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderUserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderCustomerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderCheckinTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderCheckoutTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderServices = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.orderServicesIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderServicesName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderServicesPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRoleError = new System.Windows.Forms.Label();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblOrderStaff = new System.Windows.Forms.Label();
            this.cbbOrderRoom = new System.Windows.Forms.ComboBox();
            this.lblOrderRoom = new System.Windows.Forms.Label();
            this.cbbOrderStaff = new System.Windows.Forms.ComboBox();
            this.lblOrderCustomer = new System.Windows.Forms.Label();
            this.lblOrderPrice = new System.Windows.Forms.Label();
            this.txtOrderPrice = new System.Windows.Forms.TextBox();
            this.lblOrderCheckIn = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lstUsers.AllowColumnReorder = true;
            this.lstUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.lstUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderIndex,
            this.orderRoomId,
            this.orderUserId,
            this.orderCustomerId,
            this.orderCheckinTime,
            this.orderCheckoutTime,
            this.orderStatus,
            this.orderPrice,
            this.orderServices});
            this.lstUsers.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUsers.ForeColor = System.Drawing.Color.White;
            this.lstUsers.FullRowSelect = true;
            this.lstUsers.GridLines = true;
            this.lstUsers.HideSelection = false;
            this.lstUsers.Location = new System.Drawing.Point(12, 262);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(887, 307);
            this.lstUsers.TabIndex = 2;
            this.lstUsers.UseCompatibleStateImageBehavior = false;
            this.lstUsers.View = System.Windows.Forms.View.Details;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // orderIndex
            // 
            this.orderIndex.Text = "#";
            this.orderIndex.Width = 30;
            // 
            // orderRoomId
            // 
            this.orderRoomId.Text = "Room";
            // 
            // orderUserId
            // 
            this.orderUserId.Text = "Staff";
            this.orderUserId.Width = 100;
            // 
            // orderCustomerId
            // 
            this.orderCustomerId.Text = "Customer";
            this.orderCustomerId.Width = 90;
            // 
            // orderCheckinTime
            // 
            this.orderCheckinTime.Text = "Check In";
            this.orderCheckinTime.Width = 140;
            // 
            // orderCheckoutTime
            // 
            this.orderCheckoutTime.Text = "Check Out";
            this.orderCheckoutTime.Width = 140;
            // 
            // orderStatus
            // 
            this.orderStatus.Text = "Status";
            this.orderStatus.Width = 100;
            // 
            // orderPrice
            // 
            this.orderPrice.Text = "Price";
            this.orderPrice.Width = 140;
            // 
            // orderServices
            // 
            this.orderServices.Text = "Services";
            this.orderServices.Width = 80;
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderServicesIndex,
            this.orderServicesName,
            this.orderServicesPrice});
            this.listView1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(583, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(316, 231);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // orderServicesIndex
            // 
            this.orderServicesIndex.Text = "#";
            this.orderServicesIndex.Width = 30;
            // 
            // orderServicesName
            // 
            this.orderServicesName.Text = "Services Name";
            this.orderServicesName.Width = 140;
            // 
            // orderServicesPrice
            // 
            this.orderServicesPrice.Text = "Services Price";
            this.orderServicesPrice.Width = 140;
            // 
            // lblRoleError
            // 
            this.lblRoleError.AutoSize = true;
            this.lblRoleError.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleError.ForeColor = System.Drawing.Color.Red;
            this.lblRoleError.Location = new System.Drawing.Point(44, 59);
            this.lblRoleError.Name = "lblRoleError";
            this.lblRoleError.Size = new System.Drawing.Size(0, 16);
            this.lblRoleError.TabIndex = 35;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(277, 56);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(0, 16);
            this.lblPasswordError.TabIndex = 34;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.txtPassword.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(16, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(243, 27);
            this.txtPassword.TabIndex = 33;
            // 
            // lblOrderStaff
            // 
            this.lblOrderStaff.AutoSize = true;
            this.lblOrderStaff.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStaff.ForeColor = System.Drawing.Color.White;
            this.lblOrderStaff.Location = new System.Drawing.Point(307, 14);
            this.lblOrderStaff.Name = "lblOrderStaff";
            this.lblOrderStaff.Size = new System.Drawing.Size(51, 19);
            this.lblOrderStaff.TabIndex = 32;
            this.lblOrderStaff.Text = "Staff:";
            // 
            // cbbOrderRoom
            // 
            this.cbbOrderRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.cbbOrderRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbOrderRoom.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbOrderRoom.ForeColor = System.Drawing.Color.White;
            this.cbbOrderRoom.FormattingEnabled = true;
            this.cbbOrderRoom.Location = new System.Drawing.Point(16, 36);
            this.cbbOrderRoom.Name = "cbbOrderRoom";
            this.cbbOrderRoom.Size = new System.Drawing.Size(243, 27);
            this.cbbOrderRoom.TabIndex = 31;
            // 
            // lblOrderRoom
            // 
            this.lblOrderRoom.AutoSize = true;
            this.lblOrderRoom.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderRoom.ForeColor = System.Drawing.Color.White;
            this.lblOrderRoom.Location = new System.Drawing.Point(12, 14);
            this.lblOrderRoom.Name = "lblOrderRoom";
            this.lblOrderRoom.Size = new System.Drawing.Size(61, 19);
            this.lblOrderRoom.TabIndex = 30;
            this.lblOrderRoom.Text = "Room:";
            // 
            // cbbOrderStaff
            // 
            this.cbbOrderStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.cbbOrderStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbOrderStaff.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbOrderStaff.ForeColor = System.Drawing.Color.White;
            this.cbbOrderStaff.FormattingEnabled = true;
            this.cbbOrderStaff.Location = new System.Drawing.Point(311, 36);
            this.cbbOrderStaff.Name = "cbbOrderStaff";
            this.cbbOrderStaff.Size = new System.Drawing.Size(243, 27);
            this.cbbOrderStaff.TabIndex = 36;
            this.cbbOrderStaff.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblOrderCustomer
            // 
            this.lblOrderCustomer.AutoSize = true;
            this.lblOrderCustomer.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderCustomer.ForeColor = System.Drawing.Color.White;
            this.lblOrderCustomer.Location = new System.Drawing.Point(12, 75);
            this.lblOrderCustomer.Name = "lblOrderCustomer";
            this.lblOrderCustomer.Size = new System.Drawing.Size(92, 19);
            this.lblOrderCustomer.TabIndex = 37;
            this.lblOrderCustomer.Text = "Customer:";
            // 
            // lblOrderPrice
            // 
            this.lblOrderPrice.AutoSize = true;
            this.lblOrderPrice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderPrice.ForeColor = System.Drawing.Color.White;
            this.lblOrderPrice.Location = new System.Drawing.Point(307, 75);
            this.lblOrderPrice.Name = "lblOrderPrice";
            this.lblOrderPrice.Size = new System.Drawing.Size(55, 19);
            this.lblOrderPrice.TabIndex = 39;
            this.lblOrderPrice.Text = "Price:";
            // 
            // txtOrderPrice
            // 
            this.txtOrderPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.txtOrderPrice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderPrice.ForeColor = System.Drawing.Color.White;
            this.txtOrderPrice.Location = new System.Drawing.Point(311, 97);
            this.txtOrderPrice.Name = "txtOrderPrice";
            this.txtOrderPrice.Size = new System.Drawing.Size(243, 27);
            this.txtOrderPrice.TabIndex = 38;
            // 
            // lblOrderCheckIn
            // 
            this.lblOrderCheckIn.AutoSize = true;
            this.lblOrderCheckIn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderCheckIn.ForeColor = System.Drawing.Color.White;
            this.lblOrderCheckIn.Location = new System.Drawing.Point(12, 138);
            this.lblOrderCheckIn.Name = "lblOrderCheckIn";
            this.lblOrderCheckIn.Size = new System.Drawing.Size(83, 19);
            this.lblOrderCheckIn.TabIndex = 40;
            this.lblOrderCheckIn.Text = "Check In:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 27);
            this.dateTimePicker1.TabIndex = 41;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(911, 581);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblOrderCheckIn);
            this.Controls.Add(this.lblOrderPrice);
            this.Controls.Add(this.txtOrderPrice);
            this.Controls.Add(this.lblOrderCustomer);
            this.Controls.Add(this.cbbOrderStaff);
            this.Controls.Add(this.lblRoleError);
            this.Controls.Add(this.lblPasswordError);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblOrderStaff);
            this.Controls.Add(this.cbbOrderRoom);
            this.Controls.Add(this.lblOrderRoom);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lstUsers);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstUsers;
        private System.Windows.Forms.ColumnHeader orderIndex;
        private System.Windows.Forms.ColumnHeader orderRoomId;
        private System.Windows.Forms.ColumnHeader orderUserId;
        private System.Windows.Forms.ColumnHeader orderCustomerId;
        private System.Windows.Forms.ColumnHeader orderCheckinTime;
        private System.Windows.Forms.ColumnHeader orderCheckoutTime;
        private System.Windows.Forms.ColumnHeader orderStatus;
        private System.Windows.Forms.ColumnHeader orderPrice;
        private System.Windows.Forms.ColumnHeader orderServices;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader orderServicesIndex;
        private System.Windows.Forms.ColumnHeader orderServicesName;
        private System.Windows.Forms.ColumnHeader orderServicesPrice;
        private System.Windows.Forms.Label lblRoleError;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblOrderStaff;
        private System.Windows.Forms.ComboBox cbbOrderRoom;
        private System.Windows.Forms.Label lblOrderRoom;
        private System.Windows.Forms.ComboBox cbbOrderStaff;
        private System.Windows.Forms.Label lblOrderCustomer;
        private System.Windows.Forms.Label lblOrderPrice;
        private System.Windows.Forms.TextBox txtOrderPrice;
        private System.Windows.Forms.Label lblOrderCheckIn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}