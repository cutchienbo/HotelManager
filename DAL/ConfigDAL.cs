﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class ConfigDAL : Database
    {
        Config config = new Config();

        public Config getConfigInfo()
        {
            SqlDataReader res = queryExecuteReader("config_proc");

            if(res != null)
            {
               
                do {
                    this.config.sCheckinTime = res["checkin_time"].ToString();
                    this.config.sCheckoutTime = res["checkout_time"].ToString();

                    return this.config;
                } 
                while (res.Read()) ;

             
            }
            else
            {
                return null;
            }
        }

        public bool editConfigInfo(Config config)
        {
            string[] param = { "checkin_time", "checkout_time" };
            string[] value = {config.sCheckinTime, config.sCheckoutTime};

            try
            {
                SqlDataReader res = queryExecuteReader("edit_config_proc", param, value);

                return true;
            }
            catch
            {
                return false;
            }

            
        }
    }
}
