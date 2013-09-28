using System;

class MatrixB
{
    static void Main()
    {
        Console.Write("Please enter the size of the matrix (n,n); n = ");
        int matrixSize = int.Parse(Console.ReadLine());
        int rows = matrixSize;
        int columns = matrixSize;
        int[,] matrix = new int[rows, columns];
        int counter = 0;

        counter = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int evenCheck = row & 1;
            if (evenCheck == 0)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    counter++;
                    matrix[col, row] = counter;
                }
            }
            else if (evenCheck == 1)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    counter++;
                    matrix[col, row] = counter;
                }
            }
        }
        PrintArray(matrix);
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

