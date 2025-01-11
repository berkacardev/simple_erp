using Entity;
using Model;
using Repository;
using Repository.RamRepository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Exceptions;

namespace Service.Implementations
{
    public class AuthenticationServiceImpl : IAuthenticationService
    {
        private AbstractRepositoryBase<AuthUser> AuthUserRepository;
        private static AuthUserModel AuthUserModel = null;

        public AuthenticationServiceImpl()
        {
            AuthUserRepository = new AuthUserRamRepositoryImpl();
        }

        public AuthUserModel Login(AuthUserModel authUserModel)
        {
            if (authUserModel.UserName == String.Empty)
            {
                throw new UserNameIsEmptyException();
            }
            if (authUserModel.UserPassword == String.Empty)
            {
                throw new UserPasswordIsEmptyException();
            }

            AuthUser _authUser = new AuthUser(authUserModel.UserName, authUserModel.UserPassword);
            var result = AuthUserRepository.GetAll().Find(u => u.UserName == authUserModel.UserName && u.UserPassword == authUserModel.UserPassword);
            if (result == null)
            {
                throw new WrongUserNameOrPasswordException();
            }
            AuthUserModel = new AuthUserModel(result.Id, result.UserName, result.UserPassword);
            return AuthUserModel;
        }
    }
}
