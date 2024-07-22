using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI
{
    public class PokemonStat
    {
        public NamedAPIResource stat {  get; set; }
        public int effort { get; set; }
        public int base_stat { get; set; }
    }
}
