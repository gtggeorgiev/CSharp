//Problem 1. Numbers from 1 to N

//Write a program that enters from the console a positive integer n 
//and prints all the numbers from 1 to n, on a single line, separated by a space.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.NumbersFrom1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter positive intiger n= ");
            int positiveIntiger = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter <= positiveIntiger)
            {
                Console.Write("{0}  ", counter);
                counter++;
            }

            
        }
    }
}
