using System;

//Problem 12. Parse URL

//    Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

//Example:
//URL 	Information
//http://telerikacademy.com/Courses/Courses/Details/212 	
//[protocol] = http
//[server] = telerikacademy.com
//[resource] = /Courses/Courses/Details/212

namespace _12ParseURL
{
    class ParseURL
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input URL:");
            string URL = Console.ReadLine().ToLower();
            string protocol = URL.Substring(0, URL.IndexOf(":"));
            URL = URL.Remove(0, protocol.Length + "://".Length);
            string server = URL.Substring(0, URL.IndexOf("/"));
            string resource = URL.Remove(0, server.Length);
            Console.WriteLine(protocol);
            Console.WriteLine(server);
            Console.WriteLine(resource);
        }
    }
}
