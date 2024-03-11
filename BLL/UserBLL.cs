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

        public User checkLogin(User user)
        {
            return this.userDAL.checkLogin(user);
        }

        public List<User> getUsers()
        {
            return this.userDAL.getUsers();
        }

        public List<Role> getRoles()
        {
            return this.userDAL.getRoles();
        }
    }
}
