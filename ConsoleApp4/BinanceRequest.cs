using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp4
{
    // کلاس برای ایجاد درخواست
    public class BinanceRequest
    {
        private readonly string _endpoint;
        private readonly HttpMethod _method;
        private readonly string _apiKey;

        public BinanceRequest(string endpoint, HttpMethod method, string apiKey)
        {
            _endpoint = endpoint;
            _method = method;
            _apiKey = apiKey;
        }

        public void SetContent(object content)
        {
            // تنظیم محتوا
        }

        public async Task<HttpResponseMessage> SendAsync(HttpClient httpClient)
        {
            return await httpClient.SendAsync(new HttpRequestMessage(_method, _endpoint));
        }
    }
}
