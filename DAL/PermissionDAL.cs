using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using LIB;

namespace DAL
{
    public class PermissionDAL
    {
        List<Role> roles = new List<Role>();
        List<Permission> permissions = new List<Permission>();

        public List<Permission> getPermissions()
        {
            DataTable res = DB.queryExecuteAdapter("permission_proc");

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
            DataTable res = DB.queryExecuteAdapter("role_proc");
            
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
            DB.addParam("name", role.sName);

            DataTable res = DB.queryExecuteAdapter("add_role_proc");

            if (res != null)
            {
                return true;
            }

            return false;
        }

        public bool removeRole(Role role)
        {
            DB.addParam("name", role.sName);

            DataTable res = DB.queryExecuteAdapter("remove_role_proc");

            if (res != null)
            {
                return true;
            }

            return false;
        }

        public void editRolePermission(string roleName, string perCode, string isInsert)
        {
            DB.addParam("per_code", perCode);
            DB.addParam("role_name", roleName);
            DB.addParam("is_insert", isInsert);

            DataTable res = DB.queryExecuteAdapter("role_permission_proc");
        }

        public List<Permission> getPermissionByRoleName(string roleName)
        {
            List<Permission> list = new List<Permission>();

            DB.addParam("role_name", roleName);

            DataTable res = DB.queryExecuteAdapter("select_per_by_role_name_proc");

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
