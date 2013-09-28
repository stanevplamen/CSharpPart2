using System;

class Triangle
{
    static void Main()
    {
        Console.WriteLine("Please choose the method for the calculation of the surface area of a triangle");
        Console.WriteLine("1 - By given side and an altitude to it");
        Console.WriteLine("2 - By given three sides");
        Console.WriteLine("3 - By given two sides and an angle between them");
        Console.Write("Select your choice (1-3): ");

        int userChoice = int.Parse(Console.ReadLine());
        double triangleArea = ResultMethod(userChoice);
        Console.WriteLine("\nThe area if the triangle is: {0:0.00} cm2", triangleArea);
    }

    static double ResultMethod(int userChoice)
    {
        switch (userChoice)
        {
            case 1:
                return MethodOne();
            case 2:
                return MethodTwo();
            case 3:
                return MethodThree();

            default:
                Console.WriteLine();
                Console.WriteLine("Please enter a corrent choice number");
                return 0;
        }
    }

    static double MethodOne()
    {
        Console.Write("Please enter a side lenght (cm): ");
        double siteB = double.Parse(Console.ReadLine());
        Console.Write("Please enter the altitude to the side (cm): ");
        double siteAltitude = double.Parse(Console.ReadLine());

        double area = siteB * siteAltitude / 2;
        return area;
    }

    static double MethodTwo()
    {
        Console.Write("Please enter the side 'a' lenght (cm): ");
        double siteA = double.Parse(Console.ReadLine());
        Console.Write("Please enter the side 'b' lenght (cm): ");
        double siteB = double.Parse(Console.ReadLine());
        Console.Write("Please enter the side 'c' lenght (cm): ");
        double siteC = double.Parse(Console.ReadLine());

        double p = (siteA + siteB + siteC) / 2;
        double area = Math.Sqrt(p * (p - siteA) * (p - siteB) * (p - siteC));
        return area;
    }

    static double MethodThree()
    {
        Console.Write("Please enter the side 'a' lenght (cm): ");
        double siteA = double.Parse(Console.ReadLine());
        Console.Write("Please enter the side 'b' lenght (cm): ");
        double siteB = double.Parse(Console.ReadLine());
        Console.Write("Please enter the angle between them in degrees: ");
        double angleAB = double.Parse(Console.ReadLine());

        angleAB = Math.PI * angleAB / 180.0; // converting degrees to radians
        double siteC = Math.Sqrt(Math.Pow(siteA, 2) + Math.Pow(siteB, 2) - 2 * siteA * siteB * Math.Cos(angleAB));
        double p = (siteA + siteB + siteC) / 2;
        double area = Math.Sqrt(p * (p - siteA) * (p - siteB) * (p - siteC));
        return area;
    }
}

