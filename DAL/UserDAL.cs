using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;
using System.Collections;
using LIB;

namespace DAL
{
    public class UserDAL
    {
        public User checkLogin(User user)
        {
            List<Permission> permissions = new List<Permission>();
            List<User> users = new List<User>();

            DB.addParam("id_code", user.sIdCode);
            DB.addParam("password", user.sPassword);


            DataTable res = DB.queryExecuteAdapter("login_proc");
            
            if(res.Rows.Count > 0)
            {
                // Chuyển array các quyền thành 1 string, ghép tên của user lên đầu 
                // và cách chuỗi các quyền = 1 dấu "-", các quyền cách nhau 1 dấu phẩy.
                // Ví dụ: Trung Kien-hotel,user,customer.

                user.sId = (int)res.Rows[0]["id"];
                user.sFullName = res.Rows[0]["full_name"].ToString();

                foreach(DataRow row in res.Rows)
                {
                    Permission permission = new Permission();

                    permission.sCode = row["code"].ToString();

                    permissions.Add(permission);
                }

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

            DataTable res = DB.queryExecuteAdapter("user_proc");

            if(res != null)
            {
                foreach(DataRow row in res.Rows)
                {
                    User user = new User();

                    user.addDataToUser(row);

                    users.Add(user);
                }

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

            DataTable res = DB.queryExecuteAdapter("select_full_role_proc");

            if (res != null)
            {
                foreach (DataRow row in res.Rows)
                {
                    Role role = new Role();

                    role.sName = (string)row["name"];

                    roles.Add(role);
                }

                return roles;
            }
            else
            {
                return null;
            }
        }

        public User insertUser(User user)
        {
            DataTable res = DB.queryExecuteAdapter("insert_user_proc", user.getUserToDictionary());

            if(res != null)
            {
                foreach (DataRow row in res.Rows)
                {
                    user.addDataToUser(row);
                }

                return user;
            }
            
            return null;
        }

        public List<User> searchUser(string field, string searchStr, bool isActive)
        {
            List<User> users = new List<User>();

            string p = "";

            switch (field)
            {
                case "Full name":
                    p = "full_name";
                    break;
                case "Id code":
                    p = "id_code";
                    break;
                case "Phone number":
                    p = "phone_number";
                    break;
                case "Email":
                    p = "email";
                    break;
            }

            DB.addParam(p, searchStr);
            DB.addParam("statetus", (isActive ? 1 : 0).ToString());

            DataTable res = DB.queryExecuteAdapter("search_user_proc");

            if (res != null) {
                foreach (DataRow row in res.Rows)
                {
                    User user = new User();

                    user.addDataToUser(row);

                    users.Add(user);
                }

                return users;
            }

            return null;
        }

        public int deleteUser(string id)
        {
            DB.addParam("id", id);

            DataTable res = DB.queryExecuteAdapter("delete_user_proc");

            if (res.Rows.Count > 0)
            {
                return (int)res.Rows[0][0];
            }

            return 0;
        }

        public bool updateUser(User user)
        {
            //string[] paras = { "id", "id_code", "full_name", "phone_number", "email", "address", "password", "role_name", "statetus" };
            //string[] value = { user.sId.ToString(), user.sIdCode, user.sFullName, user.sPhoneNumber,
            //                    user.sEmail, user.sAddress, user.sPassword, user.sRoleName, user.sStatetus.ToString()};



            DataTable res = DB.queryExecuteAdapter("update_user_proc", user.getUserToDictionary(true));

            if (res != null)
            {
                return true;
            }

            return false;
        }

        public List<User> getCustomer()
        {
            try
            {
                DataTable res = DB.queryExecuteAdapter("get_customer");

                List<User> users = new List<User>();

                foreach (DataRow row in res.Rows)
                {
                    User user = new User();

                    user.addDataToCustomer(row);

                    users.Add(user);
                }

                return users;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public List<User> searchCustomer(User user)
        {
            try
            {
                DB.addParam("id_code", user.sIdCode == "" ? null: user.sIdCode);
                DB.addParam("full_name", user.sFullName == "" ? null: user.sFullName);
                DB.addParam("phone_number", user.sPhoneNumber == "" ? null : user.sPhoneNumber);
                DB.addParam("email", user.sEmail == "" ? null : user.sEmail);
                DB.addParam("address", user.sAddress == "" ? null : user.sAddress);
                DB.addParam("statetus", user.sStatetus);

                DataTable res = DB.queryExecuteAdapter("search_customer");

                List<User> users = new List<User>();

                foreach (DataRow row in res.Rows)
                {
                    User tempUser = new User();

                   tempUser.addDataToUser(row); 

                    users.Add(tempUser);
                }

                return users;
            }
            catch(Exception ex) { 
                return null;
            }
        }

        public bool changeCustomerState(string idCode, int state)
        {
            try
            {
                DB.addParam("id_code", idCode);
                DB.addParam("state", state);

                DataTable res = DB.queryExecuteAdapter("change_customer_state");

                if (res.Rows[0][0].ToString() == "1")
                {
                    return true;
                }

                return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
