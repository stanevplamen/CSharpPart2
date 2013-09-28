using System;

class PrintMatrix
{
    static void Main()
    {
        Console.Write("Please enter the size of the matrix (n,n); n = ");
        int matrixSize = int.Parse(Console.ReadLine());
        int rows = matrixSize;
        int columns = matrixSize;
        int[,] matrix = new int[rows, columns];
        int counter = 0;
        int direction = 1;
        int currentRow = 0;
        int currentCol = -1;

        int row = 0;
        int col = 0;
        int loop = 0;

        while (counter <= matrixSize * matrixSize)
        {
            if (direction == 1)
            {
                for (col = currentCol + 1; col < matrix.GetLength(1) - loop; col++)
                {
                    row = currentRow;
                    counter++;
                    matrix[col, row] = counter;
                }
                currentCol = col - 1;
                direction = 2;
            }
            if (counter == matrixSize * matrixSize)
            {
                break;
            }
            if (direction == 2)
            {
                for (row = currentRow + 1; row < matrix.GetLength(0) - loop; row++)
                {
                    col = currentCol;
                    counter++;
                    matrix[col, row] = counter;
                }
                currentRow = row - 1;
                direction = 3;
            }
            if (counter == matrixSize * matrixSize)
            {
                break;
            }

            if (direction == 3)
            {
                for (col = currentCol - 1; col >= 0 + loop; col--)
                {
                    counter++;
                    row = currentRow;
                    matrix[col, row] = counter;
                }
                currentCol = col + 1;
                direction = 4;
            }
            if (counter == matrixSize * matrixSize)
            {
                break;
            }

            if (direction == 4)
            {
                for (row = currentRow - 1; row > 0 + loop; row--)
                {
                    col = currentCol;
                    counter++;
                    matrix[col, row] = counter;
                }
                currentRow = row + 1;
                direction = 1;
            }
            loop++;
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

