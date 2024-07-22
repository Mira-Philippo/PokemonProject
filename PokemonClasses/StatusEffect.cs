using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonClasses
{
    public class StatusEffect
    {
        public static readonly StatusEffect Burn = new StatusEffect();
        public static readonly StatusEffect Sleep = new StatusEffect();
        public static readonly StatusEffect Freeze = new StatusEffect();
        public static readonly StatusEffect Paralysis = new StatusEffect();
        public static readonly StatusEffect Poison = new StatusEffect();
        public static readonly StatusEffect BadPoison = new StatusEffect();

        public int TurnsLeft;

        public void DecreaseTurn()
        {
            this.TurnsLeft--;
        }
    }
}
