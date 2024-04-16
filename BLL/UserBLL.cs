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

        public User insertUser(User user)
        {
            return this.userDAL.insertUser(user);
        }

        public List<User> searchUser(string field, string searchValue, bool isActive)
        {
            return this.userDAL.searchUser(field, searchValue, isActive);
        }

        public int deleteUser(string id)
        {
            return this.userDAL.deleteUser(id);
        }

        public bool updateUser(User user)
        {
            return this.userDAL.updateUser(user);
        }

        public List<User> getCustomer()
        {
            return this.userDAL.getCustomer();
        }

        public List<User> searchCustomer(User user)
        {
            return this.userDAL.searchCustomer(user);
        }

        public bool changeCustomerState(string idCode, int state)
        {
            return this.userDAL.changeCustomerState(idCode, state);
        }
    }
}
