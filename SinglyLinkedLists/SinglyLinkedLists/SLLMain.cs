using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkedLists
{
    class SLLMain
    {
        static void Main(string[] args)
        {
            SLL sll = new SLL();
            
            Console.WriteLine("Add First");
            sll.AddFirst(2);
            sll.AddFirst(6);
            PrintLinked(sll.Head);

            Console.WriteLine("Add Last");
            sll.AddLast(4);
            sll.AddLast(7);
            PrintLinked(sll.Head);

            Console.WriteLine("Add before");
            sll.AddBefore(5, 9);
            PrintLinked(sll.Head);

            Console.WriteLine("Add After");
            sll.AddAfter(5, 9);
            PrintLinked(sll.Head);

            Console.WriteLine("Remove");
            sll.RemoveNode(4);
            PrintLinked(sll.Head);

            Console.WriteLine("Find Middle");
            SLLNode middle = sll.GetMiddle();
            Console.WriteLine(middle.Value);

            Console.WriteLine("Find 3rd from end");
            SLLNode nth = sll.GetNodeFromEnd(3);
            Console.WriteLine(nth.Value);

            Console.ReadLine();
        }

         static void PrintLinked(SLLNode node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
