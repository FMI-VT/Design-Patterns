using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDemo
{
    public class NovelHeroFinal : ICloneable
    {
        int m_health;
        int m_courage;
        double m_money;
        AdditionalDetails m_details = new AdditionalDetails();

        public int Health
        {
            get { return m_health; }
            set { m_health = value; }
        }

        public int Courage
        {
            get { return m_courage; }
            set { m_courage = value; }
        }

        public double Money
        {
            get { return m_money; }
            set { m_money = value; }
        }

        public AdditionalDetails Details
        {
            get { return m_details; }
            set { m_details = value; }
        }

        private object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        private object DeepCopy()
        {
            NovelHeroFinal cloned = this.MemberwiseClone() as NovelHeroFinal;
            cloned.Details = new AdditionalDetails();
            cloned.Details.Charisma = this.Details.Charisma;
            cloned.Details.Fitness = this.Details.Fitness;

            return cloned;
        }

        #region ICloneable Members

        public object Clone()
        {
            return DeepCopy();
        }

        #endregion
    }
}