using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

class WordsCount
{
    static void Main()
    {
        var matches = new Dictionary<string, int>();
        var keyWords = new List<string>();

        string words = "words.txt";
        string text = "text.txt";
        string result = "result.txt";

        using (var reader = new StreamReader(words))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                keyWords.Add(line);
            }
        }

        using (var reader = new StreamReader(text))
        {
            using (var writer = new StreamWriter(result))
            {
                string textContent = reader.ReadToEnd();
                foreach (var keyWord in keyWords)
                {
                    var regex = new Regex(@"\b" + keyWord + @"\b", RegexOptions.IgnoreCase);
                    matches[keyWord] = regex.Matches(textContent).Count;
                }
                var sortedMatches = matches.OrderByDescending(p => p.Value);
                foreach (var match in sortedMatches)
                {
                    writer.WriteLine("{0} - {1}", match.Key, match.Value);
                }
            }
        }

    }
}
