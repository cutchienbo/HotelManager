using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Config
    {
        private string checkin_time;
        private string checkout_time;

        public string sCheckinTime
        {
            get
            {
                return this.checkin_time;
            }
            set
            {
                this.checkin_time = value;
            }
        }

        public string sCheckoutTime
        {
            get
            {
                return this.checkout_time;
            }
            set
            {
                this.checkout_time = value;
            }
        }

        public Config()
        {
            this.checkin_time = "00:00";
            this.checkout_time = "00:00";
        }

        public Config(string _checkin_time, string _checkout_time)
        {
            this.checkin_time = _checkin_time;
            this.checkout_time = _checkout_time;
        }
    }
}
