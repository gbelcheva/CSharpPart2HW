using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromize
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            if (CheckPalindrome(str))
            {
                Console.WriteLine(str);
            }
            else
            {
                var sb = new StringBuilder(str);

                var counter = 0;
                while (!CheckPalindrome(sb.ToString()))
                {
                    sb.Insert(str.Length, str[counter]);

                    counter++;
                }

                Console.WriteLine(sb.ToString());
            }
        }

        private static bool CheckPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
