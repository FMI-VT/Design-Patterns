using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorExamp1
{
    class Component : IComponent {
        public string Operation()
        {
            return "I am walking ";
        }
    }
}
