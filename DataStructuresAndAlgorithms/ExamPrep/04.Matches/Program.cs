using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Matches
{
    public class Hash
    {
        private const ulong BASE1 = 127;
        private const ulong BASE2 = 131;
        private const ulong MOD = 1000000033;

        private static ulong[] powers1;
        private static ulong[] powers2;

        public static void ComputePowers(int n)
        {
            powers1 = new ulong[n + 1];
            powers2 = new ulong[n + 1];
            powers1[0] = 1;
            powers2[0] = 1;

            for (int i = 0; i < n; i++)
            {
                powers1[i + 1] = powers1[i] * BASE1 % MOD;
                powers2[i + 1] = powers2[i] * BASE2 % MOD;
            }
        }

        public ulong Value1 { get; private set; }
        public ulong Value2 { get; private set; }

        public Hash(string str)
        {
            this.Value1 = 0;

            foreach (char c in str)
            {
                this.Add(c);
            }
        }

        public void Add(char c)
        {
            this.Value1 = (this.Value1 * BASE1 + c) % MOD;
            this.Value2 = (this.Value2 * BASE2 + c) % MOD;
        }

        public void Remove(char c, int length)
        {
            this.Value1 = (MOD + this.Value1 - powers1[length] * c % MOD) % MOD;
            this.Value2 = (MOD + this.Value2 - powers2[length] * c % MOD) % MOD;
        }
    }

    class Program
    {

        private static bool IsCommonString(string str1, string str2, int length)
        {
            //var window1 = new char[length];
            //Array.Copy(str1, window1, length);
            var hash1 = new Hash(str1.Substring(0, length)); // new Hash(window1);

            HashSet<ulong> hashes1 = new HashSet<ulong>();
            HashSet<ulong> hashes2 = new HashSet<ulong>();

            hashes1.Add(hash1.Value1);
            hashes2.Add(hash1.Value2);

            for (int i = 0; i < str1.Length - length - 1; i++) // ???????????????????
            {
                hash1.Add(str1[length + i]);
                hash1.Remove(str1[i], length);

                hashes1.Add(hash1.Value1);
                hashes2.Add(hash1.Value2);
            }

            //var window2 = new char[length];
            //Array.Copy(str2, window2, length);
            var hash2 = new Hash(str2.Substring(0, length));// new Hash(window2);

            if (hashes1.Contains(hash2.Value1) && 
                hashes2.Contains(hash2.Value2))
            {
                return true;
            }

            for (int i = 0; i < str2.Length - length - 1; i++)
            {
                hash2.Add(str2[length + i]);
                hash2.Remove(str2[i], length);
                if (hashes1.Contains(hash2.Value1) &&
                    hashes2.Contains(hash2.Value2))
                {
                    return true;
                }
            }

            return false;
        }

        private static int MatchCommonSubstrings(string str1, string str2)
        {
            Hash.ComputePowers(Math.Min(str1.Length, str2.Length));
            int left = 0;
            int right = Math.Max(str1.Length, str2.Length);

            while (left < right)
            {
                int middle = (left + right) / 2;
                bool isCommonLength = IsCommonString(str1, str2, middle);

                if (isCommonLength)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle;
                }
            }

            return right - 1;
        }

        // T" = (T' - T'(0) * Base^(wordLength - 1)) * Base + newChar
        static void Main(string[] args)
        {
            // MockInput();

            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();

            int maxCommonLength = MatchCommonSubstrings(str1, str2);
            Console.WriteLine(maxCommonLength);
        }

        private static void MockInput()
        {
            string input = @"-=input=-
put-=42;";

            Console.SetIn(new StringReader(input));
        }
        
    }
}
