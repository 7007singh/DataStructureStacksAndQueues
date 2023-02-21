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
            StackLinkedList stack = new StackLinkedList();
            stack.Push(56);
            stack.Push(30);
            stack.Push(70);
            stack.Display();
            while(stack.top != null)
            {
                stack.Peek();
                stack.Pop();
            }            
            Console.ReadLine();
        }
    }
}
