using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI
{
    public class PokemonHeldItem
    {
        NamedAPIResource item {  get; set; }
        List<PokemonHeldItemVersion> version_details { get; set; }
    }
}
