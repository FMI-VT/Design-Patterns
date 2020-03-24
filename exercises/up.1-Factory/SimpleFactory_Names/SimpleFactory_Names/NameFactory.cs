using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory_Names
{
    //decision-making class
    public class NameFactory 
    {
        public NameFactory() { }
        public Names getName(string name)
        {
            int i = name.IndexOf(",");
            if (i > 0)
                return new InvertReading(name);
            else
                return new TrueReading(name);




           
        }
    }
}
