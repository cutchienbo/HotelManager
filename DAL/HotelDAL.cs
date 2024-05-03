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
    public class HotelDAL
    {
        public List<Room> getRoomOrder(string startDate, string endDate, string roomTypeName = "")
        {
            List<Room> rooms = new List<Room>();

            DB.addParam("room_type_name", roomTypeName);

            DataTable res = DB.queryExecuteAdapter("get_room");

            foreach (DataRow row in res.Rows) 
            {
                DB.addParam("room_id", row["id"]);
                DB.addParam("start_date", startDate);
                DB.addParam("end_date", endDate);

                DataTable res2 = DB.queryExecuteAdapter("get_order_in_range_date");

                Room room = new Room();

                room.addDataToRoom(row);

                List<Order> orders = new List<Order>();

                foreach (DataRow row2 in res2.Rows)
                {
                    Order order = new Order();

                    order.addDataToOrder(row2);

                    orders.Add(order);
                }

                room.orders = orders;

                rooms.Add(room);
            }

            return rooms;
        }

        public List<RoomType> getRoomType()
        {
            DataTable res = DB.queryExecuteAdapter("get_room_type");

            List<RoomType> roomTypes = new List<RoomType>();

            foreach(DataRow row in res.Rows)
            {
                RoomType roomType = new RoomType();

                roomType.name = row["name"].ToString();

                roomTypes.Add(roomType);    
            }

            return roomTypes;
        }

        public string[] getTimeConfig()
        {
            DataTable res = DB.queryExecuteAdapter("config_proc");

            string[] data = { res.Rows[0]["checkin_time"].ToString(), res.Rows[0]["checkout_time"].ToString() };

            return data;
        }

        public bool changeRoomStatus(int roomId, int status)
        {
            DB.addParam("room_id", roomId);
            DB.addParam("status", status);  

            DataTable res = DB.queryExecuteAdapter("change_room_status");

            if(res.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        public List<Service> getOrderService(int orderId)
        {
            DB.addParam("order_id", orderId);

            DataTable res = DB.queryExecuteAdapter("get_order_service");

            List<Service> services = new List<Service>();

            foreach(DataRow row in res.Rows)
            {
                Service service = new Service();

                service.name = row["name"].ToString();
                service.price = Convert.ToInt32(row["price"]);
                service.quantity = Convert.ToInt32(row["quantity"]);

                services.Add(service);
            }

            return services;
        }

        public User getCustomerByIdCode(string idCode)
        {
            DB.addParam("id_code", idCode);

            DataTable res = DB.queryExecuteAdapter("get_customer_by_id_code");

            User customer = new User();

            if(res.Rows.Count > 0)
            {
                customer.addDataToCustomer(res.Rows[0]);

                return customer;
            }

            return null;
        }

        public int insertCustomer(User customer)
        {
            DataTable res = DB.queryExecuteAdapter("insert_customer", customer.getCustomerToDictionary());

            return Convert.ToInt32(res.Rows[0][0]);
        }

        public int insertOrder(Order order)
        {
            DataTable res = DB.queryExecuteAdapter("insert_order", order.getOrderToDictionary(false));

            return Convert.ToInt32(res.Rows[0][0]);
        }

        public bool insertOrderRoom(int orderId, int roomId)
        {
            DB.addParam("order_id", orderId);
            DB.addParam("room_id", roomId);

            DataTable res = DB.queryExecuteAdapter("insert_order_room");

            if(res.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        public bool changeOrderStatus(int orderId, int status)
        {
            DB.addParam("order_id", orderId);
            DB.addParam("status", status);

            DataTable res = DB.queryExecuteAdapter("change_order_status");

            if (res.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        public string getTotalOrderPrice(int orderId)
        {
            DB.addParam("order_id", orderId);

            DataTable res = DB.queryExecuteAdapter("get_order_price");

            return res.Rows[0]["total_price"].ToString();
        }

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

        public bool insertOrderService(int orderId, int serviceId, int quantity)
        {
            DB.addParam("order_id", orderId);
            DB.addParam("service_id", serviceId);
            DB.addParam("quantity", quantity);

            DataTable res = DB.queryExecuteAdapter("insert_order_service");

            if(res.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        public List<Room> getRoomByOrderId(int orderId)
        {
            DB.addParam("order_id", orderId);

            DataTable res = DB.queryExecuteAdapter("get_room_by_order_id");

            List<Room> rooms = new List<Room>();

            foreach(DataRow row in res.Rows)
            {
                Room room = new Room();

                room.addDataToRoom(row);

                rooms.Add(room);
            }

            return rooms;
        }

        public List<User> getOrderUser(int orderId)
        {
            DB.addParam("order_id", orderId);

            DataTable res = DB.queryExecuteAdapter("get_total_order_user");

            List<User> users = new List<User>();

            foreach(DataRow row in res.Rows)
            {
                User user = new User();

                user.addDataToCustomer(row);

                Room room = new Room();

                room.room_number = row["room_number"].ToString();

                user.room = room;

                users.Add(user);
            }

            return users;
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
                room.id = Convert.ToInt32(row["id"]);

                rooms.Add(room);
            }

            return rooms;
        }

        public int insertOrderUser(int orderId, string roomNumber, int userId)
        {
            DB.addParam("order_id", orderId);
            DB.addParam("room_number", roomNumber);
            DB.addParam("user_id", userId);

            DataTable res = DB.queryExecuteAdapter("insert_order_user");

            if(res.Rows.Count > 0)
            {
                return Convert.ToInt32(res.Rows[0][0]);
            }

            return -1;
        }
    }
}
