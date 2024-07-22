using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net;

namespace PokemonAPI
{
    public class ApiConnection
    {
        const string baseURL = "https://pokeapi.co/api/v2/";
        HttpClient httpClient = new HttpClient();
        public WebClient webClient = new WebClient();

        public ApiConnection()
        {
            httpClient.BaseAddress = new Uri(baseURL);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public object GetResultFromUrl(string url)
        {
            var response = httpClient.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                throw new Exception("Something went wrong when establishing connection: " + response.StatusCode.ToString());
            }
        }
        
    }
}
