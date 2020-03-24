using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern1
{
    public class SingletonClass
    {
        private static bool instance_flag= false;
        private SingletonClass()
        {
        }
        public static SingletonClass getMethod()
        {
            if (!instance_flag)
            {
                instance_flag = true;
                return new SingletonClass();
            }
            else
                return null;
        }
    }
}
