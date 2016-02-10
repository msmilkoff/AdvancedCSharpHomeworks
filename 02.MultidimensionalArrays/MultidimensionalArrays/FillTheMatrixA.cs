using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FillTheMatrixA
{
    static void Main()
    {
        Console.Write("Matrix size = ");
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];

        int temp = 1;
        for (int col = 0; col < size; col++)
        {
            for (int row = 0; row < size; row++)
            {
                    matrix[row, col] = temp;
                    temp++;
            }
        }

        PrintMatrix(matrix);
    }
    static void PrintMatrix(int[,] matrix) 
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
    
}

