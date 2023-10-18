using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp4
{
    public class BinanceAPIException : Exception
    {
        public BinanceAPIException(string message) : base(message) { }
    }
}
