using System;

class AddPolynomials
{
    static int[] SumCoeffs(int[] firstCoeffs, int[] secondCoeffs)
    {
        int[] newCoeffs = new int[firstCoeffs.Length];
        for (int i = 0; i < firstCoeffs.Length; i++)
        {
            newCoeffs[i] = firstCoeffs[i] + secondCoeffs[i];
        }
        return newCoeffs;
    }

    static void Main()
    {
        int[] firstCoeffs = (LoadArray());
        Print(firstCoeffs);
        int[] secondCoeffs = (LoadArray());
        Print(secondCoeffs);

        int[] sumCoeffs = SumCoeffs(firstCoeffs, secondCoeffs);
        Console.Write("\nThe sum is: ");
        Print(sumCoeffs);
    }

    static int counter = 0;
    static int counterPrint = 0;

    private static int[] LoadArray()
    {
        counter++;
        Console.WriteLine("Please enter the coefficients(integers) of the {0} polynomial nx2 + mx + k:", counter);
        int[] array = new int[3];
        Console.Write("k = ");
        array[0] = int.Parse(Console.ReadLine());
        Console.Write("m = ");
        array[1] = int.Parse(Console.ReadLine());
        Console.Write("n = ");
        array[2] = int.Parse(Console.ReadLine());
        return array;
    }

    private static void Print(int[] polynomToPrint)
    {
        counterPrint++;
        Console.WriteLine("Polynomial {0} is: {1}x2 + {2}x +{3}", counterPrint, polynomToPrint[2], polynomToPrint[1], polynomToPrint[0]);
    }
}
