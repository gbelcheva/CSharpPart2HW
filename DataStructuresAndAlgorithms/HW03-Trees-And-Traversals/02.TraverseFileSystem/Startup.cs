namespace _02.TraverseFileSystem
{
    using System;
    using System.IO;

    public class Startup
    {
        public static void Main()
        {
            string path = @"C:\Windows";

            FindExeFiles(path);
        }

        private static void FindExeFiles(string path)
        {
            string[] files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                if (file.EndsWith(".exe"))
                {
                    Console.WriteLine(new FileInfo(file).Name);
                }
            }

            string[] directories = Directory.GetDirectories(path);
            foreach (var directory in directories)
            {
                try
                {
                    FindExeFiles(directory);
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Access to directory {0} is denied.", directory);
                }
                catch (PathTooLongException)
                {
                    Console.WriteLine("Directory name is too long.");
                }
            }
        }
    }
}
