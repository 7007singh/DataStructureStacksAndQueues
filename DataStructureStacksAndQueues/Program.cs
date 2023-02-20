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
            StackLinkedList pushElement = new StackLinkedList();
            pushElement.Push(56);
            pushElement.Push(30);
            pushElement.Push(70);
            pushElement.Display();
            Console.ReadLine();
        }
    }
}
