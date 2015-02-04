//Problem 1. Sum of 3 Numbers

//Write a program that reads 3 real numbers from the console and prints their sum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sum_of_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // First number
            Console.Write("Enter first number: ");
            string strFirstNumber = Console.ReadLine();
            double firstNumber = double.Parse(strFirstNumber);

            // Second number
            Console.Write("Enter second number: ");
            string strSecondNumber = Console.ReadLine();
            double secondNumber = double.Parse(strSecondNumber);

            // Third number
            Console.Write("Enter third number: ");
            string strThirdNumber = Console.ReadLine();
            double thirdNumber = double.Parse(strThirdNumber);

            // Sum of these tree numbers
            Console.WriteLine("Sum= " + "{0} + {1} + {2} = {3}", firstNumber, secondNumber, thirdNumber,
                                                                firstNumber + secondNumber + thirdNumber);
        }
    }
}
