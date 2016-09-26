using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the list
            DoubleLinkedList list = new DoubleLinkedList();
            int selection = 0;

            // Display the Menu
            do
            {
                Console.WriteLine("[1] Print out the list");
                Console.WriteLine("[2] Insert a node in beginning of the list");
                Console.WriteLine("[7] Exit the Application");
                selection = Convert.ToInt32(Console.ReadLine());

                switch( selection )
                {
                    case 1:
                        list.PrintList();
                        break;
                    case 2:
                        list.InsertInBeginning();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please Select a choice from the menu");
                        break;
                }

            } while (selection != 7);

        }
    }
}
