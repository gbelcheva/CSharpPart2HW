namespace ProcessTelerikRssFeed.VideoMembers
{
    using Newtonsoft.Json;
    using System;

    public class Video
    {
        public string Id { get; set; }

        [JsonProperty("yt:videoId")]
        public string YtId { get; set; }

        [JsonProperty("yt:channelId")]
        public string YtChannelId { get; set; }

        public string Title { get; set; }

        public Link Link { get; set; }

        public Author Author { get; set; }

        [JsonProperty("published")]
        public DateTime PublishedDate { get; set; }

        [JsonProperty("updated")]
        public DateTime UpdatedDate { get; set; }

        [JsonProperty("media:group")]
        public Media Media { get; set; }
    }
}
