using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonClass sc = SingletonClass.getMethod();
            if (sc != null)
                Console.WriteLine ("Got 1 instantion of the class");

            SingletonClass sc2 = SingletonClass.getMethod();
            if (sc2 == null)
                Console.WriteLine ("Can\'t get other instantion");

            //SingletonClass sc3 = new SingletonClass(); // the constructor is private
        }

    }
}
