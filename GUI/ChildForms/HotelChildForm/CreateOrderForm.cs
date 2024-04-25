using GUI.Event;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI.ChildForms.HotelChildForm
{
    public partial class CreateOrderForm : Form
    {
        private HotelBLL hotelBLL = new HotelBLL();
        public event EventHandler<OpenChildForm> handleOpenChildForm;
        private string checkInTime;
        private string checkOutTime;
        private int price;
        private string roomId;
        private User customer;
        private User staff;

        public CreateOrderForm(dynamic paras, User staff)
        {
            InitializeComponent();

            this.init(paras);

            this.staff = staff;
        }

        private void init(string paras)
        {
            string[] data = paras.Split('-');

            this.roomId = data[0];

            string checkInTime = data[2].Split('&')[0];
            string checkOutTime = data[2].Split('&')[1];

            this.checkInTime = checkInTime.Split('/')[1] + '/' + checkInTime.Split('/')[0] + '/' + DateTime.Now.Year;
            this.checkOutTime = checkOutTime.Split('/')[1] + '/' + checkOutTime.Split('/')[0] + '/' + DateTime.Now.Year;

            txtRoomNumber.Text = data[1];

            dtpCheckInTime.Value = DateTime.Parse(this.checkInTime);
            dtpCheckOutTime.Value = DateTime.Parse(this.checkOutTime);

            this.price = Convert.ToInt32(data[3]);
        }

        private void iconButton1_Click(object sender, EventArgs e)
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

        private void btnCreateOrder_Click(object sender, EventArgs e)
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

            if(check == true)
            {
                int customerId = 0;

                if(this.customer == null)
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

                Order order = new Order();

                order.user_id = this.staff.sId;
                order.customer_id = customerId;
                order.check_in_date = this.checkInTime;
                order.check_out_date = this.checkOutTime;
                order.price = this.price;

                int orderId = this.hotelBLL.insertOrder(order);

                string[] roomIdx = this.roomId.Split('+');

                foreach(string id in roomIdx)
                {
                    this.hotelBLL.insertOrderRoom(orderId, Convert.ToInt32(id));
                }

                handleOpenChildForm?.Invoke(this, new OpenChildForm("back"));
            }
        }

        private void txtIdCode_TextChanged(object sender, EventArgs e)
        {
            if(txtIdCode.Text.Length == 12)
            {
                this.customer = this.hotelBLL.getCustomerByIdCode(txtIdCode.Text);

                if(customer != null)
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
