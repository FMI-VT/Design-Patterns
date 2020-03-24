using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    // Strategy interface
    interface IStrategy
    {
        int Move(Context c);
    }
}
