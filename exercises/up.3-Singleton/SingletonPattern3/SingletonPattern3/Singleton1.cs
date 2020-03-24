using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern3
{
    //Define Singleton class by property 
    public class Singleton1
    {
        private static Singleton1 instance = null;

        private Singleton1() { }

        public static Singleton1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton1();
                }
                return instance;
            }
        }
    }
}
