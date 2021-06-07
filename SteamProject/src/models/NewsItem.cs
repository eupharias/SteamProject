using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteamProject.src.models
{
    class NewsItem
    {
        /// <summary>
        /// public instance variables
        /// </summary>
        [JsonProperty("gid")]
        public string Gid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("is_external_url")]
        public bool IsExternalUrl { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("contents")]
        public string Contents { get; set; }

        [JsonProperty("feedlabel")]
        public string FeedLabel { get; set; }

        [JsonProperty("date")]
        public long Date { get; set; }

        [JsonProperty("feedname")]
        public string FeedName { get; set; }

        [JsonProperty("feed_type")]
        public long FeedType { get; set; }

        [JsonProperty("appid")]
        public long AppId { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Tags { get; set; }

        //public int Gid { get => gid; set => gid = value; }
        //public string Title { get => title; set => title = value; }
        //public string Url { get => url; set => url = value; }
        //public bool IsExternalUrl { get => isExternalUrl; set => isExternalUrl = value; }
        //public string Author { get => author; set => author = value; }
        //public string Contents { get => contents; set => contents = value; }
        //public string FeedLabel { get => feedLabel; set => feedLabel = value; }
        //public string Date { get => date; set => date = value; }
        //public string FeedName { get => feedName; set => feedName = value; }
        //public int FeedType { get => feedType; set => feedType = value; }
        //public int AppId { get => appId; set => appId = value; }
    }
}
