namespace CatalogueSongsExtractorXmlReader
{
    using System;
    using System.Xml;

    public class EntryPoint
    {
        public static void Main()
        {
            Console.WriteLine("Extract song titles with XML reader: ");

            using (XmlReader reader = XmlReader.Create("../../../catalogue.xml"))
            {
                bool insideSong = false;
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element &&
                        reader.Name == "song")
                    {
                        insideSong = true;

                        continue;
                    }

                    if (reader.NodeType == XmlNodeType.Element &&
                        reader.Name == "title" &&
                        insideSong)
                    {
                        Console.WriteLine(" - {0}", reader.ReadElementString());

                        insideSong = false;
                    }
                }
            }
        }
    }
}
