using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Palindromes
{
    static void Main()
    {
        var text = Console.ReadLine()
            .Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        List<string> palindromes = new List<string>();
        for (int i = 0; i < text.Length; i++)
        {
            if (IsPalindrome(text[i]))
            {
                palindromes.Add(text[i]);
                
            }
        }
        palindromes.Sort();
        var uniquePalindromes = new HashSet<string>(palindromes);
        Console.Write(string.Join(", ", uniquePalindromes));
        Console.WriteLine();
    }
    static bool IsPalindrome(string word)
    {
        int leftIndex = 0;
        int rightIndex = word.Length - 1;
        while (true)
        {
            if (leftIndex > rightIndex)
            {
                return true;
            }

            char leftChar = word[leftIndex];
            char rightChar = word[rightIndex];
            if (leftChar != rightChar)
            {
                return false;
            }
            leftIndex++;
            rightIndex--;
        }
        
    }
}
