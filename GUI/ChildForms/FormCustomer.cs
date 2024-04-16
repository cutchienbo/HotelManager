using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI.ChildForms
{
    public partial class FormCustomer : Form
    {
        UserBLL userBLL = new UserBLL();
        private int totalCustomer = 1;
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            List<User> users = this.userBLL.getCustomer();

            foreach(User user in users)
            {
                this.addUserToListView(user);
            }
        }

        private void addUserToListView(User user)
        {
            string status = user.sStatetus == 1 ? "Active" : "Disable";

            string[] item =
            {
                    this.totalCustomer.ToString(),
                    user.sFullName,
                    user.sIdCode,
                    user.sPhoneNumber,
                    user.sEmail,
                    user.sAddress,
                    status,
                    user.sId.ToString(),
                    };

            ListViewItem lstItem = new ListViewItem(item);

            lstCustomer.Items.Add(lstItem);

            this.totalCustomer++;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstCustomer.Items.Clear();
            this.totalCustomer = 1;

            User user = new User();

            user.sIdCode = txtIdCode.Text;
            user.sFullName = txtFullName.Text;
            user.sPhoneNumber = txtPhoneNumber.Text;
            user.sEmail = txtEmail.Text;
            user.sAddress = txtAddress.Text;
            user.sStatetus = chkStatetus.Checked ? 1 : 0;

            List<User> users = this.userBLL.searchCustomer(user);

            foreach (User u in users)
            {
                this.addUserToListView(u);
            }
        }

        private void lstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem lstItem = lstCustomer.FocusedItem;

            txtFullName.Text = lstItem.SubItems[1].Text;
            txtIdCode.Text = lstItem.SubItems[2].Text;
            txtPhoneNumber.Text = lstItem.SubItems[3].Text;
            txtEmail.Text = lstItem.SubItems[4].Text;
            txtAddress.Text = lstItem.SubItems[5].Text;

            chkStatetus.Checked = lstItem.SubItems[6].Text == "Active" ? true : false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "";
            txtIdCode.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";

            chkStatetus.Checked = false;
        }

        private void btnChangeState_Click(object sender, EventArgs e)
        {
            if (lstCustomer.SelectedItems.Count > 0)
            {
                string idCode = lstCustomer.FocusedItem.SubItems[2].Text;
                int state = lstCustomer.FocusedItem.SubItems[6].Text == "Active" ? 1 : 0;

                bool check = this.userBLL.changeCustomerState(idCode, state);

                chkStatetus.Checked = state == 1 ? false : true;

                lstCustomer.FocusedItem.SubItems[6].Text = lstCustomer.FocusedItem.SubItems[6].Text == "Active" ? "Disable" : "Active";
            }
        }
    }
}
