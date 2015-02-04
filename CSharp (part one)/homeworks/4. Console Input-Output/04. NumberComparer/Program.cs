//Problem 4. Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumberComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            //First number
            Console.Write("Enter first number: ");
            string strFirstNumber = Console.ReadLine();
            double firstNumber = double.Parse(strFirstNumber);

            //Second number
            Console.Write("Enter second number: ");
            string strSecondNumber = Console.ReadLine();
            double secondNumber = double.Parse(strSecondNumber);

            //Greater number
            Console.WriteLine("Greater number is: " + (firstNumber >= secondNumber ? firstNumber : secondNumber));
        }
    }
}
