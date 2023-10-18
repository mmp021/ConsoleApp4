using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp4
{
    // کلاس پایه برای ارتباط با API
    public class BinanceAPI
    {
        protected readonly HttpClient HttpClient;
        protected readonly string ApiKey;

        public BinanceAPI(HttpClient httpClient, string apiKey)
        {
            HttpClient = httpClient;
            ApiKey = apiKey;
        }
    }
}
