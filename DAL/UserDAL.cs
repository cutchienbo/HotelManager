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
        public User checkLogin(User user)
        {
            List<Permission> permissions = new List<Permission>();
            List<User> users = new List<User>();

            string[] param = {"id_code", "password"};
            string[] value = {user.sIdCode, user.sPassword};


            SqlDataReader res = queryExecuteReader("login_proc", param, value);
            
            if(res != null)
            {
                // Chuyển array các quyền thành 1 string, ghép tên của user lên đầu 
                // và cách chuỗi các quyền = 1 dấu "-", các quyền cách nhau 1 dấu phẩy.
                // Ví dụ: Trung Kien-hotel,user,customer.

                user.sId = (int)res["id"];
                user.sFullName = res["full_name"].ToString();

                do
                {
                    Permission permission = new Permission();

                    permission.sCode = res["code"].ToString();

                    permissions.Add(permission);
                }
                while (res.Read());

                user.sPermission = permissions;

                return user;
            }
            else
            {
                return null;
            }
        }

        public List<User> getUsers()
        {
            List<User> users = new List<User>();

            SqlDataReader res = queryExecuteReader("user_proc");

            if(res != null)
            {
                do
                {
                    User user = new User();

                    user.sId = (int)res["id"];
                    user.sRoleId = (int)res["role_id"];
                    user.sRoleName = res["name"].ToString();
                    user.sFullName = res["full_name"].ToString();
                    user.sIdCode = res["id_code"].ToString();
                    user.sPhoneNumber = res["phone_number"].ToString();
                    user.sEmail = res["email"].ToString();
                    user.sAddress = res["address"].ToString();
                    user.sPassword = res["password"].ToString();
                    user.sStatetus = (int)res["statetus"];

                    users.Add(user);
                }
                while(res.Read());

                return users;
            }
            else
            {
                return null;
            }
        }

        public List<Role>  getRoles()
        {
            List<Role>  roles = new List<Role>();

            SqlDataReader res = queryExecuteReader("select_full_role_proc");

            if (res != null)
            {
                do
                {
                    Role role = new Role();

                    role.sName = (string)res["name"];

                    roles.Add(role);
                }
                while (res.Read());

                return roles;
            }
            else
            {
                return null;
            }
        }
    }
}
