using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI
{
    public class PokemonAbility
    {
        public bool is_hidden { get; set; }
        public int slot { get; set; }
        public NamedAPIResource ability {  get; set; }
    }
}
