using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp4
{
    // کلاس مدیریت کلاسهای مدل داده
    public class ModelManager
    {
        public OrderRequest CreateOrder(string symbol, string side, string type, decimal quantity, decimal price)
        {
            return new OrderRequest
            {
                Symbol = symbol,
                Side = side,
                Type = type,
                Quantity = quantity,
                Price = price,
            };
        }
    }
}
