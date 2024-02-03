using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal abstract class Collectable : Displayable
    {
        public string Description { get; set; }

        public CollectionBoard CBoard { get; set; }

        public abstract void AddMe(List<Collectable> list);
        
        public abstract void Display();
        
            
        

    }
}

