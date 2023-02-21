using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureStacksAndQueues
{
    internal class StackLinkedList
    {
        public Node top;

        internal void Push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
            Console.WriteLine("{0} pushed", data);
        }
        internal void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty. please add node to pop");
                return;
            }

            Console.WriteLine("{0} poped", top.data);
            top = top.next;
        }
        internal void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty. Please add node to peek");
                return;
            }
            Console.WriteLine("\n{0} is on the top of Stack", this.top.data);
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
