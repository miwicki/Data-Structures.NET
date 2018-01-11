using System;
using System.Collections.Generic;
using System.Text;

namespace TwoStacksOneQueue
{
    public class TwoStacksOneQueue
    {
        public Stack<int> stack1 = null;
        public Stack<int> stack2 = null;

        public void Enqueue(int n)
        {
            stack1.Push(n);
        }

        public int Dequeue()
        {
            int tempDequeue = 0;

            if (stack2.Count == null)
            {
                while (stack1.Count != null)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            if (stack2.Count != null)
            {
                tempDequeue = stack2.Pop();
            }

            return tempDequeue;
        }
    }
}