using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProxyAPI2.ApiClient
{
    public class ApiClient
    {

        static HttpClient client = new HttpClient();

        public static async Task<string> Get(string url, string parameter, int id)
        {
            string serviceUrl = $"{url}{parameter}{id}";
            using (var r = await client.GetAsync(new Uri(serviceUrl)))
                return await r.Content.ReadAsStringAsync();
        }

    }
}
