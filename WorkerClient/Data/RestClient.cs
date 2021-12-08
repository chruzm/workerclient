using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Client.Data;
using WorkerClient.Models;

namespace WorkerClient.Data
{
    public class RestClient : ITest
    {
        public async Task<OrderObject> ReceiveOrdersAsync(int itemnumber)
        {
            using HttpClient client = new HttpClient();
            
            HttpResponseMessage responseMessage = await client.GetAsync("http://localhost:8080/orders/"+itemnumber);
            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception(@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");

            
            string result = await responseMessage.Content.ReadAsStringAsync();
            OrderObject item = JsonSerializer.Deserialize<OrderObject>(result, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            //Console.WriteLine(item.adr);
            return item ;
        }
    }
}