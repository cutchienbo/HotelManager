using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using LIB;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ConfigDAL
    {
        Config config = new Config();

        public Config getConfigInfo()
        {
            DataTable res = DB.queryExecuteAdapter("config_proc");

            if(res != null)
            {
               foreach(DataRow row in res.Rows)
               {
                    this.config.sCheckinTime = row["checkin_time"].ToString();
                    this.config.sCheckoutTime = row["checkout_time"].ToString();
               }

                return this.config;
            }
            else
            {
                return null;
            }
        }

        public bool editConfigInfo(Config config)
        {
            DB.addParam("checkin_time", config.sCheckinTime);
            DB.addParam("checkout_time", config.sCheckoutTime);

            try
            {
                DataTable res = DB.queryExecuteAdapter("edit_config_proc");

                return true;
            }
            catch
            {
                return false;
            }

            
        }
    }
}
