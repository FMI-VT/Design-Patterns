using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod_Shop_Supply
{
    class ProductA : IProduct {
        public String SupplyFrom()
        {
            return " from Greece";
        }
    }
}
