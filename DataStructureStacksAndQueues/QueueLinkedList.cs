using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureStacksAndQueues
{
    internal class QueueLinkedList
    {
        public Node front;
        public Node rear;
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (rear == null)
            {
               front = rear = newNode;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
            Console.WriteLine("{0} inserted into Queue", data);
        }
        public void Display()
        {
            Console.WriteLine("Displaying nodes");
            if (front == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else
            {
                Node temp = front;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
