using System;

class LargerThanNeighbours
{
    static void Main()
    {
        int[] numbers = {1, 3, 4, 5, 1, 0, 5};
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
        }
    }
    static bool IsLargerThanNeighbours(int[] arr, int i)
    {
        bool isLarger = false;
        if (i == 0)
        {
            isLarger = arr[i] > arr[i+1];
        }
        else if (i > 0 && i < arr.Length -1)
        {
            isLarger = (arr[i] > arr[i + 1] && arr[i] > arr[i - 1]);
        }
        else
        {
            isLarger = arr[i] > arr[i - 1];
        }
        return isLarger;
    }
}

