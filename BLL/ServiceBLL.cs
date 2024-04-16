using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;
using System.Collections;
using DAL;

namespace BLL
{
    public class ServiceBLL
    {
        ServiceDAL serviceDAL = new ServiceDAL();

        public List<Service> getService()
        {
            return this.serviceDAL.getService();
        }

        public bool updateService(Service service)
        {
            return this.serviceDAL.updateService(service);
        }

        public int insertService(Service service)
        {
            return this.serviceDAL.insertService(service);
        }

        public bool deleteService(int id)
        {
            return this.serviceDAL.deleteService(id);
        }

        public List<Service> searchService(string name, int price, int status)
        {
            return this.serviceDAL.searchService(name, price, status);
        }
    }
}
