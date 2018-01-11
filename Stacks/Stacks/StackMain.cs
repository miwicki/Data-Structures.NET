using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    class StackMain
    {
        public static void Main(string[] args)
        {
            Stack s = new Stack();

            StackNode tempNode = null;

            s.Push(5);
            s.Push(6);
            s.Push(7);

            tempNode = s.Peek();

            Console.WriteLine("Expected value is 7, Actual value is " + tempNode.Value);

            s.Pop();

            tempNode = s.Peek();

            Console.WriteLine("Expected value is 6, Actual value is " + tempNode.Value);

            Console.ReadLine();
        }
    }
}