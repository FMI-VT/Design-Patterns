﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorExamp1
{
    class DecoratorA : IComponent
    {
        IComponent component;

        public DecoratorA(IComponent c)
        {
            component = c;
        }

        public string Operation()
        {
            string s = component.Operation();
            s += "and listening to Z Rock ";
            return s;
        }
    }
}
