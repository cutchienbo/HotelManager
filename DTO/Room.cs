using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Room
    {
        public int id { get; set; }

        public string room_type_name { get; set; }

        public string room_number { get; set; }

        public int bed { get; set;}

        public int price { get; set; }

        public int status { get; set; }

        public int deleted { get; set; }

        public List<Order> orders { get; set; }

        public int roomIndex { get; set; }

        public Dictionary<string, dynamic> getRoomToDictionary(bool needId)
        {
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();

            if(needId == true)
            {
                data.Add("id", this.id);
            }

            data.Add("room_number", this.room_number);
            data.Add("room_type_name", this.room_type_name);
            data.Add("bed", this.bed);
            data.Add("price", this.price);
            data.Add("deleted", this.deleted);

            return data;
        }

        public void addDataToRoom(DataRow data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.room_number = data["room_number"].ToString();
            this.room_type_name = data["name"].ToString();
            this.bed = Convert.ToInt32(data["bed"]);
            this.price = Convert.ToInt32(data["price"]);
            this.status = Convert.ToInt32(data["status"]);
            this.deleted = Convert.ToInt32(data["deleted"]);
        }
    }
}
