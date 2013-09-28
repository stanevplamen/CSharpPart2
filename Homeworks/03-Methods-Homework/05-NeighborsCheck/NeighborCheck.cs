using System;

namespace BiggerNeighbor
{
    public class NeighborCheck
    {
        public static int sign = 0;

        public static int ValidPosition(int[] elements, int position)
        {
            if (position + 1 < elements.Length && position - 1 >= 0)
            {
                return 1;
            }
            else if (position + 1 == elements.Length)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        public static bool BiggerCheck(int[] elements, int position)
        {
            sign = ValidPosition(elements, position);
            if (sign == 1 && elements[position] > elements[position - 1] && elements[position] > elements[position + 1])
            {
                return true;
            }
            else if (sign == 2 && elements[position] > elements[position - 1])
            {
                return true;
            }
            else if (sign == 3 && elements[position] > elements[position + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 6 };
            int index = 7;
            bool checkBool = BiggerCheck(array, index);
            Console.WriteLine("The element at position {0} is {1}", index, array[index]);
            if (sign == 1)
            {
                Console.WriteLine("{0} is bigger than {1} and {2} : {3}", array[index], array[index - 1], array[index + 1], checkBool);
            }
            else if (sign == 2)
            {
                Console.WriteLine("{0} is bigger than {1} and (empty) : {2}", array[index], array[index - 1], checkBool);
            }
            else if (sign == 3)
            {
                Console.WriteLine("{0} is bigger than (empty) and {1} : {2}", array[index], array[index + 1], checkBool);
            }
        }
    }
}
