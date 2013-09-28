using System;
using System.Numerics;

class FactorialCalculation
{
    static BigInteger Factorial(int n)
    {
        BigInteger factorialN = 1;
        for (int currentN = 1; currentN <= n; currentN++)
        {
            if (currentN == n)
            {
                return factorialN * currentN;
            }
            else
            {
                factorialN = currentN * factorialN;
                Print(currentN, factorialN);
            }
        }
        return (factorialN);
    }

    static void Main()
    {        
        int n = 100; // int.Parse(Console.ReadLine());
        BigInteger nFactorial = Factorial(n);
        Print(n, nFactorial);
    }

    static void Print(int n, BigInteger factorial)
    {
        Console.WriteLine("{0}! = {1}", n, factorial);
    }
}
