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
    public class RoomBLL
    {
        RoomDAL roomDAL = new RoomDAL();

        public List<Room> getRoom() { 
            return this.roomDAL.getRoom();
        }

        public List<RoomType> getRoomType()
        {
            return this.roomDAL.getRoomType();
        }

        public bool updateRoom(Room room)
        {
            return this.roomDAL.updateRoom(room);
        }

        public bool insertRoom(Room room)
        {
            return this.roomDAL.insertRoom(room);
        }

        public int deleteRoom(int id)
        {
            return this.roomDAL.deleteRoom(id);
        }
    }
}
