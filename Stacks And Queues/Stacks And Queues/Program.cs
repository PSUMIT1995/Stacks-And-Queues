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
            // Creating object
            LinkedListStack my_Stack = new LinkedListStack();
            my_Stack.Push(70);
            my_Stack.Push(30);
            my_Stack.Push(56);
            my_Stack.Display();
            my_Stack.IsEmpty();
            my_Stack.Display();
        }
    }
}
