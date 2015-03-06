using System;

//Problem 4. Print a Deck of 52 Cards

//    Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//        The card faces should start from 2 to A.
//        Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

//output

//2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
//3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
//…  
//K of spades, K of clubs, K of hearts, K of diamonds
//A of spades, A of clubs, A of hearts, A of diamonds

//Note: You may use the suit symbols instead of text.

namespace _04CardDeck
{
    class CardDeck
    {
        static void Main(string[] args)
        {
            Console.Title = "Playing Cards Deck";
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string[] cardHeight = {"J", "Q", "K", "A"};
            char[] cardSuit = { '\u2663', '\u2660', '\u2665', '\u2666' };
            //string[] cardSuit = { " of spades", " of clubs", " of hearts", " of diamonds" };
            //Output 13x4 table
            for (int i = 2; i <= 14; i++) //rows
            {
                for (int j = 0; j < 4; j++) //columns
                {
                    switch (i)
                    {
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10: 
                            Console.Write("{0,2}{1} ", i, cardSuit[j]); 
                            break;
                        default:
                            Console.Write("{0,2}{1} ", cardHeight[i - 11], cardSuit[j]);
                            break;
                    }
                }
                System.Console.WriteLine();
            }
        }
    }
}
