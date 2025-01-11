using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Constants;

namespace Utility.Exceptions
{
    public class UserNameIsEmptyException : Exception
    {
        public UserNameIsEmptyException():base(GlobalConstants.USERNAME_MUST_NOT_EMPTY_MESSAGE) { }
    }
}
