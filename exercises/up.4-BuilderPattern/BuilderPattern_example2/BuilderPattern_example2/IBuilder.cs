using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern_example2
{
    interface IBuilder {
        void BuildPartA( );
        void BuildPartB( );
        Product GetResult( );
    }
}
