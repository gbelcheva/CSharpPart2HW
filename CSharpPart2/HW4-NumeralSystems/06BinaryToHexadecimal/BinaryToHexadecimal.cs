using System;

//Problem 6. Binary to hexadecimal

//    Write a program to convert binary numbers to hexadecimal numbers (directly).


namespace _06BinaryToHexadecimal
{
    class BinaryToHexadecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input binary number:");
            string binary = Console.ReadLine();
            string hex = "";
            string binarySubStr = "";
            if (binary.Length % 4 != 0)
            {
                binary = binary.PadLeft(4 - (binary.Length % 4) + binary.Length, '0');
            }
            
            for (int i = 0; i < binary.Length / 4; i++)
            {
                binarySubStr = binary.Substring(0 + i * 4, 4);
                switch (binarySubStr)
                {
                    case "0000": hex += '0'; break;
                    case "0001": hex += '1'; break;
                    case "0010": hex += '2'; break;
                    case "0011": hex += '3'; break;
                    case "0100": hex += '4'; break;
                    case "0101": hex += '5'; break;
                    case "0110": hex += '6'; break;
                    case "0111": hex += '7'; break;
                    case "1000": hex += '8'; break;
                    case "1001": hex += '9'; break;
                    case "1010": hex += 'A'; break;
                    case "1011": hex += 'B'; break;
                    case "1100": hex += 'C'; break;
                    case "1101": hex += 'D'; break;
                    case "1110": hex += 'E'; break;
                    case "1111": hex += 'F'; break;
                    default: break;
                }
            }
            Console.WriteLine("HEX representation is:");
            Console.WriteLine(hex);
        }
    }
}
