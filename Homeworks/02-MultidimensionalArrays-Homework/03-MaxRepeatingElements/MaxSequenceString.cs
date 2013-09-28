using System;

class MaxSequenceString
{
    static void Main()
    {
        string[,] stringMatrix =
            {
                { "ha"  ,  "fifi",  "ha",   "xx" },
                { "ha"   , "ha",    "fifi", "ha" },
                { "xxx" ,  "xy",    "ha",   "fifi" },
                { "xxx" ,  "ha",    "zz",   "ha" },
            };

        int rows = stringMatrix.GetLength(0);
        int columns = stringMatrix.GetLength(1);
        int matrixSize = rows * columns;

        // horizontal check

        int countHorizontal = 1;
        string HorizontalString = null;
        string currentHorizontalString = null;
        int maxHorizontalSequence = 0;

        for (int row = 0; row < stringMatrix.GetLength(0); row++)
        {
            countHorizontal = 1;
            for (int col = 0; col < stringMatrix.GetLength(1) - 1; col++)
            {
                if (maxHorizontalSequence < countHorizontal)
                {
                    maxHorizontalSequence = countHorizontal;
                    HorizontalString = currentHorizontalString;
                }
                if (stringMatrix[row, col] == stringMatrix[row, col + 1])
                {
                    countHorizontal++;
                    currentHorizontalString = stringMatrix[row, col];
                }
                else
                {
                    countHorizontal = 1;
                }
            }
        }

        // vertical check

        int countVertical = 1;
        string VerticalString = null;
        string currentVerticalString = null;
        int maxVerticalSequence = 0;

        for (int col = 0; col < stringMatrix.GetLength(1); col++)
        {
            countVertical = 1;
            for (int row = 0; row < stringMatrix.GetLength(0) - 1; row++)
            {
                if (maxVerticalSequence < countVertical)
                {
                    maxVerticalSequence = countVertical;
                    VerticalString = currentVerticalString;
                }
                if (stringMatrix[row, col] == stringMatrix[row + 1, col])
                {
                    countVertical++;
                    currentVerticalString = stringMatrix[row, col];
                }
                else
                {
                    countVertical = 1;
                }
            }
        }

        // Diagonal1 check // left -> right, top -> bottom (left)

        int countDiagonal1 = 1;
        string Diagonal1String = null;
        string currentDiagonal1String = null;
        int maxDiagonal1Sequence = 0;

        for (int row = 0; row < stringMatrix.GetLength(0) - 1; row++)
        {
            if (maxDiagonal1Sequence < countDiagonal1)
            {
                maxDiagonal1Sequence = countDiagonal1;
                Diagonal1String = currentDiagonal1String;
            }
            countDiagonal1 = 1;
            for (int col = 0; col < stringMatrix.GetLength(1) - 1; col++)
            {
                if (maxDiagonal1Sequence < countDiagonal1)
                {
                    maxDiagonal1Sequence = countDiagonal1;
                    Diagonal1String = currentDiagonal1String;
                }
                if (row + col + 1 >= stringMatrix.GetLength(0))
                {
                    break;
                }
                if (stringMatrix[row + col, col] == stringMatrix[row + col + 1, col + 1])
                {
                    countDiagonal1++;
                    currentDiagonal1String = stringMatrix[row + col, col];
                }
                else
                {
                    countDiagonal1 = 1;
                }
            }
        }

        // Diagonal2 check //  left -> right, top -> bottom (right)

        int countDiagonal2 = 1;
        string Diagonal2String = null;
        string currentDiagonal2String = null;
        int maxDiagonal2Sequence = 0;

        for (int col = 1; col < stringMatrix.GetLength(1) - 1; col++)
        {
            if (maxDiagonal2Sequence < countDiagonal2)
            {
                maxDiagonal2Sequence = countDiagonal2;
                Diagonal2String = currentDiagonal2String;
            }
            countDiagonal2 = 1;
            for (int row = 0; row < stringMatrix.GetLength(0) - 1; row++)
            {
                if (maxDiagonal2Sequence < countDiagonal2)
                {
                    maxDiagonal2Sequence = countDiagonal2;
                    Diagonal2String = currentDiagonal2String;
                }
                if (row + col + 1 >= stringMatrix.GetLength(1))
                {
                    break;
                }
                if (stringMatrix[row, row + col] == stringMatrix[row + 1, row + col + 1])
                {
                    countDiagonal2++;
                    currentDiagonal2String = stringMatrix[row ,row + col];
                }
                else
                {
                    countDiagonal2 = 1;
                }
            }
        }

        // Diagonal3 check //  left <- right, top -> bottom (left)

        int countDiagonal3 = 1;
        string Diagonal3String = null;
        string currentDiagonal3String = null;
        int maxDiagonal3Sequence = 0;

        for (int col = stringMatrix.GetLength(1) - 1; col >= 1; col--)
        {
            if (maxDiagonal3Sequence < countDiagonal3)
            {
                maxDiagonal3Sequence = countDiagonal3;
                Diagonal3String = currentDiagonal3String;
            }
            countDiagonal3 = 1;
            for (int row = 0; row < stringMatrix.GetLength(0); row++)
            {
                if (maxDiagonal3Sequence < countDiagonal3)
                {
                    maxDiagonal3Sequence = countDiagonal3;
                    Diagonal3String = currentDiagonal3String;
                }
                if (row + 1 == stringMatrix.GetLength(0) || -row + col - 1 < 0)
                {
                    break;
                }
                if (stringMatrix[row, -row + col] == stringMatrix[row + 1, -row + col - 1])
                {
                    countDiagonal3++;
                    currentDiagonal3String = stringMatrix[row, -row + col];
                }
                else
                {
                    countDiagonal3 = 1;
                }
            }
        }

        // Diagonal4 check //  left <- right, top -> bottom (right)

        int countDiagonal4 = 1;
        string Diagonal4String = null;
        string currentDiagonal4String = null;
        int maxDiagonal4Sequence = 0;
        int col1 = stringMatrix.GetLength(1);
        int counter = 0;

        while (col1 - counter >= 0)
        {
            countDiagonal4 = 1;
            for (int row = 1; row < stringMatrix.GetLength(0); row++)
            {
                if (maxDiagonal4Sequence < countDiagonal4)
                {
                    maxDiagonal4Sequence = countDiagonal4;
                    Diagonal4String = currentDiagonal4String;
                }
                if (row + 1 + counter > stringMatrix.GetLength(0) - 1)
                {
                    break;
                }
                if (stringMatrix[row + counter, col1 - row] == stringMatrix[row + 1 + counter, col1 - 1 - row])
                {
                    countDiagonal4++;
                    currentDiagonal4String = stringMatrix[row + counter, col1 - row];
                }
                else
                {
                    countDiagonal4 = 1;
                }
            }
            counter++;
        }

        // all max repeating sequences are:

        Console.WriteLine("Max horizontal repeating string: {0}, {1} times", HorizontalString, maxHorizontalSequence);
        Console.WriteLine();
        Console.WriteLine("Max vertical repeating string: {0}, {1} times", VerticalString, maxVerticalSequence);
        Console.WriteLine();

        Console.WriteLine("Max diagonal(left -> right, top -> bottom (left)) repeating string: {0}, {1} times", Diagonal1String, maxDiagonal1Sequence);
        Console.WriteLine();
        Console.WriteLine("Max diagonal(left -> right, top -> bottom (right)) repeating string: {0}, {1} times", Diagonal2String, maxDiagonal2Sequence);
        Console.WriteLine();
        Console.WriteLine("Max diagonal(left <- right, top -> bottom (left)) repeating string: {0}, {1} times", Diagonal3String, maxDiagonal3Sequence);
        Console.WriteLine();
        Console.WriteLine("Max diagonal(left <- right, top -> bottom (right)) repeating string: {0}, {1} times", Diagonal4String, maxDiagonal4Sequence);
        Console.WriteLine();

        // The max repeating sequence

        int[] maxArray = { maxVerticalSequence, maxVerticalSequence, maxDiagonal1Sequence, 
                         maxDiagonal2Sequence, maxDiagonal3Sequence, maxDiagonal4Sequence};

        int maxValue = 0;
        int index = -1;
        int counterIndex = 0;
        foreach (int c in maxArray)
        {
            if (maxValue < c)
            {
                maxValue = c;
                index = counterIndex;
            }
            counter++;
        }

        string[] repeatingWords = { HorizontalString, VerticalString, Diagonal1String, 
                         Diagonal2String, Diagonal3String, Diagonal4String};

        Console.WriteLine();
        Console.WriteLine("The max repeating string is \"{0}\", - {1} times", repeatingWords[index], maxValue);
    }
}

