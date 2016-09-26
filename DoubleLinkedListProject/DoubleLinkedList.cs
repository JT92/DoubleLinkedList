using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedListProject
{
    class DoubleLinkedList
    {
        private Node start;

        public DoubleLinkedList()
        {
            start = null;
        }

        public void PrintList()
        {
            // If list is empty, return message
            Node p;
            if (start == null)
            {
                Console.WriteLine("List is Empty");
            }

            // If list contains data, traverse and print
            p = start;
            Console.Write("List is : ");
            while ( p != null )
            {
                Console.Write(p.value + " ");
                p = p.next;
            }
            Console.WriteLine();
        }

        // Insert data into the beginning of the list
        public void InsertInBeginning(int theValue)
        {
            Node temp = new Node(theValue);
            temp.next = start;
            start.prev = temp;
            start = temp;
        }

    }
}
