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

namespace GUI.ChildForms
{
    public partial class FormHotel : Form
    {
        private HotelBLL hotelBLL = new HotelBLL();
        private List<Room> roomLst;
        private List<Order> currentOrderChoose = new List<Order>();
        private List<ListViewHitTestInfo> currentTickCell = new List<ListViewHitTestInfo>();
        private Room roomSelected;

        public FormHotel()
        {
            InitializeComponent();
        }

        private void initBoard()
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

            this.roomLst = this.hotelBLL.getRoomOrder(startDate, endDate);

            int roomIndex = 0;

            foreach (Room room in this.roomLst)
            {
                string[] value = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
                ListViewItem item = new ListViewItem(value);

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
                        DateTime checkinTime = DateTime.Parse(order.check_in_date);
                        DateTime checkoutTime = DateTime.Parse(order.check_out_date);

                        int duration = checkoutTime.Subtract(checkinTime).Days;

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

                        order.startIndex = checkinTimeIndex;
                        order.endIndex = checkinTimeIndex + duration;
                        order.roomInx = roomIndex;

                        Color logColor = Color.White;

                        switch (order.status)
                        {
                            case 2:
                                logColor = Color.Violet;
                                break;
                            case 3:
                                logColor = Color.Green;
                                break;
                            default:
                                if (checkoutTime.Subtract(DateTime.Now).Hours < 0)
                                {
                                    logColor = Color.Red;
                                }
                                else if (checkinTime.Subtract(DateTime.Now).Hours < 0)
                                {
                                    logColor = Color.Orange;
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
           this.initBoard();
        }

        private void createDefaultCell()
        {
            for (int i = 0; i < this.roomLst.Count; i++)
            {
                for (int j = 1; j < 16; j++)
                {
                    if (lstHotel.Items[i].SubItems[j].Tag == null)
                    {
                        if (j < 7)
                        {
                            lstHotel.Items[i].SubItems[j].BackColor = Color.Violet;
                        }
                        else if(j == 7)
                        {
                            lstHotel.Items[i].SubItems[j].BackColor = Color.Brown;
                            lstHotel.Items[i].SubItems[j].Tag = i.ToString();
                        }
                        else
                        {
                            lstHotel.Items[i].SubItems[j].Tag = i.ToString() + "-" + j.ToString();
                        }
                    }
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

        private void lstHotel_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo item = lstHotel.HitTest(e.X, e.Y);

            if (item.SubItem != null)
            {
                //Check is click in to a cell have tag => cell have colored
                if (item.SubItem.Tag != null)
                {
                    //Check clicked into a cell =>
                        //clicked: unclick,
                        //no click: unclick a group of cell have been in the same order,
                                    //active cell have been together in order,
                                    //unlick a choosed cell not in order.

                    //Click in cell had order
                    if (item.SubItem.Text == "" && item.SubItem.Tag.ToString().Contains(','))
                    {
                        this.disableCell();

                        this.activeCell(item);

                        if (this.currentTickCell != null)
                        {
                            foreach (ListViewHitTestInfo hitItem in this.currentTickCell)
                            {
                                hitItem.SubItem.Text = "";
                            }

                            this.currentTickCell.Clear();
                        }
                    }
                    //Unclick in cell had order
                    else if (item.SubItem.Tag.ToString().Contains(','))
                    {
                        this.disableCell();
                    }
                    else
                    {
                        //Click in empty cell have empty room
                        if (item.SubItem.Text == "" && this.roomLst[Convert.ToInt32(item.SubItem.Tag.ToString().Split('-')[0])].status == 0)
                        {
                            item.SubItem.Text = "Tick";

                            this.currentTickCell.Add(item);

                            this.disableCell();
                        }
                        //Unclick in empty cell have empty room
                        else if (item.SubItem.Text == "Tick")
                        {
                            item.SubItem.Text = "";
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
                this.disableCell();
            }
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
    }
}
