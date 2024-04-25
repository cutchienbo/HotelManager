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
    public class RoomDAL
    {
        public List<Room> getRoom()
        {
            List<Room> rooms = new List<Room>();

            DataTable res = DB.queryExecuteAdapter("get_room");

            foreach (DataRow row in res.Rows)
            {
                Room room = new Room();

                room.addDataToRoom(row);

                rooms.Add(room);
            }

            return rooms;
        }

        public List<RoomType> getRoomType()
        {
            List<RoomType> roomTypes = new List<RoomType>();

            DataTable res = DB.queryExecuteAdapter("get_room_type");

            foreach (DataRow row in res.Rows)
            {
                RoomType roomType = new RoomType();

                roomType.id = Convert.ToInt32(row["id"]);
                roomType.name = row["name"].ToString();

                roomTypes.Add(roomType);
            }

            return roomTypes;
        }

        public bool updateRoom(Room room)
        {
            DataTable res = DB.queryExecuteAdapter("update_room", room.getRoomToDictionary(true));

            if(res.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        public bool insertRoom(Room room)
        {
            DataTable res = DB.queryExecuteAdapter("insert_room", room.getRoomToDictionary(false));

            if (res.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        public int deleteRoom(int id)
        {
            DB.addParam("room_id", id);

            DataTable res = DB.queryExecuteAdapter("delete_room");

            return Convert.ToInt32(res.Rows[0][0]);
        }
    }
}
