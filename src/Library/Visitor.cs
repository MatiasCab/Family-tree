using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public abstract class Visitor 
    {
        public int AgeTotal
        {
            get
            {
                return this.Total;
            }
        }

        protected int Total {get; set;} = 0; 

        public abstract void Visit(Node node);
    }
}
