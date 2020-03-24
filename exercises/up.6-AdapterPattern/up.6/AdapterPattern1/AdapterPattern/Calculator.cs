using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    public class Calculator
    {
        public int GetArea(Rectangle rectangle)
        {
            int area = rectangle.Width * rectangle.Height;

            return area;
        }
    }
}
