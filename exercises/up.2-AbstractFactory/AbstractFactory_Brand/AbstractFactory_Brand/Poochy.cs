using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory_Brand
{
    class Poochy : IBrand
    {
        public int Price { 
            get { 
                return new Gucci().Price / 3; 
            } 
        }
        public string Material { 
            get 
            { 
                return "Plastic"; 
            } 
        }
    }
}
