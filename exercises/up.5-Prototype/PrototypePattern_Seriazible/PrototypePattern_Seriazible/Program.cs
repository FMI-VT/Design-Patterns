using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern_Seriazible
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create first object
            Dummy d1 = new Dummy();
            d1.ValueType = "1";
            d1.ReferenceType = new DummyRef() { Id = "1" };

            //Make deep copy in second object
            Dummy d2 = d1.DeepCopy();
           // d2.ValueType = "2";
            //d2.ReferenceType.Id = "2";

            //Check if both are equal or not
            
            if (d1.ValueType == d2.ValueType && d1.ReferenceType.Id == d2.ReferenceType.Id)
            {
                Console.WriteLine("\n The both objects are equal!\n");
            }

            Dummy d3 = d1.Clone();
            if (d3 != d1)
            {
               //
            }
            if (d1.ValueType == d3.ValueType && d1.ReferenceType.Id == d3.ReferenceType.Id)
            {
                Console.WriteLine("\n The both objects are equal!\n");
            }
        }
    }
}
