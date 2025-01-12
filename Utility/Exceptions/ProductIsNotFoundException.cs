using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Constants;

namespace Utility.Exceptions
{
    public class ProductIsNotFoundException : Exception
    {
        public ProductIsNotFoundException() : base(GlobalConstants.PRODUCT_IS_NOT_FOUND_MESSAGE) { }
    }
}
