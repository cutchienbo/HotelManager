using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PermissionDAL : Database
    {
        List<Role> roles = new List<Role>();
        List<Permission> permissions = new List<Permission>();

        public List<Permission> getPermissions()
        {
            DataTable res = queryExecuteAdapter("permission_proc");

            if (res != null)
            {
                foreach(DataRow row in res.Rows)
                {
                    Permission per = new Permission();

                    per.sCode = row["code"].ToString();

                    this.permissions.Add(per);
                }

                return this.permissions;
            }

            return null;
        }

        public List<Role> getRoles()
        {
            DataTable res = queryExecuteAdapter("role_proc");
            
            foreach(DataRow row in res.Rows)
            {
                Role role = new Role();
                
                role.sName = row["name"].ToString();
                role.sId = row["id"].ToString();

                this.roles.Add(role);
            }

            return this.roles;
        }

        public bool addRole(Role role)
        {
            string[] param = { "name" };
            string[] value = { role.sName };

            SqlDataReader res = queryExecuteReader("add_role_proc", param, value);

            if (res != null)
            {
                return true;
            }

            return false;
        }

        public bool removeRole(Role role)
        {
            string[] param = { "name" };
            string[] value = { role.sName };

            SqlDataReader res = queryExecuteReader("remove_role_proc", param, value);

            if (res != null)
            {
                return true;
            }

            return false;
        }

        public void editRolePermission(string roleName, string perCode, string isInsert)
        {
            string[] param = { "per_code", "role_name", "is_insert" };
            string[] value = { perCode, roleName, isInsert };

            SqlDataReader res = queryExecuteReader("role_permission_proc", param, value);
        }

        public List<Permission> getPermissionByRoleName(string roleName)
        {
            string[] param = { "role_name" };
            string[] value = { roleName };
            List<Permission> list = new List<Permission>();

            DataTable res = queryExecuteAdapter("select_per_by_role_name_proc", param, value);

            if(res != null)
            {
                foreach(DataRow row in res.Rows)
                {
                    Permission permission = new Permission();
                    permission.sCode = row["code"].ToString();

                    list.Add(permission);
                }

                return list;
            }

            return null;
        }

    }

}
