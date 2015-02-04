//Problem 5. The Biggest of 3 Numbers

//Write a program that finds the biggest of three numbers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TheBiggestOf3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("biggest --> {0}", a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("biggest --> {0}", b);
            }
            else if (c > b && c > a)
            {
                Console.WriteLine("biggest --> {0}", c);
            }

        }
    }
}
