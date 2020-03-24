﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern1
{
    // The Interface
    public interface IComponent<T>
    {
        void Add(IComponent<T> c);
        IComponent<T> Remove(T s);
        string Display(int depth);
        IComponent<T> Find(T s);
        T Name { get; set; }
    }
}
