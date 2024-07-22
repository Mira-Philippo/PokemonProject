using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI
{
    public class PokemonMove
    {
        NamedAPIResource move {  get; set; }
        List<PokemonMoveVersion> version_group_details { get; set; }
    }
}
