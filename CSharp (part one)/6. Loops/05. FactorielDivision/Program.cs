//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

using System;

class FactorielDivision
{
    static void Main()
    {
        Console.Write("Enter n= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter x= ");
        int x = int.Parse(Console.ReadLine());

        int result = 1;
        double resultTwo = 1;

        for (int i = 1; i <= n; i++)
        {
            result *= i;
            resultTwo += (result / Math.Pow(x, i));

        }
        Console.WriteLine("{0:F5}",resultTwo);
    }
}

