namespace CataloguePriceExtractorLinq
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class EntryPoint
    {
        public static void Main()
        {
            Console.WriteLine("Albums published 5 years ago or earlier (LINQ): ");

            string inputFile = "../../../catalogue.xml";

            var currentYear = DateTime.Now.Year;

            XDocument xmlCatalogue = XDocument.Load(inputFile);
            var albums =
                from album in xmlCatalogue.Descendants("album")
                where Int16.Parse(album.Element("year").Value) < (currentYear - 5)
                select new
                {
                    Name = album.Element("name").Value,
                    Year = album.Element("year").Value,
                    Price = album.Element("price").Value
                };

            foreach (var a in albums)
            {
                Console.WriteLine(" - {0}, year: {1}, price: {2}", a.Name, a.Year, a.Price);
            }
        }
    }
}
