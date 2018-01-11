using System;
using System.Collections.Generic;
using System.Text;

namespace Queues
{
    class QueueMain
    {
        public static void Main(string[] args)
        {
            Queue que = new Queue();

            que.Enqueue(5);
            que.Enqueue(7);
            que.Enqueue(13);

            QueueNode temp = que.Dequeue();
            Console.WriteLine(temp.Value);

            temp = que.Dequeue();
            Console.WriteLine(temp.Value);

            temp = que.Peek();
            Console.WriteLine(temp.Value);

            Console.ReadLine();
        }
    }
}