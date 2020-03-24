using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory_Brand
{
    // An interface for all Brands
    interface IBrand
    {
        int Price { get; }
        string Material { get; }
    }
}
