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
using System.Runtime.CompilerServices;

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

            List<ValidateItem> validateItems = new List<ValidateItem>();

            ValidateItem idCode = new ValidateItem(
                lblIdCodeError, 
                txtIdCode.Text, 
                @"empty | pattern:[0-9]+", 
                @"Id code can not null ! | Id code only accept number !"
            );
            validateItems.Add(idCode);

            ValidateItem fullName = new ValidateItem(
               lblFullNameError,
               txtFullName.Text,
               @"empty | pattern:[a-zA-Z]+[\s][a-zA-Z]+",
               @"Full name can not null ! | Wrong full name format !"
            );
            validateItems.Add(fullName);

            ValidateItem phoneNumber = new ValidateItem(
                lblPhoneNumberError,
                txtPhoneNumber.Text,
                @"empty | pattern:[0-9]+",
                @"Phone number can not null ! | Wrong phone number format !"
            );
            validateItems.Add(phoneNumber);

            ValidateItem role = new ValidateItem(
                lblRoleError,
                cbbRole.Text,
                @"empty",
                @"Role can not null"
            );
            validateItems.Add(role);

            ValidateItem address = new ValidateItem(
                lblAddressError,
                txtAddress.Text,
                @"empty | pattern:.[,].",
                @"Address can not null ! | Wrong address format !"
            );
            validateItems.Add(address);

            foreach (ValidateItem item in validateItems)
            {
                if (!item.handleValidate())
                    break;
            }

        }

        private void resetErrorLog()
        {
            lblAddressError.Text = "address";
            lblEmailError.Text = "email";
            lblFullNameError.Text = "fullname";
            lblIdCodeError.Text = "idcode";
            lblPasswordError.Text = "pasword";
            lblPhoneNumberError.Text = "phone";
            lblRoleError.Text = "role";
        }
    }
}
