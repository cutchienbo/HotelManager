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

            lblCheckinTimeValue.Text = config.sCheckinTime.Substring(0, 5);
            lblCheckoutTimeValue.Text = config.sCheckoutTime.Substring(0, 5);
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
