//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation 
//ax2 + bx + c = 0 and solves it (prints its real roots).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            //first coefficient --> a
            Console.Write("Enter a= ");
            string strFirstCoefficient = Console.ReadLine();
            double firstCoefficient = double.Parse(strFirstCoefficient);

            //second coefficient --> b
            Console.Write("Enter b= ");
            string strSecondCoefficient = Console.ReadLine();
            double secondCoeficient = double.Parse(strSecondCoefficient);

            //third coefficient --> c
            Console.Write("Enter c= ");
            string strThirdCoefficient = Console.ReadLine();
            double thirdCoeficient = double.Parse(strThirdCoefficient);

            // Discriminant of Quadratic Equation
            double discriminant = (secondCoeficient * secondCoeficient) - (4 * firstCoefficient * thirdCoeficient);

            if (discriminant > 0)
            {
                Console.WriteLine("x1 = {0}", (-secondCoeficient + Math.Sqrt(discriminant)) / (2 * firstCoefficient));
                Console.WriteLine("x2 = {0}", (-secondCoeficient - Math.Sqrt(discriminant)) / (2 * firstCoefficient));
            }
            else if (discriminant == 0)
            {
                Console.WriteLine("x1 = x2 = {0}", (-secondCoeficient) / (2 * firstCoefficient));
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
