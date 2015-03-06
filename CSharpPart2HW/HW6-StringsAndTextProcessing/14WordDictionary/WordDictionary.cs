using System;
using System.Collections.Generic;

//Problem 14. Word dictionary

//    A dictionary is stored as a sequence of text lines containing words and their explanations.
//    Write a program that enters a word and translates it by using the dictionary.

//Sample dictionary:
//input 	output
//.NET 	platform for applications from Microsoft
//CLR 	managed execution environment for .NET
//namespace 	hierarchical organization of classes

namespace _14WordDictionary
{
    class WordDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
            dict.Add( ".NET" , "Platform for applications from Microsoft." );
            dict.Add( "CLR" , "Managed execution environment for .NET." );
            dict.Add( "namespace" , "Hierarchical organization of classes." );
            dict.Add( "ACL" , "A list that specifies the rules for access to a particular resource." );
            dict.Add( "class" , "A reference type that encapsulates data (constants and fields) and behavior (methods, properties, indexers, events, operators, instance constructors, static constructors, and destructors), and can contain nested types." );
            dict.Add( "method" , "In WMI, a function that describes the behavior of a class. Including a method in a class does not guarantee an implementation of the method." );
            dict.Add( "delegate" , "A reference to a function. A delegate is equivalent to a function pointer." );
            dict.Add( "template" , "A declarative page fragment that is used to provide a visual interface for a templated ASP.NET server control." );
            dict.Add( "SOAP" , "A simple, XML-based protocol for exchanging structured and type information on the Web." );
            dict.Add( "Silverlight" , "A cross-browser, cross-platform client technology that helps developers design, develop, and deliver media-enabled experiences and rich interactive applications on the Web." );
            dict.Add( "query" , "An expression in the form of a query expression or method-based query (or a combination of the two) that extracts information from a data source." );
            dict.Add( "property" , "A class member that is like a public field, but that includes features such as versioning, encapsulation, and the ability to execute additional logic through get and set accessor methods. See also: encapsulation, field, version policy. " );
            dict.Add("pipeline", "Sdd-in programming model, represents a linear communication model of segments that exchange data between an add-in and its host.");

            Console.WriteLine("Input term to search:\n{0}\n", string.Join( "\n", dict.Keys));
            Console.WriteLine("Type 'end' to quit.\n");
            string input = "";
            while (true)
            {
                input = Console.ReadLine();
                if (dict.ContainsKey(input))
                {
                    Console.WriteLine(dict[input]);
                }
                else if (input.ToLower() == "end")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Unrecognised term. Try again.");
                }
            }
        }
    }
}

