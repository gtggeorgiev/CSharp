//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, 
//the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;

class MinMaxSumAverage
{
    static void Main(string[] args)
    {
        Console.Write("Enter value of n: ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;
        int min = int.MaxValue;
        int max = int.MinValue;

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Number {0}: ", i);
            int p = int.Parse(Console.ReadLine());
            sum += (double)p;
            if (p < min)
            {
                min = p;
            }
            if (p > max)
            {
                max = p;
            }
        }

        Console.WriteLine("Min= {0}", min);
        Console.WriteLine("Max= {0}", max);
        Console.WriteLine("Sum = {0}", sum);
        Console.WriteLine("Average sum = {0:F2}", (sum) / n);
    }
}

