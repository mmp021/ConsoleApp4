using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp4
{
    // کلاس مدیریت سفارشات
    public class OrderManager : BinanceAPI
    {
        public OrderManager(HttpClient httpClient, string apiKey) : base(httpClient, apiKey)
        {
        }

        public async Task<OrderResponse> PlaceOrderAsync(OrderRequest order)
        {
            try
            {
                var request = new BinanceRequest("api/v3/order/place", HttpMethod.Post, ApiKey);
                request.SetContent(order);
                var response = await new APIManager(HttpClient, ApiKey).SendRequestAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<OrderResponse>(json);
                }
                else
                {
                    throw new BinanceAPIException("خطا در ثبت سفارش");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new BinanceAPIException("Error connecting to the API: " + ex.Message);
            }
        }
    }
}
