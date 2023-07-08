using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
                temp.next=node;
            }
            Console.WriteLine("{0} inserted in linked list",data);
        }
       
        public void RemoveFirstElement()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            else
            {
                Node temp = head;
                head = temp.next;
                Console.WriteLine("First element is removed successfully ");
            }
        }

        public void RemoveLastElement()
        {
            if(head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            if(head.next==null) 
            {
                Console.WriteLine("The next element of head is null");
            }
            else
            {
                Node temp=head;
                while(temp.next.next!=null)
                {
                    temp=temp.next;//making previous element is first element
                }
                temp.next = null;
            }
            Console.WriteLine("Last element is deleted successfully");
        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("List is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

    }
}
