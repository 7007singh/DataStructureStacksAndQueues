using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureStacksAndQueues
{
    internal class StackLinkedList
    {
        public Node top;
        
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                top = newNode;
                Console.WriteLine("{0} pushed to stack ", newNode.data);
            }
            else
            {
                newNode.next = top;
                top = newNode;
                Console.WriteLine("{0} pushed to stack ", newNode.data);
            }
        }
        public void Display()
        {
            Console.WriteLine("Displaying nodes");
            if (top == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
