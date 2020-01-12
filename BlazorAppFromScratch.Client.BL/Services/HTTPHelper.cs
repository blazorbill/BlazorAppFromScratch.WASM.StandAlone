using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppFromScratch.Client.BL.Services
{
    public static class HTTPHelper
    {
        public static HttpClient client = new HttpClient();
        public async static Task<T> HttpGet<T>(string uri)
        {

            var request = new HttpRequestMessage(HttpMethod.Get,
                $"https://localhost:44301/api/{uri}");
            request.Headers.Add("Accept", "application/json");

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var myName = JsonConvert.DeserializeObject<T>(json);
                return myName;
            }
            else
            {
                throw new System.Exception();
            }
        }
    }

}
