namespace CataloguePriceExtractorXPath
{
    using System;
    using System.Xml;

    public class EntryPoint
    {
        public static void Main()
        {
            Console.WriteLine("Albums published 5 years ago or earlier (XPath): ");

            XmlDocument catalogue = new XmlDocument();
            catalogue.Load("../../../catalogue.xml");

            var currentYear = DateTime.Now.Year;

            string xPathPattern = "/catalogue/*[year < " + (currentYear - 5) + "]";
            XmlNodeList albums = catalogue.SelectNodes(xPathPattern);

            foreach (XmlNode albumNode in albums)
            {
                var currentNameNode = albumNode.SelectSingleNode("name");
                var currentYearNode = albumNode.SelectSingleNode("year");
                var currentPriceNode = albumNode.SelectSingleNode("price");

                string name = currentNameNode.InnerText;
                string year = currentYearNode.InnerText;
                string price = currentPriceNode.InnerText;

                Console.WriteLine(" - {0}, year: {1}, price: {2}", name, year, price);
            }
        }
    }
}
