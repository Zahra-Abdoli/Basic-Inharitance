using System;
using System.Collections.Generic;
using System.Text;

namespace StackOfString
{
    class StackOfString
    {
        private List<string> data = new List<string>();

        public List<string> Data
        {
            get { return data; }
             private set { data = value; }
        }
        public void Push(string item) => data.Add(item);  

        public string Pop() {
            string item = data[data.Count-1];
            data.Remove(item);
            return item;
        }
        public string Peek() { 
            string item = data[data.Count-1];
            return item;
        }
        public bool IsEmpty() { 
            if (data.Count == 0) return true;
            else return false;
        }



    }
}
