using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonPrinter pr1, pr2;
            //open one printer--this should always work
            Console.WriteLine("Opening one spooler");
            try
            {
                pr1 = new SingletonPrinter();
            }
            catch (SingletonException e)
            {
                Console.WriteLine(e.Message);
            }
            //try to open another printer --should fail
            Console.WriteLine("Opening two spoolers");
            try
            {
                pr2 = new SingletonPrinter();
            }
            catch (SingletonException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
