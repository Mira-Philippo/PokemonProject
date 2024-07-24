using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI
{
    public class EvolutionDetail
    {
        public NamedAPIResource item {  get; set; }
        public NamedAPIResource trigger { get; set; }
        public int gender { get; set; }
        public NamedAPIResource held_item { get; set; }
        public NamedAPIResource known_move { get; set; }
        public NamedAPIResource known_move_type { get; set; }
        public NamedAPIResource location { get; set; }
        public int min_level { get; set; }
        public int min_happiness { get; set;}
        public int min_beauty { get; set; }
        public int min_affection { get; set; }
        public bool needs_overworld_rain { get; set; }
        public NamedAPIResource party_species { get; set; }
        public NamedAPIResource party_type { get; set; }
        public int relative_physical_stats { get; set; }
        public string time_of_day { get; set; }
        public NamedAPIResource trade_species { get; set; }
        public bool turn_upside_down { get; set; }
    }
}
