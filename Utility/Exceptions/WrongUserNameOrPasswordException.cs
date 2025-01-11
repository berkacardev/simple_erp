using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Constants;

namespace Utility.Exceptions
{
    public class WrongUserNameOrPasswordException : Exception
    {
        public WrongUserNameOrPasswordException() : base(GlobalConstants.WRONG_USERNAME_OR_PASSOWRD)
        {
        }

    }
}
