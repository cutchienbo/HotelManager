using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Event;
using DTO;
using BLL;
using LIB;

namespace GUI.ChildForms.HotelChildForm
{
    public partial class AddUserForm : Form
    {
        public event EventHandler<OpenChildForm> handleOpenChildForm;
        private HotelBLL hotelBLL = new HotelBLL();
        private List<Room> rooms;
        private User customer;
        private int orderId;

        public AddUserForm(dynamic paras)
        {
            InitializeComponent();

            this.init(paras);
        }

        private void init(int orderId)
        {
            this.rooms = this.hotelBLL.getOrderRoom(orderId);

            cbbRoomNumber.Items.Clear();

            foreach(Room room in this.rooms)
            {
                cbbRoomNumber.Items.Add(room.room_number);
            }

            cbbRoomNumber.SelectedIndex = 0;

            this.orderId = orderId;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            handleOpenChildForm?.Invoke(this, new OpenChildForm("back"));
        }

        private void resetErrorLog()
        {
            lblAddressError.Text = "";
            lblFullNameError.Text = "";
            lblIdCodeError.Text = "";
            lblPhoneNumberError.Text = "";
            lblEmailError.Text = "";
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.resetErrorLog();

            bool check = true;

            if (this.customer == null)
            {
                List<ValidateItem> validateItems = new List<ValidateItem>();

                ValidateItem idCode = new ValidateItem(
                    lblIdCodeError,
                    txtIdCode.Text,
                    @"empty | length:12 | pattern:[0-9]+ | existed:id_code-user",
                    @"Id code can not null ! | Correct length is 13 | Id code accept number only ! | Id Code is existed !"
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

                foreach (ValidateItem item in validateItems)
                {
                    if (!item.handleValidate())
                    {
                        check = false;

                        break;
                    }
                }
            }

            if (check == true)
            {
                int customerId = 0;

                if (this.customer == null)
                {
                    User customer = new User();

                    customer.sIdCode = txtIdCode.Text;
                    customer.sFullName = txtFullName.Text;
                    customer.sPhoneNumber = txtPhoneNumber.Text;
                    customer.sAddress = txtAddress.Text;
                    customer.sEmail = txtEmail.Text;

                    customerId = this.hotelBLL.insertCustomer(customer);
                }
                else
                {
                    customerId = this.customer.sId;
                }

                int id = this.hotelBLL.insertOrderUser(this.orderId, cbbRoomNumber.Text, customerId);

                if(id == 0)
                {
                    lblLog.Text = "User is existed in order !";
                    lblLog.ForeColor = Color.Red;
                }
                else
                {
                    lblLog.Text = "Add user success !";
                    lblLog.ForeColor = Color.Lime;
                }


                this.customer = null;
            }
        }

        private void txtIdCode_TextChanged(object sender, EventArgs e)
        {
            if (txtIdCode.Text.Length == 12)
            {
                this.customer = this.hotelBLL.getCustomerByIdCode(txtIdCode.Text);

                if (customer != null)
                {
                    MessageBox.Show("Customers who have used the services of the hotel !");

                    txtFullName.Text = this.customer.sFullName;
                    txtEmail.Text = this.customer.sEmail;
                    txtPhoneNumber.Text = this.customer.sPhoneNumber;
                    txtAddress.Text = this.customer.sAddress;
                }
            }
        }
    }
}
