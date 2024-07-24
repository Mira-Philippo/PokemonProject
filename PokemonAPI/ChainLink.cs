using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI
{
    public class ChainLink
    {
        public bool is_baby {  get; set; }
        public NamedAPIResource species { get; set; }
        public EvolutionDetail evolution_details { get; set; }
        public ChainLink evolves_to { get; set; }

    }
}
