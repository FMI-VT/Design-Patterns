using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory_Brand
{
    // All concrete ProductB's
    class Shoes<Brand> : IShoes  where Brand : IBrand, new()
    {
        private Brand myBrand;
        public Shoes()
        {
            // The following line is not possible without new() constraint:
            myBrand = new Brand();
        }

        public int Price { 
            get 
            { 
                return myBrand.Price; 
            } 
        }
    }
}
