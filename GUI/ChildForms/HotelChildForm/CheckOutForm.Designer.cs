namespace GUI.ChildForms.HotelChildForm
{
    partial class CheckOutForm
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
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.lstRoom = new System.Windows.Forms.ListView();
            this.orderRoomIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderRoomType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOrderPrice = new System.Windows.Forms.Label();
            this.lblOrderCustomer = new System.Windows.Forms.Label();
            this.lblRoleError = new System.Windows.Forms.Label();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblOrderStaff = new System.Windows.Forms.Label();
            this.lstService = new System.Windows.Forms.ListView();
            this.orderServicesIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderServicesName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderServicesPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpOrderCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpOrderCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblOrderCheckIn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.lblServicePrice = new System.Windows.Forms.Label();
            this.lblToTalPrice = new System.Windows.Forms.Label();
            this.btnCheckOut = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(97)))));
            this.lblTitle.Location = new System.Drawing.Point(355, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(132, 27);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Check-Out";
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
            this.btnBack.Location = new System.Drawing.Point(8, 22);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(33, 29);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtStaff
            // 
            this.txtStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.txtStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaff.Enabled = false;
            this.txtStaff.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.txtStaff.Location = new System.Drawing.Point(12, 165);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(282, 23);
            this.txtStaff.TabIndex = 61;
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
            this.columnHeader2,
            this.columnHeader3});
            this.lstRoom.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lstRoom.FullRowSelect = true;
            this.lstRoom.GridLines = true;
            this.lstRoom.HideSelection = false;
            this.lstRoom.Location = new System.Drawing.Point(12, 203);
            this.lstRoom.Name = "lstRoom";
            this.lstRoom.Size = new System.Drawing.Size(392, 231);
            this.lstRoom.TabIndex = 60;
            this.lstRoom.UseCompatibleStateImageBehavior = false;
            this.lstRoom.View = System.Windows.Forms.View.Details;
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
            this.orderRoomType.Text = "Room Type";
            this.orderRoomType.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Duration";
            this.columnHeader3.Width = 75;
            // 
            // lblOrderPrice
            // 
            this.lblOrderPrice.AutoSize = true;
            this.lblOrderPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(97)))));
            this.lblOrderPrice.Location = new System.Drawing.Point(8, 538);
            this.lblOrderPrice.Name = "lblOrderPrice";
            this.lblOrderPrice.Size = new System.Drawing.Size(117, 24);
            this.lblOrderPrice.TabIndex = 59;
            this.lblOrderPrice.Text = "Total price:";
            // 
            // lblOrderCustomer
            // 
            this.lblOrderCustomer.AutoSize = true;
            this.lblOrderCustomer.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lblOrderCustomer.Location = new System.Drawing.Point(8, 75);
            this.lblOrderCustomer.Name = "lblOrderCustomer";
            this.lblOrderCustomer.Size = new System.Drawing.Size(92, 19);
            this.lblOrderCustomer.TabIndex = 57;
            this.lblOrderCustomer.Text = "Customer:";
            // 
            // lblRoleError
            // 
            this.lblRoleError.AutoSize = true;
            this.lblRoleError.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleError.ForeColor = System.Drawing.Color.Red;
            this.lblRoleError.Location = new System.Drawing.Point(41, 230);
            this.lblRoleError.Name = "lblRoleError";
            this.lblRoleError.Size = new System.Drawing.Size(0, 16);
            this.lblRoleError.TabIndex = 56;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(274, 227);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(0, 16);
            this.lblPasswordError.TabIndex = 55;
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.txtCustomer.Location = new System.Drawing.Point(12, 97);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(282, 23);
            this.txtCustomer.TabIndex = 54;
            // 
            // lblOrderStaff
            // 
            this.lblOrderStaff.AutoSize = true;
            this.lblOrderStaff.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lblOrderStaff.Location = new System.Drawing.Point(8, 143);
            this.lblOrderStaff.Name = "lblOrderStaff";
            this.lblOrderStaff.Size = new System.Drawing.Size(51, 19);
            this.lblOrderStaff.TabIndex = 53;
            this.lblOrderStaff.Text = "Staff:";
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
            this.lstService.Location = new System.Drawing.Point(492, 203);
            this.lstService.Name = "lstService";
            this.lstService.Size = new System.Drawing.Size(420, 231);
            this.lstService.TabIndex = 52;
            this.lstService.UseCompatibleStateImageBehavior = false;
            this.lstService.View = System.Windows.Forms.View.Details;
            // 
            // orderServicesIndex
            // 
            this.orderServicesIndex.Text = "#";
            this.orderServicesIndex.Width = 30;
            // 
            // orderServicesName
            // 
            this.orderServicesName.Text = "Services Name";
            this.orderServicesName.Width = 150;
            // 
            // orderServicesPrice
            // 
            this.orderServicesPrice.Text = "Services Price";
            this.orderServicesPrice.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Quantity";
            this.columnHeader1.Width = 75;
            // 
            // dtpOrderCheckOut
            // 
            this.dtpOrderCheckOut.CalendarForeColor = System.Drawing.Color.White;
            this.dtpOrderCheckOut.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.dtpOrderCheckOut.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpOrderCheckOut.Enabled = false;
            this.dtpOrderCheckOut.Location = new System.Drawing.Point(492, 165);
            this.dtpOrderCheckOut.Name = "dtpOrderCheckOut";
            this.dtpOrderCheckOut.Size = new System.Drawing.Size(282, 27);
            this.dtpOrderCheckOut.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(488, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 64;
            this.label1.Text = "Check Out:";
            // 
            // dtpOrderCheckIn
            // 
            this.dtpOrderCheckIn.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.dtpOrderCheckIn.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.dtpOrderCheckIn.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.dtpOrderCheckIn.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.dtpOrderCheckIn.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.dtpOrderCheckIn.Enabled = false;
            this.dtpOrderCheckIn.Location = new System.Drawing.Point(492, 93);
            this.dtpOrderCheckIn.Name = "dtpOrderCheckIn";
            this.dtpOrderCheckIn.Size = new System.Drawing.Size(282, 27);
            this.dtpOrderCheckIn.TabIndex = 63;
            // 
            // lblOrderCheckIn
            // 
            this.lblOrderCheckIn.AutoSize = true;
            this.lblOrderCheckIn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lblOrderCheckIn.Location = new System.Drawing.Point(488, 71);
            this.lblOrderCheckIn.Name = "lblOrderCheckIn";
            this.lblOrderCheckIn.Size = new System.Drawing.Size(83, 19);
            this.lblOrderCheckIn.TabIndex = 62;
            this.lblOrderCheckIn.Text = "Check In:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(8, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "Service:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(8, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 67;
            this.label3.Text = "Room:";
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lblRoomPrice.Location = new System.Drawing.Point(75, 462);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRoomPrice.Size = new System.Drawing.Size(329, 19);
            this.lblRoomPrice.TabIndex = 68;
            this.lblRoomPrice.Text = "100.000VND";
            this.lblRoomPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.lblServicePrice.Location = new System.Drawing.Point(87, 502);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblServicePrice.Size = new System.Drawing.Size(317, 19);
            this.lblServicePrice.TabIndex = 69;
            this.lblServicePrice.Text = "100.000VND";
            this.lblServicePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblToTalPrice
            // 
            this.lblToTalPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToTalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(97)))));
            this.lblToTalPrice.Location = new System.Drawing.Point(131, 538);
            this.lblToTalPrice.Name = "lblToTalPrice";
            this.lblToTalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblToTalPrice.Size = new System.Drawing.Size(273, 23);
            this.lblToTalPrice.TabIndex = 70;
            this.lblToTalPrice.Text = "100.000VND";
            this.lblToTalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(97)))));
            this.btnCheckOut.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.btnCheckOut.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(97)))));
            this.btnCheckOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckOut.IconSize = 30;
            this.btnCheckOut.Location = new System.Drawing.Point(752, 502);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(160, 60);
            this.btnCheckOut.TabIndex = 72;
            this.btnCheckOut.Text = "Check out";
            this.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(226)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(934, 585);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.lblToTalPrice);
            this.Controls.Add(this.lblServicePrice);
            this.Controls.Add(this.lblRoomPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpOrderCheckOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpOrderCheckIn);
            this.Controls.Add(this.lblOrderCheckIn);
            this.Controls.Add(this.txtStaff);
            this.Controls.Add(this.lstRoom);
            this.Controls.Add(this.lblOrderPrice);
            this.Controls.Add(this.lblOrderCustomer);
            this.Controls.Add(this.lblRoleError);
            this.Controls.Add(this.lblPasswordError);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblOrderStaff);
            this.Controls.Add(this.lstService);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CheckOutForm";
            this.Text = "CheckOutForm";
            this.Load += new System.EventHandler(this.CheckOutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.ListView lstRoom;
        private System.Windows.Forms.ColumnHeader orderRoomIndex;
        private System.Windows.Forms.ColumnHeader orderRoom;
        private System.Windows.Forms.ColumnHeader orderRoomType;
        private System.Windows.Forms.Label lblOrderPrice;
        private System.Windows.Forms.Label lblOrderCustomer;
        private System.Windows.Forms.Label lblRoleError;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblOrderStaff;
        private System.Windows.Forms.ListView lstService;
        private System.Windows.Forms.ColumnHeader orderServicesIndex;
        private System.Windows.Forms.ColumnHeader orderServicesName;
        private System.Windows.Forms.ColumnHeader orderServicesPrice;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.DateTimePicker dtpOrderCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpOrderCheckIn;
        private System.Windows.Forms.Label lblOrderCheckIn;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Label lblServicePrice;
        private System.Windows.Forms.Label lblToTalPrice;
        private FontAwesome.Sharp.IconButton btnCheckOut;
    }
}