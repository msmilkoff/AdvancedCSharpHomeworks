using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SequenceInMatrix
{
    static void Main()
    {
        Console.Write("Enter the number of the rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of the columns: ");
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];

        Console.WriteLine("Enter the cells of the matrix:");
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("matrix[{0},{1}] = ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }

        string longestSequenceString = matrix[0, 0];
        int countMax = 0;
        int currentCount = 0;

        //rows
        for (int r = 0; r < rows; r++)
        {

            for (int c = 0; c < cols - 1; c++)
            {
                if (matrix[r, c] == matrix[r, c + 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (currentCount > countMax)
                {
                    longestSequenceString = matrix[r, c];
                    countMax = currentCount;
                }
            }
            currentCount = 1;
        }

        //cols
        for (int col = 0; col < cols; col++)
        {
            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (currentCount > countMax)
                {
                    longestSequenceString = matrix[row, col];
                    countMax = currentCount;
                }
            }
            currentCount = 1;
        }
        //diagonal
        for (int row = 0, col = 0; row < rows - 1 && col < cols - 1; row++, col++)
        {
            if ((matrix[row, col] == matrix[row + 1, col + 1]))
            {
                currentCount++;
            }
            else
            {
                currentCount = 1;
            }
            if (currentCount > countMax)
            {
                countMax = currentCount;
                longestSequenceString = matrix[row, col];
            }
        }
        currentCount = 1;

        string output = "";
        for (int w = 0; w <= countMax; w++)
        {
            output += longestSequenceString + ", ";
        }
        output = output.TrimEnd(' ').TrimEnd(',');
        Console.WriteLine(output);
    }
}

