using System;

namespace Day14_Stach_and_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the stack programs");


            Stack stack = new Stack();
            stack.push(70);
            stack.push(30);
            stack.push(56);
            stack.Display();
            stack.peek();
            stack.pop();
            Console.WriteLine("After poped the stack becomes ");
            stack.Display();

            stack.Isempty();
            stack.Display();

            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();

            queue.dequeue();
            queue.dequeue();
            queue.dequeue();
            queue.Display();


        }
    }
}
