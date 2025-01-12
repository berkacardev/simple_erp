using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Constants;

namespace Utility.Exceptions
{
    internal class ProductFirstStockQuaintityIsNotNumericException : Exception
    {
        public ProductFirstStockQuaintityIsNotNumericException() : base(GlobalConstants.PRODUCT_FIRST_STOCK_QUANTITY_IS_NOT_NUMERIC_MESSAGE) { }
    }
}
