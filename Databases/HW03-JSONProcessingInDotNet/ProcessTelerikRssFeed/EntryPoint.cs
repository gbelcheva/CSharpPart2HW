namespace ProcessTelerikRssFeed
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using ProcessTelerikRssFeed.VideoMembers;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Xml;
    using System.Xml.Linq;

    public class EntryPoint
    {
        public static void Main()
        {
            string rssUrl = @"https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            string xmlOutputFile = "../../telerikRss.xml";

            if (!File.Exists(xmlOutputFile))
            {
                using (WebClient webclient = new WebClient())
                {
                    webclient.DownloadFile(rssUrl, xmlOutputFile);
                }
            }

            var xmlDoc = XDocument.Load(xmlOutputFile);
            var jsonDoc = JsonConvert.SerializeXNode(xmlDoc, Newtonsoft.Json.Formatting.Indented);
            var jsonObject = JObject.Parse(jsonDoc);

            var videoObjects = jsonObject["feed"]["entry"];
            var videoTitles = videoObjects.Select(v => string.Format("- {0}", v["title"])).ToArray();

            Console.WriteLine(string.Join("\n", videoTitles));

            var videoPocos = new List<Video>();
            foreach (var v in videoObjects)
            {
                var currentVideoPoco = JsonConvert.DeserializeObject<Video>(v.ToString());
                videoPocos.Add(currentVideoPoco);
            }

            GenerateHtml(videoPocos);
        }

        private static void GenerateHtml(List<Video> videoPocos)
        {
            string outputHtml = "../../telerikRss.html";

            XElement meta = new XElement("meta");
            meta.SetAttributeValue("charset", "utf-8");
            XElement head = new XElement("head");
            head.Add(meta);

            XElement title = new XElement("title");
            title.Value = "Telerik RSS Feed";
            head.Add(title);

            XElement html = new XElement("html");
            html.Add(head);

            XElement body = new XElement("body");
            foreach (var vPoco in videoPocos)
            {
                XElement videoLink = new XElement("a");
                videoLink.Value = vPoco.Title;
                videoLink.SetAttributeValue("href", vPoco.Link.Href);

                XElement linkWrapper = new XElement("h2");
                linkWrapper.Add(videoLink);

                XElement videoContainer = new XElement("div");
                videoContainer.SetAttributeValue("class", "video-container");
                videoContainer.Add(linkWrapper);

                XElement videoIFrame = new XElement("iframe");
                videoIFrame.SetAttributeValue("width", vPoco.Media.Content.Width);
                videoIFrame.SetAttributeValue("height", vPoco.Media.Content.Height);
                videoIFrame.SetAttributeValue("src", @"https://www.youtube.com/embed/" + vPoco.YtId);
                videoIFrame.Value = "";
                videoContainer.Add(videoIFrame);

                body.Add(videoContainer);
            }

            html.Add(body);

            XDocument htmlDoc = new XDocument();
            htmlDoc.AddFirst(new XDocumentType("html", null, null, null));
            htmlDoc.Add(html);

            var settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            settings.NewLineOnAttributes = true;
            settings.Indent = true;

            using (XmlWriter writer = XmlWriter.Create(outputHtml, settings))
            {
                htmlDoc.Save(writer);
            }
        }

    }
}
