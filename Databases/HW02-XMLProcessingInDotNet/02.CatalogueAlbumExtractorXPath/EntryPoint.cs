namespace CatalogueAlbumExtractorXPath
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

            string xPathPattern = "/catalogue/album";

            XmlNodeList albums = catalogue.SelectNodes(xPathPattern);

            foreach (XmlNode albumNode in albums)
            {
                var currentArtistNode = albumNode.SelectSingleNode("artist");
                if (currentArtistNode == null)
                {
                    continue;
                }

                string artist = currentArtistNode.InnerText;
                if (artistsAlbums.ContainsKey(artist))
                {
                    artistsAlbums[artist] = Int32.Parse(artistsAlbums[artist].ToString()) + 1;
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
