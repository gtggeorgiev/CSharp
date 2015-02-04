//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_of_5_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter five numbers given in a single line, separated by a space");
            string input = Console.ReadLine();
            string[] fiveNumbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            for (int i = 0; i < fiveNumbers.Length; i++)
            {
                sum += double.Parse(fiveNumbers[i]);
            }

            Console.WriteLine("Sum = " + sum);
        }
    }
}
