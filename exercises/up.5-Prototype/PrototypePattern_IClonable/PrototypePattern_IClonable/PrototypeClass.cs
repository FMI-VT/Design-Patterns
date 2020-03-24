using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern_IClonable
{
    class PrototypeClass : ICloneable
    {
        public int Data { get; set; }
        public PrototypeClass(int x)
        {
            this.Data = x;
        }
        public void PrintData()
        {
            Console.WriteLine("My value is :" + Data);
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
