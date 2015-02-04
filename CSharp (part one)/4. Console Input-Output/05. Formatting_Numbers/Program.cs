//Problem 5. Formatting Numbers

//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Formatting_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a= ");
            int a = int.Parse(Console.ReadLine());
            if (a >= 0 && a <= 500)
            {
                Console.Write("Enter b= ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Enter c= ");
                double c = double.Parse(Console.ReadLine());


                //a printed in hexadecimal
                Console.WriteLine();
                string hexValue = a.ToString("X");
                Console.Write(hexValue);

                //a printed in binry form
                string binary = Convert.ToString(a, 2).PadLeft(10, '0');

                Console.WriteLine("{0, -10}| {1} | {2, 10:N2} | {3 : 0.000}", hexValue, binary, b, c);
            }
            else
            {
                Console.WriteLine("Exeption --> 0 <= a <= 500!!!");
            }
        }
    }
}
