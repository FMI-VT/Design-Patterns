using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDemo
{
    public abstract class AProtagonistEx
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

        public abstract AProtagonistEx Clone();
    }
}
