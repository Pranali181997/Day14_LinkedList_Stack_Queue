using System;
using System.Collections.Generic;
using System.Text;

namespace Day14_Stach_and_Queue
{
    class Stack
    {
        public Node top;
        public void push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            
            Console.WriteLine("{0} push into stack", value);
        }

        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data+ "");
                temp = temp.next;
            }
        }

   public void peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty ");
                return;
            }
            Console.WriteLine("{0}is in the top of the stack " , this.top.data);
        }

        public void pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Satck is empty");
                return;
            }
            Console.WriteLine("Value pop is {0} ", this.top.data);
            this.top = this.top.next;
        }
        public void Isempty()
        {
            while (this.top != null)
            {
                peek();
                pop();
            }
        }

    }

}
  