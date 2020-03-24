using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory_Brand
{
    class Client<Brand>  where Brand : IBrand, new( ) 
    {
        public void ClientMain( ) 
        {
            // The following line is not possible without new() constraint:
            IFactory<Brand> factory = new Factory<Brand>( );

            IBag bag = factory.CreateBag( );
            IShoes shoes = factory.CreateShoes( );

            Console.WriteLine("I bought a Bag which is made from " + bag.Material);
            Console.WriteLine("I bought some shoes which cost " + shoes.Price);
        }
    }
}
