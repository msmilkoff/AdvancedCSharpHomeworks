using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class MinMaxAvg
{
    static void Main()
    {
        double[] original = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToArray();

        List<double> roundNumbers = new List<double>();
        List<double> floatNumbers = new List<double>();

        for (int i = 0; i < original.Length; i++)
        {
            if (original[i] % 1 == 0)
            {
                roundNumbers.Add(original[i]);
            }
            else
            {
                floatNumbers.Add(original[i]);
            }
        }

        Console.WriteLine();
        Console.WriteLine("[{0:F2}] -> min {1:F2}, max {2:F2}, sum {3:F2}, avg {4:F2}", 
            String.Join(", ", floatNumbers),
            floatNumbers.Min(),
            floatNumbers.Max(),
            floatNumbers.Sum(),
            floatNumbers.Average());

        Console.WriteLine();

        Console.WriteLine("[{0:F2}] -> min {1:F0}, max {2:F0}, sum {3:F0}, avg {4:F0}",
            String.Join(", ", roundNumbers),
            roundNumbers.Min(),
            roundNumbers.Max(),
            roundNumbers.Sum(),
            roundNumbers.Average());

        //foreach (var item in roundNumbers)
        //{
        //    Console.Write(item);
        //}
        //Console.WriteLine();

        //foreach (var num in floatNumbers)
        //{
        //    Console.Write(num);
        //}
        //Console.WriteLine();
    }
}

