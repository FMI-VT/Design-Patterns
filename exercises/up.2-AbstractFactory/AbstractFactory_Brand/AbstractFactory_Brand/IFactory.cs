using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory_Brand
{
    interface IFactory<Brand>  where Brand : IBrand
    {
        IBag CreateBag();
        IShoes CreateShoes();
    }
}
