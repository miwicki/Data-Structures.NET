using System;
using System.Collections.Generic;
using System.Text;

namespace TwoStacksOneQueue
{
    public class TwoStacksOneQueueMain
    {
        public void Main(string[] args)
        {
            QueueUsingTwoStacks q = new QueueUsingTwoStacks();

            q.Enqueue(5);
            q.Enqueue(500);
            q.Enqueue(55);

            int result = q.Dequeue();
            Console.WriteLine(result);
        }
    }
}
