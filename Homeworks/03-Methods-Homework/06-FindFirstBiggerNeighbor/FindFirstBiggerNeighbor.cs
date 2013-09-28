using System;
using BiggerNeighbor;

class FindFirstBiggerNeighbor
{
    public static int sign = 0;

    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 6 };

        for (int i = 0; i < array.Length; i++)
        {
            int index = i;

            bool checkBool = BiggerNeighbor.NeighborCheck.BiggerCheck(array, index);
            sign = BiggerNeighbor.NeighborCheck.sign;

            if (sign == 1 && checkBool == true)
            {
                Console.WriteLine("{0} is bigger than {1} and {2}", array[index], array[index - 1], array[index + 1]);
                Environment.Exit(0);
            }
            else if (sign == 2 && checkBool == true) 
            {
                Console.WriteLine("{0} is bigger than {1} and (empty)", array[index], array[index - 1]);
                Environment.Exit(0);
            }
            else if (sign == 3 && checkBool == true)
            {
                Console.WriteLine("{0} is bigger than (empty) and {1}", array[index], array[index + 1]);
                Environment.Exit(0);          
            }
        }
        Console.WriteLine("-1, no such element");
    }
}
