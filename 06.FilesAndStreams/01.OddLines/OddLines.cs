using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        using (var readOddLines = new StreamReader("lines.txt"))
        {
            int lineNumber = 1;
            string line = readOddLines.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine(line);
                }

                lineNumber++;
                line = readOddLines.ReadLine();
            }
        }
    }
}
