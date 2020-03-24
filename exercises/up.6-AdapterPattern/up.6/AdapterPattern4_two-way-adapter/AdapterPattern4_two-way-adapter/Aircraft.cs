using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern4_two_way_adapter
{
    // Target
    public sealed class Aircraft : IAircraft
    {
        int height;
        bool airborne;
        public Aircraft()
        {
            height = 0;
            airborne = false;
        }
        public void TakeOff()
        {
            Console.WriteLine("Aircraft engine takeoff");
            airborne = true;
            height = 200; // Meters
        }
        public bool Airborne
        {
            get { return airborne; }
        }
        public int Height
        {
            get { return height; }
        }
    }
}
