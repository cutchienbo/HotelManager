using System;
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

namespace GUI
{
    public partial class Manager : Form
    {
        private IconButton activeBtn;
        private Panel leftBtnBorder;
        private Form currentChildForm;
        public Manager(string full_name, string permission)
        {
            InitializeComponent();
            this.leftBtnBorder = new Panel();
            this.leftBtnBorder.Size = new Size(6, 62);
            this.leftBtnBorder.BackColor = Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.leftBtnBorder.TabIndex = 2;
            this.leftBtnBorder.BringToFront();

            lblName.Text = full_name;

            permission = permission.Trim(',');
            string[] perStr = permission.Split(',');

            foreach (string str in perStr)
            {
                string first = str.Substring(0, 1);
                string second = str.Substring(1);

                drawButton(first.ToUpper() + second);
            }
            
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
            button.ForeColor = Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            button.Font = new System.Drawing.Font("Arial", 8.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            button.IconColor = Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(254)))), ((int)(((byte)(241)))));
            button.BackColor = Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            button.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
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
            button.BackColor = Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            button.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
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
                currentChildForm.Close();
            }

            addChildForm.Invoke(this, null);
        }
        
        public void openChildForm(Form childForm)
        {
            this.currentChildForm = childForm;

            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Size = new Size(1232, 716);

            panelChildForm.Controls.Add(childForm);

            childForm.BringToFront();
            childForm.Show();
        }

        public void btnHotel()
        {
            Form childForm = new FormHotel();

            openChildForm(childForm);
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
            Form childForm = new FormCustomer();

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
