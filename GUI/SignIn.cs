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
using FontAwesome.Sharp;

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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            bool baseResult = base.ProcessCmdKey(ref msg, keyData);

            if (keyData == Keys.Tab && txtIdCode.Focused)
            {
                txtPassword.PasswordChar = '*';
                txtPassword.Text = "";
                txtPassword.Focus();

                return true;
            }


            return baseResult;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblIdCodeError.Text = "";
            lblPasswordError.Text = "";

            if (txtIdCode.Text == "Nhập số căn cước công dân...")
            {
                lblIdCodeError.Text = "You need to enter the id code !";
                return;
            }
            else
            {
                this.user.sIdCode = txtIdCode.Text;
            }

            if (txtPassword.Text == "Nhập mật khẩu...")
            {
                lblPasswordError.Text = "You need to enter the password !";
                return;
            }
            else
            {
                this.user.sPassword = txtPassword.Text;
            }
            

            this.user = userBLL.checkLogin(user);

            if(this.user == null)
            {
                txtIdCode.Text = "Nhập số căn cước công dân...";
                txtPassword.Text = "Nhập mật khẩu...";
                txtPassword.PasswordChar = '\0';

                lblIdCodeError.Text = "Id code or password is wrong !";

                return;
            }

            this.Hide();

            Manager main = new Manager(this.user);

            main.Show();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            txtIdCode.Text = "Nhập số căn cước công dân...";
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;

            if(txtPassword.Text != "Nhập mật khẩu...")
            {
                if (txtPassword.PasswordChar != '*')
                {
                    txtPassword.PasswordChar = '*';

                    btn.IconChar = IconChar.EyeSlash;
                }
                else
                {
                    txtPassword.PasswordChar = '\0';

                    btn.IconChar = IconChar.Eye;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
