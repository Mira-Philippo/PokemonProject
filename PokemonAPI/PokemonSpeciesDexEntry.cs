using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI
{
    public class PokemonSpeciesDexEntry
    {
        public int entry_number {  get; set; }
        public NamedAPIResource pokedex {  get; set; }
    }
}
