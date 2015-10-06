namespace ProcessTelerikRssFeed.VideoMembers
{
    using Newtonsoft.Json;

    public class Media
    {
        [JsonProperty("media:title")]
        public string Title { get; set; }

        [JsonProperty("media:content")]
        public Content Content { get; set; }

        [JsonProperty("media:thumbnail")]
        public Content Thumbnail { get; set; }

        [JsonProperty("media:description")]
        public string Description { get; set; }

        [JsonProperty("media:community")]
        public Community Community { get; set; }
    }
}
