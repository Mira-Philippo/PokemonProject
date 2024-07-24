using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI
{
    public class EvolutionTrigger
    {
        public int id {  get; set; }
        public string name { get; set; }
        public List<Name> names { get; set; }
        public List<NamedAPIResource> pokemon_species { get; set; }
    }
}
