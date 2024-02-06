using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text.Json;

namespace API
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> moveIDList = new List<int>();
            int pokemonList = 493;


            pokemonList++;
            string[] finalList = new string[pokemonList - 1];
            int progress = 0;
            Console.WriteLine("Getting the data for " + (pokemonList - 1) + " pokemon...");
            DateTime startTime = DateTime.Now;

            //GET POKEMON
            string baseURL = "https://pokeapi.co/api/v2/";
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(baseURL);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            for (int c = 1; c < pokemonList; c++)
            {
                // Get data response
                var response = httpClient.GetAsync("pokemon/" + c).Result;
                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body
                    var dataObjects = response.Content.ReadAsStringAsync().Result;
                    Pokemon pokemon = JsonSerializer.Deserialize<Pokemon>(dataObjects);
                    string[] spriteString = ObjectToStringList(pokemon.sprites.versions);
                    spriteString = TrimArray(146, 162, spriteString);
                    //index 145 has the start of animated so we can cut everything before that away
                    Console.WriteLine();
                    /*
                    var response2 = httpClient.GetAsync("pokemon-species/" + c).Result;
                    if (response2.IsSuccessStatusCode)
                    {
                        var dataObjects2 = response2.Content.ReadAsStringAsync().Result;
                        PokemonSpecies pokemon2 = JsonSerializer.Deserialize<PokemonSpecies>(dataObjects2);
                    }
                    */
                }
            }
        }
        public static string[] TrimArray(int startIndex, int endIndex, string[] array) 
        {
            string[] returnArray = new string[endIndex-startIndex];
            int n = 0;
            for (int i = startIndex; i < endIndex; i++)
            {
                returnArray[n] = array[i];
                n++;
            }
            return returnArray;
        }
        public static string[] ObjectToStringList(object obj)
        {
            string json = obj.ToString();
            json = json.Replace('{', ' ');
            json = json.Replace('}', ' ');
            json = json.Replace('[', ' ');
            json = json.Replace(']', ' ');
            json = json.Replace(',', ' ');
            json = json.Replace('"', ' ');
            json = json.Replace(':', ' ');
            string[] split = json.Split(' ');
            
            int n = 0;
            for (int i = 0; i < split.Length; i++)
            {
                if (split[i] != "")
                {
                    n++;
                }
            }

            string[] returnList = new string[n];
            n = 0;
            for (int i = 0; i < split.Length; i++)
            {
                if (split[i] != "" && split[i] != "https")
                {
                    returnList[n] = split[i];
                    n++;
                }
            }
            return returnList;
        }
    }



    public class Pokemon
    {
        public string name { get; set; } //name
        public int id { get; set; } //pokedexID
        public int base_experience { get; set; } //expYield
        public float height { get; set; } // height
        public float weight { get; set; } // weight in hectograms
        public object types { get; set; } //types

        public PokemonSprites sprites { get; set; }
       // public pokemonStat[] stats { get; set; } //EVYield
        //public pokemonAbility[] abilities { get; set; }

        //public PokemonMove[] moves { get; set; }

        //public object stats { get; set; } //BaseStats
    }

    public class PokemonSprites
    {
        public object versions { get; set; }
    }
}