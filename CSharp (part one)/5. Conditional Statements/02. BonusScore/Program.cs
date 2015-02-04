//Problem 2. Bonus Score

//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter bonus score: ");
            int bonusScore = int.Parse(Console.ReadLine());

            if (bonusScore >= 1 && bonusScore <= 3)
            {
                Console.WriteLine("Result --> {0}", bonusScore * 10);
            }
            else if (bonusScore >= 4 && bonusScore <= 6)
            {
                Console.WriteLine("Result --> {0}", bonusScore * 100);
            }
            else if (bonusScore >= 7 && bonusScore <= 9)
            {
                Console.WriteLine("Result --> {0}", bonusScore * 1000);
            }
            else 
            {
                Console.WriteLine("Invalid score");
            }

        }
    }
}
