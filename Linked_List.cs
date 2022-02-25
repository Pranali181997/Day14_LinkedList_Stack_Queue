using System;
using System.Collections.Generic;
using System.Text;

namespace LinkList
{
    class UC_1_LinkList
    {
        public Node Head;
        public void Add(int data)
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
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        public void Display()
        {
            Node temp = this.Head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

        public void Insert(int position, int data)
        {

            Node newestNode = new Node(data);
            if (this.Head == null)
            {
                this.Head = newestNode;
            }
            if (position == 0)
            {
                newestNode.next = this.Head;
                this.Head = newestNode;
            }
            Node prev = null;
            Node current = this.Head;
            int count = 0;

            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestNode.next = prev.next;
            prev.next = newestNode;
        }
        public Node RemoveLastNode()
        {
            if (Head == null)
            {
                return null;
            }
            if (Head.next == null)
            {
                return null;
            }
            Node NewNode = Head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
            return Head;

        }
        public Node RemoveFirsttNode()
        {
            if (Head == null)
            {
                return null;
            }
            if (this.Head == null)
            {
                return null;
            }
            this.Head = this.Head.next;
            return this.Head;

        }
        public int Search(int value)
        {
            Node node = this.Head;
            int count = 0;
            while (node != null)
            {

                if (node.data == value)
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }

        public Node InsertAtParticularPosition(int position, int data)
        {
            Node newestNode = new Node(data);
            if (this.Head == null)
            {
                return newestNode;
            }
            if (position == 0)
            {
                newestNode.next = this.Head;
                this.Head = newestNode;
                return this.Head;
            }
            Node prev = null;
            Node current = this.Head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestNode.next = prev.next;
            prev.next = newestNode;
            return this.Head;
        }
        public void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.Head == null)
            {
                this.Head = newNode;
            }
            else
            {
                Node temp = this.Head;
                Head = newNode;
                Head.next = temp;
            }
        }
        internal void DeleteNodeAtParticularPosition(int position)
        {
            if (this.Head == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            Node temp = this.Head;
            if (position == 0)
            {
                this.Head = temp.next;
                return;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;

            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node next = temp.next.next;
            temp.next = next;
            Size();
        }
        internal void Size()
        {
            Node temp = this.Head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
                count++;
            }
            Console.WriteLine("\nLength of LinkedList is :-" + " " + count);
        }
    }
}




