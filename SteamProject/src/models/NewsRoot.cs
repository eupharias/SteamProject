using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteamProject.src.models
{
    class NewsRoot
    {
        [JsonProperty("appnews")]
        public AppNews Appnews { get; set; }
    }
}
