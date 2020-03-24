using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern3
{
    //Define Singleton class by static initialization -> C# 3.0
    //The sealed class cannot be derivate,which could add instances
    public sealed class Singleton2
    {
        // readonly means that the variable can be assigned only during static initialization (below) or in a class constructor
        private static readonly Singleton2 instance = new Singleton2();

        private Singleton2() { }

        public static Singleton2 Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
