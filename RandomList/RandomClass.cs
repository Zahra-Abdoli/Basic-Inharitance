using System;
using System.Collections.Generic;
using System.Text;

namespace RandomList
{
    class RandomClass:List<string>
    {
        public string RandomString() 
        {
            Random rand = new Random();
            int index = rand.Next(this.Count);
            
           string item= this[index];
            this.Remove(item);
            return item;



        }
    }
}
