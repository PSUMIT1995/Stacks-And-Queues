using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_And_Queues
{
    internal class LinkedListStack
    {

        public Node top;
        public LinkedListStack()
        {
            this.top = null;
        }

        /// Method to push element in the stack 
        public void Push(int value)
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
            Console.WriteLine(value + " pushed to stack");
        }

       
        /// Method to display stack
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        
        /// Returns the top element of stack without deleting it
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("\n" + this.top.data + " is in the top of the stack");
        }

        
        /// Delete the topmost element
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is " + this.top.data);
            this.top = this.top.next;
        }

       
        /// Check if the stack is empty
        public void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            Console.WriteLine("Stack is empty");
        }
    }
}