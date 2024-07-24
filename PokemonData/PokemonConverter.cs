using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PokemonAPI;

namespace PokemonData
{
    public class PokemonConverter
    {
        //TODO
        //Switch moves to be ints, only save the ID
        //Switch abilities to their ID aswell
        //Flavor text entries should be the latest available entry
        public static PokemonConverter ConvertToConvertedPokemon(Pokemon pokemon, PokemonSpecies pokemonSpecies)
        {
            PokemonConverter converter = new PokemonConverter();
            converter.id = pokemon.id;
            converter.name = pokemon.name;
            converter.base_experience = pokemon.base_experience;
            converter.height = pokemon.height;
            converter.weight = pokemon.weight;
            converter.abilities = new List<string>();
            foreach (PokemonAbility ability in pokemon.abilities)
            {
                converter.abilities.Add(ability.ability.name + "-" + ability.is_hidden.ToString());
            }
            converter.game_indices = new List<string>();
            foreach (VersionGameIndex index in pokemon.game_indices)
            {
                converter.game_indices.Add(index.version.name);
            }
            converter.held_items = new List<string>();
            foreach (PokemonHeldItem item in pokemon.held_items)
            {
                converter.held_items.Add(item.item.name + "-" + item.version_details[0].version.name + ":" + item.version_details[0].rarity);
            }
            converter.location_area_encounters = pokemon.location_area_encounters;
            converter.past_types = new List<string>();
            foreach (PokemonTypePast pastType in pokemon.past_types)
            {
                converter.past_types.Add(pastType.types[0].type.name + "/" + pastType.types[1].type.name);
            }
            converter.stats = new List<int>();
            foreach (PokemonStat stat in pokemon.stats)
            {
                converter.stats.Add(stat.base_stat);
            }
            converter.types = new List<string>();
            foreach (PokemonType type in pokemon.types)
            {
                converter.types.Add(type.type.name);
            }
            converter.gender_rate = pokemonSpecies.gender_rate;
            converter.capture_rate = pokemonSpecies.capture_rate;
            converter.base_happiness = pokemonSpecies.base_happiness;
            converter.is_baby = pokemonSpecies.is_baby;
            converter.is_legendary = pokemonSpecies.is_legendary;
            converter.is_mythical = pokemonSpecies.is_mythical;
            converter.hatch_counter = pokemonSpecies.hatch_counter;
            converter.has_gender_differences = pokemonSpecies.has_gender_differences;
            converter.forms_switchable = pokemonSpecies.forms_switchable;
            if (pokemonSpecies.growth_rate != null)
            {
                converter.growth_rate = pokemonSpecies.growth_rate.name;
            }
            else
            {
                converter.growth_rate = null;
            }
            if (pokemonSpecies.pokedex_numbers != null)
            {
                converter.pokedex_numbers = new List<int>();
                foreach (PokemonSpeciesDexEntry entry in pokemonSpecies.pokedex_numbers)
                {
                    converter.pokedex_numbers.Add(entry.entry_number);
                }
            }
            else
            {
                converter.pokedex_numbers = null;
            }
            if (pokemonSpecies.egg_groups != null)
            {
                converter.egg_groups = new List<string>();
                foreach (NamedAPIResource eggGroup in pokemonSpecies.egg_groups)
                {
                    converter.egg_groups.Add(eggGroup.name);
                }
            }
            else
            {
                pokemonSpecies.egg_groups = null;
            }
            
            converter.color = pokemonSpecies.color.name;
            converter.shape = pokemonSpecies.shape.name;
            converter.habitat = pokemonSpecies.habitat.name;
            converter.generation = pokemonSpecies.generation.name;
            converter.pal_park_encounters = new List<string>();
            foreach (PalParkEncounterArea area in pokemonSpecies.pal_park_encounters)
            {
                converter.egg_groups.Add($"{area.area},{area.base_score},{area.rate}");
            }
            foreach (FlavorText text in pokemonSpecies.flavor_text_entries)
            {
                if (text.language.name == "en")
                {
                    converter.flavor_text_entries = text.flavor_text;
                    break;
                }
                
            }
            foreach (Description text in pokemonSpecies.form_descriptions)
            {
                if (text.language.name == "en")
                {
                    converter.form_descriptions = text.description;
                    break;
                }

            }
            foreach (Genus genus in pokemonSpecies.genera)
            {
                if (genus.language.name == "en")
                {
                    converter.genera = genus.genus;
                    break;
                }

            }
            converter.varieties = new List<string>();
            foreach (PokemonSpeciesVariety variety in pokemonSpecies.varieties)
            {
                converter.varieties.Add(variety.pokemon.name + "," + variety.is_default);

            }
            converter.moves = new List<string>();
            foreach (PokemonMove move in pokemon.moves)
            {
                converter.moves.Add(move.move.url);

            }
            if(pokemonSpecies.evolves_from_species != null)
            {
                converter.evolves_from_species = pokemonSpecies.evolves_from_species.name;
            }
            else
            {
                converter.evolves_from_species = null;
            }
            
            converter.evolution_chain = pokemonSpecies.evolution_chain.url;
            return converter;

        }
        public int id { get; set; }
        public string name { get; set; }
        public int base_experience { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public List<string> abilities { get; set; }
        public List<string> game_indices { get; set; }
        public List<string> held_items { get; set; }
        public string location_area_encounters { get; set; }
        public List<string> past_types { get; set; }
        public List<int> stats { get; set; }
        public List<string> types { get; set; }
        public int gender_rate { get; set; }
        public int capture_rate { get; set; }
        public int base_happiness { get; set; }
        public bool is_baby { get; set; }
        public bool is_legendary { get; set; }
        public bool is_mythical { get; set; }
        public int hatch_counter { get; set; }
        public bool has_gender_differences { get; set; }
        public bool forms_switchable { get; set; }
        public string growth_rate { get; set; }
        public List<int> pokedex_numbers { get; set; }
        public List<string> egg_groups { get; set; }
        public string color { get; set; }
        public string shape { get; set; }
        public string habitat { get; set; }
        public string generation { get; set; }
        public List<string> pal_park_encounters { get; set; }
        public string flavor_text_entries { get; set; }
        public string form_descriptions { get; set; }
        public string genera { get; set; }
        public List<string> varieties { get; set; }
        public string evolves_from_species { get; set; }
        public string evolution_chain { get; set; }
        
        public PokemonSprites sprites { get; set; }
        public PokemonCries cries { get; set; }
        public List<string> moves { get; set; }
    }
}
