using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class UserDAL : Database
    {
        User user = new User();

        public string checkLogin(User user)
        {
            string[] param = {"id_code", "password"};
            string[] value = {user.sIdCode, user.sPassword};
            

            SqlDataReader res = queryExecuteReader("login_proc", param, value);
            
            if(res != null)
            {
                // Chuyển array các quyền thành 1 string, ghép tên của user lên đầu 
                // và cách chuỗi các quyền = 1 dấu "-", các quyền cách nhau 1 dấu phẩy.
                // Ví dụ: Trung Kien-hotel,user,customer.

                string resStr = "";
                resStr = res["full_name"].ToString() + "-";

                do
                {
                    resStr += res["code"].ToString() + ",";
                }
                while (res.Read());
                

                return resStr;
            }
            else
            {
                return "id code or password wrong";
            }
        }
    }
}
