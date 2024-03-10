using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Permission
    {
        private string code;

        public Permission() {
            this.code = "";
        }

        public Permission(string _code)
        {
            this.code = _code;
        }

        public string sCode {  
            get { 
                return this.code;
            }
            set
            {
                this.code = value;
            }
        }
    }
}
