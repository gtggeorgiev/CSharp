//Problem 7. Calculate N! / (K! * (N-K)!)

//In combinatorics, the number of ways to choose k different members out of a group of n different elements 
//(also known as the number of combinations) is calculated by the following formula: formula For example, 
//there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
//Try to use only two loops.

using System;
using System.Numerics;

class Combinatoric
{
    static void Main()
    {
        Console.Write("Please, enter n= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please, enter k= ");
        int k = int.Parse(Console.ReadLine());
        
        if (1 < k && k < n && n < 100)
        {
            BigInteger resultOne = 1;
            BigInteger resultTwo = 1;
            BigInteger resultThree = 1;
            int NMinusK = (n - k);

            for (int i = 1; i <= n; i++)
            {
                resultOne *= i;
            }
            for (int j = 1; j <= k; j++)
            {
                resultTwo *= j;
            }
            for (int x = 1; x <= NMinusK; x++)
            {
                resultThree *= x;
            }

            Console.WriteLine("n! / (k! * (n-k)!) = {0}", resultOne / (resultTwo * resultThree));
        }
        else
        {
            Console.WriteLine("Invalid dates!!!");
        }
    }
}
