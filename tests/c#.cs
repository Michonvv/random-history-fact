using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

class Program
{
    static async Task Main()
    {
        using (HttpClient client = new HttpClient())
        {
            string url = "https://randomhistoricalfact.000webhostapp.com/fact";
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Ensure a successful response

                string responseBody = await response.Content.ReadAsStringAsync();
                JObject data = JObject.Parse(responseBody);

                if (data.ContainsKey("fact"))
                {
                    Console.WriteLine(data["fact"]);
                }
                else
                {
                    Console.WriteLine("Error: 'fact' field not found in the response.");
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error fetching data: {e.Message}");
            }
        }
    }
}
