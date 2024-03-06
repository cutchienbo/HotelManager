using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        private int id;
        private int role_id;
        private string full_name;
        private string id_code;
        private string phone_number;
        private string email;
        private string address;
        private string password;

        public int sId {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public int sRoleId
        {
            get
            {
                return this.role_id;
            }
            set
            {
                this.role_id = value;
            }
        }
        public string sFullName
        {
            get
            {
                return this.full_name;
            }
            set
            {
                this.full_name = value;
            }
        }
        public string sIdCode
        {
            get
            {
                return this.id_code;
            }
            set
            {
                this.id_code = value;
            }
        }
        public string sPhoneNumber
        {
            get
            {
                return this.phone_number;
            }
            set
            {
                this.phone_number = value;
            }
        }
        public string sEmail
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        public string sAddress
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }
        public string sPassword
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

        public User() { }

        public User(
            int id,
            int role_id,
            string full_name,
            string id_code,
            string phone_number,
            string email,
            string address,
            string password
        )
        {
            this.id = id;
            this.role_id = role_id;
            this.full_name = full_name;
            this.id_code = id_code;
            this.phone_number = phone_number;
            this.email = email;
            this.address = address;
            this.password = password;
        }
    }
}
