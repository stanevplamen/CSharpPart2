using System;
using System.IO;

class MatrixWriteAndRead
{
    /// <summary>
    /// First enter the matrix size: N
    /// On the next N rows enter N numbers separated with spaces
    /// The program writes a text file with the matrix and calculates the max platform 2/2
    /// </summary>
    static void Main()
    {
        // 1. read the size of the matrix
        Console.Write("Please enter the size of the square matrix [n,n], n = ");
        int n = int.Parse(Console.ReadLine());

        // 2. making the matrix
        int[,] matrix = LoadMatrix(n);

        // 3. Writing the matrix on the txt file
        PrintMatrixToFile(matrix);

        // 4. Reading the matrix from the txt file
        int[,] matrixFromFile = MatrixFromText(n);

        // 5. Max platform 2/2 sum calculation
        int maxSum = MaxSumCalc(matrixFromFile);

        // 6. Writing max sum to a txt file
        IntegerWriting(maxSum);
    }

    // 2
    static int[,] LoadMatrix(int n)
    {
        int[,] matrix = new int[n, n];

        for (int row = 0; row < n; row++)
        {
            Console.Write("Please enter the {0} row ({1} numbers separated with spaces):", row, n);
            string[] strNumbers = Console.ReadLine().Split();
            for (int col = 0; col < strNumbers.Length; col++)
            {
                matrix[row, col] = int.Parse(strNumbers[col]); ;
            }
        }
        return matrix;
    }

    // 3
    static void PrintMatrixToFile(int[,] matrix)
    {
        string fileNameMatrix = @"..\..\InputMatrix.txt";
        StreamWriter streamWriterOne = new StreamWriter(fileNameMatrix);
        using (streamWriterOne)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    streamWriterOne.Write("{0} ", matrix[row, col]);
                }
                streamWriterOne.WriteLine();
            }
        }
        Console.WriteLine("The matrix is loaded");
    }

    // 4
    static int[,] MatrixFromText(int matrixLenght)
    {
        int[,] matrixFromFile = new int[matrixLenght, matrixLenght];
        string fileToOpen = @"..\..\InputMatrix.txt";
        StreamReader streamReaderOne = new StreamReader(fileToOpen);

        using (streamReaderOne)
        {
            string currentLine = streamReaderOne.ReadLine();

            for (int row = 0; row < matrixLenght; row++)
            {
                string[] strNumbers = currentLine.Split();
                for (int col = 0; col < matrixLenght; col++)
                {
                    matrixFromFile[row, col] = int.Parse(strNumbers[col]); ;
                }
                currentLine = streamReaderOne.ReadLine();
            }
        }

        return matrixFromFile;
    }

    // 5
    static int MaxSumCalc(int[,] matrix)
    {
        int maxSum = int.MinValue;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (maxSum < sum)
                {
                    maxSum = sum;
                }
            }
        }
        return maxSum;
    }

    // 6
    static void IntegerWriting(int maxSum)
    {
        string fileToWrite = @"..\..\ResultMaxSum.txt";
        StreamWriter streamWriterOne = new StreamWriter(fileToWrite);

        using (streamWriterOne)
        {
            streamWriterOne.WriteLine(maxSum);
        }
        Console.WriteLine("Result loaded");
    }
}

