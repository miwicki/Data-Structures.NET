using System;
using System.Collections.Generic;
using System.Text;

namespace TwoStacksOneQueue
{
    public class TwoStacksOneQueueMain
    {
        public void Main(string[] args)
        {
            TwoStacksOneQueue Q = new TwoStacksOneQueue();

            Q.Enqueue(5);
            Q.Enqueue(55);
            Q.Enqueue(555);


            int result = Q.Dequeue();
            Console.WriteLine(result);
        }
    }
}
