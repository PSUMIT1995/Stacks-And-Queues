using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_And_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pushing values to Stack");
            LinkedListStack mystack = new LinkedListStack();
            mystack.Push(70);
            mystack.Push(30);
            mystack.Push(56);
            mystack.Display();

        }
    }
}