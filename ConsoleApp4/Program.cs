using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp4
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string apiKey = "YOUR_API_KEY";
            var httpClient = new HttpClient();
            var orderManager = new OrderManager(httpClient, apiKey);
            var modelManager = new ModelManager();

            var order = modelManager.CreateOrder("BTCUSDT", "BUY", "LIMIT", 1, 10000);
            var response = await orderManager.PlaceOrderAsync(order);

            if (response != null)
            {
                Console.WriteLine("سفارش با موفقیت ثبت شد");
            }
        }
    }
}
