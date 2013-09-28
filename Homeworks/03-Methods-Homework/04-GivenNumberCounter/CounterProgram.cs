using System;

namespace GivenNumberCounter
{
    public class CounterProgram
    {
        static int[] justNumbers = { 1, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 6, 7, 
                                     1, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 6, 7,
                                     1, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 6, 7,
                                     1, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 6, 7, };

        public static int RepetitionsFinder(int number)
        {
            Array.Sort(justNumbers);
            int outputIndex = Array.BinarySearch(justNumbers, number);
            int repeat = 0;
            for (int i = outputIndex; i < justNumbers.Length; i++)
            {
                if (justNumbers[i] == number)
                {
                    repeat++;
                }
                else
                {
                    break;
                }
            }
            for (int i = outputIndex - 1; i >= 0; i--)
            {
                if (justNumbers[i] == number)
                {
                    repeat++;
                }
                else
                {
                    break;
                }
            }
            return repeat;
        }

        static void Main()
        {
            int requestedNumber = 5;

            int result = RepetitionsFinder(requestedNumber);
            Console.WriteLine("The number {0} is repeating {1} times", requestedNumber, result);
        }
    }
}