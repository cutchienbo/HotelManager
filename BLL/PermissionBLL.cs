using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class PermissionBLL
    {
        PermissionDAL perDAL = new PermissionDAL();

        public List<Role> getRoles()
        {
            return perDAL.getRoles();
        }

        public List<Permission> getPermissions()
        {
            return perDAL.getPermissions();
        }

        public bool addRole(Role role)
        {
            return perDAL.addRole(role);
        }

        public bool removeRole(Role role)
        {
            return perDAL.removeRole(role);
        }

        public void addRolePer(string roleName, string perCode)
        {
            perDAL.editRolePermission(roleName, perCode, "1");
        }

        public void removeRolePer(string roleName, string perCode)
        {
            perDAL.editRolePermission(roleName, perCode, "0");
        }
    }
}
