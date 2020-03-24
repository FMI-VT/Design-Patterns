using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


// Adapter Pattern - Pluggable
// Adapter can accept any number of pluggable adaptees and targets
// and route the requests via a delegate, in some cases using the
// anonymous delegate construct



// In pluggable adapters, the name of a method called by the client and 
//that existing in the ITarget interface can be different. 
//The adapter must be able to handle the name change.

//Suppose the client wants to use its own names, or that there is more than one
//client and they have different terminologies. To achieve these name changes in a very
//dynamic way, we can use delegates.

namespace AdapterPattern5_Pluggable
{
    class Program
    {
        //Client
        static void Main(string[] args)
        {
            Adapter adapter1 = new Adapter(new Adaptee());
            Console.WriteLine(adapter1.Request(5));

            Adapter adapter2 = new Adapter(new Target());
            Console.WriteLine(adapter2.Request(5));
        }
    }
}
