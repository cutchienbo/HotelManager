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

namespace GUI.ChildForms
{
    public partial class FormOrder : Form
    {
        private OrderBLL orderBLL = new OrderBLL();
        private List<Order> orderList = new List<Order>();
        private int totalOrder = 1;
        private int totalRoom = 1;
        private int totalService = 1;

        public FormOrder()
        {
            InitializeComponent();
        }

        private void showLog(string str, bool type)
        {
            if (type == true)
            {
                lblLog.ForeColor = Color.Lime;
            }
            else
            {
                lblLog.ForeColor = Color.Red;
            }

            lblLog.Text = str;
        }

        private void addOrderToListView(Order order)
        {
            string[] item =
            {
                order.id.ToString(),
                order.user_name,
                order.customer_name,
                order.check_in_date.Substring(0, 10),
                order.check_out_date.Substring(0, 10),
                order.status == 1 ? "Active" : "Disable",
                order.price.ToString(),
                (this.totalOrder - 1).ToString()
            };

            ListViewItem lstItem = new ListViewItem(item);

            lstOrder.Items.Add(lstItem);

            this.totalOrder++;
        }

        private void addServiceToListView(Service service)
        {
            string[] item =
            {
                this.totalService.ToString(),
                service.name,
                service.price.ToString(),
            };

            ListViewItem lstItem = new ListViewItem(item);

            lstService.Items.Add(lstItem);

            this.totalService++;
        }

        private void addRoomToListView(Room room)
        {
            string[] item =
            {
                this.totalRoom.ToString(),
                room.room_number.ToString(),
                room.room_type_name
            };

            ListViewItem lstItem = new ListViewItem(item);

            lstRoom.Items.Add(lstItem);

            this.totalRoom++;
        }


        private void FormOrder_Load(object sender, EventArgs e)
        {
            this.orderList = this.orderBLL.getOrder();

            foreach(Order order in this.orderList)
            {
                this.addOrderToListView(order);
            }
        }

        private void clearTextbox()
        {
            txtOrderPrice.Text = "";
            txtCustomer.Text = "";
            txtStaff.Text = "";
            dtpOrderCheckIn.Value = DateTime.Now;
            dtpOrderCheckOut.Value = DateTime.Now;
        }

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.totalRoom = 1;
            this.totalService = 1;

            lstService.Items.Clear();
            lstRoom.Items.Clear();  

            ListViewItem item = lstOrder.FocusedItem;

            int itemIndex = Convert.ToInt32(item.SubItems[7].Text);

            if (this.orderList[itemIndex].rooms == null && this.orderList[itemIndex].services == null)
            {
                int orderId = Convert.ToInt32(item.SubItems[0].Text);

                this.orderList[itemIndex].rooms = this.orderBLL.getOrderRoom(orderId);

                foreach(Room room in this.orderList[itemIndex].rooms){
                    this.addRoomToListView(room);
                }

                this.orderList[itemIndex].services = this.orderBLL.getOrderService(orderId);

                foreach(Service service in this.orderList[itemIndex].services)
                {
                    this.addServiceToListView(service);
                }
            }
            else
            {
                foreach (Room room in this.orderList[itemIndex].rooms)
                {
                    this.addRoomToListView(room);
                }

                foreach (Service service in this.orderList[itemIndex].services)
                {
                    this.addServiceToListView(service);
                }
            }

            txtOrderPrice.Text = item.SubItems[6].Text;
            txtCustomer.Text = item.SubItems[2].Text;
            txtStaff.Text = item.SubItems[1].Text;
            chkStatetus.Checked = item.SubItems[5].Text == "Active" ? true : false;
            dtpOrderCheckIn.Value = DateTime.Parse(item.SubItems[3].Text);
            dtpOrderCheckOut.Value = DateTime.Parse(item.SubItems[4].Text);

            if(item.SubItems[5].Text == "Active")
            {
                btnUndo.Enabled = false;
            }
            else
            {
                btnUndo.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clearTextbox();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Order order = new Order();

            order.customer_name = txtCustomer.Text;
            order.user_name = txtStaff.Text;
            order.price = Convert.ToInt32(txtOrderPrice.Text == "" ? "0" : txtOrderPrice.Text);
            order.check_in_date = dtpOrderCheckIn.Value.ToString().Substring(0, 10);
            order.check_out_date = dtpOrderCheckOut.Value.ToString().Substring(0, 10);
            order.status = chkStatetus.Checked == true ? 1 : 0;

            this.orderList = this.orderBLL.searchOrder(order);

            lstOrder.Items.Clear();
            lstRoom.Items.Clear();
            lstService.Items.Clear();

            this.totalOrder = 1;
            this.totalRoom = 1;
            this.totalService = 1;

            foreach (Order item in this.orderList)
            {
                this.addOrderToListView(item);
            }
        }

        private void FormOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedItems.Count > 0)
            {
                ListViewItem item = lstOrder.FocusedItem;

                int id = Convert.ToInt32(item.SubItems[0].Text);
                int status = item.SubItems[5].Text == "Active" ? 1 : 0;

                bool res = this.orderBLL.deleteOrder(id, status);

                if (res == true)
                {
                    this.showLog("Delete success!", true);

                    lstOrder.Items.Remove(item);
                }
                else
                {
                    this.showLog("Remove success!", true);

                    item.SubItems[5].Text = "Disable";
                }
            }
            else
            {
                this.showLog("Select order to delete !", false);
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedItems.Count > 0)
            {
                ListViewItem item = lstOrder.FocusedItem;

                int id = Convert.ToInt32(item.SubItems[0].Text);

                bool res = this.orderBLL.undoOrder(id);

                if (res == true)
                {
                    this.showLog("Undo success!", true);

                    item.SubItems[5].Text = "Active";

                    btnUndo.Enabled = false;
                }
                else
                {
                    this.showLog("Undo fail!", false);
                }
            }
            else
            {
                this.showLog("Select order to undo !", false);
            }
        }
    }
}
