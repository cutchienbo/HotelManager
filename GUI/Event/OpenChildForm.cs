using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Event
{
    public class OpenChildForm : EventArgs
    {
        public OpenChildForm(string action, dynamic paras = null, object ob = null)
        {
            this.action = action;
            this.paras = paras;
            this.ob = ob;
        }

        public string action { get; private set;}

        public dynamic paras { get; private set; }

        public object ob { get; private set; }
    }
}
