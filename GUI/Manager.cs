﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using FontAwesome.Sharp;
using GUI.ChildForms;
using DTO;
using GUI.Event;
using GUI.ChildForms.HotelChildForm;

namespace GUI
{
    public partial class Manager : Form
    {
        private IconButton activeBtn;
        private Panel leftBtnBorder;
        private Form currentChildForm;
        private User currentUser;

        public Manager(User user)
        {
            InitializeComponent();
            this.leftBtnBorder = new Panel();
            this.leftBtnBorder.Size = new Size(6, 62);
            this.leftBtnBorder.BackColor = Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(97)))));
            this.leftBtnBorder.TabIndex = 2;
            this.leftBtnBorder.BringToFront();

            lblName.Text = user.sFullName;

            foreach (Permission per in user.sPermission)
            {
                string first = per.sCode.Substring(0, 1);
                string second = per.sCode.Substring(1);

                drawButton(first.ToUpper() + second);
            }

            this.currentUser = user;
        }
        
        public IconChar Hotel()
        {
            return IconChar.Hotel;
        }

        public IconChar User()
        {
            return IconChar.UserTie;
        }

        public IconChar Customer()
        {
            return IconChar.Users;
        }

        public IconChar Room()
        {
            return IconChar.Bed;
        }

        public IconChar Service()
        {
            return IconChar.BellConcierge;
        }

        public IconChar Order()
        {
            return IconChar.List;
        }

        public IconChar Config()
        {
            return IconChar.Gears;
        }

        public IconChar Statistical()
        {
            return IconChar.ChartLine;
        }

        public IconChar Permission()
        {
            return IconChar.Key;
        }

        public void activeBtnHandle(IconButton button)
        {
            button.ForeColor = Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(97)))));
            button.Font = new System.Drawing.Font("Arial", 8.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            button.IconColor = Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(59)))), ((int)(((byte)(97)))));
            button.BackColor = Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(226)))), ((int)(((byte)(220)))));
            button.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(226)))), ((int)(((byte)(220)))));
            button.ImageAlign = ContentAlignment.MiddleRight;
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.TextImageRelation = TextImageRelation.TextBeforeImage;
            button.Padding = new Padding(15, 0, 5, 0);

            button.Controls.Add(this.leftBtnBorder);

            this.activeBtn = button;
        }

        public void disableBtnHandle(IconButton button)
        {
            button.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            button.Font = new Font("Arial", 8.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            button.IconColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            button.BackColor = Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            button.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
            button.Padding = new Padding(15, 0, 0, 0);

            button.Controls.Remove(this.leftBtnBorder);
        }

        private void activeBtn_Click(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;

            if (this.activeBtn != null)
            {
                disableBtnHandle(this.activeBtn);
            }

            activeBtnHandle(btn);

            MethodInfo addChildForm = this.GetType().GetMethod(btn.Name);

            if(this.currentChildForm != null)
            {
                this.currentChildForm.Close();
            }

            addChildForm.Invoke(this, null);
        }
        
        public void openChildForm(Form childForm)
        {
            this.currentChildForm = childForm;

            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.Size = new Size(921, 716);
            childForm.FormBorderStyle = FormBorderStyle.None;

            panelChildForm.Controls.Add(childForm);

            childForm.BringToFront();
            childForm.Show();
        }

        public void hotelChildForm(object sender, OpenChildForm e)
        {
            switch (e.action)
            {
                case "create order":
                    CreateOrderForm createOrder = new CreateOrderForm(e.paras, this.currentUser);
                    this.openChildForm(createOrder);
                    createOrder.handleOpenChildForm += hotelChildForm;
                    break;
                case "add service":
                    AddServiceForm addService = new AddServiceForm(e.paras);
                    this.openChildForm(addService);
                    addService.handleOpenChildForm += hotelChildForm;
                    break;
                case "check out":
                    CheckOutForm checkOut = new CheckOutForm(e.paras, e.ob);
                    this.openChildForm(checkOut);
                    checkOut.handleOpenChildForm += hotelChildForm;
                    break;
                case "add user":
                    AddUserForm addUser = new AddUserForm(e.paras);
                    this.openChildForm(addUser);
                    addUser.handleOpenChildForm += hotelChildForm;
                    break;
                case "back":
                    this.btnHotel();
                    break;
            }
        }

        public void btnHotel()
        {
            FormHotel childForm = new FormHotel();

            openChildForm((Form)childForm);

            childForm.handleOpenChildForm += hotelChildForm;
        }

        public void btnUser()
        {
            Form childForm = new FormUser();

            openChildForm(childForm);
        }

        public void btnCustomer()
        {
            Form childForm = new FormCustomer();

            openChildForm(childForm);
        }

        public void btnRoom()
        {
            Form childForm = new FormRoom();

            openChildForm(childForm);
        }

        public void btnService()
        {
            Form childForm = new FormService();

            openChildForm(childForm);
        }

        public void btnStatistical()
        {
            Form childForm = new FormStatistical();

            openChildForm(childForm);
        }

        public void btnPermission()
        {
            Form childForm = new FormPermission();

            openChildForm(childForm);
        }

        public void btnOrder()
        {
            Form childForm = new FormOrder();

            openChildForm(childForm);
        }

        public void btnConfig()
        {
            Form childForm = new FormConfig();

            openChildForm(childForm);
        }

        private void drawButton(string name)
        {
            var button = new IconButton();

            this.disableBtnHandle(button);

            button.FlatStyle = FlatStyle.Flat;
            button.Flip = FlipOrientation.Normal;
            button.IconFont = IconFont.Solid;
            button.IconSize = 30;
            button.Location = new Point(0, 0);
            button.Margin = new Padding(0);
            button.Name = "btn" + name;
            button.Size = new Size(169, 62);
            button.TabIndex = 1;
            button.Text = name;
            button.UseVisualStyleBackColor = false;
            button.Cursor = Cursors.Hand;

            button.Click += new EventHandler(this.activeBtn_Click);

            MethodInfo addIcon = this.GetType().GetMethod(name);

            button.IconChar = (IconChar)addIcon.Invoke(this, null);

            panelMain.Controls.Add(button);
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void radClose_CheckedChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radMinisize_CheckedChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            radMinisize.Checked = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Form signInForm = new SignIn();

            signInForm.Show();

            this.Close();
        }
    }
}
