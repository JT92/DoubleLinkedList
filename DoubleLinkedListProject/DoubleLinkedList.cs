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
                return;
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

        // Insert data into the beginning of the list (or into empty list)
        public void InsertInBeginning(int theValue)
        {
            Node temp = new Node(theValue);
            
            // if list empty
            if (start == null)
            {
                start = temp;
                return;
            }

            temp.next = start;
            start.prev = temp;
            start = temp;
        }
        
        // Insert data into end of list (or into empty list)
        public void InsertAtEnd(int theValue)
        {
            Node temp = new Node(theValue);

            // if list is empty
            if (start == null)
            {
                start = temp;
                return;
            }

            Node p = start;
            while (p.next != null)
                p = p.next;
            p.next = temp;
            temp.prev = p;
        }

        // Find node by value
        public Node FindNode(int theValue)
        {
            // find p (node)
            Node p = start;
            while (p != null)
            {
                if (p.value == theValue)
                    break;
                p = p.next;
            }
            return p;
        }

        // Insert data after a node
        public void InsertAfterNode(int theNode, int theValue)
        {
            // find p (node)
            Node p = FindNode(theNode);

            if (p == null)
                Console.WriteLine(theNode + " could not be found");
            else
            {
                // insert new node
                Node temp = new Node(theValue);
                temp.prev = p;
                temp.next = p.next;
                if (p.next != null)
                    p.next.prev = temp; // should not be done if next node is null
                p.next = temp;
            }

        }

        // Insert data before a node
        public void InsertBeforeNode(int theNode, int theValue)
        {
            // find p (node)
            Node p = FindNode(theNode);

            // if list is empty
            if (p == null)
                Console.WriteLine(theNode + " could not be found");
            
            // if you are trying to insert before first node
            else if (start.value == theNode)
            {
                InsertInBeginning(theValue);
                return;
            }
            else
            {
                // insert new node
                Node temp = new Node(theValue);
                temp.prev = p.prev;
                temp.next = p;
                p.prev.next = temp;
                p.prev = temp;
            }
        }

        // Delete the first Node
        public void DeleteFirstNode()
        {
            // if no nodes in list
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            
            // if one node in list
            if (start.next == null)
                start = null;

            // if more than one nodes in list
            else
            {
                start = start.next;
                start.prev = null;
            }
        }

        // Delete the last node in the list
        public void DeleteLastNode()
        {
            // if no nodes in list
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            // if one node in list
            if (start.next == null)
                start = null;

            // if more than one nodes in list
            else
            {
                Node p = start;
                while (p.next.next != null)
                    p = p.next;
                p.next = null;
            }
        }

        // Delete specified Node
        public void DeleteSpecifiedNode(int theNode)
        {
            // if no nodes in list
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            // find the Node
            Node p = FindNode(theNode);

            // if at beginning
            if (p.prev == null)
                DeleteFirstNode();

            // if at end
            else if (p.next == null)
                DeleteLastNode();

            // if in between nodes
            else
            {
                p.prev.next = p.next;
                p.next.prev = p.prev;
            }
        }
        
        // Reverse the list
        public void ReverseList()
        {
            // if there are 0 or 1 elements, do nothing
            if (start == null || start.next == null)
                return;

            Node p1 = start;                // set p1 to first node
            Node p2 = start.next;           // set p2 to second node

            while (p2 != null)
            {
                p1.next = p1.prev;          
                p1.prev = p2;
                p1 = p2;
                p2 = p2.next;
            }
            p1.next = p1.prev;
            p1.prev = null;
            start = p1;
        }


        // Create a list
        public void CreateList()
        {
            int i, n, theValue;
            Console.Write("Enter the number of nodes to insert: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;

            for ( i = 1; i<=n; i++)
            {
                Console.Write("Enter an element to be inserted: ");
                theValue = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(theValue);
            }
            
        }


    }
}
