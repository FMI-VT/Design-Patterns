using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorTestApp
{
    interface IIterator
    {
        string FirstItem { get;}
        string NextItem{ get;}
        string CurrentItem{ get;}
        bool IsDone { get;}

    }
}
