using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Constants;

namespace Utility.Exceptions
{
    public class ProductIdIsNotNumericException : Exception
    {
        public ProductIdIsNotNumericException() : base(GlobalConstants.PRODUCT_ID_IS_NOT_NUMERIC_MESSAGE) { }
    }
}
