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
using System.Text.RegularExpressions;

namespace GUI.ChildForms
{
    public partial class FormUser : Form
    {
        UserBLL userBLL = new UserBLL();
        List<User> users = new List<User>();
        List<Role> roles = new List<Role>();

        public FormUser()
        {
            InitializeComponent();
            this.showUsers();
        }

        private void showUsers()
        {
            this.users = userBLL.getUsers();

            this.roles = userBLL.getRoles();

            foreach(Role role in roles)
            {
                cbbRole.Items.Add(role.sName);
            }

            int i = 1;

            foreach(User user in this.users) 
            {
                string status = user.sStatetus == 1 ? "Active" : "Disable";

                string[] item =
                {
                    i.ToString(),
                    user.sFullName,
                    user.sIdCode,
                    user.sPhoneNumber,
                    user.sEmail,
                    user.sAddress,
                    user.sPassword,
                    status,
                    user.sRoleName
                };

                ListViewItem lstItem = new ListViewItem(item);

                lstUsers.Items.Add(lstItem);

                i++;
            }
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem lstItem = lstUsers.FocusedItem;

            txtFullName.Text = lstItem.SubItems[1].Text;
            txtIdCode.Text = lstItem.SubItems[2].Text;
            txtPhoneNumber.Text = lstItem.SubItems[3].Text;
            txtEmail.Text = lstItem.SubItems[4].Text;
            txtAddress.Text = lstItem.SubItems[5].Text;
            txtPassword.Text = lstItem.SubItems[6].Text;

            chkStatetus.Checked = lstItem.SubItems[7].Text == "Active" ? true : false;

            cbbRole.SelectedItem = lstItem.SubItems[8].Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.resetErrorLog();

            User user = new User();

            user.sIdCode = txtIdCode.Text;
            user.sFullName = txtFullName.Text;
            user.sPhoneNumber = txtPhoneNumber.Text;
            user.sEmail = txtEmail.Text;
            user.sAddress = txtAddress.Text;
            user.sPassword = txtPassword.Text;
            user.sStatetus = chkStatetus.Checked ? 1 : 0;
            user.sRoleName = cbbRole.Text;

            //Validate:
            //id code
            if(user.sIdCode == "")
            {
                lblIdCodeError.Text = "Id code can not null !";
                return;
            }

            if (!Regex.IsMatch(user.sIdCode, @"[0-9]+"))
            {
                lblIdCodeError.Text = "Id code accept number only !";
                return;
            }

            //full name
            if (user.sFullName == "")
            {
                lblFullNameError.Text = "Full name can not null !";
                return;
            }

            if (!Regex.IsMatch(user.sFullName, @"[a-zA-Z]+[\s][a-zA-Z]+"))
            {
                lblFullNameError.Text = "Wrong full name format !";
                return;
            }

            //

        }

        private void resetErrorLog()
        {
            lblAddressError.Text = "";
            lblEmailError.Text = "";
            lblFullNameError.Text = "";
            lblIdCodeError.Text = "";
            lblPasswordError.Text = "";
            lblPhoneNumberErro.Text = "";
            lblRoleError.Text = "";
        }
    }
}
