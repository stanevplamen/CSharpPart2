using System;

public static class GlobalMembersPermutationsWithRepetition
{
    public static uint[] numbersArray = new uint[100];
    public static uint iteration;
    public static void Print()
    {
        uint i;
        for (i = 0; i < iteration; i++)
        {
            Console.Write("{0:D} ", numbersArray[i] + 1);
        }
        Console.Write("\n");
    }
    public static int length;
    public static void Permute(uint start)
    {
        uint k;
        if (start >= iteration)
        {
            GlobalMembersPermutationsWithRepetition.Print();
            return;
        }
        for (k = 0; k < length; k++)
        {
            numbersArray[start] = k;
            /* if */
            GlobalMembersPermutationsWithRepetition.Permute(start + 1);
        }
    }
    static void Main()
    {
        Console.Write("Please enter N = ");
        length = int.Parse(Console.ReadLine());
        Console.Write("Please enter K = ");
        iteration = uint.Parse(Console.ReadLine());

        GlobalMembersPermutationsWithRepetition.Permute(0);
    }
}
