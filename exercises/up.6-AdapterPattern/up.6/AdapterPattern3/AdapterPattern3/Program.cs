using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern3
{
    class Program
    {
        //Client
        static void Main(string[] args)
        {
            // Showing the Adaptee in standalone mode
            Adaptee first = new Adaptee( );
            Console.Write("Before the new standard\nPrecise reading: ");
            Console.WriteLine(first.SpecificRequest(5,3));
    
            // What the client really wants
            ITarget second = new Adapter( );
            Console.WriteLine("\nMoving to the new standard");
            Console.WriteLine(second.Request(5));
           // the Adapter adds the words "Rough estimate is" to indicate that
           //the Request has been adapted before it calls the SpecificRequest
        }
    }
}
