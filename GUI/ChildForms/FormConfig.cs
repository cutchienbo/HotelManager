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

namespace GUI.ChildForms
{
    public partial class FormConfig : Form
    {
        ConfigBLL configBLL = new ConfigBLL();
        Config config = new Config();

        public FormConfig()
        {
            InitializeComponent();
            showConfigInfo();
        }

        public void showConfigInfo()
        {
            this.config = configBLL.getConfigInfo();

            this.formatConfigInfo(this.config);

            lblCheckinTimeValue.Text = config.sCheckinTime;
            lblCheckoutTimeValue.Text = config.sCheckoutTime;

            string[] checkinTime = config.sCheckinTime.Split(':');
            string[] checkoutTime = config.sCheckoutTime.Split(':');

            numCheckinHour.Value = Decimal.Parse(checkinTime[0]);
            numCheckinMinute.Value = Decimal.Parse(checkinTime[1]);
            numCheckoutHour.Value = Decimal.Parse(checkoutTime[0]);
            numCheckoutMinute.Value = Decimal.Parse(checkoutTime[1]);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.config.sCheckinTime = numCheckinHour.Value + ":" + numCheckinMinute.Value; ;
            this.config.sCheckoutTime = numCheckoutHour.Value + ":" + numCheckoutMinute.Value;

            bool res = this.configBLL.editConfigInfo(config);

            if(res)
            {
                this.formatConfigInfo(this.config);

                lblCheckinTimeValue.Text = this.config.sCheckinTime;
                lblCheckoutTimeValue.Text = this.config.sCheckoutTime;
            }
        }

        private Config formatConfigInfo(Config config)
        {
            string[] checkinTime = config.sCheckinTime.Split(':');
            string[] checkoutTime = config.sCheckoutTime.Split(':');

            if (checkinTime[0].Length == 1)
            {
                checkinTime[0] = "0" + checkinTime[0];
            }

            if (checkinTime[1].Length == 1)
            {
                checkinTime[1] = "0" + checkinTime[1];
            }

            if (checkoutTime[0].Length == 1)
            {
                checkoutTime[0] = "0" + checkoutTime[0];
            }

            if (checkoutTime[1].Length == 1)
            {
                checkoutTime[1] = "0" + checkoutTime[1];
            }

            config.sCheckinTime = checkinTime[0] + " : " + checkinTime[1];
            config.sCheckoutTime = checkoutTime[0] + " : " + checkoutTime[1];

            return config;
        }
    }
}
