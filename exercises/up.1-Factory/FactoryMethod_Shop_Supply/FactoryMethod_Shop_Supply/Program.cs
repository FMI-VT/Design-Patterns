using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod_Shop_Supply
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator( );
            IProduct product;

            for (int i = 1; i <= 12; i++)
            {
                product = c.FactoryMethod(i);
                Console.WriteLine("Oranges " + product.SupplyFrom());
            }

        }
    }
}
