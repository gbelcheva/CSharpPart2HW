using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ShortestPath
{
    class Program
    {
        private static string path;
        private static SortedSet<string> paths;
        private static char[] currentPath;

        static void Main(string[] args)
        { 
            path =  Console.ReadLine();
            paths = new SortedSet<string>();
            currentPath = path.ToCharArray(); ;
            GetAllPaths(0);

            Console.WriteLine(paths.Count);
            Console.WriteLine(string.Join("\n", paths));
        }

        private static void GetAllPaths(int index)
        {
            if (index == path.Length)
            {
                paths.Add(new string(currentPath));
            }
            else if (currentPath[index] != '*')
            {
                GetAllPaths(index + 1);
            }
            else
            {
                currentPath[index] = 'S';
                GetAllPaths(index + 1);
                currentPath[index] = 'R';
                GetAllPaths(index + 1);
                currentPath[index] = 'L';
                GetAllPaths(index + 1);
                currentPath[index] = '*';
            }
        }
    }
}
