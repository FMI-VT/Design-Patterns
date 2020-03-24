using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern_example2
{
    class Director
    {
        public int mode { set; get; }
        // Build a Product from several parts
        public void Construct(IBuilder builder) {

            if (mode == 0)
            {
                builder.BuildPartA();
                builder.BuildPartB();
                builder.BuildPartB();
            }
            else if (mode == 1)
            {
                builder.BuildPartA();
                builder.BuildPartA();
                builder.BuildPartB();
            }
            else {

                builder.BuildPartA();
                builder.BuildPartB();
            }
        }
    }
}
