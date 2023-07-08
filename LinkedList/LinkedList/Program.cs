using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1-Insert data in linked list");
                Console.WriteLine("2-Remove first element");
                Console.WriteLine("choose any above option");
                int option=Convert.ToInt32(Console.ReadLine());
                LinkedListDemo linkesListDemo = new LinkedListDemo();

                switch (option)
                {
                    case 1:
                        Console.WriteLine("######## data in Linked list #######");
                        linkesListDemo.InsertData(56);
                        linkesListDemo.InsertData(30);
                        linkesListDemo.InsertData(70);
                        linkesListDemo.Display();
                        break;
                    case 2:
                        Console.WriteLine("######### remove first element ######");
                        linkesListDemo.InsertData(56);
                        linkesListDemo.InsertData(30);
                        linkesListDemo.InsertData(70);
                        linkesListDemo.RemoveFirstElement();
                        linkesListDemo.Display();

                        break;
                    default:
                        Console.WriteLine("Invalide option");
                        break;

                }
            }
        }
    }
}
