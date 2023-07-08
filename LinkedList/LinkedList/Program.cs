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
                Console.WriteLine("1-insert data in linked list");
                Console.WriteLine("choose any above option");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("######## insert data #######");
                        LinkedListDemo linkesList = new LinkedListDemo();
                        linkesList.Insert(40);
                        linkesList.Insert(12);
                        linkesList.Insert(23);
                        linkesList.Insert(66);
                        linkesList.Insert(94);
                        break;
                    default:
                        Console.WriteLine("Invalide option");
                        break;

                }
            }
        }
    }
}
