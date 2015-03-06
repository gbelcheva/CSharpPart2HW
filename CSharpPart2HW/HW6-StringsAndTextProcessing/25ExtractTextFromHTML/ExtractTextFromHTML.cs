using System;
using System.Text;

//Problem 25. Extract text from HTML

//    Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

//Example input:

//<html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a> aims to provide free real-world practical
//    training for young people who want to turn into
//    skilful .NET software engineers.</p></body>
//</html>

//Output:

//Title: News

//Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.

namespace _25ExtractTextFromHTML
{
    class ExtractTextFromHTML
    {
        static void Main(string[] args)
        {
            string text = @"<html>
<head><title>News</title></head>
<body><p><a href=""http://academy.telerik.com"">Telerik
Academy</a> aims to provide free real-world practical
training for young people who want to turn into
skilful .NET software engineers.</p></body>
</html>";
            int endIndex = text.IndexOf("</title>");
            int startIndex = text.IndexOf("<title>") + "<title>".Length;
            if (text.IndexOf("<title>") > -1)
            {
                string title = text.Substring(startIndex, endIndex - startIndex);
                Console.WriteLine("Title: {0}", title);
            }
            StringBuilder sb = new StringBuilder(text.Substring(text.IndexOf("<body>"), text.Length - text.IndexOf("<body>")));
            while (sb.ToString().IndexOf("<") > -1)
            {
                startIndex = sb.ToString().IndexOf("<");
                endIndex = sb.ToString().IndexOf(">");
                sb.Remove(startIndex, endIndex - startIndex + 1);
            }
            string finalText = sb.ToString().Replace(System.Environment.NewLine, " ");
            Console.WriteLine("Text: {0}", finalText);
        }
    }
}
