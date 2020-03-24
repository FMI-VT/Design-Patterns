using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory_Brand
{
    // All concrete ProductA's
    class Bag<Brand> : IBag  where Brand : IBrand, new()
    {
        private Brand myBrand;
        public Bag()
        {
            // The following line is not possible without new() constraint:
            myBrand = new Brand();
        }

        public string Material { 
            get 
            { 
                return myBrand.Material; 
            } 
        }
    }
}
