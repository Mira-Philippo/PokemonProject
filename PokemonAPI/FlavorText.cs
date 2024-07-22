using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI
{
    public class FlavorText
    {
        public string flavor_text {  get; set; }
        public NamedAPIResource language { get; set; }
        public NamedAPIResource version {  get; set; }
    }
}
