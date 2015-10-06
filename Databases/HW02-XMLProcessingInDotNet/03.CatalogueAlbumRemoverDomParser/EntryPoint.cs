namespace CatalogueAlbumRemoverDomParser
{
    using System;
    using System.Xml;

    public class EntryPoint
    {
        public static void Main()
        {
            XmlDocument catalogue = new XmlDocument();
            catalogue.Load("../../../catalogue.xml");

            XmlNode rootNode = catalogue.DocumentElement;

            for (int i = 0; i < rootNode.ChildNodes.Count; i++)
            {
                var node = rootNode.ChildNodes[i];

                var priceNode = node["price"];
                if (priceNode == null)
                {
                    Console.WriteLine(priceNode.Name);
                    continue;
                }

                double price = Double.Parse(priceNode.InnerText);
                if (price > 20.00)
                {
                    rootNode.RemoveChild(node);

                    i--;
                }
            }

            catalogue.Save("../../../catalogueAlbumRemoverDomParser.xml");
        }
    }
}
