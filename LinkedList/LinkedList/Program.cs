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

                Console.WriteLine("choose any above option");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("######## data in Linked list #######");
                        LinkedListDemo linkesListDemo = new LinkedListDemo();
                        linkesListDemo.InsertData(56);
                        linkesListDemo.InsertData(30);
                        linkesListDemo.InsertData(70);
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
