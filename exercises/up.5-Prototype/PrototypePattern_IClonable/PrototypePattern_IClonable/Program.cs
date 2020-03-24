using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern_IClonable
{
    class Program
    {
        static void Main(string[] args)
        {
            PrototypeClass prototype = new PrototypeClass(10);
           
            Dictionary<string, PrototypeClass> map = new Dictionary<string, PrototypeClass>();
            string name = "Object";

            for (int i = 1; i < 10; i++)
            {
                string t = name + i.ToString();
                map[t] = prototype.Clone() as PrototypeClass;
                map[t].Data *= i;
                Console.Write("My name is :{0} and ", t);
                map[t].PrintData();
                

                //usage witout collection
               // PrototypeClass temp = prototype.Clone() as PrototypeClass;
               // temp.Data *= i;
               // temp.PrintData();
            }
            Console.ReadKey();
        }
    }
}
