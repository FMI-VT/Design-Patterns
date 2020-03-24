using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern_Seriazible
{
    [Serializable()]
    public class Dummy : Prototype<Dummy>
    {
        public string ValueType { get; set; }
        public DummyRef ReferenceType { get; set; }
    }
}
