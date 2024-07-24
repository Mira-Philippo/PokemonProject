using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI
{
    public class EvolutionChain
    {
        public int id {  get; set; }
        public NamedAPIResource baby_trigger_item { get; set; }
        public ChainLink chain {  get; set; }

    }
}
