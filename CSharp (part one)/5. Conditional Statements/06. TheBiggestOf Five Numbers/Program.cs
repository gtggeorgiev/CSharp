//Problem 6. The Biggest of Five Numbers

//Write a program that finds the biggest of five numbers by using only five if statements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TheBiggestOfFiveNumbers
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
            Console.Write("d = ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("e = ");
            double e = double.Parse(Console.ReadLine());

            if (a >= b && a >= c && a >= d && a >= e)
            {
                Console.WriteLine("bigest --> {0}", a);
            }
            else if (b >= a && b >= c && b >= d && b >= e)
            {
                Console.WriteLine("biggest --> {0}", b);
            }
            else if (c >= a && c >= b && c >= d && c >= d)
            {
                Console.WriteLine("biggest --> {0}", c);
            }
            else if (d >= a && d >= b && d >= c && d >= e)
            {
                Console.WriteLine("biggest --> {0}", d);
            }
            else if (e >= a && e >= b && e >= c && e >= d)
            {
                Console.WriteLine("biggest --> {0}", e);
            }
        }
    }
}
