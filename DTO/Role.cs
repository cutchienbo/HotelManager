using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Role
    {
        private string id;
        private string name;
        private List<Permission> permissions;

        public string sName
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string sId
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public List<Permission> sPermission
        {
            get
            {
                return this.permissions;
            }
            set
            {
                this.permissions = value;
            }
        }

        public Role()
        {
            this.id = "";
            this.name = "";
            this.permissions = new List<Permission>();
        }

        public Role(string _id, string _name, List<Permission> _permission)
        {
            this.id = _id;
            this.name = _name;
            this.permissions = _permission;
        }
    }
}
