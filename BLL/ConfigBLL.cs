using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ConfigBLL
    {
        ConfigDAL configDAL = new ConfigDAL();

        public Config getConfigInfo()
        {
            return configDAL.getConfigInfo(); 
        }

        public bool editConfigInfo(Config config)
        {
            return configDAL.editConfigInfo(config);
        }
    }
}
