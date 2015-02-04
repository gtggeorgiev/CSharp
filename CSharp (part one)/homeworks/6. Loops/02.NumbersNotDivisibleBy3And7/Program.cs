﻿//Problem 2. Numbers Not Divisible by 3 and 7

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n 
//not divisible by 3 and 7, on a single line, separated by a space.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumbersNotDivisibleBy3And7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter positive number n= ");
            uint n = uint.Parse(Console.ReadLine());
            uint counter = 1;

            while(counter <= n)
            {
                if (counter % 3 == 0 || counter % 7== 0)
                {
                    counter++;
                    continue;
                }
                Console.Write("{0}  ", counter);
                counter++;
            }
        }
    }
}
