using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class SignIn : Form
    {
        User user = new User();
        UserBLL userBLL = new UserBLL();

        public SignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIdCode.Text == "Nhập số căn cước công dân...")
            {
                user.sIdCode = "";
            }
            else
            {
                user.sIdCode = txtIdCode.Text;
            }

            if (txtPassword.Text == "Nhập mật khẩu...")
            {
                user.sPassword = "";
            }
            else
            {
                user.sPassword = txtPassword.Text;
            }
            

            string getUser = userBLL.checkLogin(user);

            switch (getUser)
            {
                case "required_id_code":
                    MessageBox.Show("Bạn chưa nhập số căn cước công dân");
                    return;
                case "required_password":
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                    return;
                case "id code or password wrong":
                    txtIdCode.Text = "";
                    txtPassword.Text = "";
                    MessageBox.Show("Số căn cước công dân hoặc mật khẩu của bạn sai");
                    return;
            }

            string[] listStr = getUser.Split('-');

            string fullName = listStr[0];
            string permisssion = listStr[1];

            this.Hide();

            Manager main = new Manager(fullName, permisssion);
            main.Show();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            txtIdCode.Text = "Nhập số căn cước công dân...";
            txtPassword.PasswordChar = '\0';
            txtPassword.Text = "Nhập mật khẩu...";
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
          
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Nhập mật khẩu...";
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Nhập mật khẩu...")
            {
    
                txtPassword.PasswordChar = '*';
                txtPassword.Text = "";
            }
        }

        private void txtIdCode_Leave(object sender, EventArgs e)
        {
            if (txtIdCode.Text == "")
            {

                txtIdCode.Text = "Nhập số căn cước công dân...";
            }
        }

        private void txtIdCode_Click(object sender, EventArgs e)
        {
            if (txtIdCode.Text == "Nhập số căn cước công dân...")
            {
                txtIdCode.Text = "";
            }
        }

        private void txtIdCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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
    }
}
