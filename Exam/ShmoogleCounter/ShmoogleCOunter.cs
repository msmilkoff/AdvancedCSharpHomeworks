namespace ShmoogleCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class ShmoogleCounter
    {
        public static void Main()
        {
            var sourceCode = new StringBuilder();

            string lineOfCode = Console.ReadLine();

            while (lineOfCode != "//END_OF_CODE")
            {
                sourceCode.Append(lineOfCode);

                lineOfCode = Console.ReadLine();
            }

            var intVariableNames = new List<string>();
            var doubleVariableNames = new List<string>();

            string pattern = @"(int|double) ([a-z]+\w*)";

            MatchCollection matches = Regex.Matches(sourceCode.ToString(), pattern);

            foreach (Match match in matches)
            {
                if (match.Groups[1].Value == "int")
                {
                    intVariableNames.Add(match.Groups[2].Value);
                }
                else
                {
                    doubleVariableNames.Add(match.Groups[2].Value);
                }
            }

            doubleVariableNames.Sort();
            intVariableNames.Sort();

            var output = new StringBuilder();
            output.Append("Doubles: ");
            output.AppendLine(doubleVariableNames.Any() 
                ? $"{string.Join(", ", doubleVariableNames)}"
                : "None");

            output.Append("Ints: ");
            output.AppendLine(intVariableNames.Any() 
                ? $"{string.Join(", ", intVariableNames)}" 
                : "None");

            Console.WriteLine(output.ToString());
        }
    }
}
