using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RamRepository.Implementations
{
    public class AuthUserRamRepositoryImpl : IAuthUserRepository
    {
        private List<AuthUser> users;

        public AuthUserRamRepositoryImpl()
        {
            users = new List<AuthUser>();
            users.Add(new AuthUser(1,"admin","12345678"));
            users.Add(new AuthUser(1, "berk", "aa123456"));
        }

        public void Add(AuthUser t)
        {
            users.Add(t);
        }

        public AuthUser Delete(AuthUser t)
        {
            if (users.Contains(t))
            {
                users.Remove(t);
                return t;
            }
            else
            {
                return null;
            }
        }

        public AuthUser Get(int id)
        {
            return users.Where(u => u.Id == id).First();
        }

        public List<AuthUser> GetAll()
        {
            return users;
        }

        public AuthUser Update(AuthUser t)
        {
            AuthUser authUser = users.Find(u => u.Id == t.Id);
            if (authUser == null)
            {
                return null;
            }
            else
            {
                authUser.UserName = t.UserName;
                authUser.UserPassword = t.UserPassword;
                return authUser;
            }
        }
    }
}
