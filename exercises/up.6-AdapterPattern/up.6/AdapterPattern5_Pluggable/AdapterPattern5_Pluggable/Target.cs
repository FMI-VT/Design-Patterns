using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern5_Pluggable
{
    // New standard for requests
    class Target
    {
        public string Estimate(int i)
        {
            return "Estimate is " + (int)Math.Round(i / 3.0);
        }
    }
}
