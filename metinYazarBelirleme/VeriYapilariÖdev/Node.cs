using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariÖdev
{
    public class Node
    {
        public string Data { get; set; }
        public Node Next;
        public int frequency; //farklı kelime kullanım sayısı
        public Node()
        {

        }
        public Node(string d)
        {
            Data = d;
            Next = null;
        }
    }
}
