using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacadeLib;

namespace FacadePattern
{
    class Program
    {
        //Client
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Facade.Operation1();
            Facade.Operation2();
        }
    }
}
