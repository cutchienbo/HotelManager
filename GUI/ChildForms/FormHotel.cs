using BLL;
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
using GUI;
using GUI.Event;
using System.Windows.Controls;
using DAL;
using LIB;

namespace GUI.ChildForms
{
    public partial class FormHotel : Form
    {
        private HotelBLL hotelBLL = new HotelBLL();
        private List<Room> roomLst;
        private List<Order> currentOrderChoose = new List<Order>();
        private int startCellIdx = 0;
        private int endCellIdx = 0;
        private List<int> roomCellSelected = new List<int>();
        private Room roomSelected;
        public event EventHandler<OpenChildForm> handleOpenChildForm;
        private string checkInTime;
        private string checkOutTime;

        public FormHotel()
        {
            InitializeComponent();

            string[] time = this.hotelBLL.getTimeConfig();

            this.checkInTime = time[0];
            this.checkOutTime = time[1];
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

        private void initBoard(string roomTypeName = "")    
        {
            lstHotel.Items.Clear();

            //Get a startDay and endDate to render a list of day depend to current date choose in DTP
            string startDate = dtpSystemTime.Value.AddDays(-6).ToString();
            string endDate = dtpSystemTime.Value.AddDays(8).ToString();

            int currentDayIndex = 7;

            int startInx = -6;

            for (int i = 1; i < lstHotel.Columns.Count; i++)
            {
                lstHotel.Columns[i].Text = dtpSystemTime.Value.AddDays(startInx).Day.ToString() + "/" + dtpSystemTime.Value.AddDays(startInx++).Month.ToString();
            }

            this.roomLst = this.hotelBLL.getRoomOrder(startDate, endDate, roomTypeName);

            int roomIndex = 0;

            foreach (Room room in this.roomLst)
            {
                string[] value = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
                System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem(value);

                item.UseItemStyleForSubItems = false;

                switch (room.status)
                {
                    case 1:
                        item.SubItems[0].BackColor = Color.Yellow;
                        break;
                    case 2:
                        item.SubItems[0].BackColor = Color.SkyBlue;
                        break;
                }

                item.SubItems[0].Text = room.room_number;
                item.SubItems[0].Tag = roomIndex;

                if (room.orders != null)
                {
                    foreach (Order order in room.orders)
                    {
                        DateTime checkinTime = DateTime.Parse(order.check_in_date).AddHours(Convert.ToInt32(this.checkInTime.Split(':')[0])).AddMinutes(Convert.ToInt32(this.checkInTime.Split(':')[1]));
                        DateTime checkoutTime = DateTime.Parse(order.check_out_date).AddHours(Convert.ToInt32(this.checkOutTime.Split(':')[0])).AddMinutes(Convert.ToInt32(this.checkOutTime.Split(':')[1]));

                        if (order.status == 1 && checkoutTime >= DateTime.Now)
                        {
                            continue;
                        }

                        int duration = checkoutTime.Subtract(checkinTime).Days + 1;

                        int checkinTimeIndex = 0;

                        if (checkinTime < dtpSystemTime.Value)
                        {
                            checkinTimeIndex = currentDayIndex - dtpSystemTime.Value.Subtract(checkinTime).Days;
                        }
                        else if (checkinTime > dtpSystemTime.Value)
                        {
                           checkinTimeIndex = currentDayIndex + checkinTime.Subtract(dtpSystemTime.Value).Days + 1;
                        }
                        else
                        {
                            checkinTimeIndex = currentDayIndex;
                        }

                        order.startIndex = checkinTimeIndex < 1 ? 1 : checkinTimeIndex;
                        order.endIndex = checkinTimeIndex + duration > 15 ? 15 : checkinTimeIndex + duration;
                        order.roomInx = roomIndex;

                        Color logColor = Color.White;

                        switch (order.status)
                        {
                            case 1:
                                logColor = Color.Navy; 
                                break;
                            case 2:
                                logColor = Color.Violet;

                                if (checkoutTime < DateTime.Now)
                                {
                                    logColor = Color.Red;
                                }
                                else if (checkinTime < DateTime.Now)
                                {
                                    logColor = Color.Orange;
                                }

                                break;
                            case 3:
                                logColor = Color.LimeGreen;

                                if (checkoutTime < DateTime.Now)
                                {
                                    logColor = Color.Red;
                                }

                                break;
                        }

                        int endIndex = checkinTimeIndex + duration;

                        for (int i = checkinTimeIndex; i <= endIndex; i++)
                        {
                            if(i > 0 && i < 16) 
                            {
                                item.SubItems[i].BackColor = logColor;
                                item.SubItems[i].Tag = order.id.ToString() + "," + roomIndex.ToString();
                            }
                        }
                    }
                }

                lstHotel.Items.Add(item);

                roomIndex++;
            }

            this.createDefaultCell();
        }

        private void FormHotel_Load(object sender, EventArgs e)
        {
            List<RoomType> roomTypes = this.hotelBLL.getRoomType();

            cbbRoomType.Items.Add("All");

            foreach(RoomType roomType in roomTypes)
            {
                cbbRoomType.Items.Add(roomType.name);
            }

            cbbRoomType.SelectedIndex = 0;
        }

        private void createDefaultCell()
        {
            int startIdx = -6;

            for (int i = 0; i < this.roomLst.Count; i++)
            {
                startIdx = -6;

                for (int j = 1; j < 16; j++)
                {
                    if (lstHotel.Items[i].SubItems[j].Tag == null)
                    {
                        if (dtpSystemTime.Value.AddDays(startIdx) < DateTime.Now.AddDays(-1) && j != 7)
                        {
                            lstHotel.Items[i].SubItems[j].BackColor = Color.Wheat;
                        }
                        else
                        {
                            string day = (Convert.ToInt32(lstHotel.Columns[j].Text.Split('/')[0]) + 1).ToString();
                            string month = lstHotel.Columns[j].Text.Split('/')[1];

                            string date = month + '/' + day;

                            if (j == 7)
                            {
                                lstHotel.Items[i].SubItems[j].BackColor = Color.Brown;
                                lstHotel.Items[i].SubItems[j].Tag = i.ToString() + "-" + date + "-" + j.ToString();
                            }
                            else
                            {
                                lstHotel.Items[i].SubItems[j].Tag = i.ToString() + "-" + date + "-" + j.ToString();
                            }
                        }
                    }

                    startIdx++;
                }
            }
        }

        private void activeCell(ListViewHitTestInfo item)
        {
            int orderId = Convert.ToInt32(item.SubItem.Tag.ToString().Split(',')[0]);

            foreach (Room room in this.roomLst)
            {
                foreach (Order order in room.orders)
                {
                    if (order.id == orderId)
                    {
                        int roomIndex = order.roomInx;

                        int startOrderIndex = order.startIndex;
                        int endOrderIndex = order.endIndex;

                        for (int i = startOrderIndex; i <= endOrderIndex; i++)
                        {
                            lstHotel.Items[roomIndex].SubItems[i].Text = "Tick";
             
                            this.currentOrderChoose.Add(order);
                        }
                    }
                }
            }
        }

        private void disableCell()
        {
            if (this.currentOrderChoose.Count > 0)
            {
                foreach (Order order in this.currentOrderChoose)
                {
                    int roomIndex = order.roomInx;

                    int startOrderIndex = order.startIndex;
                    int endOrderIndex = order.endIndex;

                    for (int i = startOrderIndex; i <= endOrderIndex; i++)
                    {
                        lstHotel.Items[roomIndex].SubItems[i].Text = "";
                    }
                }

                this.currentOrderChoose.Clear();
            }
        }

        private void resetTextBox()
        {
            txtCustomerName.Text = "";
            txtStaffName.Text = "";
            lblLog.Text = "";
            lblTotalPrice.Text = "0VND";
        }

        private void showColorInfo(string info)
        {
            MessageBox.Show(info);
        }

        private void addServiceToListView(List<Service> services)
        {
            for (int i = 0; i < services.Count; i++)
            {
                System.Windows.Forms.ListViewItem serviceItem = new System.Windows.Forms.ListViewItem();

                serviceItem.Text = (i + 1).ToString();
                serviceItem.SubItems.Add(services[i].name);
                serviceItem.SubItems.Add(Money.convertMoney(services[i].price.ToString()));
                serviceItem.SubItems.Add(Money.convertMoney(services[i].quantity.ToString()));

                lstService.Items.Add(serviceItem);
            }
        }

        private void lstHotel_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo item = lstHotel.HitTest(e.X, e.Y);

            lstService.Items.Clear();

            lblLog.Text = "";

            if (item.SubItem != null)
            {
                //Check is click in to a cell have tag => cell have colored
                if (item.SubItem.Tag != null)
                {
                    //Click in cell had order
                    if (item.SubItem.Text == "" && item.SubItem.Tag.ToString().Contains(','))
                    {
                        this.disableCell();

                        this.activeCell(item);

                        this.resetSelectEmptyCell();

                        int roomIdx = Convert.ToInt32(item.SubItem.Tag.ToString().Split(',')[1]);
                        int orderId = Convert.ToInt32(item.SubItem.Tag.ToString().Split(',')[0]);

                        foreach (Order order in this.roomLst[roomIdx].orders)
                        {
                            if(order.id == orderId)
                            {
                                txtCustomerName.Text = order.customer_name;
                                txtStaffName.Text = order.user_name;

                                if(order.services == null)
                                {
                                    order.services = this.hotelBLL.getOrderService(orderId);
                                }

                                if(order.totalPrice == null)
                                {
                                    order.totalPrice = this.hotelBLL.getTotalOrderPrice(orderId);
                                }

                                lblTotalPrice.Text = Money.convertMoney(order.totalPrice) + "VND";

                                this.addServiceToListView(order.services);

                                break;
                            }
                        }
                    }
                    //Unclick in cell had order
                    else if (item.SubItem.Tag.ToString().Contains(','))
                    {
                        this.disableCell();

                        this.resetTextBox();
                    }
                    else
                    {
                        this.resetTextBox();

                        //Click in empty cell have empty room
                        if (item.SubItem.Text == "" && this.roomLst[Convert.ToInt32(item.SubItem.Tag.ToString().Split('-')[0])].status == 0)
                        {
                            string month = item.SubItem.Tag.ToString().Split('-')[1].Split('/')[0];
                            string day = item.SubItem.Tag.ToString().Split('-')[1].Split('/')[1];

                            int currentDay = DateTime.DaysInMonth(DateTime.Now.Year, Convert.ToInt32(month));

                            day = Convert.ToInt32(day) > currentDay ? currentDay.ToString() : day;

                            if (DateTime.Parse(month + "/" + day) >= DateTime.Now)
                            {
                                if(this.startCellIdx != 0)
                                {
                                    item.SubItem.Text = "Tick";

                                    int cellIdx = Convert.ToInt32(item.SubItem.Tag.ToString().Split('-')[2]);

                                    int roomIdx = Convert.ToInt32(item.SubItem.Tag.ToString().Split('-')[0]);

                                    if (!this.roomCellSelected.Contains(roomIdx))
                                    {
                                        this.roomCellSelected.Add(roomIdx);
                                    }

                                    if(cellIdx > this.endCellIdx)
                                    {
                                        this.endCellIdx = cellIdx;
                                    }
                                    else if(cellIdx < this.startCellIdx)
                                    {
                                        this.startCellIdx = cellIdx;
                                    }

                                    foreach(int i in this.roomCellSelected)
                                    {
                                        bool check = true;

                                        for (int j = this.startCellIdx; j <= this.endCellIdx; j++)
                                        {
                                            if(lstHotel.Items[i].SubItems[j].BackColor != Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181))))) && check)
                                            {
                                                check = false;
                                            }

                                            lstHotel.Items[i].SubItems[j].Text = check ? "Tick" : "";
                                        }
                                    }
                                }
                                else
                                {
                                    item.SubItem.Text = "Tick";

                                    this.startCellIdx = Convert.ToInt32(item.SubItem.Tag.ToString().Split('-')[2]);

                                    this.endCellIdx = Convert.ToInt32(item.SubItem.Tag.ToString().Split('-')[2]);

                                    this.roomCellSelected.Add(Convert.ToInt32(item.SubItem.Tag.ToString().Split('-')[0]));
                                }

                                this.disableCell();
                            }
                        }
                        //Unclick in empty cell have empty room
                        else if (item.SubItem.Text == "Tick")
                        {
                            this.resetSelectEmptyCell();
                        }
                        //Click in room number cell
                        else if(item.SubItem.Text != "")
                        {
                            txtRoomNumber.Text = item.SubItem.Text;

                            int roomIndex = Convert.ToInt32(item.SubItem.Tag);

                            this.roomSelected = this.roomLst[roomIndex];
                            this.roomSelected.roomIndex = roomIndex;

                            switch (this.roomLst[roomIndex].status)
                            {
                                case 0:
                                    cbbRoomStatus.Text = "None";
                                    break;
                                case 1:
                                    cbbRoomStatus.Text = "Maintaining";
                                    break;
                                case 2:
                                    cbbRoomStatus.Text = "Cleaning";
                                    break;
                            }
                        }
                    }
                }
            }
            else
            {
                this.resetTextBox();

                this.disableCell();
            }
        }

        private void resetSelectEmptyCell()
        {
            foreach (int i in this.roomCellSelected)
            {
                for (int j = this.startCellIdx; j <= this.endCellIdx; j++)
                {
                    lstHotel.Items[i].SubItems[j].Text = "";
                }
            }

            this.roomCellSelected.Clear();

            this.startCellIdx = 0;
            this.endCellIdx = 0;
        }

        private void dtpSystemTime_ValueChanged(object sender, EventArgs e)
        {
            this.initBoard();
        }

        private void cbbRoomStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            int roomId = this.roomSelected.id;

            int status = 0;

            switch (cbbRoomStatus.Text)
            {
                case "Maintaining":
                    status = 1;
                    break;
                case "Cleaning":
                    status = 2;
                    break;
            }

            bool res = this.hotelBLL.changeRoomStatus(roomId, status);

            if(res == true)
            {
                this.roomLst[this.roomSelected.roomIndex].status = status;

                Color backColor = Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));

                switch (status)
                {
                    case 1:
                        backColor = Color.Yellow;
                        break;
                    case 2:
                        backColor = Color.SkyBlue;
                        break;
                }

                lstHotel.Items[this.roomSelected.roomIndex].SubItems[0].BackColor = backColor;
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (this.roomCellSelected.Count > 0)
            {
                string paras = "";
                string id = "";
                int price = 0;

                foreach (int i in this.roomCellSelected)
                {
                    paras += ',' + this.roomLst[i].room_number;
                    id += '+' + this.roomLst[i].id.ToString();
                    price += Convert.ToInt32(this.roomLst[i].price);
                }

                price *= this.endCellIdx - this.startCellIdx + 1;

                id = id.Substring(1);
                paras = id + '-' + paras.Substring(1) + '-';

                paras += lstHotel.Columns[this.startCellIdx].Text + '&' + lstHotel.Columns[this.endCellIdx].Text + '-' + price.ToString();

                handleOpenChildForm?.Invoke(this, new OpenChildForm("create order", paras));
            }
            else
            {
                this.showLog("Empty room selected !", false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.showColorInfo("Empty - The room can book");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.showColorInfo("Active - The room is used");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.showColorInfo("Booking - The room is booked");
        }
       
        private void button8_Click(object sender, EventArgs e)
        {
            this.showColorInfo("Over Time - The room check out late");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.showColorInfo("Late Time - The room check in late");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.showColorInfo("Maintaining - The room is maintained");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.showColorInfo("Cleaning - The room is cleaned");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.showColorInfo("Last Time - The cell of the past");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.showColorInfo("Current Time - The cell of the current time in dataTimePicker");
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            this.showColorInfo("Success Order - The cell of the success order");
        }

        private void cbbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbRoomType.Text == "All")
            {
                this.initBoard();
            }
            else
            {
                this.initBoard(cbbRoomType.Text);
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if(this.currentOrderChoose.Count > 0)
            {
                Order order = this.currentOrderChoose[0];

                if (lstHotel.Items[order.roomInx].SubItems[order.startIndex].BackColor == Color.Violet || lstHotel.Items[order.roomInx].SubItems[order.startIndex].BackColor == Color.Orange)
                {
                    if (Convert.ToInt32(this.checkInTime.Split(':')[0]) - DateTime.Now.Hour == 1 && Convert.ToInt32(this.checkInTime.Split(':')[1]) - DateTime.Now.Minute > -31 || Convert.ToInt32(this.checkInTime.Split(':')[0]) - DateTime.Now.Hour < 1 && DateTime.Parse(order.check_in_date) <= DateTime.Now)
                    {
                        this.hotelBLL.changeOrderStatus(order.id, 3);

                        this.showLog("Check-in success !", true);

                        this.initBoard();
                    }
                    else
                    {
                        this.showLog("It's not time to check-in yet !", false);
                    }
                }
                else
                {
                    this.showLog("Can not check-in !", false);
                }
            }
            else
            {
                this.showLog("Select order to check-in !", false);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(this.currentOrderChoose.Count > 0)
            {
                if (this.currentOrderChoose[0].status == 2)
                {
                    bool check = this.hotelBLL.changeOrderStatus(this.currentOrderChoose[0].id, 4);

                    if (check)
                    {
                        this.showLog("Cancel order success !", true);

                        this.initBoard();
                    }
                    else
                    {
                        this.showLog("Can not cancel order !", false);
                    }
                }
                else
                {
                    this.showLog("Just booking can cancel !", false);
                }
            }
            else
            {
                this.showLog("Select order to cancel !", false);
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (this.currentOrderChoose.Count > 0)
            {
                if (this.currentOrderChoose[0].status == 3)
                {
                    handleOpenChildForm?.Invoke(this, new OpenChildForm("add service", this.currentOrderChoose[0].id));

                    this.showLog("Add service success !", true);
                }
                else
                {
                    this.showLog("Order not active !", false);
                }
            }
            else
            {
                this.showLog("Select order to add service !", false);
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (this.currentOrderChoose.Count > 0)
            {
                if (this.currentOrderChoose[0].status == 3)
                {
                    handleOpenChildForm?.Invoke(this, new OpenChildForm("check out", "", this.currentOrderChoose[0]));
                }
                else
                {
                    this.showLog("Can not check-out !", false);
                }
            }
            else
            {
                this.showLog("Select order to check-out !", false);
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            dtpSystemTime.Value = DateTime.Now;
        }
    }
}
