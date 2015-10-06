namespace ProcessTelerikRssFeed.VideoMembers
{
    using Newtonsoft.Json;

    public class Community
    {
        [JsonProperty("media:starRating")]
        public Rating StarRating { get; set; }

        [JsonProperty("media:statistics")]
        public Statistics Statistics { get; set; }
    }
}
