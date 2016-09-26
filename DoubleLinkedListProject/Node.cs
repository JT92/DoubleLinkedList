using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedListProject
{
    class Node
    {
        public Node prev;
        public int value;
        public Node next;

        public Node(int theValue)
        {
            value = theValue;
            prev = null;
            next = null;
        }
    }
}
