// To test the program with other types, please replace the word 'decimal' with float, int , long, double;

using System;
using System.Threading.Tasks;
using System.Threading;

class SetVarOperations
{
    // creates an integer between 3 and 20
    static int GiveInt()
    {
        Random rndInt = new Random();
        Thread.Sleep(15); // wait to generate different number
        int random = rndInt.Next(3, 20);
        return random;
    }

    static dynamic GiveDifferentType()
    {
        // creates a float / decimal /int / long / etc 
        // just change the "cast"
        decimal randTempOne = (decimal)(GiveInt() * 2.0);
        decimal randTempTwo = (decimal)Math.Sqrt(GiveInt());
        return (decimal)(randTempOne * randTempTwo);
    }

    // calculate the max, min , sum and product
    static dynamic[] MaxMinSum(dynamic[] elements)
    {
        dynamic[] output = new dynamic[5]; // here will be copied the five results (0-min, 1-max, 2-sum , 3-product), 4-average
        output[0] = -1000000; // in this example (enought for the generation limit)
        output[1] = 1000000;
        output[2] = 0;
        output[3] = 1;
        int i = 0;
        for (i = 0; i < elements.Length; i++)
        {
            if (output[0] < elements[i])
            {
                output[0] = elements[i];
            }
            if (output[1] > elements[i])
            {
                output[1] = elements[i];
            }
            output[2] = output[2] + elements[i];
            output[3] = output[3] * elements[i];
        }
        output[4] = output[2] / i;
        return output;
    }

    static void Main()
    {
        // declare a random length
        int length = GiveInt();
        // declare the set ot integers (please see the method)
        dynamic[] setOfNumbers = new dynamic[length];

        for (int i = 0; i < setOfNumbers.Length; i++)
        {
            //Console.Write("Please enter the {0} member value: ", i);
            setOfNumbers[i] = GiveDifferentType(); //int.Parse(Console.ReadLine());
        }

        dynamic[] results = MaxMinSum(setOfNumbers);

        PrintSet(setOfNumbers);
        PrintAnsw(results);
    }
    // printing the starting set
    private static void PrintSet(dynamic[] setOfNumbers)
    {
        Console.Write("The given set is: ");
        foreach (var c in setOfNumbers)
        {
            Console.Write("{0:0.000}  ", c);
        }
        Console.WriteLine();
    }

    // printing the results
    private static void PrintAnsw(dynamic[] results)
    {
        Console.WriteLine("The max value is: {0:0.000} , type {1}", results[0], TypeOf(results[0]));
        Console.WriteLine("The min value is: {0:0.000} type {1}", results[1], TypeOf(results[1]));
        Console.WriteLine("The average is: {0:0.000} type {1}", results[4], TypeOf(results[4]));
        Console.WriteLine("The sum is: {0:0.000} type {1}", results[2], TypeOf(results[2]));
        Console.WriteLine("The product is: {0:0.000} type {1}", results[3], TypeOf(results[3]));
    }

    // gets the type of the result
    static Type TypeOf(dynamic variable)
    {
        Type type = variable.GetType();
        return type;
    }
}
