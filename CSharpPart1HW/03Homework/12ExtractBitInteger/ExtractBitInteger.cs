using System;

//Problem 12. Extract Bit from Integer

//    Write an expression that extracts from given integer n the value of given bit at index p.

//Examples:
//n 	binary representation 	p 	bit @ p
//5 	00000000 00000101 	2 	1
//0 	00000000 00000000 	9 	0
//15 	00000000 00001111 	1 	1
//5343 	00010100 11011111 	7 	1
//62241 	11110011 00100001 	11 	0

namespace _12ExtractBitInteger
{
    class ExtractBitInteger
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input integer number n and position p: ");
            int n;
            int p;
            while (!(int.TryParse(Console.ReadLine(), out n) && int.TryParse(Console.ReadLine(), out p)))
            {
                Console.WriteLine("Invalid numbers. Try again:\n ");
            }
            int nRightP = n >> p;
            int bit = nRightP & 1;
            Console.WriteLine("Bit @ p:\n{0}", bit);
        }
    }
}
