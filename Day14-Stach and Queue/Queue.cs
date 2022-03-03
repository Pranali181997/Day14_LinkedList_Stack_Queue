using System;
using System.Collections.Generic;
using System.Text;

namespace Day14_Stach_and_Queue
{
    class Queue
    {
        public Node Head;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (this.Head == null)
            {
                this.Head = node;
            }
            else
            {
                Node temp = Head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Queue", node.data);
        }

        public void Display()
        {
            Node temp = this.Head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        public void dequeue()
        {
            if (this.Head == null)
            {
                Console.WriteLine("Satck is empty");
                return;
            }
            Console.WriteLine("Value dequeue is {0} ", this.Head.data);
            this.Head = this.Head.next;
        }
    }

}
