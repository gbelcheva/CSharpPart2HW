using System;
using System.Collections.Generic;
using System.Text;

//Problem 18. Extract e-mails

//    Write a program for extracting all email addresses from given text.
//    All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
// n @ doigiorenginr riongnrrn@dgnifng.bg @@@ sklfgoenr@dlksgs.com ewklnr@sfsfd.bg

namespace _18ExtractE_mails
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> temp = new List<char> { '+', '-', '.', '_'};
            for (int i = 48; i <= 57; i++)
            {
                temp.Add((char)i);
            }
            for (int i = 65; i <= 90; i++)
            {
                temp.Add((char)i);
            }
            for (int i = 97; i <= 122; i++)
            {
                temp.Add((char)i);
            }
            char[] chars = temp.ToArray();

            Console.WriteLine("Insert text:");
            StringBuilder text = new StringBuilder(Console.ReadLine());
            List<StringBuilder> addresses = new List<StringBuilder>();
            int indexEnd = 0;
            int j = 0;
            while (text.ToString().IndexOf("@") > -1)
            {
                int indexStart = text.ToString().IndexOf("@", indexEnd);

                if (indexStart == 0)
                {
                    text.Remove(indexStart, 1);
                    continue;
                }
                if (indexStart == text.Length - 1)
                {
                    break;
                }
                if (!IsAllowedChar(text[indexStart - 1], chars) || !IsAllowedChar(text[indexStart - 1], chars))
                {
                    indexEnd++;
                    continue;
                }

                addresses.Add(new StringBuilder(""));
                int i = indexStart;

                while (IsAllowedChar(text[i - 1], chars) && i >= 0)
                {
                    addresses[j].Insert(0, text[i - 1]);
                    i--;
                }
                addresses[j].Append('@');
                i = indexStart;

                while (IsAllowedChar(text[i + 1], chars))
                {
                    addresses[j].Append(text[i + 1]);
                    i++;
                    if (i + 1 > text.Length - 1)
                    {
                        break;
                    }
                }

                if (i + 1 > text.Length - 1)
                {
                    break;
                }

                text.Remove(indexStart, 1);
                indexEnd = i;
                j++;
            }

            Console.WriteLine("\nFound email addresses:\n");
            Console.WriteLine(string.Join("\n", addresses));
        }

        private static bool IsAllowedChar(char ch, char[] chars)
        {
            bool isAllowed = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (ch == chars[i])
                {
                    return isAllowed = true;
                }
            }
            return isAllowed;
        }
    }
}
