using System;

namespace _01.Staircases
{
    class Program
    {
        private static long[,] memoCount;

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            memoCount = new long[n + 1, n + 1];
            memoCount[0, 0] = 1;
            memoCount[1, 1] = 1;
            memoCount[2, 2] = 1;

            for (int blocks = 3; blocks <= n; blocks++)
            {
                for (int maxLastLevel = 0; maxLastLevel <= blocks; maxLastLevel++)
                {
                    for (int currenLastLevel = 0; currenLastLevel < maxLastLevel ; currenLastLevel++)
                    {
                        if (blocks - maxLastLevel < currenLastLevel)
                        {
                            break;
                        }

                        memoCount[blocks, maxLastLevel] += memoCount[blocks - maxLastLevel, currenLastLevel];
                    }
                }
            }


            long totalStaircases = 0;
            for (int i = 1; i < n; i++)
            {
                totalStaircases += memoCount[n, i];

            }

            Console.WriteLine(totalStaircases);
        }

        //private static long CountStaircases(int blocks, int lastLevel)
        //{
            
        //    if (blocks < 3 && lastLevel == blocks)
        //    {
        //        return 1;
        //    }

        //    if (memoCount[blocks, lastLevel] > 0)
        //    {
        //        return memoCount[blocks, lastLevel];
        //    }

        //    for (int i = 0; i < lastLevel; i++)
        //    {
        //        if (blocks - lastLevel < i)
        //        {
        //            continue;
        //        }
        //        memoCount[blocks, lastLevel] += CountStaircases(blocks - lastLevel, i);
        //    }

        //    return memoCount[blocks, lastLevel];

        //}
    }
}
