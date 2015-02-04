//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PlayWithInt_DoubleAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int intiger;
            double floatingPoint;

            bool isItInt = int.TryParse(str, out intiger);
            bool isDoubleInt = double.TryParse(str, out floatingPoint);

            int choice = 0;
            if (isItInt)
            {
                choice = 1;
            }
            else if (isDoubleInt)
            {
                choice = 2;
            }
            else
            {
                choice = 3;
            }
            switch (choice)
            {
                case 1:
                    intiger += 1;
                    Console.WriteLine("Intiger number: {0}", intiger);
                    break;
                case 2:
                    floatingPoint += 1;
                    Console.WriteLine("Double number: {0}", floatingPoint);
                    break;
                case 3:
                    str += "*";
                    Console.WriteLine("String variavle: {0}", str);
                    break;
            }
        }
    }
}
