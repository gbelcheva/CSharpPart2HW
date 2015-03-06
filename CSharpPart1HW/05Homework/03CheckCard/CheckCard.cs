using System;
using System.Text;

//Problem 3. Check for a Play Card

//    Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:

//character 	Valid card sign?
//5 	yes
//1 	no
//Q 	yes
//q 	no
//P 	no
//10 	yes
//500 	no

namespace _03CheckCard
{
    class CheckCard
    {
        static void Main(string[] args)
        {
            string[] cards = new string[]{"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A",};
            Console.WriteLine("Input playing card:");
            string card = Console.ReadLine();
            for (int i = 0; i < cards.Length; i++)
            {
                if (card.Equals(cards[i], StringComparison.Ordinal))
                {
                    Console.WriteLine("yes");
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
