using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Constants;

namespace Utility.Exceptions
{
    public class ProductSalesPriceIsNotNumericException:Exception
    {
        public ProductSalesPriceIsNotNumericException() : base(GlobalConstants.PRODUCT_SALES_PRICE_IS_NOT_NUMERIC_MESSAGE) { }
    }
}
