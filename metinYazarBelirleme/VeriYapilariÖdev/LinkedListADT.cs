using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariÖdev
{
    public abstract class LinkedListADT
    {
        public Node Head;
        public LinkedListADT()
        {
            this.Head = null;
        }
        public abstract void Push(string value);
        public abstract string Pop();
        public abstract string Peek();
        public abstract string DisplayElements();
    }
}
