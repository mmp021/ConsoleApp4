using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp4
{
    // کلاس‌ها برای مدل‌های داده
    public class OrderRequest
    {
        public string Symbol { get; set; }
        public string Side { get; set; }
        public string Type { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
