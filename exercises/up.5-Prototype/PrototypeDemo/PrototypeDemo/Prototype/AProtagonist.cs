using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDemo
{
    public abstract class AProtagonist
    {
        int m_health;
        int m_courage;
        double m_money;

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

        public abstract AProtagonist Clone();
    }
}
