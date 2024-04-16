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
using System.Data.SqlClient;

namespace GUI.ChildForms
{
    public partial class FormUser : Form
    {
        UserBLL userBLL = new UserBLL();
        List<User> users = new List<User>();
        List<Role> roles = new List<Role>();
        int totalUser = 1;

        public FormUser()
        {
            InitializeComponent();
            this.showUsers();
            this.showRoles();
            cbbSearchField.SelectedIndex = 0;
            chkIsActive.Checked = true;
        }

        private void showUsers()
        {
            this.users = userBLL.getUsers();

            this.totalUser = 1;

            foreach(User user in this.users) 
            {
                addUserToListView(user);
            }
        }

        private void showRoles()
        {
            this.roles = userBLL.getRoles();

            foreach (Role role in roles)
            {
                cbbRole.Items.Add(role.sName);
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

            List<ValidateItem> validateItems = new List<ValidateItem>();

            ValidateItem idCode = new ValidateItem(
                lblIdCodeError,
                txtIdCode.Text,
                @"empty | pattern:[0-9]+ | existed:id_code-user | length:13",
                @"Id code can not null ! | Id code only accept number ! | Id code existed ! | Correct length is 13"
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
                @"empty | pattern:[0-9]+ | existed:phone_number-user | length:10-13",
                @"Phone number can not null ! | Wrong phone number format ! | Phone number exsisted ! | Correct length is 10 - 13"
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

            ValidateItem email = new ValidateItem(
                lblEmailError,
                txtEmail.Text,
                @"empty | pattern:.@. | existed:email-user",
                @"Email can not null ! | Email wrong format ! | Email existed !"
            );
            validateItems.Add(email);

            ValidateItem password = new ValidateItem(
               lblPasswordError,
               txtPassword.Text,
               @"empty | length:8-16",
               @"Email can not null ! | Correct length is 8 -16 !"
           );
            validateItems.Add(email);

            bool check = true;

            foreach (ValidateItem item in validateItems)
            {
                if (!item.handleValidate())
                {
                    check = false;

                    break;
                }
            }

            if (check != false)
            {
                user = this.userBLL.insertUser(user);

                if(user != null)
                {
                    this.showLog("Insert user success !", true);

                    addUserToListView(user);
                }
                else
                {
                    this.showLog("Can not insert user !", false);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedItems.Count > 0)
            {
                this.resetErrorLog();

                User user = new User();

                user.sId = int.Parse(lstUsers.FocusedItem.SubItems[9].Text);
                user.sIdCode = txtIdCode.Text;
                user.sFullName = txtFullName.Text;
                user.sPhoneNumber = txtPhoneNumber.Text;
                user.sEmail = txtEmail.Text;
                user.sAddress = txtAddress.Text;
                user.sPassword = txtPassword.Text;
                user.sStatetus = chkStatetus.Checked ? 1 : 0;
                user.sRoleName = cbbRole.Text;

                List<ValidateItem> validateItems = new List<ValidateItem>();

                ValidateItem idCode = new ValidateItem(
                    lblIdCodeError,
                    txtIdCode.Text,
                    @"empty | pattern:[0-9]+ | length:13",
                    @"Id code can not null ! | Id code only accept number ! | Correct length is 13"
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
                    @"empty | pattern:[0-9]+ | length:10-13",
                    @"Phone number can not null ! | Wrong phone number format ! | Correct length is 10 - 13"
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

                ValidateItem email = new ValidateItem(
                    lblEmailError,
                    txtEmail.Text,
                    @"empty | pattern:.@.",
                    @"Email can not null ! | Email wrong format !"
                );
                validateItems.Add(email);

                ValidateItem password = new ValidateItem(
                   lblPasswordError,
                   txtPassword.Text,
                   @"empty | length:8-16",
                   @"Email can not null ! | Correct length is 8 -16 !"
               );
                validateItems.Add(email);

                bool check = true;

                foreach (ValidateItem item in validateItems)
                {
                    if (!item.handleValidate())
                    {
                        check = false;

                        break;
                    }
                }

                if (check != false)
                {
                    check = this.userBLL.updateUser(user);

                    if(check == true)
                    {
                        this.showLog("Update success !", true);

                        lstUsers.Items.Clear();

                        this.showUsers();
                    }
                    else
                    {
                        this.showLog("Can not update !", false);
                    }
                }
                else
                {
                    this.showLog("Can not update !", false);
                }
            }
            else
            {
                this.showLog("Please select user to update !", false);
            }
        }

        private void resetErrorLog()
        {
            lblAddressError.Text = "";
            lblEmailError.Text = "";
            lblFullNameError.Text = "";
            lblIdCodeError.Text = "";
            lblPasswordError.Text = "";
            lblPhoneNumberError.Text = "";
            lblRoleError.Text = "";
            lblUserLog.Text = "";
        }

        private void showLog(string str, bool type)
        {
            if(type == true)
            {
                lblUserLog.ForeColor = Color.Lime;
            }
            else
            {
                lblUserLog.ForeColor = Color.Red;
            }

            lblUserLog.Text = str;
        }

        private void addUserToListView(User user)
        {
            string status = user.sStatetus == 1 ? "Active" : "Disable";

            string[] item =
            {
                    this.totalUser.ToString(),
                    user.sFullName,
                    user.sIdCode,
                    user.sPhoneNumber,
                    user.sEmail,
                    user.sAddress,
                    user.sPassword,
                    status,
                    user.sRoleName,
                    user.sId.ToString(),
                    };

            ListViewItem lstItem = new ListViewItem(item);

            lstUsers.Items.Add(lstItem);

            this.totalUser++;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.resetErrorLog();

            List<User> users = new List<User>();

            users = userBLL.searchUser(cbbSearchField.Text, txtSearchValue.Text, chkIsActive.Checked);

            lstUsers.Items.Clear();
            this.totalUser = 1;

            if(users != null) 
            {
                foreach (User user in users)
                {
                    addUserToListView(user);
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.resetErrorLog();

            this.clearTextBox();

            lstUsers.Items.Clear();

            txtSearchValue.Text = "";

            this.totalUser = 1;

            this.showUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.resetErrorLog();

            string id = "";

            if (lstUsers.SelectedItems.Count > 0)
            {
                id = lstUsers.SelectedItems[0].SubItems[9].Text;
            }

            if (id == "")
            {
                this.showLog("Please select user to delete !", false);
            }
            else
            {
                int res = this.userBLL.deleteUser(id);

                switch (res)
                {
                    case 2: this.showLog("User have effect with system !", false); break;
                    case 1: this.showLog("User not exist !", false); break;
                    case 4: this.showLog("Delete success !", true); this.clearTextBox(); break;
                    case 3: this.showLog("Disable user success !", true); this.clearTextBox(); break;
                }

                lstUsers.Items.Clear();

                this.showUsers();
            }
        }

        private void clearTextBox()
        {
            txtIdCode.Text = "";
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.clearTextBox();
        }
    }
}
