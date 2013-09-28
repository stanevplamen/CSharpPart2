using System;

class MaxPlatformSum
{
    static void Main()
    {
        Console.Write("Please enter the number of rows; r = ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number of columns; c = ");
        int columns = int.Parse(Console.ReadLine());
        int matrixSize = rows * columns;
        int[,] matrix = new int[rows, columns];
        int counter = 0;
        int bestSum = int.MinValue;
        int bestRow = -1;
        int bestCol = -1;

        // the declaration is with the counter
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                counter++;
                matrix[row, col] = counter; // int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("The matrix is: ");
        PrintArray(matrix);

        // search for the max platform
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        // print the platform
        Console.WriteLine("The best platform is: ");
        Console.WriteLine("   {0} {1} {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
        Console.WriteLine("   {0} {1} {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine("   {0} {1} {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
        Console.WriteLine();
        Console.WriteLine("The maximal sum is: {0}", bestSum);

    }

    private static void PrintArray(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}