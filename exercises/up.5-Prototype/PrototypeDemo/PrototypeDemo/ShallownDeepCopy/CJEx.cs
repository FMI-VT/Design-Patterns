using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDemo
{
    class OtherHero : AProtagonistEx
    {
        public override AProtagonistEx Clone()
        {
            //return ShallowCopy();
            return DeepCopy();
        }

        private AProtagonistEx ShallowCopy()
        {
            return this.MemberwiseClone() as AProtagonistEx;
        }

        private AProtagonistEx DeepCopy()
        {
            OtherHero cloned = this.MemberwiseClone() as OtherHero;
            cloned.Details = new AdditionalDetails();
            cloned.Details.Charisma = this.Details.Charisma;
            cloned.Details.Fitness = this.Details.Fitness;

            return cloned as AProtagonistEx;
        }
    }
}
