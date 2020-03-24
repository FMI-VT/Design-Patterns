﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory_Brand
{
    // Concrete Factories (both in the same one)
    class Factory<Brand> : IFactory<Brand>
    where Brand : IBrand, new()
    {
        public IBag CreateBag()
        {
            return new Bag<Brand>();
        }

        public IShoes CreateShoes()
        {
            return new Shoes<Brand>();

        }
    }
}