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
        public char v;

        public Node(char v)
        {
            this.v = v;
        }
    }

    class Tree
    {
        Queue<Node> q = new Queue<Node>();
        public void BreadthFirst(Node Root)
        {

            if (Root != null)
            {
                Console.Write(Root.v + " ");
                if (Root.left != null) q.Enqueue(Root.left);
                if (Root.right != null) q.Enqueue(Root.right);

                if (q.Count > 0)
                {
                    BreadthFirst(q.Dequeue());
                }
            }
        }

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


            //Preorder Expected: A B D E C F G
            Console.WriteLine("PreOrder");
            Preorder(a);
            Console.WriteLine("");

            //InOrder Expected: D B E A F C G
            Console.WriteLine("InOrder");
            Inorder(a);
            Console.WriteLine("");

            //PostOreder Expected: D E B F G C A
            Console.WriteLine("PostOrder");
            Postorder(a);
            Console.WriteLine("");

            //BreadthFirst Expected: A B C D E F G
            Console.WriteLine("BreadthFirst");
            Tree myTree = new Tree();
            myTree.BreadthFirst(a);
            Console.WriteLine("");
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


    }

}

