using SteamProject.src.service;
using System;

namespace SteamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(SteamNews.FetchArticles("440"));
        }
    }
}
