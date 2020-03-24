using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenBook
{
    // Bridge
    interface Bridge
    {
        void Add(string message);
        void Add(string friend, string message);
        void Poke(string who);
    }
}
