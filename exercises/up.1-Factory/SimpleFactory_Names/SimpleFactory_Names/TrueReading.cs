using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory_Names
{
    public class TrueReading : Names
    {
        public TrueReading(string name) {
            int i = name.IndexOf (" ");
            if(i > 0) {
                frName = name.Substring (0, i).Trim ();
                lName = name.Substring(i + 1).Trim();
            }
            else
            {
                lName = name;
                frName = "";
            }
        }
    }
}
