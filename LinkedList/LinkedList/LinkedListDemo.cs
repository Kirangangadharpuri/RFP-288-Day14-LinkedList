using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListDemo
    {
       public void Add()
        {
            LinkedList<int> linkedList= new LinkedList<int>();
            linkedList.AddFirst(70);
            linkedList.AddFirst(30);
            linkedList.AddFirst(56);
            foreach(int elements in linkedList)
            {
                Console.WriteLine(elements);
            }
        }

    }
}
