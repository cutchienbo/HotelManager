using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;


namespace BLL
{
    public class UserBLL
    {
        UserDAL userDAL = new UserDAL();

        public string checkLogin(User user)
        {
            if(user.sIdCode == "")
            {
                return "required_id_code";
            }

            if(user.sPassword == "")
            {
                return "required_password";
            }
            
            string info = userDAL.checkLogin(user);

           

            return info;
        }
    }
}
