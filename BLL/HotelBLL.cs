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

        public List<Room> getRoomOrder(string startDate, string endDate, string roomTypeName = "")
        {
            return this.hotelDAL.getRoomOrder(startDate, endDate, roomTypeName);
        }

        public List<RoomType> getRoomType()
        {
            return this.hotelDAL.getRoomType();
        }

        public string[] getTimeConfig()
        {
            return this.hotelDAL.getTimeConfig();
        }

        public bool changeRoomStatus(int roomId, int status)
        {
            return this.hotelDAL.changeRoomStatus(roomId, status);
        }

        public List<Service> getOrderService(int orderId)
        {
            return this.hotelDAL.getOrderService(orderId);
        }

        public User getCustomerByIdCode(string idCode)
        {
            return this.hotelDAL.getCustomerByIdCode(idCode);
        }

        public int insertCustomer(User customer)
        {
            return this.hotelDAL.insertCustomer(customer);
        }

        public int insertOrder(Order order)
        {
            return this.hotelDAL.insertOrder(order);
        }

        public bool insertOrderRoom(int orderId, int roomId)
        {
            return this.hotelDAL.insertOrderRoom(orderId, roomId);
        }

        public bool changeOrderStatus(int orderId, int status)
        {
            return this.hotelDAL.changeOrderStatus(orderId, status);
        }

        public string getTotalOrderPrice(int orderId)
        {
            return this.hotelDAL.getTotalOrderPrice(orderId);   
        }

        public List<Service> getService()
        {
            return this.hotelDAL.getService();
        }

        public bool insertOrderService(int orderId, int serviceId, int quantity)
        {
            return this.hotelDAL.insertOrderService(orderId, serviceId, quantity);
        }

        public List<Room> getRoomByOrderId(int orderId)
        {
            return this.hotelDAL.getRoomByOrderId(orderId);
        }

        public List<User> getOrderUser(int orderId)
        {
            return this.hotelDAL.getOrderUser(orderId);
        }

        public List<Room> getOrderRoom(int orderId)
        {
            return this.hotelDAL.getOrderRoom(orderId);
        }

        public int insertOrderUser(int orderId, string roomNumber, int userId)
        {
            return this.hotelDAL.insertOrderUser(orderId, roomNumber, userId);
        }
    }
}
