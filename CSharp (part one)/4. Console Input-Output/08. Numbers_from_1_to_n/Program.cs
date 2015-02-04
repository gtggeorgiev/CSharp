//Problem 8. Numbers from 1 to n

//Write a program that reads an integer number n from the console and prints all the numbers in
//the interval [1..n], each on a single line.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Numbers_from_1_to_n
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
