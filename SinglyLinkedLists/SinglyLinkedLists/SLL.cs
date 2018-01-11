using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges.Week_02
{
    public class SLL
    {
        public SLLNode Head = null;

       
        public void AddFirst(int value)
        {
            SLLNode newNode = new SLLNode { Value = value };
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            newNode.Next = Head;
            Head = newNode;
            return;
        }

        public void AddLast(int value)
        {
            SLLNode newNode = new SLLNode();
            newNode.Value = value;
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            SLLNode current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void AddBefore(int value, int targetedValue)
        {
            if (Head == null)
            {
                Console.WriteLine("Head is null");
                return;
            }

            SLLNode newNode = new SLLNode();
            newNode.Value = value;

            if (Head.Value == targetedValue)
            {
                newNode.Next = Head;
                Head = newNode;
                return;
            }

            if(Head.Next != null)
            {
                SLLNode current = Head.Next;
                SLLNode previous = Head;
                while(current != null)
                {
                    if(current.Value == targetedValue)
                    {
                        previous.Next = newNode;
                        newNode.Next = current;
                        return;
                    }
                    current = current.Next;
                    previous = previous.Next;
                }
                Console.WriteLine("Targeted value is not found!");
            }
        }

        public void AddAfter(int value, int targetedValue)
        {
            if (Head == null)
            {
                Console.WriteLine("Head is null");
                return;
            }

            SLLNode newNode = new SLLNode();
            newNode.Value = value;

            if (Head.Value == targetedValue)
            {
                newNode.Next = Head;
                Head = newNode;
                return;
            }

            if (Head.Next != null)
            {
                SLLNode current = Head.Next;
                SLLNode previous = Head;
                while (previous != null)
                {
                    if (previous.Value == targetedValue)
                    {
                        previous.Next = newNode;
                        newNode.Next = current;
                        return;
                    }
                    current = current.Next;
                    previous = previous.Next;
                }
            }
            Console.WriteLine("Targeted value is not found!");
        }

        public void RemoveNode(int targetedValue)
        {
            if(Head == null)
            {
                Console.WriteLine("Head is not found");
                return;
            }

            if(Head.Value == targetedValue)
            {
                Head = Head.Next;
                return;
            }
            if(Head.Next != null)
            {
                SLLNode current = Head.Next;
                SLLNode prev = Head;
                while(current != null)
                {
                    if(current.Value == targetedValue)
                    {
                        SLLNode temp = current.Next;
                        current = null;
                        prev.Next = temp;
                        return;
                    }
                    current = current.Next;
                    prev = prev.Next;
                }
            }
            Console.WriteLine("Targeted value is not found!");
        }

        public SLLNode GetMiddle()
        {
            if (Head == null) return Head;

            SLLNode walker = Head;
            SLLNode runner = Head;

            while (runner.Next != null)
            {
                runner = runner.Next;
                if (runner.Next != null)
                {
                    runner = runner.Next;
                    walker = walker.Next;
                }
            }
            return walker;
        }

        public SLLNode GetNodeFromEnd(int nth)
        {
            if (Head == null) return null;

            SLLNode walker = Head;
            SLLNode sleeper = Head;

            int count = 0;
            while (walker != null)
            {
                walker = walker.Next;
                if (count == nth)
                {
                    sleeper = sleeper.Next;
                    nth++;
                }
                count++;
            }
            return sleeper; 
        }
    }
}