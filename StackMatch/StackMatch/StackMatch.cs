using System;
using System.Collections.Generic;
using System.Text;

namespace StackMatch
{
    public class Stack
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Should be true");
         Console.WriteLine(Match("{{{((()))}}}"));
         Console.ReadLine();

            Console.WriteLine("Should be false");
        Console.WriteLine(Match("{{{(({)))}}}"));
        Console.ReadLine();

        }


        public static bool Match(string string1)
         {

            Stack<char> stack = new Stack<char>();
            string string2 = "";

            for (int i = 0; i<string1.Length; i++) stack.Push(string1[i]);
             
            while(stack.Count != 0) string2 += stack.Pop();

            for (int i = 0; i<string1.Length/2; i++)
             {
                if (string1[i] == '(' && string2[i] != ')') return false;

                if (string1[i] == '{' && string2[i] != '}') return false;
             }

             return true;   
                
         }
          
    }
}