using System;

//Problem 9.* Binary floating-point

//    Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float).

//Example:
//number 	sign 	exponent 	mantissa
//-27,25 	1 	10000011 	10110100000000000000000

namespace _09BinaryFloating_point
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input float number:");
            float num = float.Parse(Console.ReadLine());
            long bits = System.BitConverter.ToInt32(System.BitConverter.GetBytes(num), 0) & 0xFFFFFFFF;
            string binary = Convert.ToString(bits, 2).PadLeft(32, '0');
            string sign = binary.Substring(0, 1);
            string exponent = binary.Substring(1, 8);
            string mantissa = binary.Substring(9, 23);
            Console.WriteLine("Binary representation (sign, exponent, mantissa):");
            Console.WriteLine(sign + " " + exponent + " " + mantissa);
        }
    }
}
