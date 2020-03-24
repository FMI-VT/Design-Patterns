using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OpenBook
{
    // The Client
    class Program : SpaceBookSystem
    {
        static void Main(string[] args)
        {
            Portal me = new Portal(new MyOpenBook("Judith"));
            me.Add("Hello world");
            me.Add("Today I worked 18 hours");
            Portal tom = new Portal(new MyOpenBook("Tom"));
            tom.Poke("Judith-1");
            tom.SuperPoke("Judith-1", "hugged");
            tom.Add("Judith-1", "Poor you");
            tom.Add("Hey, I'm on OpenBook - it's cool!");
        }
    }
}
