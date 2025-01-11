using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Constants;

namespace Utility.Exceptions
{
    public class UserPasswordIsEmptyException : Exception
    {
        public UserPasswordIsEmptyException() : base(GlobalConstants.USERPASSWORD_MUST_NOT_EMPTY_MESSAGE) { }
    }
}
