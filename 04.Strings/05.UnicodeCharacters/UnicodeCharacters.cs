using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        foreach (char character in input)
        {
            sb.Append("/u");
            sb.Append(String.Format("{0:x4}", (int)character));
        }
        Console.WriteLine(sb.ToString());
    }
}