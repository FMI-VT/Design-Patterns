using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDemo
{
    class NovelHero : AProtagonist
    {
        public override AProtagonist Clone()
        {
            return this.MemberwiseClone() as AProtagonist;
        }
    }
}
