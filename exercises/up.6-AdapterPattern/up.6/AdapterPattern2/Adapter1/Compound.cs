using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter1
{
    /// <summary>
    /// The 'Target' class
    /// </summary>
    public class Compound
    {
        protected string _chemical;
        protected float _boilingPoint;
        protected float _meltingPoint;
        protected double _molecularWeight;
        protected string _molecularFormula;

        // Constructor

        public Compound(string chemical)
        {
            this._chemical = chemical;
        }
        
        public virtual void Display()
        {
            Console.WriteLine("\nCompound: {0} ------ ", _chemical);
        }
    }
}
