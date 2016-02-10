using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class StringLength
{
    static void Main()
    {
        string constrainedString = Console.ReadLine();
        char[] charArray = constrainedString.ToCharArray();
        if (charArray.Length >= 20)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.Write(charArray[i]);
            }
            Console.WriteLine();
        }
        else
        {
            int differenceInLength = 20 - constrainedString.Length;
            Console.WriteLine(constrainedString + new string('*', differenceInLength));
        }
    }
}
