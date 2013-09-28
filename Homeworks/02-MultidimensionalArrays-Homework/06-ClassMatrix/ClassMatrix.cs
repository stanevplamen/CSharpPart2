using System;

class Matrix
{
    public const int matSize = 4;
    private int[,] m_matrix = new int[matSize, matSize];

    // allow callers to initialize (indexer)
    public int this[int x, int y]
    {
        get { return m_matrix[x, y]; }
        set { m_matrix[x, y] = value; }
    }

    // add matrices
    public static Matrix operator +(Matrix matrixOne, Matrix matrixTwo)
    {
        Matrix matrixPlus = new Matrix();

        for (int x = 0; x < matSize; x++)
            for (int y = 0; y < matSize; y++)
                matrixPlus[x, y] = matrixOne[x, y] + matrixTwo[x, y];

        return matrixPlus;
    }

    // substract matrices
    public static Matrix operator -(Matrix matrixOne, Matrix matrixTwo)
    {
        Matrix matrixSubstract = new Matrix();

        for (int x = 0; x < matSize; x++)
            for (int y = 0; y < matSize; y++)
                matrixSubstract[x, y] = matrixOne[x, y] - matrixTwo[x, y];

        return matrixSubstract;
    }

    // multiply matrices
    public static Matrix operator *(Matrix matrixOne, Matrix matrixTwo)
    {
        Matrix matrixMultiply = new Matrix();

        if (matSize == matSize) // true
        {
            for (int i = 0; i < matSize; i++)
            {
                for (int j = 0; j < matSize; j++)
                {
                    matrixMultiply[i, j] = 0;
                    for (int k = 0; k < matSize; k++) // OR k<matrixTwo.GetLength(0)
                    {
                        matrixMultiply[i, j] = matrixMultiply[i, j] + matrixOne[i, k] * matrixTwo[k, j];

                    }
                }
            }
        }
        else
        {
            Console.WriteLine("\n Number of columns in Matrix1 is not equal to Number of rows in Matrix2.");
            Console.WriteLine("\n Therefore Multiplication of Matrix1 with Matrix2 is not possible");
            Environment.Exit(-1);
        }
        return matrixMultiply;
    }

}

class MatrixTest
{
    // test Matrix
    static void Main()
    {
        Matrix matrixOne = new Matrix();
        Matrix matrixTwo = new Matrix();

        // init matrices 
        InitMatrix(matrixOne);
        InitMatrix(matrixTwo);


        // print out matrices
        Console.WriteLine("Matrix 1: ");
        PrintMatrix(matrixOne);

        Console.WriteLine("Matrix 2: ");
        PrintMatrix(matrixTwo);

        // perform operation and print out results
        Matrix matrixThree = matrixOne + matrixTwo;

        Matrix matrixFive = matrixOne * matrixTwo;

        Matrix matrixFour = matrixOne - matrixTwo;


        Console.WriteLine();
        Console.WriteLine("Matrix 1 + Matrix 2 = ");
        PrintMatrix(matrixThree);

        Console.WriteLine();
        Console.WriteLine("Matrix 1 - Matrix 2 = ");
        PrintMatrix(matrixFour);

        Console.WriteLine();
        Console.WriteLine("Matrix 1 * Matrix 2 = ");
        PrintMatrix(matrixFive);

    }

    // initialize matrix with values
    public static void InitMatrix(Matrix mat)
    {
        int counterOne = 0;
        for (int x = 0; x < Matrix.matSize; x++)
        {
            for (int y = 0; y < Matrix.matSize; y++)
            {
                mat[x, y] = counterOne;
                counterOne++;
            }
        }
    }


    // print matrix to console
    public static void PrintMatrix(Matrix mat)
    {
        Console.WriteLine();
        for (int x = 0; x < Matrix.matSize; x++)
        {
            Console.Write("[ ");
            for (int y = 0; y < Matrix.matSize; y++)
            {
                // format the output
                string printer = Convert.ToString((mat[x, y]));
                Console.Write("{0,6}", printer);

                if ((y + 1 % 2) < 3)
                    Console.Write(", ");
            }
            Console.WriteLine(" ]");
        }
        Console.WriteLine();
    }
}