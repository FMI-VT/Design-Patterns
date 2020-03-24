using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern3
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton1 s1 = Singleton1.Instance;
            Console.WriteLine("Creating the instance of Singleton1");
            Singleton1 ss1 = Singleton1.Instance;
            Console.WriteLine("Creating the second instance of Singleton1");
            if (s1 == ss1)
            {
                Console.WriteLine("This is the same object");
            }

            Console.WriteLine("\n\n Creating the instance of Singleton2");
            Singleton2 s2 = Singleton2.Instance;
            Singleton2 ss2 = Singleton2.Instance;
            Console.WriteLine("Creating the second instance of Singleton2");
            if (s2 == ss2)
            {
                Console.WriteLine("This is the same object");
            }
        }
    }
}
