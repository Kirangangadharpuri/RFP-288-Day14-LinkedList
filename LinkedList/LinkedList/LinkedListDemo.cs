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
        public void InsertData(int data)
        {
            Node node = new Node(data);
            if (head==null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp=temp.next;
                }
                temp.next=temp;
            }
            Console.WriteLine("{0} inserted in linked list",data);
        }

    }
}
