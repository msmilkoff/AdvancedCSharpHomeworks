using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SortArrayOfNumbers
    {
        static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            Array.Sort(arr);
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }

