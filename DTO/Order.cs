using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Order
    {
        public int id {  get; set; }

        public string user_name { get; set; }

        public string customer_name { get; set; }

        public int user_id { get; set; }

        public int customer_id { get; set; }

        public string check_in_date { get; set; }

        public string check_out_date { get; set; }

        public int status { get; set; }

        public int price { get; set; }

        public List<Room> rooms { get; set; }

        public List<Service> services { get; set; }

        public List<User> users { get; set; }

        public int startIndex { get; set; }

        public int endIndex { get; set; }

        public int roomInx { get; set; }

        public string totalPrice { get; set; }

        public void addDataToOrder(DataRow row)
        {
            this.id = Convert.ToInt32(row["id"]);
            this.user_name = row["user_name"].ToString();
            this.customer_name = row["customer_name"].ToString();
            this.check_in_date = row["checkin"].ToString();
            this.check_out_date = row["checkout"].ToString();
            this.status = Convert.ToInt32(row["status"]);
            this.price = Convert.ToInt32(row["price"]);
        }

        public Dictionary<string, dynamic> getOrderToDictionary(bool check = true)
        {
            Dictionary<string, dynamic> dic = new Dictionary<string, dynamic>();

            if(check)
            {
                dic.Add("customer_name", this.customer_name);
                dic.Add("staff_name", this.user_name);
                dic.Add("status", this.status);
            }
            else
            {
                dic.Add("user_id", this.user_id);
                dic.Add("customer_id", this.customer_id);
            }

            dic.Add("price", this.price);
            dic.Add("check_in_date", this.check_in_date);
            dic.Add("check_out_date", this.check_out_date);

            return dic;
        }
    }
}
