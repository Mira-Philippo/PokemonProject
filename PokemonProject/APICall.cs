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
                FinalPokemon finalPokemon = new FinalPokemon();
                // Get data response
                var response = httpClient.GetAsync("pokemon/" + c).Result;
                if (response.IsSuccessStatusCode)
                {
                    var response2 = httpClient.GetAsync("pokemon-species/" + c).Result;
                    if (response2.IsSuccessStatusCode)
                    {
                        

                        // Parse the response bodies
                        var dataObjects = response.Content.ReadAsStringAsync().Result;
                        Pokemon pokemon = JsonSerializer.Deserialize<Pokemon>(dataObjects);
                        var dataObjects2 = response2.Content.ReadAsStringAsync().Result;
                        PokemonSpecies pokemonspecies = JsonSerializer.Deserialize<PokemonSpecies>(dataObjects2);

                        //GET SPRITES
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

                        if (spriteString[3] != "null")
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
                        } //FEMALE SPRITES

                        finalPokemon.pokedexID = pokemon.id;
                        finalPokemon.catchRate = pokemonspecies.capture_rate;
                        finalPokemon.HatchTime = pokemonspecies.hatch_counter;
                        finalPokemon.expYield = pokemon.base_experience;
                        finalPokemon.baseFriendship = pokemonspecies.base_happiness;
                        finalPokemon.genderRatio = pokemonspecies.gender_rate;
                        finalPokemon.height = pokemon.height;
                        finalPokemon.weight = pokemon.weight;

                        //Pokemon types
                        string[] split = ObjectToStringList(pokemon.types);
                        finalPokemon.Type1 = split[4];
                        if (split.Length > 6)
                        {
                            finalPokemon.Type2 = split[11];
                        }
                        else
                        {
                            finalPokemon.Type2 = "none";
                        }

                        //Egg groups
                        split = ObjectToStringList(pokemonspecies.egg_groups);
                        finalPokemon.eggGroup1 = split[1];
                        if (split.Length > 4)
                        {
                            finalPokemon.eggGroup2 = split[5];
                        }
                        else
                        {
                            finalPokemon.eggGroup2 = "none";
                        }

                        //Evolution Chain
                        string evoUrl = pokemonspecies.evolution_chain.ToString().Substring(34).TrimEnd('}', '"');
                        
                        var evoresponse = httpClient.GetAsync(evoUrl).Result;
                        if (evoresponse.IsSuccessStatusCode)
                        {
                            var evoData = evoresponse.Content.ReadAsStringAsync().Result;
                            evo evo = JsonSerializer.Deserialize<evo>(evoData);
                            
                            chainLink chain = JsonSerializer.Deserialize<chainLink>(evo.chain.ToString());
                            chainLink[] chainList = JsonSerializer.Deserialize<chainLink[]>(chain.evolves_to.ToString());
                            string currentPokemon = null;
                            string[] species;
                            string[] nextPokemon = new string[10];
                            string[] evoDetails = new string[10];
                            nextPokemon[0] = "none";
                            species = ObjectToStringList(chain.species);
                            if (species[1] == pokemon.name) //If the first pokemon in the evo line is the pokemon we're working on
                            {
                                //Next list of pokemon we encounter MUST be the evolutions
                                if (chainList.Length > 0)
                                {
                                    string[] evolutionDetailList;

                                    for (int i = 0; i < chainList.Length; i++) //Add each second pokemon
                                    {
                                        species = ObjectToStringList(chainList[i].species);
                                        nextPokemon[i] = species[1]; //Add to evo list
                                        evolutionDetailList = ObjectToStringList(chainList[i].evolution_details.ToString());
                                        evoDetails[i] = GetEvoDetails(evolutionDetailList);
                                    }
                                }
                            }
                            else if (chainList.Length > 0) //If its not the first pokemon, check one of the second
                            {
                                for (int i = 0; i < chainList.Length; i++) //Go through all second pokemon until we find our pokemon
                                {
                                    species = ObjectToStringList(chainList[i].species);
                                    if (species[1] == pokemon.name) //Our current pokemon is in the second stage
                                    {
                                        chainLink[] chainList2 = JsonSerializer.Deserialize<chainLink[]>(chainList[i].evolves_to.ToString());
                                        if (chainList2.Length > 0)
                                        {
                                            string[] evolutionDetailList;
                                            for (int i2 = 0; i2 < chainList2.Length; i2++)
                                            {
                                                species = ObjectToStringList(chainList2[i2].species);
                                                nextPokemon[i2] = species[1]; //Add to evo list
                                                evolutionDetailList = ObjectToStringList(chainList2[i2].evolution_details.ToString());
                                                evoDetails[i2] = GetEvoDetails(evolutionDetailList);
                                            }
                                            break;
                                        }
                                        break;
                                    }
                                }
                                //We didn't have a pokemon in the first or second stage which means we must have a third stage
                            }
                            finalPokemon.EvoDetails = evoDetails;
                            finalPokemon.Evolution = nextPokemon;
                        }

                        //Level group
                        string[] growth = ObjectToStringList(pokemonspecies.growth_rate);
                        finalPokemon.levelGroup = growth[1];

                        //Abilities
                        string[] abilitySplit;
                        finalPokemon.ability = new string[3];
                        int n = 0;
                        for (int i = 0; i < pokemon.abilities.Length; i++)
                        {
                            abilitySplit = ObjectToStringList(pokemon.abilities[i].ability);
                            if (pokemon.abilities[i].is_hidden)
                            {
                                finalPokemon.ability[2] = abilitySplit[1];
                            }
                            else
                            { finalPokemon.ability[n] = abilitySplit[1]; }
                            n++;
                        }
                        if (finalPokemon.ability[1] == null)
                        {
                            finalPokemon.ability[1] = "none";
                        }
                    }
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
        public static string GetEvoDetails(string[] detail)
        {
            string text = "";
            int nextInt = 0;
            for (int i = 0; i < detail.Length; i++)
            {
                if (0 == 0)
                {
                    nextInt = i + 1;
                    if (detail[i] == "item" && detail[nextInt] != "null")
                    {
                        text += "item:" + detail[nextInt + 1] + ",";
                    }
                    if (detail[i] == "trigger" && detail[nextInt] != "null")
                    {
                        text += "trigger:" + detail[nextInt + 1] + ",";
                    }
                    if (detail[i] == "gender" && detail[nextInt] != "null")
                    {
                        text += "gender:" + detail[nextInt] + ",";
                    }
                    if (detail[i] == "held_item" && detail[nextInt] != "null")
                    {
                        text += "held_item:" + detail[nextInt] + ",";
                    }
                    if (detail[i] == "known_move" && detail[nextInt] != "null")
                    {
                        text += "known_move:" + detail[nextInt + 1] + ",";
                    }
                    if (detail[i] == "known_move_type" && detail[nextInt] != "null")
                    {
                        text += "known_move_type:" + detail[nextInt + 1] + ",";
                    }
                    if (detail[i] == "location" && detail[nextInt] != "null")
                    {
                        text += "location:" + detail[nextInt + 1] + ",";
                    }
                    if (detail[i] == "min_level" && detail[nextInt] != "null")
                    {
                        text += "min_level:" + detail[nextInt] + ",";
                    }
                    if (detail[i] == "min_happiness" && detail[nextInt] != "null")
                    {
                        text += "min_happiness:" + detail[nextInt] + ",";
                    }
                    if (detail[i] == "needs_overworld_rain" && detail[nextInt] != "false")
                    {
                        text += "needs_overworld_rain:" + detail[nextInt] + ",";
                    }
                    if (detail[i] == "party_species" && detail[nextInt] != "null")
                    {
                        text += "party_species:" + detail[nextInt] + ",";
                    }
                    if (detail[i] == "party_type" && detail[nextInt] != "null")
                    {
                        text += "party_type:" + detail[nextInt] + ",";
                    }
                    if (detail[i] == "relative_physical_stats" && detail[nextInt] != "null")
                    {
                        text += "relative_physical_stats:" + detail[nextInt] + ",";
                    }
                    if (detail[i] == "time_of_day" && detail[nextInt] != "trade_species")
                    {
                        text += "time_of_day:" + detail[nextInt] + ",";
                    }
                    if (detail[i] == "trade_species" && detail[nextInt] != "null")
                    {
                        text += "trade_species:" + detail[nextInt] + ",";
                    }
                    if (detail[i] == "turn_upside_down" && detail[nextInt] != "false")
                    {
                        text += "turn_upside_down:" + detail[nextInt] + ",";
                    }
                    if (detail[i] == "min_beauty" && detail[nextInt] != "null")
                    {
                        text += "min_beauty:" + detail[nextInt] + ",";
                    }
                    if (detail[i] == "min_affection" && detail[nextInt] != "null")
                    {
                        text += "min_affection:" + detail[nextInt] + ",";
                    }
                    if (detail[i] == "turn_upside_down")
                    {
                        break;
                    }
                }
            }
            return text;
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
        public pokemonAbility[] abilities { get; set; }

        //public PokemonMove[] moves { get; set; }

        //public object stats { get; set; } //BaseStats
    }

    public class PokemonSpecies
    {
        public int capture_rate { get; set; } //Catchrate
        public int hatch_counter { get; set; } //HatchTime
        public int base_happiness { get; set; } //BaseFriendship
        public float gender_rate { get; set; } //genderRatio
        public object egg_groups { get; set; } //egg groups
        public object growth_rate { get; set; } //levelGroup
        public object evolution_chain { get; set; } //Evolution
    }

    struct FinalPokemon
    {
        public int pokedexID;
        public int catchRate;
        public int HatchTime;
        public int expYield;
        public int baseFriendship;

        public float genderRatio;
        public float height;
        public float weight;

        public string eggGroup1;
        public string eggGroup2;
        public string Type1;
        public string Type2;
        public string levelGroup;
        public int[] EVYield;
        public int[] BaseStats;
        public string[] ability;
        public string[] Evolution;
        public string[] EvoDetails;
        public string moveList;
        public string Sprite;
    }

    public class EvolutionDetail
    {
        public object item { get; set; }
        public object trigger { get; set; }
        public object gender { get; set; }
        public object held_item { get; set; }
        public object known_move { get; set; }
        public object known_move_type { get; set; }
        public object location { get; set; }
        public object min_level { get; set; }
        public object min_happiness { get; set; }
        public object needs_overworld_rain { get; set; }
        public object party_species { get; set; }
        public object party_type { get; set; }
        public object relative_physical_stats { get; set; }
        public object time_of_day { get; set; }
        public object trade_species { get; set; }
        public object turn_upside_down { get; set; }
        public object min_beauty { get; set; }
        public object min_affection { get; set; }
    }

    public class PokemonSprites
    {
        public object versions { get; set; }
    }

    public class pokemonAbility
    {
        public bool is_hidden { get; set; }
        public int slot { get; set; }
        public object ability { get; set; }
    }

    public class chainLink
    {
        public bool is_baby { get; set; }
        public object species { get; set; }
        public object evolution_details { get; set; } //what causes the evo
        public object evolves_to { get; set; } //what it evolves into
    }

    

    public class evo
    {
        public object chain { get; set; }
    }
}
