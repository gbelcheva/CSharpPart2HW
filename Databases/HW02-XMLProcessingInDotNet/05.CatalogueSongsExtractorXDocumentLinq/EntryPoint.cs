namespace CatalogueSongsExtractorXDocumentLinq
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class EntryPoint
    {
        public static void Main()
        {
            Console.WriteLine("Extract song titles with XDocument and LINQ: ");

            string inputFile = "../../../catalogue.xml";

            XDocument xmlCatalogue = XDocument.Load(inputFile);

            var songs =
                from song in xmlCatalogue.Descendants("song")
                select new 
                { 
                    Title = song.Element("title").Value
                };

            foreach (var s in songs)
            {
                Console.WriteLine(" - {0}", s.Title);
            }
        }
    }
}
