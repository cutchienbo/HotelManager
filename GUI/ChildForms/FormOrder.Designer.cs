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
            this.lstOrder = new System.Windows.Forms.ListView();
            this.orderIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderUserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderCustomerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderCheckinTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderCheckoutTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstService = new System.Windows.Forms.ListView();
            this.orderServicesIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderServicesName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderServicesPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRoleError = new System.Windows.Forms.Label();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblOrderStaff = new System.Windows.Forms.Label();
            this.lblOrderCustomer = new System.Windows.Forms.Label();
            this.lblOrderPrice = new System.Windows.Forms.Label();
            this.txtOrderPrice = new System.Windows.Forms.TextBox();
            this.lblOrderCheckIn = new System.Windows.Forms.Label();
            this.dtpOrderCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpOrderCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.lstRoom = new System.Windows.Forms.ListView();
            this.orderRoomIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderRoomType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLog = new System.Windows.Forms.Label();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstOrder
            // 
            this.lstOrder.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lstOrder.AllowColumnReorder = true;
            this.lstOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.lstOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderIndex,
            this.orderUserId,
            this.orderCustomerId,
            this.orderCheckinTime,
            this.orderCheckoutTime,
            this.orderStatus,
            this.orderPrice});
            this.lstOrder.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lstOrder.FullRowSelect = true;
            this.lstOrder.GridLines = true;
            this.lstOrder.HideSelection = false;
            this.lstOrder.Location = new System.Drawing.Point(280, 262);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(619, 307);
            this.lstOrder.TabIndex = 2;
            this.lstOrder.UseCompatibleStateImageBehavior = false;
            this.lstOrder.View = System.Windows.Forms.View.Details;
            this.lstOrder.SelectedIndexChanged += new System.EventHandler(this.lstOrder_SelectedIndexChanged);
            // 
            // orderIndex
            // 
            this.orderIndex.Text = "#";
            this.orderIndex.Width = 30;
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
            this.orderCheckinTime.Width = 100;
            // 
            // orderCheckoutTime
            // 
            this.orderCheckoutTime.Text = "Check Out";
            this.orderCheckoutTime.Width = 100;
            // 
            // orderStatus
            // 
            this.orderStatus.Text = "Status";
            // 
            // orderPrice
            // 
            this.orderPrice.Text = "Price";
            this.orderPrice.Width = 100;
            // 
            // lstService
            // 
            this.lstService.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lstService.AllowColumnReorder = true;
            this.lstService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.lstService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstService.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderServicesIndex,
            this.orderServicesName,
            this.orderServicesPrice,
            this.columnHeader1});
            this.lstService.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lstService.FullRowSelect = true;
            this.lstService.GridLines = true;
            this.lstService.HideSelection = false;
            this.lstService.Location = new System.Drawing.Point(546, 12);
            this.lstService.Name = "lstService";
            this.lstService.Size = new System.Drawing.Size(353, 231);
            this.lstService.TabIndex = 3;
            this.lstService.UseCompatibleStateImageBehavior = false;
            this.lstService.View = System.Windows.Forms.View.Details;
            this.lstService.SelectedIndexChanged += new System.EventHandler(this.lstService_SelectedIndexChanged);
            // 
            // orderServicesIndex
            // 
            this.orderServicesIndex.Text = "#";
            this.orderServicesIndex.Width = 30;
            // 
            // orderServicesName
            // 
            this.orderServicesName.Text = "Services Name";
            this.orderServicesName.Width = 125;
            // 
            // orderServicesPrice
            // 
            this.orderServicesPrice.Text = "Services Price";
            this.orderServicesPrice.Width = 120;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Quantity";
            this.columnHeader1.Width = 75;
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
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.txtCustomer.Location = new System.Drawing.Point(16, 34);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(245, 23);
            this.txtCustomer.TabIndex = 33;
            // 
            // lblOrderStaff
            // 
            this.lblOrderStaff.AutoSize = true;
            this.lblOrderStaff.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lblOrderStaff.Location = new System.Drawing.Point(12, 100);
            this.lblOrderStaff.Name = "lblOrderStaff";
            this.lblOrderStaff.Size = new System.Drawing.Size(51, 19);
            this.lblOrderStaff.TabIndex = 32;
            this.lblOrderStaff.Text = "Staff:";
            // 
            // lblOrderCustomer
            // 
            this.lblOrderCustomer.AutoSize = true;
            this.lblOrderCustomer.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lblOrderCustomer.Location = new System.Drawing.Point(12, 12);
            this.lblOrderCustomer.Name = "lblOrderCustomer";
            this.lblOrderCustomer.Size = new System.Drawing.Size(92, 19);
            this.lblOrderCustomer.TabIndex = 37;
            this.lblOrderCustomer.Text = "Customer:";
            // 
            // lblOrderPrice
            // 
            this.lblOrderPrice.AutoSize = true;
            this.lblOrderPrice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lblOrderPrice.Location = new System.Drawing.Point(12, 180);
            this.lblOrderPrice.Name = "lblOrderPrice";
            this.lblOrderPrice.Size = new System.Drawing.Size(55, 19);
            this.lblOrderPrice.TabIndex = 39;
            this.lblOrderPrice.Text = "Price:";
            // 
            // txtOrderPrice
            // 
            this.txtOrderPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.txtOrderPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrderPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.txtOrderPrice.Location = new System.Drawing.Point(16, 202);
            this.txtOrderPrice.Name = "txtOrderPrice";
            this.txtOrderPrice.Size = new System.Drawing.Size(245, 23);
            this.txtOrderPrice.TabIndex = 38;
            // 
            // lblOrderCheckIn
            // 
            this.lblOrderCheckIn.AutoSize = true;
            this.lblOrderCheckIn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lblOrderCheckIn.Location = new System.Drawing.Point(12, 268);
            this.lblOrderCheckIn.Name = "lblOrderCheckIn";
            this.lblOrderCheckIn.Size = new System.Drawing.Size(83, 19);
            this.lblOrderCheckIn.TabIndex = 40;
            this.lblOrderCheckIn.Text = "Check In:";
            // 
            // dtpOrderCheckIn
            // 
            this.dtpOrderCheckIn.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.dtpOrderCheckIn.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.dtpOrderCheckIn.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.dtpOrderCheckIn.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.dtpOrderCheckIn.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.dtpOrderCheckIn.Location = new System.Drawing.Point(16, 290);
            this.dtpOrderCheckIn.Name = "dtpOrderCheckIn";
            this.dtpOrderCheckIn.Size = new System.Drawing.Size(245, 27);
            this.dtpOrderCheckIn.TabIndex = 41;
            // 
            // dtpOrderCheckOut
            // 
            this.dtpOrderCheckOut.CalendarForeColor = System.Drawing.Color.White;
            this.dtpOrderCheckOut.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.dtpOrderCheckOut.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpOrderCheckOut.Location = new System.Drawing.Point(16, 370);
            this.dtpOrderCheckOut.Name = "dtpOrderCheckOut";
            this.dtpOrderCheckOut.Size = new System.Drawing.Size(245, 27);
            this.dtpOrderCheckOut.TabIndex = 43;
            this.dtpOrderCheckOut.ValueChanged += new System.EventHandler(this.dtpOrderCheckOut_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(12, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Check Out:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(97)))));
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(97)))));
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 25;
            this.btnSearch.Location = new System.Drawing.Point(144, 526);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 43);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(97)))));
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnClear.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(97)))));
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.IconSize = 25;
            this.btnClear.Location = new System.Drawing.Point(16, 526);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 43);
            this.btnClear.TabIndex = 48;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstRoom
            // 
            this.lstRoom.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lstRoom.AllowColumnReorder = true;
            this.lstRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.lstRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderRoomIndex,
            this.orderRoom,
            this.orderRoomType,
            this.columnHeader2});
            this.lstRoom.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lstRoom.FullRowSelect = true;
            this.lstRoom.GridLines = true;
            this.lstRoom.HideSelection = false;
            this.lstRoom.Location = new System.Drawing.Point(280, 12);
            this.lstRoom.Name = "lstRoom";
            this.lstRoom.Size = new System.Drawing.Size(260, 231);
            this.lstRoom.TabIndex = 49;
            this.lstRoom.UseCompatibleStateImageBehavior = false;
            this.lstRoom.View = System.Windows.Forms.View.Details;
            this.lstRoom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstRoom_MouseDown);
            // 
            // orderRoomIndex
            // 
            this.orderRoomIndex.Text = "#";
            this.orderRoomIndex.Width = 30;
            // 
            // orderRoom
            // 
            this.orderRoom.Text = "Room";
            // 
            // orderRoomType
            // 
            this.orderRoomType.Text = "RT";
            this.orderRoomType.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Customer";
            this.columnHeader2.Width = 85;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.ForeColor = System.Drawing.Color.Red;
            this.lblLog.Location = new System.Drawing.Point(177, 432);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(0, 22);
            this.lblLog.TabIndex = 50;
            // 
            // txtStaff
            // 
            this.txtStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.txtStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaff.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.txtStaff.Location = new System.Drawing.Point(16, 122);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(245, 23);
            this.txtStaff.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(12, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Status:";
            // 
            // cbbStatus
            // 
            this.cbbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.cbbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbStatus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "",
            "Success",
            "Booking",
            "Active",
            "Cancel"});
            this.cbbStatus.Location = new System.Drawing.Point(16, 457);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(245, 27);
            this.cbbStatus.TabIndex = 53;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(226)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(911, 581);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStaff);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lstRoom);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpOrderCheckOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpOrderCheckIn);
            this.Controls.Add(this.lblOrderCheckIn);
            this.Controls.Add(this.lblOrderPrice);
            this.Controls.Add(this.txtOrderPrice);
            this.Controls.Add(this.lblOrderCustomer);
            this.Controls.Add(this.lblRoleError);
            this.Controls.Add(this.lblPasswordError);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblOrderStaff);
            this.Controls.Add(this.lstService);
            this.Controls.Add(this.lstOrder);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOrder";
            this.Text = "u";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormOrder_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstOrder;
        private System.Windows.Forms.ColumnHeader orderIndex;
        private System.Windows.Forms.ColumnHeader orderUserId;
        private System.Windows.Forms.ColumnHeader orderCustomerId;
        private System.Windows.Forms.ColumnHeader orderCheckinTime;
        private System.Windows.Forms.ColumnHeader orderCheckoutTime;
        private System.Windows.Forms.ColumnHeader orderStatus;
        private System.Windows.Forms.ColumnHeader orderPrice;
        private System.Windows.Forms.ListView lstService;
        private System.Windows.Forms.ColumnHeader orderServicesIndex;
        private System.Windows.Forms.ColumnHeader orderServicesName;
        private System.Windows.Forms.ColumnHeader orderServicesPrice;
        private System.Windows.Forms.Label lblRoleError;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblOrderStaff;
        private System.Windows.Forms.Label lblOrderCustomer;
        private System.Windows.Forms.Label lblOrderPrice;
        private System.Windows.Forms.TextBox txtOrderPrice;
        private System.Windows.Forms.Label lblOrderCheckIn;
        private System.Windows.Forms.DateTimePicker dtpOrderCheckIn;
        private System.Windows.Forms.DateTimePicker dtpOrderCheckOut;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnClear;
        private System.Windows.Forms.ListView lstRoom;
        private System.Windows.Forms.ColumnHeader orderRoomIndex;
        private System.Windows.Forms.ColumnHeader orderRoom;
        private System.Windows.Forms.ColumnHeader orderRoomType;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}