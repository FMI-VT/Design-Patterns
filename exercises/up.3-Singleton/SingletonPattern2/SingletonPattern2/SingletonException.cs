using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern2
{
    public class SingletonException : Exception
    {
        //new exception type for singleton classes
        public SingletonException(string s) : base(s)
        {
        }
    }
}
