using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteamProject.src.models
{
    class AppNews
    {
        /// <summary>
        /// Private instance variables
        /// </summary>
        [JsonProperty("appid")]
        public long AppId { get; set; }

        [JsonProperty("newsitems")]
        public NewsItem[] NewsItems { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        //public int AppId { get => appId; set => appId = value; }
        //public int Count { get => count; set => count = value; }
        //internal NewsItem[] NewsItems { get => newsItems; set => newsItems = value; }
    }
}
