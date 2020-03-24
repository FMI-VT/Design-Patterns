using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern1
{
    class Program
    {
        class Abstraction
        {
            Bridge bridge;
            public Abstraction(Bridge implementation)
            {
                bridge = implementation;
            }
            public string Operation()
            {
                return "Abstraction" + " <<< BRIDGE >>>> " + bridge.OperationImp();
            }
        }

        interface Bridge
        {
            string OperationImp();
        }

        class ImplementationA : Bridge
        {
            public string OperationImp()
            {
                return "ImplementationA";
            }
        }

        class ImplementationB : Bridge
        {
            public string OperationImp()
            {
                return "ImplementationB";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bridge Pattern\n");
            Console.WriteLine(new Abstraction(new ImplementationA()).Operation());
            Console.WriteLine(new Abstraction(new ImplementationB()).Operation());
        }
    }
}