using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI
{
    public class PokemonAbility
    {
        bool is_hidden { get; set; }
        int slot { get; set; }
        NamedAPIResource ability {  get; set; }
    }
}
