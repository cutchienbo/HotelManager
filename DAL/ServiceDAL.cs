using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;
using System.Collections;
using LIB;

namespace DAL
{
    public class ServiceDAL
    {

        public List<Service> getService()
        {
            DataTable res = DB.queryExecuteAdapter("get_service");

            List<Service> services = new List<Service>();

            foreach(DataRow row in res.Rows)
            {
                Service service = new Service();

                service.addDataToService(row);

                services.Add(service);
            }

            return services;
        }

        public bool updateService(Service service)
        {
            DataTable res = DB.queryExecuteAdapter("update_service", service.getServiceToDictionary(true));

            if(res.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        public int insertService(Service service)
        {
            DataTable res = DB.queryExecuteAdapter("insert_service", service.getServiceToDictionary(false));

            if (res.Rows.Count > 0)
            {
                return Convert.ToInt32(res.Rows[0][0]);
            }

            return -1;
        }

        public bool deleteService(int id)
        {
            DB.addParam("id", id);

            DataTable res = DB.queryExecuteAdapter("delete_service");

            if (Convert.ToInt32(res.Rows[0][0]) == 1)
            {
                return false;
            }

            return true;
        }

        public List<Service> searchService(string name, int price, int status)
        {
            DB.addParam("name", name);
            
            if(price != 0)
            {
                DB.addParam("price", price);
            }

            DB.addParam("status", status);

            DataTable res = DB.queryExecuteAdapter("search_service");

            List<Service> services = new List<Service>();

            foreach (DataRow row in res.Rows)
            {
                Service service = new Service();

                service.addDataToService(row);

                services.Add(service);
            }

            return services;
        }
    }
}
