using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureStacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose any program to execute\n1.Stack operations\n2.Queue operations");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    StackLinkedList stack = new StackLinkedList();
                    stack.Push(56);
                    stack.Push(30);
                    stack.Push(70);
                    stack.Display();
                    while (stack.top != null)
                    {
                        stack.Peek();
                        stack.Pop();
                    }
                    break;
                case 2:
                    QueueLinkedList queue = new QueueLinkedList();
                    queue.Enqueue(56);
                    queue.Enqueue(30);
                    queue.Enqueue(70);
                    queue.Display();
                    queue.Dequeue();
                    break;
            }  
            Console.ReadLine();
        }
    }
}
