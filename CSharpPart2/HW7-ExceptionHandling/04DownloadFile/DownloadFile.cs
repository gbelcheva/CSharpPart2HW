using System;
using System.Net;

//Problem 4. Download file

//    Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//    Find in Google how to download files in C#.
//    Be sure to catch all exceptions and to free any used resources in the finally block.


namespace _04DownloadFile
{
    class DownloadFile
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Input file URL:");
                string URL = Console.ReadLine();
                Console.WriteLine("Input file name to be saved:");
                string fileName = Console.ReadLine();
            try
            {
                using (WebClient Client = new WebClient())
                {
                    Client.DownloadFile(URL, fileName);
                }
                Console.WriteLine("The file is downloaded to your current directory.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The address is null");
            }
            catch (WebException)
            {
                Console.WriteLine("The URI is invalid, or the filename is empty, or the file does not exist, or an error occurred while downloading the data");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("An attempt to read, seek, or write to a stream that does not support the invoked functionality");
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
