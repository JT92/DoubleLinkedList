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
            list.CreateList();
            int selection = 0;

            // Display the Menu
            do
            {
                Console.WriteLine();
                Console.WriteLine("[1] Print out the list");
                Console.WriteLine("[2] Insert a node at the beginning of the list");
                Console.WriteLine("[3] Insert a node at the end of the list");
                Console.WriteLine("[4] Insert after a specified node");
                Console.WriteLine("[5] Insert before a specified node");
                Console.WriteLine("[6] Delete first node");
                Console.WriteLine("[7] Delete last node");
                Console.WriteLine("[8] Delete a specified node");
                Console.WriteLine("[9] Reverse the list");
                Console.WriteLine("[10] Exit the Application");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                    switch( selection )
                    {
                        case 1:
                            list.PrintList();
                            break;
                        case 2:
                            Console.Write("Enter the value you want to insert: ");
                            list.InsertInBeginning(ReadInt());
                            break;
                        case 3:
                            Console.Write("Enter the value you want to insert: ");
                            list.InsertAtEnd(ReadInt());
                            break;
                        case 4:
                            {
                                Console.Write("Enter the value you want to insert: ");
                                int insertValue = ReadInt();
                                Console.Write("Enter the element after which to insert: ");
                                list.InsertAfterNode(ReadInt(), insertValue);
                                break;
                            }
                        case 5:
                            {
                                Console.Write("Enter the value you want to insert: ");
                                int insertValue = ReadInt();
                                Console.Write("Enter the element before which to insert: ");
                                list.InsertBeforeNode(ReadInt(), insertValue);
                                break;
                            }
                        case 6:
                            list.DeleteFirstNode();
                            break;
                        case 7:
                            list.DeleteLastNode();
                            break;
                        case 8:
                            Console.Write("Enter the value of the node you want to delete: ");
                            list.DeleteSpecifiedNode(ReadInt());
                            break;
                        case 9:
                            list.ReverseList();
                            break;
                        case 10:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Please Select a choice from the menu");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a number");
                }
            } while (selection != 10);
        }

        public static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
