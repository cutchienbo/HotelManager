using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;
using System.Collections;
using DP;


namespace DAL
{
    public class OrderDAL
    {
        public List<Order> getOrder()
        {
            DataTable res = DB.queryExecuteAdapter("get_order");

            List<Order> orders = new List<Order>();

            foreach (DataRow row in res.Rows)
            {
                Order order = new Order();

                order.addDataToOrder(row);

                orders.Add(order);
            }

            return orders;
        }

        public List<Room> getOrderRoom(int orderId)
        {
            DB.addParam("order_id", orderId);

            DataTable res = DB.queryExecuteAdapter("get_order_room");

            List<Room> rooms = new List<Room>();

            foreach (DataRow row in res.Rows)
            {
                Room room = new Room();

                room.room_number = row["room_number"].ToString();
                room.room_type_name = row["name"].ToString();

                rooms.Add(room);
            }

            return rooms;
        }

        public List<Service> getOrderService(int orderId)
        {
            DB.addParam("order_id", orderId);

            DataTable res = DB.queryExecuteAdapter("get_order_service");

            List<Service> services = new List<Service>();

            foreach (DataRow row in res.Rows)
            {
                Service service = new Service();

                service.name = row["name"].ToString();
                service.price = Convert.ToInt32(row["price"]);

                services.Add(service);
            }

            return services;
        }

        public List<Order> searchOrder(Order order)
        {
            DataTable res = DB.queryExecuteAdapter("search_order", order.getOrderToDictionary());

            List<Order> orders = new List<Order>();

            foreach (DataRow row in res.Rows)
            {
                Order tempOrder = new Order();

                tempOrder.addDataToOrder(row);

                orders.Add(tempOrder);
            }

            return orders;
        }

        public bool deleteOrder(int id, int status)
        {
            DB.addParam("order_id", id);
            DB.addParam("status", status);

            DataTable res = DB.queryExecuteAdapter("delete_order");

            return res.Rows[0][0].ToString() == "1" ? true : false;
        }

        public bool undoOrder(int id)
        {
            DB.addParam("order_id", id);

            DataTable res = DB.queryExecuteAdapter("undo_order");

            if(res.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
