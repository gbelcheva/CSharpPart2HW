namespace TxtToXmlConverter
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    public class EntryPoint
    {
        public static void Main()
        {
            string inputFile = "../../../personInfo.txt";
            string outputFile = "../../../person.xml";

            string[] personText = File.ReadAllLines(inputFile);

            XNamespace ns = "urn:person";
            XElement personXml = 
                new XElement(
                    ns + "person", 
                    new XElement(ns + "name", personText[0]), 
                    new XElement(ns + "address", personText[1]),
                    new XElement(ns + "phone", personText[2]));

            Console.WriteLine(personXml);

            personXml.Save(outputFile);
        }
    }
}
