using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class SelectionSort
{
    static void Main()
    {
        int[] array = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int tmp;
        int min;

        for (int j = 0; j < array.Length - 1; j++)
        {
            min = j;

            for (int k = j + 1; k < array.Length; k++)
            {
                if (array[k] < array[min])
                {
                    min = k;
                }
            }

            tmp = array[min];
            array[min] = array[j];
            array[j] = tmp;
        }
        foreach (var num in array)
        {
            Console.WriteLine(num);
        }
    }
}


