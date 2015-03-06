using System;
using System.IO;

//Problem 3. Read file contents

//    Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//    Find in MSDN how to use System.IO.File.ReadAllText(…).
//    Be sure to catch all possible exceptions and print user-friendly error messages.


namespace _03ReadFileContents
{
    class ReadFileContents
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input file path:");
            try
            {
                string path = Console.ReadLine();
                string readText = File.ReadAllText(path);
                Console.WriteLine("\nFile contents:");
                Console.WriteLine(readText);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Path null");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Path conatins invalid characters");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The specified path is too long");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive)");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occurred while opening the file");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("File is read-only, or points to a directory, or you don't have the required premission, or the operation is not supported on this platform");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Path is in invalid format");
            }
        }
    }
}
