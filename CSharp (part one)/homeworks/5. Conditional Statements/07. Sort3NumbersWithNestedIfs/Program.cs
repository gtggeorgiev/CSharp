//Problem 7. Sort 3 Numbers with Nested Ifs

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sort3NumbersWithNestedIfs
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
            
            if (a > b)
            {
                if (a > c)
                {
                    if (b > c)
                    {
                        Console.WriteLine("{0}  {1}  {2}", a, b, c);
                    }
                    else
                    {
                        Console.WriteLine("{0}  {1}  {2}", a, c, b);
                    }
                }
                else 
                {
                    Console.WriteLine("{0}  {1}  {2}", c, a, b);
                }
            }
            else// (a < b)
            {
                if (a < c)
                {
                    if (b > c)
                    {
                        Console.WriteLine("{0}  {1}  {2}", b, c, a);
                    }
                    else
                    {
                        Console.WriteLine("{0}  {1}  {2}", c, b, a);
                    }
                }
                else // (a > c)
                {
                    Console.WriteLine("{0}  {1}  {2}", b, a, c);
                }
            }









            //if (a >= b)
            //{
            //    if (b >= c)
            //    {
            //        Console.WriteLine("{0}  {1}  {2}", a, b, c);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0}  {1}  {2}", a, c, b);
            //    }
            //}
            //else if (b >= a)
            //{
            //    if (a >= c)
            //    {
            //        Console.WriteLine("{0}  {1}  {2}", b, a, c);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0}  {1}  {2}", b, c, a);
            //    }
            //}
            //else if (c >= a)
            //{
            //    if ()
            //}

        }
    }
}
