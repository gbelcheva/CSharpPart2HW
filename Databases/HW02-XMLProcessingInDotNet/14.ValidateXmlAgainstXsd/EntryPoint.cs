namespace ValidateXmlAgainstXsd
{
    using System;
    using System.IO;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Schema;

    public class EntryPoint
    {
        public static void Main()
        {
            string xmlFile = "../../../catalogue.xml";
            //string xmlFile = "../../../catalogueInvalid.xml";
            string xsdFile = "../../../catalogue.xsd";

            string xsd = File.ReadAllText(xsdFile);

            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add(string.Empty, XmlReader.Create(new StringReader(xsd)));

            XDocument doc = XDocument.Load(xmlFile);
            string msg = string.Empty;
            doc.Validate(
                schemas, 
                (o, e) =>
            {
                msg += e.Message + Environment.NewLine;
            });
            Console.WriteLine(msg == string.Empty ? "Document is valid" : "Document invalid: " + msg);
        }
    }
}
