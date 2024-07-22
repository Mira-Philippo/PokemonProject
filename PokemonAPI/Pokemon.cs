using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PokemonAPI
{
    public class Pokemon
    {
        public int id {  get; set; }
        public string name { get; set; }
        public int base_experience { get; set; }
        public int height { get; set; }
        public bool is_default { get; set; }
        public int order { get; set; }
        public int weight { get; set; }
        public List<PokemonAbility> abilities { get; set; }
        public List<NamedAPIResource> forms { get; set; }
        public List<VersionGameIndex> game_indices { get; set; }
        public List<PokemonHeldItem> held_items { get; set; }
        public string location_area_encounters { get; set; }
        public List<PokemonMove> moves { get; set; }
        public List<PokemonTypePast> past_types { get; set; }
        public PokemonSprites sprites { get; set; }
        public PokemonCries cries { get; set; }
        public NamedAPIResource species { get; set; }
        public List<PokemonStat> stats { get; set; }
        public List<PokemonType> types { get; set; }

        public static Pokemon ConvertJsonToObject(string json)
        {
            return JsonSerializer.Deserialize<Pokemon>(json);
        }

        public static Pokemon GetPokemon(object pokemonIdentification, ApiConnection conn)
        {
            string data = string.Empty;
            if (pokemonIdentification is string str)
            {
                data = (string)conn.GetResultFromUrl("pokemon/" + str.ToLower());
            }
            else if (pokemonIdentification is int num)
            {
                data = (string)conn.GetResultFromUrl("pokemon/" + num);
            }
            Pokemon result = Pokemon.ConvertJsonToObject(data);
            return result;
        }

        public void Print()
        {
            Console.WriteLine($"{this.name[0].ToString().ToUpper()}{this.name.Substring(1)} - {this.id}");
            if(this.types.Count > 1 )
            {
                Console.WriteLine($"Types: {this.types[0].type.name} and {this.types[1].type.name}");
            }
            else
            {
                Console.WriteLine($"Type: {this.types[0].type.name}");
            }
            Console.WriteLine($"Height: {this.height}   Weight: {this.weight}");
            Console.WriteLine($"Stats:");
            foreach (PokemonStat stat in this.stats)
            {
                Console.WriteLine(" - " + stat.stat.name + ": " + stat.base_stat);
            }

        }
    }
}
