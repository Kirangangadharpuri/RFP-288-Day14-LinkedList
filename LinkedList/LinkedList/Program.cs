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
                Console.WriteLine("1-Add data in simple linked list");

                Console.WriteLine("choose any above option");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("######## data in simple Linked list #######");
                        LinkedListDemo linkesListDemo = new LinkedListDemo();
                        linkesListDemo.Add();
                        break;
                    default:
                        Console.WriteLine("Invalide option");
                        break;

                }
            }
        }
    }
}
