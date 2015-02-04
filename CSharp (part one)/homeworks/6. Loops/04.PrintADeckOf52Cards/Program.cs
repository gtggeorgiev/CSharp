//Problem 4. Print a Deck of 52 Cards

//Write a program that generates and prints all possible cards from a standard deck of 52 cards 
//(without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 
//9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested 
//for-loops and a switch-case statement.

using System;

class DeckOf52Cards
{
    static void Main()
    {
        for (int i = 2; i <= 48; i++)
        {
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of heards, {0} of diamonds", i);

            if(i == 2)
            {
                for (int j = 1; j <= 4; j++)
                {
                    switch (j)
                    {
                        case 1:
                            Console.WriteLine("A of spades, A of clubs, A of heards, A of diamonds");
                            break;
                        case 2:
                            Console.WriteLine("K of spades, K of clubs, K of heards, K of diamonds");
                            break;
                        case 3:
                            Console.WriteLine("Q of spades, Q of clubs, Q of heards, Q of diamonds");
                            break;
                        case 4:
                            Console.WriteLine("J of spades, J of clubs, J of heards, J of diamonds");
                            break;
                    }
                }
            }

        }

        

    }
}

