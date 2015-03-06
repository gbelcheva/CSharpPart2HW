using System;

//Problem 3. Decimal to hexadecimal

//    Write a program to convert decimal numbers to their hexadecimal representation.


namespace _03DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number:");
            long numDec = long.Parse(Console.ReadLine());
            string numHex = "";
            while (!(numDec == 0))
            {
                byte remainder = (byte)(numDec % 16);
                char remainderChar;
                switch (remainder)
                {
                    case 10: remainderChar = 'A'; break;
                    case 11: remainderChar = 'B'; break;
                    case 12: remainderChar = 'C'; break;
                    case 13: remainderChar = 'D'; break;
                    case 14: remainderChar = 'E'; break;
                    case 15: remainderChar = 'F'; break;
                    default: remainderChar = Convert.ToChar(Convert.ToString(remainder));
                        break;
                }
                numHex = numHex + remainderChar;
                numDec = numDec / 16;
            }
            char[] hexChars = numHex.ToCharArray();
            Array.Reverse(hexChars);
            numHex = new string(hexChars);
            Console.WriteLine("The HEX representation is:");
            Console.WriteLine(numHex);

        }
    }
}
