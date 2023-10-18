using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp4
{
    // کلاس مدیریت کار با API
    public class APIManager : BinanceAPI
    {
        public APIManager(HttpClient httpClient, string apiKey) : base(httpClient, apiKey)
        {
        }

        public async Task<HttpResponseMessage> SendRequestAsync(BinanceRequest request) =>
            // ارسال درخواست و بازگشت پاسخ
            await request.SendAsync(HttpClient);
    }
}
