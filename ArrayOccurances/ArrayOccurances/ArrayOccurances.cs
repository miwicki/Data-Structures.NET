using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace ArrayOccurences
{
    class OccurancesCount
    {
        static void Main(string[] args)
        {
            int[] numArray = { 1, 4, 4, 4, 4, 5, 6, 6, 6, 9, 9, 12, 1, 1, 4 };
            OccurancesAllEdgeCases(numArray);
            Console.ReadLine();
        }

        static void PrintOccurances(int[] input)
        {
            int counter = 1;
            int prev, curr;
            prev = input[0];
            curr = input[1];

            int index = 1;
            while (index < input.Length -1)
            {
                if (curr != prev)
                {
                    Console.WriteLine($"{prev}:{counter} occurances");
                    counter = 0;
                }
                counter++;
                prev = curr;
                curr = input[++index];
            }
            Console.WriteLine($"{prev}:{++counter} occurances");
        }

        
    }
}