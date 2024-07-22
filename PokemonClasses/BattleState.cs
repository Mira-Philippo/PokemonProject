using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonClasses
{
    public class BattleState
    {
        public BattleState() 
        {
            this.RANDOM = new Random();
        }
        public Weather Weather { get; set; }
        public Terrain Terrain { get; set; }
        public Move LastMove { get; set; }
        public List<Pokemon> PokemonSide1 { get; set; }
        public List<Pokemon> PokemonSide2 { get; set; }
        Random RANDOM { get; set; }
        public int Random { get { return this.RANDOM.Next(1,101); } }
    }
}
