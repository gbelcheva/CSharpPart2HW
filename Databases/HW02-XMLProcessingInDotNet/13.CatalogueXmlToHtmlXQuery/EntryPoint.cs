namespace CatalogueXmlToHtmlXQuery
{
    using System.IO;
    using System.Text;
    using System.Xml;
    using SaxonWrapper;

    public class EntryPoint
    {
        public static void Main()
        {
            string xmlFile = "../../../catalogue.xml";
            string htmlFile = "../../../catalogueXQuery.html";
            string hqFile = "../../../catalogue-to-html.xq";

            using (StreamWriter streamWriter =
       new StreamWriter(htmlFile, false, Encoding.UTF8))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlFile);

                XmlTextWriter xmlWriter = new XmlTextWriter(streamWriter);

                XQueryProcessor xp = new XQueryProcessor();
                xp.LoadFromFile(hqFile);
                xp.RunQuery(xmlDoc, xmlWriter);
            }
        }
    }
}
