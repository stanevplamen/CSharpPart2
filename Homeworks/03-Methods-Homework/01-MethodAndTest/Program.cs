using System;

namespace MethodAndTest
{
    public class Program
    {
        public static string PrintApp(string userName)
        {
            string result = "Hello, " + userName;
            Console.WriteLine(result);
            return result;
        }
        static void Main()
        {
            Console.Write("Please enter your first name: ");
            string name = Console.ReadLine();
            PrintApp(name);
        }
    }
}