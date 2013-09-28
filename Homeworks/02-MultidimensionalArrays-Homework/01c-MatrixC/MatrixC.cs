using System;

class MatrixC
{
    static void Main()
    {
        Console.Write("Please enter the size of the matrix (n,n); n = ");
        int matrixSize = int.Parse(Console.ReadLine());
        int rows = matrixSize;
        int columns = matrixSize;
        int[,] matrix = new int[rows, columns];
        int counter = 0;

        int counterColumn = 2;
        int print = -1;
        counter = 0;
        bool start = true;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            counterColumn--;
            if (start == true)
            {
                for (int col = matrix.GetLength(1) - 1; col >= -1; col--)
                {
                    if (print <= 0)
                    {
                        counter++;
                        matrix[col, row] = counter;
                        print++;
                    }
                    else if (col < matrix.GetLength(1) - 2 && row < matrix.GetLength(0) - 1)
                    {
                        for (int i = 0; i < counterColumn; i++)
                        {
                            counter++;
                            matrix[col + 2 + i, row + 1 + i] = counter;
                        }
                        print = 0;
                        if (col == -1)
                        {
                            start = false;
                            break;
                        }
                        col++;
                        counterColumn++;
                    }
                }
            }

            else if (start == false)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (print <= 0)
                    {
                        counter++;
                        matrix[col, row] = counter;
                        print++;
                        if (counter == matrixSize * matrixSize)
                        {
                            break;
                        }
                    }
                    else if (col < matrix.GetLength(1) && row < matrix.GetLength(0) - 1)
                    {
                        for (int i = 0; i < counterColumn; i++)
                        {
                            counter++;
                            matrix[col + i, row + 1 + i] = counter;
                        }
                        print = 0;
                        if (col == 1)
                        {
                            start = false;
                            break;
                        }
                        col--;
                        counterColumn--;
                    }
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

