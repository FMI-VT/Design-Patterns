using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Adapter Pattern => Convert the interface of a class into another interface clients expect. 
//Adapter lets classes work together that couldn't otherwise because of incompatible interfaces. 

//This structural code demonstrates the Adapter pattern which maps the interface of 
//one class onto another so that they can work together. These incompatible classes 
//may come from different libraries or frameworks. 

namespace Adapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Non-adapted chemical compound
            Compound unknown = new Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();

            // Wait for user
            Console.ReadKey();
        }
    }
}
