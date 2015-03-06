using System;

//Problem 7. One system to any other

//    Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).


namespace _07OneSystemToAnyOther
{
    class OneSystemToAnyOther
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number to convert (digits 0-9, letters A-F):");
            string input = Console.ReadLine();
            Console.WriteLine("Input original base:");
            int originalBase = int.Parse(Console.ReadLine());
            Console.WriteLine("Input target base:");
            int targetBase = int.Parse(Console.ReadLine());
            Console.WriteLine("The number in base {0} is:", targetBase);
            Console.WriteLine(StringToInt(input, originalBase, targetBase));
        }

        static char[] GetBaseChars(int targetBase)
        {
            string allChars = "0123456789ABCDEF";
            char[] baseChars = new char[targetBase];
            for (int i = 0; i < baseChars.Length; i++)
            {
                baseChars[i] = allChars[i];
            }
            return baseChars;
        }

        static string StringToInt(string input, int originBase, int targetBase)
        {
            char[] chars = input.ToUpper().ToCharArray();
            byte[] values = new byte[input.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                switch (chars[i])
                {
                    case 'A': values[i] = 10; break;
                    case 'B': values[i] = 11; break;
                    case 'C': values[i] = 12; break;
                    case 'D': values[i] = 13; break;
                    case 'E': values[i] = 14; break;
                    case 'F': values[i] = 15; break;
                    default: values[i] = Convert.ToByte(chars[i].ToString());
                        break;
                }
            }
            long numDec = 0;
            int basePower = 1;
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                numDec = numDec + (long)(values[i] * basePower);
                basePower = basePower * originBase;
            }
            char[] baseChars = GetBaseChars(targetBase);
            string result = string.Empty;
            do
            {
                result = baseChars[numDec % targetBase] + result;
                numDec = numDec / targetBase;
            }
            while (numDec > 0);

            return result;
        }
    }
}
