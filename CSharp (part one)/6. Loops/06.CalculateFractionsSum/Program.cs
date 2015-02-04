//Problem 6. Calculate N! / K!

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter n= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please, enter k= ");
        int k = int.Parse(Console.ReadLine());

        int result = 1;
        int resultTwo = 1;
        
        if (1 < k && k < n && n < 100)
        {
            for (int i = 1; i <= n; i++)
            {
                if(i == 1)
                {
                    for (int j = 1; j <= k; j++)
                    {
                        resultTwo *= j;
                    }
                }
                result *= i;
            }

            Console.WriteLine(result / resultTwo);

        }
        else
        {
            Console.WriteLine("Invalid values");
        }
        
        
    }
}

