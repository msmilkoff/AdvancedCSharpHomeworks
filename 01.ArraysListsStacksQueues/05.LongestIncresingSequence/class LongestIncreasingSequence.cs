using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split()
            .Select(int.Parse)
            .ToArray();

        int counter = 1;
        int maxLength = 1;
        int endElement = 0;

        Console.Write("{0} ", input[0]);
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] > input[i - 1])
            {
                Console.Write("{0} ", input[i]);
                counter++;
            }
            else
            {
                counter = 1;
                Console.WriteLine();
                Console.Write("{0} ", input[i]);
            }
            if (counter > maxLength)
            {
                maxLength = counter;
                endElement = i;
            }
        }
        Console.WriteLine();
        Console.Write("Longest: ");
        for (int j = endElement - maxLength + 1; j <= endElement; j++)
        {
            Console.Write("{0} ", input[j]);
        }
        Console.WriteLine();
    }
}

