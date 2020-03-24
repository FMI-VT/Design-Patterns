using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern3
{
    // Required standard for requests
    interface ITarget
    {
        // Rough estimate required
        string Request (int i);
    }
}
