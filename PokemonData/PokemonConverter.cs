using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PokemonAPI;

namespace PokemonData
{
    public class PokemonConverter
    {
        public static string ConvertToJson(Pokemon pokemon, PokemonSpecies pokemonSpecies)
        {
            id = pokemon.id;
            name = pokemon.name;
            base_experience = pokemon.base_experience;
            height = pokemon.height;
            weight = pokemon.weight;
            abilities = new List<string>();
            foreach (PokemonAbility ability in pokemon.abilities)
            {
                abilities.Add(ability.ability.name + "-" + ability.is_hidden.ToString());
            }
            foreach (VersionGameIndex index in pokemon.game_indices)
            {
                game_indices.Add(index.version.name);
            }
            foreach (PokemonHeldItem item in pokemon.held_items)
            {
                held_items.Add(item.item.name + "-" + item.version_details[0].version.name + ":" + item.version_details[0].rarity);
            }
            location_area_encounters = pokemon.location_area_encounters;
            foreach (PokemonTypePast pastType in pokemon.past_types)
            {
                past_types.Add(pastType.types[0].type.name + "/" + pastType.types[1].type.name);
            }

        }
        public static int id { get; set; }
        public static string name { get; set; }
        public static int base_experience { get; set; }
        public static int height { get; set; }
        public static int weight { get; set; }
        public static List<string> abilities { get; set; }
        public static List<string> game_indices { get; set; }
        public static List<string> held_items { get; set; }
        public static string location_area_encounters { get; set; }
        public static List<string> past_types { get; set; }
        
        public static List<PokemonStat> stats { get; set; }
        public static List<PokemonType> types { get; set; }

        public static int gender_rate { get; set; }
        public static int capture_rate { get; set; }
        public static int base_happiness { get; set; }
        public static bool is_baby { get; set; }
        public static bool is_legendary { get; set; }
        public static bool is_mythical { get; set; }
        public static int hatch_counter { get; set; }
        public static bool has_gender_differences { get; set; }
        public static bool forms_switchable { get; set; }
        public static NamedAPIResource growth_rate { get; set; }
        public static List<PokemonSpeciesDexEntry> pokedex_numbers { get; set; }
        public static List<NamedAPIResource> egg_groups { get; set; }
        public static NamedAPIResource color { get; set; }
        public static NamedAPIResource shape { get; set; }
        public static NamedAPIResource evolves_from_species { get; set; }
        public static APIResource evolution_chain { get; set; }
        public static NamedAPIResource habitat { get; set; }
        public static NamedAPIResource generation { get; set; }
        public static List<Name> names { get; set; }
        public static PalParkEncounterArea pal_park_encounters { get; set; }
        public static List<FlavorText> flavor_text_entries { get; set; }
        public static List<Description> form_descriptions { get; set; }
        public List<Genus> genera { get; set; }
        public List<PokemonSpeciesVariety> varieties { get; set; }


        public PokemonSprites sprites { get; set; }
        public PokemonCries cries { get; set; }
        public List<PokemonMove> moves { get; set; }
    }
}
