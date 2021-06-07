using Newtonsoft.Json;
using SteamProject.src.models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SteamProject.src.service
{
    abstract class SteamNews
    {        
        // GetArticles assumes a count of 3, and a max length of 300 characters, but can be adjusted.
        public static NewsRoot FetchArticles(string appId, int count = 3, int maxLength = 300)
        {
            string json = new WebClient().DownloadString(SteamNewsAction.GetSteamNewsURL(appId, count, maxLength));
            NewsRoot SteamNewsObj = JsonConvert.DeserializeObject<NewsRoot>(json);
            return SteamNewsObj;
        }


    }
}
