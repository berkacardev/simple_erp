using Entity;
using Repository.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RamRepository.Implementations
{
    public class AuthUserRamRepositoryImpl : AbstractRepositoryBase<AuthUser>
    {
        private static AbstractReosurce<AuthUser> abstractResource = new AuthUserDummyResource();

        public AuthUserRamRepositoryImpl() : base(abstractResource)
        {

        }

        public override AuthUser Update(AuthUser t)
        {
            throw new NotImplementedException();
        }
    }
}
