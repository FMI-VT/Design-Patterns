﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern_example2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create one director and two builders
            Director director = new Director( );
            director.mode = 0;//client want of director to construct the products by builder by this mode!!

            IBuilder b1 = new Builder1( );
            IBuilder b2 = new Builder2( );

            // Construct two products
            director.Construct(b1);
            Product p1 = b1.GetResult( );
            p1.Display( );

            director.Construct(b2);
            Product p2 = b2.GetResult( );
            p2.Display( );
        }
    }
}
