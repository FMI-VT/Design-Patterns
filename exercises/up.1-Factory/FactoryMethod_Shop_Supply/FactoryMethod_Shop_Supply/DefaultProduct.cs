using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod_Shop_Supply
{
    class DefaultProduct : IProduct
    {
        public String SupplyFrom()
        {
            return " not available";
        }
    }
}
