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
using DTO;
using BLL;
using LIB;

namespace GUI.ChildForms.HotelChildForm
{
    public partial class AddServiceForm : Form
    {
        public event EventHandler<OpenChildForm> handleOpenChildForm;
        private ImageList imgList = new ImageList();
        private List<Service> serviceLst;
        private HotelBLL hotelBLL = new HotelBLL();
        private int orderId;
        private string path;
        private string lstServiceName = "";
        private string totalPrice = "0";

        public AddServiceForm(dynamic paras)
        {
            InitializeComponent();

            this.orderId = paras;
        }

        private string getPath()
        {
            string path = System.Windows.Forms.Application.StartupPath;

            path = path.Substring(0, path.LastIndexOf('\\'));
            path = path.Substring(0, path.LastIndexOf('\\'));

            return path + "\\Resources\\Services\\";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            handleOpenChildForm?.Invoke(this, new OpenChildForm("back"));
        }

        private void AddServiceForm_Load(object sender, EventArgs e)
        {
            this.path = this.getPath();

            this.imgList.ImageSize = new Size(80, 80);

            lstService.SmallImageList = this.imgList;

            this.serviceLst = this.hotelBLL.getService();

            foreach(Service service in this.serviceLst)
            {
                this.addServiceToListView(service);
            }
        }

        private void addServiceToListView(Service service)
        {
            string[] item =
            {
                service.id.ToString(),
                service.name,
                Money.convertMoney(service.price.ToString()),
            };

            ListViewItem lstItem = new ListViewItem(item);

            lstItem.ImageIndex = this.imgList.Images.Add(Image.FromFile(this.path + service.image), Color.Transparent);

            lstService.Items.Add(lstItem);
        }

        private void addServiceToCart(string name, int id, string price)
        {
            string[] item =
            {
                name,
                "1",
                id.ToString(),
                price
            };

            ListViewItem lstItem = new ListViewItem(item);

            lstServiceOrder.Items.Add(lstItem);
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

        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblLog.Text = "";

            if(lstService.SelectedItems.Count > 0)
            {
                ListViewItem focusItem = lstService.FocusedItem;

                bool check = true;

                if (lstServiceOrder.Items.Count > 0)
                {
                    foreach (ListViewItem item in lstServiceOrder.Items)
                    {
                        if (focusItem.SubItems[1].Text == item.Text)
                        {
                            item.SubItems[1].Text = (Convert.ToInt32(item.SubItems[1].Text) + 1).ToString();

                            check = false;

                            break;
                        }
                    }
                }

                if (check)
                {
                    this.addServiceToCart(focusItem.SubItems[1].Text, Convert.ToInt32(focusItem.Text), focusItem.SubItems[2].Text.Replace(".", "").ToString());
                }

                this.totalPrice = (Convert.ToInt32(this.totalPrice) + Convert.ToInt32(focusItem.SubItems[2].Text.Replace(".", ""))).ToString();

                lblPrice.Text = Money.convertMoney(this.totalPrice) + "VND";

                this.showLog("Add success !", true);
            }
            else
            {
                this.showLog("Select service to order !", false);
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            lblLog.Text = "";

            if (lstServiceOrder.SelectedItems.Count > 0)
            {
                ListViewItem item = lstServiceOrder.FocusedItem;

                this.totalPrice = (Convert.ToInt32(this.totalPrice) - Convert.ToInt32(item.SubItems[3].Text)).ToString();

                lblPrice.Text = Money.convertMoney(this.totalPrice) + "VND";

                if (item.SubItems[1].Text == "1")
                {
                    lstServiceOrder.Items.Remove(item);
                }
                else
                {
                    item.SubItems[1].Text = (Convert.ToInt32(item.SubItems[1].Text) - 1).ToString();
                }

                this.showLog("Remove success !", true);
            }
            else
            {
                this.showLog("Select service to remove !", false);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblLog.Text = "";

            this.totalPrice = "0";

            lblPrice.Text = "0VND";

            lstServiceOrder.Items.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(this.totalPrice != "0" && lstServiceOrder.Items.Count > 0)
            {
                bool check = true;

                foreach (ListViewItem item in lstServiceOrder.Items)
                {
                    check = this.hotelBLL.insertOrderService(this.orderId, Convert.ToInt32(item.SubItems[2].Text), Convert.ToInt32(item.SubItems[1].Text));

                    if (!check)
                    {
                        this.showLog("Add service fail !", false);

                        return;
                    }
                }

                handleOpenChildForm?.Invoke(this, new OpenChildForm("back"));
            }
        }
    }
}
