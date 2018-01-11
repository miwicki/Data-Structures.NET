using System;
using System.Collections.Generic;
using System.Text;

namespace Queues
{
    public class Queue
    {
        public QueueNode Head;
        public QueueNode Tail;

        public void Enqueue(int n)
        {
            QueueNode newNode = new QueueNode { Value = n };

            if (Head == null)
            {
                Head = newNode;
                Tail = Head;
                return;
            }
            Tail.Next = newNode;
            Tail = newNode;
        }

        public QueueNode Dequeue()
        {
            QueueNode dequeuedNode = Head;
            Head = Head.Next;
            if (Head == null)
            {
                Tail = null;
            }
            return dequeuedNode;
        }

        public QueueNode Peek()
        {
            return Head;
        }
    }
}