using System;
using System.Collections.Generic;
using System.Linq;

class SequenceOfEqualStrings
{
    static void Main()
    {
        string[] input = Console.ReadLine()
            .Split(' ')
            .ToArray();

        int count = 0;
        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == input[i+1])
            {
                Console.Write(input[i] + " ");
            }
            else
            {
                Console.WriteLine(input[i] + " ");
            }
            count = i;
        }
        Console.WriteLine(input[count + 1]);
    }
}

