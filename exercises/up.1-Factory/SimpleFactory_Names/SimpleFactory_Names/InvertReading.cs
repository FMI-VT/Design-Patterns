using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory_Names
{
    public class InvertReading : Names
    {
        public InvertReading(string name)
        {
            int i = name.IndexOf(",");
            if (i > 0)
            {
                lName = name.Substring(0, i);
                frName = name.Substring(i + 1).Trim();
            }
            else
            {
                lName = name;
                frName = "";
            }
        }
    }
}
