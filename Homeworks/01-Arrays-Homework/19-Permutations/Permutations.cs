// This is perpuration of string chars array (not int array)

using System;
using System.Text;

namespace Permutations
{
    class Permute
    {
        private void swap(ref char a, ref char b)
        {
            if (a == b) return;
            a ^= b;
            b ^= a;
            a ^= b;
        }

        public void Set_Permutation(char[] list)
        {
            int arrayLength = list.Length - 1;
            Permutation_Method(list, 0, arrayLength);
        }

        private void Permutation_Method(char[] list, int k, int m)
        {
            // k intial index passed 
            // m size of char array
            int i;
            if (k == m) 
            {
                Console.Write(list);
                Console.WriteLine(" ");
            }
            else
            {
                for (i = k; i <= m; i++) 
                {
                    swap(ref list[k], ref list[i]);  

                    //recursive call
                    Permutation_Method(list, k + 1, m);

                    swap(ref list[k], ref list[i]);   
                }
            }
        }
    }

    class Class1
    {
        static void Main()
        {
            Permute objPermutation = new Permute();
            string str = "123";
            char[] mycharArray = str.ToCharArray();
            /*calling the permute*/
            objPermutation.Set_Permutation(mycharArray);
        }
    }
}