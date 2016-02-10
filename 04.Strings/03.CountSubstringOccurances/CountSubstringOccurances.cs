using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CountSubstringOccurances
{
    static void Main()
    {
        string text = Console.ReadLine().ToLower();
        string search = Console.ReadLine().ToLower();

        int countOccurances = text.Split(new[] {search}, StringSplitOptions.None).Length-1;
        Console.WriteLine(countOccurances);
    }
}

