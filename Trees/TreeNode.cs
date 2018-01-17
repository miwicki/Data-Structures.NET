using System;

public class Class1
{
    class Node
    {
        public int item;
        public Node left;
        public Node right;
        public void display()
        {
            Console.Write("[");
            Console.Write(item);
            Console.Write("]");
        }
    }
}
