using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MatrixShuffling
{
    static void Main()
    {
        Console.Write("Enter matrix dimensons: ");
        int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows = dimentions[0];
        int cols = dimentions[1];
        if (dimentions.Length != 2)
        {
            Console.WriteLine("Invalid input: You must enter 2 dimensions");
            return;
        }

        // Reading the matrix row by row.
        string[,] matrix = new string[rows,cols];
        for (int row = 0; row < rows; row++)
        {
            string[] line = Console.ReadLine().Split().ToArray();

            if (line.Length > cols)
            {
                throw new FormatException("Invalid input");
            }

            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = line[col];
            }
        }
        PrintMatrix(matrix);

        //Swapping logic.
        string[] commands = new string[5];
        while (commands.Length != 1 && commands[0] != "END")
        {
            commands = Console.ReadLine().Split().ToArray();
            if (commands.Length == 5 && commands[0] == "swap")
            {
                int x1 = int.Parse(commands[1]);
                int y1 = int.Parse(commands[2]);
                int x2 = int.Parse(commands[3]);
                int y2 = int.Parse(commands[4]);

                string temp = matrix[x1, y1];
                matrix[x1, y1] = matrix[x2, y2];
                matrix[x2, y2] = temp;

                PrintMatrix(matrix);
                
                
            }
            else if (commands[0] == "END")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                return;
            }
           
        }
    }

    //Printing Method.
    static void PrintMatrix(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(" " + matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
    


