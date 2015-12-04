using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        private static int[] a;
        private static int n;

        private static void print_bracelet(int n, int[] a)
        {
            int i;

            Console.Write("[");
            for (i = 0; i < n; i++)
            {
                Console.Write(" {0}", 'a' + a[i]);
            }
            Console.Write(" ]\n");
        }

        private static int check_rev(int t, int i)
        {
            int j;

            for (j = i + 1; j <= (t + 1) / 2; j++)
            {
                if (a[j] < a[t - j + 1])
                {
                    return 0;
                }
                if (a[j] > a[t - j + 1])
                {
                    return -1;
                }
            }

            return 1;
        }

        private static void gen_bracelets(int n_a, int n_b, int t, int p, int r, int u, int v, int rs)
        {
            if (2 * (t - 1) > (n + r))
            {
                if (a[t - 1] > a[n - t + 2 + r])
                {
                    rs = 0;
                }
                else if (a[t - 1] < a[n - t + 2 + r])
                {
                    rs = 1;
                }
            }
            if (t > n)
            {
                if (rs == 0 && (n % p) == 0)
                {
                    print_bracelet(n, a);
                }
            }
            else
            {
                int n_a2 = n_a;
                int n_b2 = n_b;

                a[t] = a[t - p];

                if (a[t] == 0)
                {
                    n_a2--;
                }
                else
                {
                    n_b2--;
                }

                if (a[t] == a[1])
                {
                    v++;
                }
                else
                {
                    v = 0;
                }

                if ((u == (t - 1)) && (a[t - 1] == a[1]))
                {
                    u++;
                }

                if ((n_a2 >= 0) && (n_b2 >= 0) && !((t == n) && (u != n) && (a[n] == a[1])))
                {
                    if (u == v)
                    {
                        int rev = check_rev(t, u);

                        if (rev == 0)
                        {
                            gen_bracelets(n_a2, n_b2, t + 1, p, r, u, v, rs);
                        }

                        if (rev == 1)
                        {
                            gen_bracelets(n_a2, n_b2, t + 1, p, t, u, v, 0);
                        }
                    }
                    else
                    {
                        gen_bracelets(n_a2, n_b2, t + 1, p, r, u, v, rs);
                    }
                }

                if (u == t)
                {
                    u--;
                }

                if (a[t - p] == 0 && n_b > 0)
                {
                    a[t] = 1;

                    if (t == 1)
                    {
                        gen_bracelets(n_a, n_b - 1, t + 1, t, 1, 1, 1, rs);
                    }
                    else
                    {
                        gen_bracelets(n_a, n_b - 1, t + 1, t, r, u, 0, rs);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int n_a;
            int n_b;

            //if (argc < 3)
            //{
            //    Console.Error.Write("Usage: {0} <a> <b>\n", args[0]);
            //    return -2;
            //}

            n_a = Convert.ToInt32(args[1]);
            n_b = Convert.ToInt32(args[2]);

            //if (n_a < 0 || n_b < 0)
            //{
            //    Console.Error.Write("a and b must be nonnegative\n");
            //    return -3;
            //}

            n = n_a + n_b;
            a = new int[(n + 1)];

            //if (a.Length == 0)
            //{
            //    Console.Error.Write("could not allocate array\n");
            //    return -1;
            //}

            a[0] = 0;

            gen_bracelets(n_a, n_b, 1, 1, 0, 0, 0, 0);

            //C++ TO C# CONVERTER TODO TASK: The memory management function 'free' has no equivalent in C#:
            //free(a);
        }

    }
}
