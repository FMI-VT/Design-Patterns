using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorExamp1
{
    class DecoratorB : IComponent
    {
        IComponent component;
        public string addedState = "past the Coffee Machine ";

        public DecoratorB(IComponent c)
        {
            component = c;
        }

        public string Operation()
        {
            string s = component.Operation();
            s += "to school ";
            return s;
        }

        public string AddedBehavior()
        {
            return "and I bought a cappuccino ";
        }
    }
}
