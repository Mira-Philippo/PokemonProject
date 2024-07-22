using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI
{
    public class PokemonMoveVersion
    {
        NamedAPIResource move_learn_method {  get; set; }
        NamedAPIResource version_group { get; set; }
        int level_learned_at { get; set; }
    }
}
