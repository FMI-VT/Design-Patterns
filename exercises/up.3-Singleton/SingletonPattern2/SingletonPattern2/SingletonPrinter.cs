using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern2
{
    public class SingletonPrinter
    {
        static bool instance_flag = false; //true if one instance
        public SingletonPrinter()
        {
            if (instance_flag)
                throw new SingletonException("Only one printer allowed");
            else {
                    instance_flag = true; //set flag
                    Console.WriteLine ("printer opened");
                 }
        }
    }
}
