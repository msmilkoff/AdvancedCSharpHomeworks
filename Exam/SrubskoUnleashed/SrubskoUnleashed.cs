namespace SrubskoUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class SrubskoUnleashed
    {
        public static void Main()
        {
            var venues = new Dictionary<string, Dictionary<string, int>>();

            string pattern = @"(.+) @(.+) (\d+) (\d+)";

            string line = Console.ReadLine();

            while (line != "End")
            {
                bool isValidInput = Regex.IsMatch(line, pattern);

                if (!isValidInput)
                {
                    line = Console.ReadLine();
                    continue;
                }

                Match match = Regex.Match(line, pattern);

                string singerName = match.Groups[1].ToString();
                string venueName = match.Groups[2].ToString();
                int ticketPrice = int.Parse(match.Groups[3].ToString());
                int ticketCount = int.Parse(match.Groups[4].ToString());

                int totalMoney = ticketPrice * ticketCount;

                AddVenue(venues, venueName, singerName, totalMoney);

                line = Console.ReadLine();
            }

            var output = new StringBuilder();

            foreach (var venue in venues)
            {
                output.AppendLine(venue.Key);

                var sortedVenues = SortDictionary(venue);

                foreach (var singer in sortedVenues)
                {
                    output.AppendLine($"#  {singer.Key} -> {singer.Value}");
                }
            }

            Console.WriteLine(output.ToString());
        }

        private static Dictionary<string, int> SortDictionary(KeyValuePair<string, Dictionary<string, int>> data)
        {
            var sortedData = data.Value
                .OrderByDescending(v => v.Value)
                .ToDictionary(v => v.Key, v => v.Value);

            return sortedData;
        }

        private static void AddVenue(
            Dictionary<string, Dictionary<string, int>> venues,
            string venueName,
            string singerName,
            int totalMoney)
        {
            if (!venues.ContainsKey(venueName))
            {
                venues.Add(venueName, new Dictionary<string, int>());
            }

            if (!venues[venueName].ContainsKey(singerName))
            {
                venues[venueName].Add(singerName, totalMoney);
            }
            else
            {
                venues[venueName][singerName] += totalMoney;
            }
        }
    }
}
