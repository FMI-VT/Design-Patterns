﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod_Shop_Supply
{
    class ProductB : IProduct
    {
        public String SupplyFrom()
        {
            return " from Spain";
        }
    }
}
