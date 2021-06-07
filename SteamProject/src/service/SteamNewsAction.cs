using SteamProject.src.constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteamProject.src.service
{
    abstract class SteamNewsAction
    {
        public static string GetSteamNewsURL(string appId, int numArticles, int maxArticleLength)
        {
            return SteamConstant.SteamNewsEndpoint + appId + "&count=" + numArticles + "&maxlength=" + maxArticleLength + "&format=json";
        }
    }
}
