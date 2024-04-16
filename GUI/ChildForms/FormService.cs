using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows;
using BLL;
using System.Windows.Media.TextFormatting;
using System.IO;
using System.Windows.Documents;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI.ChildForms
{
    public partial class FormService : Form
    {
        private ServiceBLL serviceBLL = new ServiceBLL();
        private List<Service> services = new List<Service>();
        private ImageList imgList = new ImageList();
        private string newImage = "";
        private int newImgInx = 0;
        private string path;

        public FormService()
        {
            InitializeComponent();
        }

        private string getPath()
        {
            string path = System.Windows.Forms.Application.StartupPath;

            path = path.Substring(0, path.LastIndexOf('\\'));
            path = path.Substring(0, path.LastIndexOf('\\'));

            return path + "\\Resources\\Services\\";
        }

        private void FormService_Load(object sender, EventArgs e)
        {
            this.path = this.getPath();

            this.imgList.ImageSize = new System.Drawing.Size(80, 80);

            lstService.SmallImageList = this.imgList;

            this.imgList.Images.Add(System.Drawing.Image.FromFile(this.path + "empty.jpg"), Color.Transparent);

            this.services = this.serviceBLL.getService();

            foreach (Service service in services)
            {
                this.addServiceToListView(service);
            }

            this.reset();
        }

        private void addServiceToListView(Service service, bool haveImage = false)
        {
            string[] item =
            {
                "",
                service.name,
                service.price.ToString(),
                service.status == 0 ? "Disable" : "Active",
                service.id.ToString(),
                service.image
            };

            System.Windows.Forms.ListViewItem lstItem = new System.Windows.Forms.ListViewItem(item);

            if (!haveImage)
            {
                lstItem.ImageIndex = this.imgList.Images.Add(System.Drawing.Image.FromFile(this.path + service.image), Color.Transparent);

                lstItem.SubItems[0].Text = lstItem.ImageIndex.ToString();
            }
            else
            {
                lstItem.ImageIndex = this.newImgInx;

                lstItem.SubItems[0].Text = this.newImgInx.ToString();
            }

            lstService.Items.Add(lstItem);
        }

        private void lstService_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.resetErrorLog(); 

            System.Windows.Forms.ListViewItem item = lstService.FocusedItem;

            ptbServiceImage.Image = this.imgList.Images[Convert.ToInt32(item.SubItems[0].Text)];

            txtServiceName.Text = item.SubItems[1].Text;
            txtServicePrice.Text = item.SubItems[2].Text;
            chkStatetus.Checked = item.SubItems[3].Text == "Active" ? true : false;
        }

        private void resetErrorLog()
        {
            lblPriceError.Text = "";
            lblServiceName.Text = "";
            lblImageError.Text = "";
            chkStatetus.Checked = false;
            lblLog.Text = "";
        }

        private void reset()
        {
            txtServicePrice.Text = "";
            txtServiceName.Text = "";
            ptbServiceImage.Image = this.imgList.Images[0];
            this.newImage = "";
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
            if (!this.validate())
            {
                return;
            }

            if (lstService.SelectedItems.Count > 0)
            {
                Service service = new Service();

                string imgName = this.newImage.Substring(this.newImage.LastIndexOf('\\') + 1);

                System.Windows.Forms.ListViewItem item = lstService.FocusedItem;

                service.id = Convert.ToInt32(item.SubItems[4].Text);
                service.name = txtServiceName.Text;
                service.price = Convert.ToInt32(txtServicePrice.Text);
                service.status = chkStatetus.Checked == true ? 1 : 0;
                
                if(this.newImage != "")
                {
                    service.image = imgName;
                }
                else
                {
                    service.image = item.SubItems[5].Text;
                }

                bool res = this.serviceBLL.updateService(service);

                if(res == true)
                {
                    this.showLog("Update success !", true);

                    if(this.newImage != "")
                    {
                        if (!File.Exists(this.path + imgName))
                        {
                            File.Copy(this.newImage, this.path + imgName);
                        }

                        item.SubItems[5].Text = imgName;
                        item.ImageIndex = this.newImgInx;
                        item.SubItems[0].Text = this.newImgInx.ToString();
                    }
                    else
                    {
                        item.SubItems[5].Text = service.image;
                    }

                    item.SubItems[1].Text = service.name;
                    item.SubItems[2].Text = service.price.ToString();
                    item.SubItems[3].Text = service.status == 1? "Active" : "Disable";
                }
                else
                {
                    this.showLog("Can not update !", false);
                }
            }
        }

        private void ptbServiceImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Multiselect = false;

            openFileDialog.ShowDialog();

            //openFileDialog.Filter = "*.pgn|*.jpg|*.jpeg";

            this.newImage = openFileDialog.FileName;

            this.newImgInx = this.imgList.Images.Add(System.Drawing.Image.FromFile(this.newImage), Color.Transparent);

            ptbServiceImage.Image = this.imgList.Images[this.newImgInx];
        }
      

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.reset();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!this.validate())
            {
                return;
            }

            Service service = new Service();

            string imgName = this.newImage.Substring(this.newImage.LastIndexOf('\\') + 1);

            service.name = txtServiceName.Text;
            service.price = Convert.ToInt32(txtServicePrice.Text);
            service.status = chkStatetus.Checked == true ? 1 : 0;
            service.image = imgName;

            int res = this.serviceBLL.insertService(service);

            if (res != -1)
            {
                this.showLog("Insert success !", true);

                if (!File.Exists(this.path + imgName))
                {
                    File.Copy(this.newImage, this.path + imgName);
                }

                System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem();

                service.id = res;

                this.addServiceToListView(service, true);
            }
            else
            {
                this.showLog("Can not insert !", false);
            }
        }

        private bool validate()
        {
            List<ValidateItem> validateItems = new List<ValidateItem>();

            ValidateItem name = new ValidateItem(
              lblNameError,
              txtServiceName.Text,
              @"empty",
              @"Name can not null !"
            );

            validateItems.Add(name);

            ValidateItem price = new ValidateItem(
             lblPriceError,
             txtServicePrice.Text,
             @"empty | pattern:[0-9]+",
             @"Price can not null ! | Wrong format !"
            );

            validateItems.Add(price);

            bool check = true;

            foreach (ValidateItem item in validateItems)
            {
                if (!item.handleValidate())
                {
                    check = false;

                    break;
                }
            }

            if(check == true)
            {
                if (ptbServiceImage.Image == null)
                {
                    lblImageError.Text = "Choose image !";
                    return false;
                }

                return true;
            }

            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lstService.SelectedItems.Count > 0)
            {
                System.Windows.Forms.ListViewItem item = lstService.FocusedItem;

                int id = Convert.ToInt32(item.SubItems[4].Text);
                bool res = this.serviceBLL.deleteService(id);

                if (res == true)
                {
                    this.showLog("Delete success !", true);

                    this.imgList.Images.RemoveAt(Convert.ToInt32(item.SubItems[0].Text));

                    File.Delete(this.path + lstService.FocusedItem.SubItems[5].Text);

                    lstService.Items.Remove(item);
                }
                else
                {
                    this.showLog("Service can affect the system !", false);
                }
            }
            else
            {
                this.showLog("Select service to delete !", false);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearchName.Text;
            int searchPrice = Convert.ToInt32(txtSearchPrice.Text == "" ? "0" : txtSearchPrice.Text);
            int searchStatus = ckbSearchStatus.Checked == true ? 1 : 0;

            this.services = this.serviceBLL.searchService(searchName, searchPrice, searchStatus);

            lstService.Items.Clear();

            foreach ( Service service in this.services )
            {
                this.addServiceToListView(service);
            }
        }

        private void txtSearchPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
