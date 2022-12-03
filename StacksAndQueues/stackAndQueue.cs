using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class stackAndQueue
    {
        Node top;
        public stackAndQueue()
        {
            this.top = null;
        }
        public void Push(int data)
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
            Console.WriteLine("{0} is pushed to stack ", data);
        }
        internal void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + "\n");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        internal void Pop()
        {
            if (top == null)
            {
                Console.WriteLine(" Deletion is not possible");
                return;
            }
            Console.WriteLine("{0} is deleted from stack", top.data);
            top = top.next;
        }
        internal void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Console.WriteLine("{0} is on the top of the stack", top.data);
        }
    }
}
