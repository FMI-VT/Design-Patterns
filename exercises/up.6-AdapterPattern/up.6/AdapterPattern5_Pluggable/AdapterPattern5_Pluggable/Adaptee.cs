using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern5_Pluggable
{
    // Existing way requests are implemented
    class Adaptee
    {
        public double Precise(double a, double b)
        {
            return a / b;
        }
    }
}
