using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class HotelBLL
    {
        private HotelDAL hotelDAL = new HotelDAL();

        public List<Room> getRoomOrder(string startDate, string endDate)
        {
            return this.hotelDAL.getRoomOrder(startDate, endDate);
        }

        public bool changeRoomStatus(int roomId, int status)
        {
            return this.hotelDAL.changeRoomStatus(roomId, status);
        }
    }
}
