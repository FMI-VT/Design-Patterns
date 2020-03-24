using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyAggregate aggr = new MyAggregate();

            aggr[0] = "1";
            aggr[1] = "2";
            aggr[2] = "3";
            aggr[3] = "4";
            aggr[4] = "5";
            aggr[5] = "6";
            aggr[6] = "7";
            aggr[7] = "8";
            aggr[8] = "9";
            aggr[9] = "10";

            IIterator iter = aggr.GetIterator();

            for (string s = iter.FirstItem; iter.IsDone == false;  s = iter.NextItem )
            {
                Console.WriteLine(s);
            }
        }
    }
}


//IIterator: This is an interface that defines the methods for accessing and traversing elements.
//MyIterator: This is ConcreteIterator, this will implement the Iterator interface and keep track of the current position in the traversal of the aggregate object.
//IAggregate: This is an interface that defines methods for creating an Iterator object.
//MyAggregate: This is the ConcreteAggregate object, i.e., the real collection lies inside this. This class implements the IAggregate creation interface.
