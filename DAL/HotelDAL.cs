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
    public class HotelDAL
    {
        public List<Room> getRoomOrder(string startDate, string endDate)
        {
            List<Room> rooms = new List<Room>();

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
    }
}
