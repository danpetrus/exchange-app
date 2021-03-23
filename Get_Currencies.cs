using System.Net.Http;
using System.Threading.Tasks;
using System;
using Newtonsoft.Json.Linq;

namespace ArrPairs
{
    class Program
    {

        static async Task Main(string[] args)
        {
            using var client = new HttpClient();

            var result = await client.GetStringAsync("https://v6.exchangerate-api.com/v6/7438098b253ff4a245c445c0/latest/RON");

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(result);

            JObject items = JObject.Parse(result);

            var id = items["conversion_rates"].ToString();

            Console.WriteLine(id);

        }
    }

}

