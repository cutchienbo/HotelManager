using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Service
    {
        public int id {  get; set; }

        public string name { get; set; }

        public int price { get; set; }

        public int status { get; set; }

        public string image {  get; set; }

        public int quantity { get; set; }

        public void addDataToService(DataRow row)
        {
            this.id = Convert.ToInt32(row["id"]);
            this.name = row["name"].ToString();
            this.price = Convert.ToInt32(row["price"]);
            this.status = Convert.ToInt32(row["status"]);
            this.image = row["image"].ToString();
        }

        public Dictionary<string, dynamic> getServiceToDictionary(bool needId) { 
            Dictionary<string, dynamic> dic = new Dictionary<string, dynamic>();

            if(needId == true)
            {
                dic.Add("id", this.id);
            }

            dic.Add("name", this.name);
            dic.Add("price", this.price);
            dic.Add("status", this.status);
            dic.Add("image", this.image);

            return dic;
        }
    }
}
