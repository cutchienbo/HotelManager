using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class OrderBLL
    {
        private OrderDAL orderDAL = new OrderDAL();

        public List<Order> getOrder()
        {
            return this.orderDAL.getOrder();    
        }

        public List<Room> getOrderRoom(int orderId)
        {
            return this.orderDAL.getOrderRoom(orderId);
        }

        public List<Service> getOrderService(int orderId)
        {
            return this.orderDAL.getOrderService(orderId);
        }

        public List<Order> searchOrder(Order order)
        {
            return this.orderDAL.searchOrder(order);
        }

        public bool deleteOrder(int id, int status)
        {
            return this.orderDAL.deleteOrder(id, status);
        }

        public bool undoOrder(int id)
        {
            return this.orderDAL.undoOrder(id);
        }
    }
}
