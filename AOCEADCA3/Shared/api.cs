using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace AOCEADCA3
{


    public static class apiServices
    {
        public static async Task<T> GetJsonAsync<T>(this HttpClient httpClient, string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url); //makes request
            request.Headers.Add("X-Auth-Token", "16d79050687f42ae97ae447501ec8b83"); //adds API key, in the header the API requires.

            var response = await httpClient.SendAsync(request);
            response.Headers.Add("Access-Control-Allow-Origin", "*"); //Allows for CORS in response headers
            response.EnsureSuccessStatusCode();

            var responseBytes = await response.Content.ReadAsByteArrayAsync();

            return JsonSerializer.Deserialize<T>(responseBytes);
        }
    }
}    
