using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI
{
    public class PokemonHeldItem
    {
        public NamedAPIResource item {  get; set; }
        public List<PokemonHeldItemVersion> version_details { get; set; }
    }
}
