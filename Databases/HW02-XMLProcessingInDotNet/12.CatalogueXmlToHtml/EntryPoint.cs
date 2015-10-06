namespace CatalogueXmlToHtml
{
    using System.Xml.Xsl;

    public class EntryPoint
    {
        public static void Main()
        {
            string inputXslFile = "../../../catalogue.xslt";
            string inputXmlFile = "../../../catalogue.xml";
            string outputHtmlFile = "../../../catalogue.html";
            XslCompiledTransform catalogueXslt = new XslCompiledTransform();
            
            catalogueXslt.Load(inputXslFile);
            catalogueXslt.Transform(inputXmlFile, outputHtmlFile);
        }
    }
}
