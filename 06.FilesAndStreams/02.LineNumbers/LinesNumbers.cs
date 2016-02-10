using System;
using System.IO;

class LinesNumbers
{
    static void Main()
    {
        using (var reader = new StreamReader("text.txt"))
        {
            using (var writer = new StreamWriter("another-text.txt"))
            {
                int lineNumber = 1;
                string line = reader.ReadLine();
                while(line != null)
                {
                    line = String.Format("{0}. {1}", lineNumber, line);
                    writer.WriteLine(line);
                    lineNumber++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
