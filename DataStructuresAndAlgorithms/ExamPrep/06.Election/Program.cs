using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Election
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            var parties = new List<int>();

            for (int i = 0; i < parties.Count; i++)
            {
                parties[i] = int.Parse(Console.ReadLine()); ;
            }

            Console.WriteLine(GetSubsetSums(parties, k);

        }

        private static int GetSubsetSums(List<int> parties, int k)
        {
            throw new NotImplementedException();
        }
    }
}
