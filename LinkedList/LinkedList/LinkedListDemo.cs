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
        public Node head;
        public void Insert(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                    temp.next = node;

                }
                //temp.next = node;
            }
            Console.WriteLine("{0} is inserted to linked list",data);
        }

    }
}
