using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory_Names
{
    //Base class for getting split names
    public class Names
    {
        //parts stored here
        protected string frName, lName;
        //return first name
        public string getFrname()
        {
            return frName;
        }
        //return last name
        public string getLname()
        {
            return lName;
        }
    }
}
