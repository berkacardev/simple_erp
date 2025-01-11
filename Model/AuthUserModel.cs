using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AuthUserModel
    {
        public AuthUserModel (string username, string password)
        {
            this.UserName = username;
            this.UserPassword = password;
        }
        public AuthUserModel(int id,string username, string password)
        {
            this.Id = id;
            this.UserName = username;
            this.UserPassword = password;
            this.LastLogınDateTime = DateTime.Now;
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public DateTime LastLogınDateTime { get; private set; }
    }
}
