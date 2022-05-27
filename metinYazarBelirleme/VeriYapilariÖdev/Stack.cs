using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariÖdev
{
    public class Stack : LinkedListADT
    {
        public override void Push(string value)
        {
            Node tmpHead = new Node(value);
            if (Head == null)
            {
                Head = tmpHead;
            }
            else
            {
                tmpHead.Next = Head;
                Head = tmpHead;
            }
        }
        public override string Pop()
        {
            string peek = "";
            if (Head != null)
            {
                peek = Head.Data;
                Head = Head.Next;
            }
            return peek;
        }
        public override string Peek()
        {
            if (Head != null)
            {
                return Head.Data;
            }
            return "";
        }
        public override string DisplayElements()
        {
            Node temp = new Node();
            temp = Head;
            string info = "";

            if (temp == null)
            {
                return "";
            }
            else
            {
                while (temp.Next != null)
                {
                    info += temp.Data + "   ";
                    temp = temp.Next;
                }
                info += temp.Data;
                return info;
            }
        }
    }
}
