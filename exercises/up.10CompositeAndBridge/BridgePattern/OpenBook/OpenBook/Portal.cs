﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenBook
{
    // Abstraction
    class Portal
    {
        Bridge bridge;
        public Portal(Bridge aSpaceBook)
        {
            bridge = aSpaceBook;
        }
        public void Add(string message)
        { bridge.Add(message); }
        public void Add(string friend, string message)
        { bridge.Add(friend, message); }
        public void Poke(string who)
        { bridge.Poke(who); }
    }
}
