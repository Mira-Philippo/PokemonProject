using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI
{
    public class PokemonTypePast
    {
        public NamedAPIResource generation {  get; set; }
        public List<PokemonType> types { get; set; }
    }
}
