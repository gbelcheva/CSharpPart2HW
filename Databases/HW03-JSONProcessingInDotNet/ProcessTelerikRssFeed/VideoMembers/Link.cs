namespace ProcessTelerikRssFeed.VideoMembers
{
    using Newtonsoft.Json;

    public class Link
    {
        [JsonProperty("@rel")]
        public string Relative { get; set; }

        [JsonProperty("@href")]
        public string Href { get; set; }
    }
}
