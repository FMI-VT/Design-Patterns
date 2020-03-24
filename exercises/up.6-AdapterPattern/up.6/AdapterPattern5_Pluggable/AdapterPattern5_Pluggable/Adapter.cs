using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern5_Pluggable
{
    // Implementing new requests via old
    class Adapter : Adaptee
    {
        public Func<int, string> Request; //this is delegate, see:  Func<T, TResult> Delegate

        // Different constructors for the expected targets/adaptees

        // Adapter-Adaptee
        public Adapter(Adaptee adaptee)
        {
            // Set the delegate to the new standard
            Request = delegate(int i)
            {
                return "Estimate based on precision is " +(int)Math.Round(Precise(i, 3));
            };
        }
        // Adapter-Target
        public Adapter(Target target)
        {
            // Set the delegate to the existing standard
            Request = target.Estimate;
        }
    }
}
//see: Anonymous Functions C#

//Anonymous functions simplify the creation of one-time behavior for delegates. They are
//useful when additional behavior is to be added before or after a method is invoked.

//Above, the method to be invoked is Precise. The parameters are different from the ones
//in the delegate, as is the return value. The anonymous function can wrap up the
//changes and assign a “complete solution” to the delegate for later invocation.