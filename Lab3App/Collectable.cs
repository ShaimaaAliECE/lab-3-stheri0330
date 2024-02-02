using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal abstract class Collectable : Displayable
    {
        public string Description { get; set; }
        public CollectionBoard Board { get; set; }
        public abstract void Display();
        public abstract void AddMe(List<Collectable> list); //adds or removes from list and prints description of collectable and stating it was removed/added//
    }
}

