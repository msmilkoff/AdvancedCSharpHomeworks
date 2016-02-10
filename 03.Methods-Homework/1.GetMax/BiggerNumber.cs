using System;

class BiggerNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        GetMax(firstNumber, secondNumber);
    }
    static int GetMax(int bigger, int lesser)
    {
        if (bigger < lesser)
        {
            bigger = lesser;
        }
        Console.WriteLine(bigger);
        return bigger;
    }
}

