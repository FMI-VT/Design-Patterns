using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern4_two_way_adapter
{
    // Adaptee implementation
    public class Seacraft : ISeacraft
    {
        int speed = 0;
        public virtual void IncreaseRevs()
        {
            speed += 10;
            Console.WriteLine("Seacraft engine increases revs to " + speed + " knots");
        }
        public int Speed
        {
            get { return speed; }
        }
    }
}

//rev - увеличавам броя на оборотите на двигател
//knot - мярка за дължина - морски възел (1853 м)
