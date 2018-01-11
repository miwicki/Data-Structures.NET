using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedLists
{
    class DLLMain
    {
        public static void Main(string[] args)
        {
            DLL dll = new DLL();
            Console.WriteLine("Add First");
            dll.AddFirst(4);
            dll.AddFirst(6);
            PrintLinked(dll.Head);

            Console.WriteLine("Add Last");
            dll.AddLast(4);
            dll.AddLast(6);
            PrintLinked(dll.Head);

            Console.WriteLine("Add 5 Before 3");
            dll.AddBefore(5, 3);
            PrintLinked(dll.Head);

            Console.WriteLine("Add 5 After 3");
            dll.AddAfter(5, 3);
            PrintLinked(dll.Head);

            Console.WriteLine("Remove 5");
            dll.Remove(5);
            PrintLinked(dll.Head);

            Console.ReadLine();
        }

        static void PrintLinked(DLLNode node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Val);
                node = node.Next;
            }
        }
     
    }
}