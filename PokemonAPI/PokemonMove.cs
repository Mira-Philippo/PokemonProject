using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI
{
    public class PokemonMove
    {
        public NamedAPIResource move {  get; set; }
        public List<PokemonMoveVersion> version_group_details { get; set; }
    }
}
