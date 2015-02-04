//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted 
//with 2 digits after the decimal point.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CirclePerimeter_And_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //radius
            Console.Write("Enter radius of cyrcle: ");
            string strRadius = Console.ReadLine();
            double radius = double.Parse(strRadius);

            // PI
            double PI = Math.PI;

            //output
            Console.WriteLine();
            Console.WriteLine("Perimeter of cyrcle is: {0:0.00} * {1:0.00} * {1:0.00} = {2:0.00}", PI, radius, PI * radius * radius);
            Console.WriteLine("Aria of cyrcle is: 2 * {0:0.00} * {1:0.00} = {2:0.00}", PI, radius, 2 * PI * radius);
        }
    }
}
