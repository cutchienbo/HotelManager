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
    public partial class CheckOutForm : Form
    {
        public event EventHandler<OpenChildForm> handleOpenChildForm;
        private HotelBLL hotelBLL = new HotelBLL();
        private Order order;
        private List<Room> rooms;

        public CheckOutForm(dynamic paras, object ob)
        {
            InitializeComponent();

            this.order = (Order)ob;

            this.rooms = this.hotelBLL.getRoomByOrderId(this.order.id);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            handleOpenChildForm?.Invoke(this, new OpenChildForm("back"));
        }

        private void addDataToListService(Service service, int i)
        {
            string[] data =
            {
                i.ToString(),
                service.name,
                Money.convertMoney(service.price.ToString()),
                service.quantity.ToString(),
            };

            ListViewItem item = new ListViewItem(data);

            lstService.Items.Add(item);
        }

        private void addDataToListRoom(Room room, int i, int duration)
        {
            string[] data =
           {
                i.ToString(),
                room.room_number,
                room.room_type_name,
                Money.convertMoney(room.price.ToString()),
                duration.ToString()
            };

            ListViewItem item = new ListViewItem(data);

            lstRoom.Items.Add(item);
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            txtCustomer.Text = this.order.customer_name;
            txtStaff.Text = this.order.user_name;
            dtpOrderCheckIn.Value = DateTime.Parse(this.order.check_in_date);
            dtpOrderCheckOut.Value = DateTime.Parse(this.order.check_out_date);

            int duration = dtpOrderCheckOut.Value.Day - dtpOrderCheckIn.Value.Day;

            int i = 1;

            foreach(Room room in this.rooms)
            {
                this.addDataToListRoom(room, i++, duration);
            }

            i = 1;

            foreach(Service service in this.order.services)
            {
                this.addDataToListService(service, i++);
            }

            lblServicePrice.Text = Money.convertMoney((Convert.ToInt32(this.order.totalPrice.Split('.')[0]) - this.order.price).ToString()) + "VND";
            lblRoomPrice.Text = Money.convertMoney(this.order.price.ToString()) + "VND";
            lblToTalPrice.Text = Money.convertMoney(this.order.totalPrice) + "VND";
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            this.hotelBLL.changeOrderStatus(this.order.id, 1);

            handleOpenChildForm?.Invoke(this, new OpenChildForm("back"));
        }
    }
}
