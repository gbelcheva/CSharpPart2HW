using System;
using System.Text;

//Problem 15. Replace tags

//    Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

//Example:
//input 	output
//<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p> 	<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

namespace _15ReplaceTags
{
    class ReplaceTags
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert HTML document text:");
            StringBuilder text = new StringBuilder();
            text.Append(Console.ReadLine());
            int indexEnd = 0;
            while (text.ToString().IndexOf("<a href=\"") > - 1)
            {
                int indexStart = text.ToString().IndexOf("<a href=\"", indexEnd);
                text.Remove(indexStart, "<a href=\"".Length);
                text.Insert(indexStart, "[URL=");

                int indexMiddle = text.ToString().IndexOf("\">", indexStart);
                text.Remove(indexMiddle, "\">".Length);
                text.Insert(indexMiddle, "]");

                indexEnd = text.ToString().IndexOf("</a>", indexMiddle);
                text.Remove(indexEnd, "</a>".Length);
                text.Insert(indexEnd, "[/URL]");
            }
            Console.WriteLine();
            Console.WriteLine(text.ToString());


        }
    }
}
