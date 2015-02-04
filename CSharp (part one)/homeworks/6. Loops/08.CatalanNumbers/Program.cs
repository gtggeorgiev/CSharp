//Problem 8. Catalan Numbers

//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Please enter n= ");
        int n = int.Parse(Console.ReadLine());

        if(0 <= n && n <= 100)
        {
            BigInteger resultOne = 1;
            BigInteger resultTwo = 1;
            BigInteger resultThree = 1;

            for (int i = 1; i <= n; i++)
            {
                resultOne *= i;
            }

            for (int j = 1; j <= (2 * n); j++)
            {
                resultTwo *= j;
            }

            for (int x = 1; x <= (n + 1); x++)
            {
                resultThree *= x;
            }

            Console.WriteLine("{0}", (resultTwo / (resultOne * resultThree)));

        }
        else
        {
            Console.WriteLine("Invalid dates!!!");
        }
    }
}
