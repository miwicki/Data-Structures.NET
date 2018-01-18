using System;
using System.Collections;
using System.Collections.Generic;

namespace Trees
{
    //creating node class up here
    class Node
    {

        public Node left;
        public Node right;
        private char v;

        public Node(char v)
        {
            this.v = v;
        }



        //making actual tree and running tests down here
        class Program
        {
            static void Main(string[] args)
            {

                Node a = new Node('A');
                Node b = new Node('B');
                Node c = new Node('C');
                Node d = new Node('D');
                Node e = new Node('E');
                Node f = new Node('F');
                Node g = new Node('G');

                a.left = b;
                a.right = c;
                b.left = d;
                b.right = e;
                c.left = f;
                c.right = g;

                Console.WriteLine("PreOrder");
                Preorder(a);
                Console.WriteLine("---------");
                Console.WriteLine("InOrder");
                Inorder(a);
                Console.WriteLine("---------");
                Console.WriteLine("PostOrder");
                Postorder(a);
                Console.WriteLine("---------");
                Console.WriteLine("BreadthFirst");
                BreadthFirst(a);
                Console.WriteLine("---------");
                Console.ReadLine();

            }

            //Putting methods here so tests can read them
            public static void Preorder(Node Root)
            {
                if (Root != null)
                {
                    Console.Write(Root.v + " ");
                    Preorder(Root.left);
                    Preorder(Root.right);
                }
            }
            public static void Inorder(Node Root)
            {
                if (Root != null)
                {
                    Inorder(Root.left);
                    Console.Write(Root.v + " ");
                    Inorder(Root.right);
                }
            }
            public static void Postorder(Node Root)
            {
                if (Root != null)
                {
                    Postorder(Root.left);
                    Postorder(Root.right);
                    Console.Write(Root.v + " ");
                }
            }

            public static void BreadthFirst(Node Root)
            {

                Queue<Node> q = new Queue<Node>();
                Console.WriteLine(Root.v);
                if (Root.left != null) q.Enqueue(Root.left);
                if (Root.right != null) q.Enqueue(Root.right);

                if (q.Count > 0)
                {
                    BreadthFirst(q.Dequeue());
                }
            }
        }
    }
}

