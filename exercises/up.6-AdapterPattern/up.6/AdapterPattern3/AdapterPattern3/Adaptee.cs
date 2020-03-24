using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern3
{
    // Existing way requests are implemented
    class Adaptee
    {
        // Provide full precision
        public double SpecificRequest(double a, double b)
        {
            return a / b;
        }
    }
}
