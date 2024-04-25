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
using System.Windows.Documents;
using LIB;

namespace GUI.ChildForms
{
    public partial class FormRoom : Form
    {
        RoomBLL roomBLL = new RoomBLL();
        List<Room> rooms = new List<Room>();
        private int totalRoom = 1;
        public FormRoom()
        {
            InitializeComponent();
        }

        private void addRoomToListView(Room room)
        {
            string statusLog = "";

            switch (room.status)
            {
                case 0:
                    statusLog = "Empty";
                    break;
                case 1:
                    statusLog = "Maintaining";
                    break;
                case 2:
                    statusLog = "Cleaning";
                    break;
            }

            string[] item =
            {
                this.totalRoom.ToString(),
                room.room_type_name,
                room.bed.ToString(),
                statusLog,
                Money.convertMoney(room.price.ToString()),
                room.deleted == 0? "No": "Yes",
                room.room_number,
                room.id.ToString()
            };

            ListViewItem lstItem = new ListViewItem(item);

            lstRoom.Items.Add(lstItem);

            this.totalRoom++;
        }

        private void FormRoom_Load(object sender, EventArgs e)
        {
            this.rooms = this.roomBLL.getRoom();
            List<RoomType> roomTypes = this.roomBLL.getRoomType();

            foreach (Room room in this.rooms)
            {
                this.addRoomToListView(room);
            }

            cbbRoomType.Items.Add("");
            cbbSearchRoomType.Items.Add("");

            for (int i = 0; i < roomTypes.Count; i++)
            {
                cbbRoomType.Items.Add(roomTypes[i].name);
                cbbSearchRoomType.Items.Add(roomTypes[i].name);
            }

            cbbRoomType.SelectedIndex = 0;
        }

        private void classify(object sender, EventArgs e)
        {
            int isDeleted = ckbIsDeleted.Checked == true ? 1 : 0;
            string type = cbbSearchRoomType.Text;
            this.totalRoom = 1;

            lstRoom.Items.Clear();

            foreach (Room room in this.rooms)
            {
                if (room.deleted != isDeleted)
                {
                    if (room.room_type_name == type || type == "")
                    {
                        this.addRoomToListView(room);
                    }
                }
            }
        }

        private void lstRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem lstItem = lstRoom.FocusedItem;

            this.resetErrorLog();

            cbbRoomType.SelectedItem = lstItem.SubItems[1].Text;
            txtBed.Text = lstItem.SubItems[2].Text;
            txtPrice.Text = lstItem.SubItems[4].Text.Replace(".", "");
            chkStatetus.Checked = lstItem.SubItems[5].Text == "Yes" ? true : false;
            txtRoomNumber.Text = lstItem.SubItems[6].Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbbRoomType.SelectedItem = "";
            txtBed.Text = "";
            txtPrice.Text = "";
            chkStatetus.Checked = false;
            txtRoomNumber.Text = "";
        }

        private void resetErrorLog()
        {
            lblBedError.Text = "";
            lblPriceError.Text = "";
            lblRoomTypeError.Text = "";
            lblRoomNumberError.Text = "";
            lblLog.Text = "";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(lstRoom.SelectedItems.Count > 0)
            {
                this.resetErrorLog();

                Room room = new Room();

                ListViewItem item = lstRoom.FocusedItem;

                room.id = Convert.ToInt32(item.SubItems[7].Text);
                room.room_number = txtRoomNumber.Text;
                room.room_type_name = cbbRoomType.Text;
                room.bed = Convert.ToInt32(txtBed.Text);
                room.price = txtPrice.Text;
                room.deleted = chkStatetus.Checked == true ? 1 : 0;

                List<ValidateItem> validateItems = new List<ValidateItem>();

                ValidateItem roomType = new ValidateItem(
                    lblRoomTypeError,
                    cbbRoomType.Text,
                    @"empty",
                    @"Room type can not empty !"
                );

                validateItems.Add(roomType);

                ValidateItem roomNumber = new ValidateItem(
                    lblRoomNumberError,
                    txtRoomNumber.Text,
                    @"empty | pattern:[0-9]+ | existed:room_number-room",
                    @"Room number can not empty ! | Accept number only ! | Room number is existed !"
                );

                validateItems.Add(roomNumber);

                ValidateItem bed = new ValidateItem(
                    lblBedError,
                    txtBed.Text,
                    @"empty | pattern:[1-4]",
                    @"Bed quantity can not empty | Bed quantity is wrong !"
                );

                validateItems.Add(bed);

                ValidateItem price = new ValidateItem(
                    lblPriceError,
                    txtPrice.Text,
                    @"empty | pattern:[0-9.0-9]+",
                    @"Price can not empty | Wrong format !"
                );

                validateItems.Add(price);

                bool check = true;

                foreach (ValidateItem vldItem in validateItems)
                {
                    if (!vldItem.handleValidate())
                    {
                        check = false;

                        break;
                    }
                }

                if(check == true)
                {
                    bool res = this.roomBLL.updateRoom(room);

                    if(res == true)
                    {
                        this.showLog("Update success !", true);

                        lstRoom.FocusedItem.SubItems[1].Text = room.room_type_name;
                        lstRoom.FocusedItem.SubItems[2].Text = room.bed.ToString();
                        lstRoom.FocusedItem.SubItems[4].Text = Money.convertMoney(room.price.ToString());
                        lstRoom.FocusedItem.SubItems[5].Text = room.deleted == 0 ? "No" : "Yes";
                        lstRoom.FocusedItem.SubItems[6].Text = room.room_number;
                    }
                    else
                    {
                        this.showLog("Can not update !", false);
                    }
                }
            }
            else
            {
                this.showLog("Select room to update !", false);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.resetErrorLog();

            Room room = new Room();

            room.room_type_name = cbbRoomType.Text;
            room.room_number = txtRoomNumber.Text;
            room.bed = Convert.ToInt32(txtBed.Text);
            room.price = txtPrice.Text;
            room.deleted = chkStatetus.Checked == true ? 1 : 0;

            List<ValidateItem> validateItems = new List<ValidateItem>();

            ValidateItem roomType = new ValidateItem(
                lblRoomTypeError,
                cbbRoomType.Text,
                @"empty",
                @"Room type can not empty !"
            );

            validateItems.Add(roomType);

            ValidateItem roomNumber = new ValidateItem(
                lblRoomNumberError,
                txtRoomNumber.Text,
                @"empty | pattern:[0-9]+ | existed:room_number-room",
                @"Room number can not empty ! | Accept number only ! | Room number is existed !"
            );

            validateItems.Add(roomNumber);

            ValidateItem bed = new ValidateItem(
                lblBedError,
                txtBed.Text,
                @"empty | pattern:[1-4]",
                @"Bed quantity can not empty | Bed quantity is wrong !"
            );

            validateItems.Add(bed);

            ValidateItem price = new ValidateItem(
                lblPriceError,
                txtPrice.Text,
                @"empty | pattern:[0-9.0-9]+",
                @"Price can not empty | Wrong format !"
            );

            validateItems.Add(price);

            bool check = true;

            foreach (ValidateItem vldItem in validateItems)
            {
                if (!vldItem.handleValidate())
                {
                    check = false;

                    break;
                }
            }

            if (check == true)
            {
                bool res = this.roomBLL.insertRoom(room);

                if (res == true)
                {
                    this.showLog("Insert success !", true);

                    this.addRoomToListView(room);
                }
                else
                {
                    this.showLog("Can not insert !", false);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lstRoom.SelectedItems.Count > 0) {
                int id = Convert.ToInt32(lstRoom.FocusedItem.SubItems[6].Text);

                int res = this.roomBLL.deleteRoom(id);

                string log = "";
                bool logStatus = true;

                switch (res)
                {
                    case 0:
                        log = "Room is not existed !";

                        logStatus = false;

                        break;
                    case 1:
                        log = "Room is affect to system !";

                        logStatus = false;

                        break;
                    case 2:
                        log = "Delete success !";

                        lstRoom.Items.Remove(lstRoom.FocusedItem);

                        break;
                    case 3:
                        log = "Remove success !";

                        lstRoom.FocusedItem.SubItems[5].Text = "Yes";

                        break;
                }

                this.showLog(log, logStatus);
            }
            else
            {
                this.showLog("Select room to delete !", false);
            }
        }
    }
}
