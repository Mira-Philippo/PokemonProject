using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Resources;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net;
using System.Drawing;
using System.IO;


namespace PokemonProject
{
    public class APICall
    {
        public static void CallAPI()
        {
            List<int> moveIDList = new List<int>();
            int pokemonList = 20;


            pokemonList++;
            string[] finalList = new string[pokemonList - 1];
            int progress = 0;
            Console.WriteLine("Getting the data for " + (pokemonList - 1) + " pokemon...");
            DateTime startTime = DateTime.Now;

            //GET POKEMON
            string baseURL = "https://pokeapi.co/api/v2/";
            HttpClient httpClient = new HttpClient();
            WebClient webClient = new WebClient();
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
                    
                    Image image = null;
                    image = Image.FromStream(new MemoryStream(webClient.DownloadData("https:" + spriteString[1])));
                    image.Save($"..\\..\\..\\PokemonSprites/pokemon_{c:000}_{spriteString[0]}.gif");
                    image = Image.FromStream(new MemoryStream(webClient.DownloadData("https:" + spriteString[5])));
                    image.Save($"..\\..\\..\\PokemonSprites/pokemon_{c:000}_{spriteString[4]}.gif");
                    image = Image.FromStream(new MemoryStream(webClient.DownloadData("https:" + spriteString[9])));
                    image.Save($"..\\..\\..\\PokemonSprites/pokemon_{c:000}_{spriteString[8]}.gif");
                    image = Image.FromStream(new MemoryStream(webClient.DownloadData("https:" + spriteString[13])));
                    image.Save($"..\\..\\..\\PokemonSprites/pokemon_{c:000}_{spriteString[12]}.gif");
                    
                    

                    if(spriteString[3] != "null")
                    {
                        image = null;
                        image = Image.FromStream(new MemoryStream(webClient.DownloadData("https:" + spriteString[3])));
                        image.Save($"..\\..\\..\\PokemonSprites/pokemon_{c:000}_{spriteString[2]}.gif");
                        image = Image.FromStream(new MemoryStream(webClient.DownloadData("https:" + spriteString[7])));
                        image.Save($"..\\..\\..\\PokemonSprites/pokemon_{c:000}_{spriteString[6]}.gif");
                        image = Image.FromStream(new MemoryStream(webClient.DownloadData("https:" + spriteString[11])));
                        image.Save($"..\\..\\..\\PokemonSprites/pokemon_{c:000}_{spriteString[10]}.gif");
                        image = Image.FromStream(new MemoryStream(webClient.DownloadData("https:" + spriteString[15])));
                        image.Save($"..\\..\\..\\PokemonSprites/pokemon_{c:000}_{spriteString[14]}.gif");
                    }
                    
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
            webClient.Dispose();
            httpClient.Dispose();
        }
        public static string[] TrimArray(int startIndex, int endIndex, string[] array)
        {
            string[] returnArray = new string[endIndex - startIndex];
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
