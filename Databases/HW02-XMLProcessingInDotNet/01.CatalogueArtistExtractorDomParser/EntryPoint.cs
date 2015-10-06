namespace CatalogueArtistExtractorDomParser
{
    using System;
    using System.Collections;
    using System.Xml;

    public class EntryPoint
    {
        public static void Main()
        {
            Hashtable artistsAlbums = new Hashtable();

            XmlDocument catalogue = new XmlDocument();
            catalogue.Load("../../../catalogue.xml");

            XmlNode rootNode = catalogue.DocumentElement;

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                var artistNode = node["artist"];
                if (artistNode == null)
                {
                    continue;
                }

                string artist = artistNode.InnerText;
                if (artistsAlbums.ContainsKey(artist))
                {
                    artistsAlbums[artist] = 
                        Int32.Parse(artistsAlbums[artist].ToString()) + 1;
                }
                else
                {
                    artistsAlbums.Add(artist, 1);
                }
            }

            foreach (DictionaryEntry aa in artistsAlbums)
            {
                Console.WriteLine(" - {0}, albums: {1}", aa.Key, aa.Value);
            }
        }
    }
}
