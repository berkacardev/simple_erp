using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Constants;

namespace Utility.Exceptions
{
    public class ProductPurchasePriceIsNotNumericException :Exception
    {
        public ProductPurchasePriceIsNotNumericException() : base(GlobalConstants.PRODUCT_PURCHASE_PRICE_IS_NOT_NUMERIC_MESSAGE) { }
    }
}
