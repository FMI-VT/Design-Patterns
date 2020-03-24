using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceBook
{
    class Program : SpaceBookSystem
    {
        static void Main(string[] args)
        {
            //Note!!!
            // To work correctly the first user is:  Judith
            // and the next registration will be : Tom


            MySpaceBook me = new MySpaceBook();
            me.Add("Hello world");
            me.Add("Today I worked 18 hours");
            MySpaceBook tom = new MySpaceBook();
            tom.Poke("Judith");
            tom.Add("Judith", "Poor you");
            tom.Add("Off to see the Lion King tonight");
        }
    }
}
