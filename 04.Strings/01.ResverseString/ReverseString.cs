using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] reversed = input.ToCharArray();
        Array.Reverse(reversed);
        reversed.ToString();
        Console.WriteLine(reversed);
    }
}

