using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TextFilter
{
    static void Main()
    {
        string[] bannedWords = Console.ReadLine().Split(',').Select(p => p.Trim()).ToArray();
        string input = Console.ReadLine();
        StringBuilder text = new StringBuilder(input);
        Console.WriteLine();

        foreach (string bannedWord in bannedWords)
        {
            string mask = new string('*', bannedWord.Length);
            text.Replace(bannedWord, mask);
        }

        Console.WriteLine(text.ToString());
        Console.WriteLine();
    }
}

