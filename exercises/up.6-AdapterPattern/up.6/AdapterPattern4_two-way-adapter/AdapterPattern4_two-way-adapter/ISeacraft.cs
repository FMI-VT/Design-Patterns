using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern4_two_way_adapter
{
    // Adaptee interface
    public interface ISeacraft
    {
        int Speed { get; }
        void IncreaseRevs();
    }
    
}
