using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern4_two_way_adapter
{
    // ITarget interface
    public interface IAircraft
    {
        bool Airborne { get; } //излетял
        void TakeOff();
        int Height { get; }
    }
}
