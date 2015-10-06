namespace XmlReaderXmlWriter
{
    using System.Text;
    using System.Xml;

    public class EntryPoint
    {
        public static void Main()
        {
            string inputFile = "../../../catalogue.xml";
            string outputFile = "../../../album.xml";

            Encoding encoding = Encoding.GetEncoding("utf-8");

            using (XmlTextWriter writer = new XmlTextWriter(outputFile, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;
                writer.WriteStartDocument();
                writer.WriteStartElement("albums");

                using (XmlReader reader = XmlReader.Create(inputFile))
                {
                    bool insideAlbum = false;
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element &&
                            reader.Name == "album")
                        {
                            insideAlbum = true;
                            writer.WriteStartElement("album");

                            continue;
                        }

                        if (reader.NodeType == XmlNodeType.Element &&
                            reader.Name == "name" &&
                            insideAlbum)
                        {
                            writer.WriteElementString("name", reader.ReadElementString());
                        }

                        if (reader.NodeType == XmlNodeType.Element &&
                            reader.Name == "artist" &&
                            insideAlbum)
                        {
                            writer.WriteElementString("author", reader.ReadElementString());
                            writer.WriteEndElement();
                            insideAlbum = false;
                        }
                    }
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}
