using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Resources
{
    public class AuthUserDummyResource : AbstractReosurce<AuthUser>
    {
        private static List<AuthUser> AuthUsers = new List<AuthUser>();
        public AuthUserDummyResource() : base(AuthUsers)
        {
            AuthUsers.Add(new AuthUser(1, "admin", "12345678"));
            AuthUsers.Add(new AuthUser(1, "berk", "aa123456"));
        }
    }
}
