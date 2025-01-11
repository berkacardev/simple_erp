using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AuthUser : BaseEntity
    {
        public AuthUser(string userName, string userPassword)
        {
            this.UserName = userName;
            this.UserPassword = userPassword;
        }
        public AuthUser(int id,string userName, string userPassword)
        {
            this.Id = id;
            this.UserName = userName;
            this.UserPassword = userPassword;
        }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public DateTime LastLoginDateTime { get; set; }
    }
}
