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
            SqlDataReader res = queryExecuteReader("permission_proc");

            if(res != null)
            {
                do
                {
                    Permission per = new Permission();

                    per.sCode = res["code"].ToString();

                    this.permissions.Add(per);
                }
                while(res.Read());

                return this.permissions;
            }

            return null;
        }

        public List<Role> getRoles()
        {
            SqlDataReader res = queryExecuteReader("role_proc");

            if(res != null)
            {
                string role = "";
                string permission = "";

                do
                {
                    role += res["name"].ToString() + ",";
                    permission += res["code"].ToString() + ",";
                }
                while(res.Read());

                string[] _role = role.Trim(',').Split(',');
                string[] _permission = permission.Trim(',').Split(',');

                for(int i = 0; i < _role.Length; i++)
                {
                    
                    Role role1 = new Role();

                    role1.sName = _role[i];

                    int j = 0;

                    if (i < _permission.Length)
                    {
                        List<Permission> per = new List<Permission>();

                        for (j = i; j < _role.Length - 1; j++)
                        {
                            Permission permission1 = new Permission();

                            permission1.sCode = _permission[j];

                            per.Add(permission1);

                            if (_role[j] != _role[j + 1])
                            {
                                break;
                            }
                        }

                        role1.sPermission = per;

                        i = j;
                    }

                    this.roles.Add(role1);
                }

                return this.roles;
            }

            return null;
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
    }

}
