using System;

//Problem 14. Modify a Bit at Given Position

//    We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//    Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

//Examples:
//n 	binary representation of n 	p 	v 	binary result 	result
//5 	00000000 00000101 	2 	0 	00000000 00000001 	1
//0 	00000000 00000000 	9 	1 	00000010 00000000 	512
//15 	00000000 00001111 	1 	1 	00000000 00001111 	15
//5343 	00010100 11011111 	7 	0 	00010100 01011111 	5215
//62241 	11110011 00100001 	11 	0 	11110011 00100001 	62241

namespace _14ModifyBitPosition
{
    class ModifyBitPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input integer n, bit v and position p: ");
            int n = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            //check if numbers are correct
            while (!(n.GetType() == typeof(int) && p.GetType() == typeof(int) && (v == 0 || v == 1)))
            {
                Console.WriteLine("Invalid numbers.Try again:\n ");
                n = int.Parse(Console.ReadLine());
                v = int.Parse(Console.ReadLine());
                p = int.Parse(Console.ReadLine());
            }
            int result;
            if (v == 0)
            {
                int mask = ~(1 << p);
                result = n & mask;
            }
            else
            {
                int mask = 1 << p;
                result = n | mask;
            }
            Console.WriteLine("Result:\n{0}", result);
        }
    }
}
