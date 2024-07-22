using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI
{
    public class PokemonSpecies
    {
        public int id {  get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public int gender_rate { get; set; }
        public int capture_rate { get; set; }
        public int base_happiness { get; set; }
        public bool is_baby { get; set; }
        public bool is_legendary { get; set; }
        public bool is_mythical { get; set; }
        public int hatch_counter { get; set; }
        public bool has_gender_differences { get; set; }
        public bool forms_switchable { get; set; }
        public NamedAPIResource growth_rate { get; set; }
        public List<PokemonSpeciesDexEntry> pokedex_numbers { get; set; }
        public List<NamedAPIResource> egg_groups { get; set; }
        public NamedAPIResource color {  get; set; }
        public NamedAPIResource shape { get; set; }
        public NamedAPIResource evolves_from_species { get; set; }
        public APIResource evolution_chain { get; set; }
        public NamedAPIResource habitat {  get; set; }
        public NamedAPIResource generation { get; set; }
        public List<Name> names { get; set; }
        public PalParkEncounterArea pal_park_encounters { get; set; }
        public List<FlavorText> flavor_text_entries { get; set; }
        public List<Description> form_descriptions { get; set; }
        public List<Genus> genera {  get; set; }
        public List<PokemonSpeciesVariety> varieties { get; set; }
    }
}
