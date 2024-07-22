using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonClasses
{
    public class Pokemon
    {
        public string Name;
        public int Id;
        public List<StatusEffect> effects = new List<StatusEffect>();
        public Move[] moves = new Move[4];
        public PokemonStats stats = new PokemonStats();
        public HeldItem heldItem;
        public Ability ability;
        public Type type1;
        public Type type2;
        public int Level;

        public Move Move1 {
            get 
            {
                return moves[0];
            }
            set
            {
                moves[0] = value;
            }
        }
        public Move Move2
        {
            get
            {
                return moves[1];
            }
            set
            {
                moves[1] = value;
            }
        }
        public Move Move3
        {
            get
            {
                return moves[2];
            }
            set
            {
                moves[2] = value;
            }
        }
        public Move Move4
        {
            get
            {
                return moves[3];
            }
            set
            {
                moves[3] = value;
            }
        }

        public int statAttack
        {
            get
            {
                return this.stats.Attack;
            }
            set
            {
                this.stats.Attack = value;
            }
        }
        public int statSpecialAttack
        {
            get
            {
                return this.stats.SpecialAttack;
            }
            set
            {
                this.stats.SpecialAttack = value;
            }
        }
        public int statDefense
        {
            get
            {
                return this.stats.Defense;
            }
            set
            {
                this.stats.Defense = value;
            }
        }
        public int statSpecialDefense
        {
            get
            {
                return this.stats.SpecialDefense;
            }
            set
            {
                this.stats.SpecialDefense = value;
            }
        }
        public int statHealth
        {
            get
            {
                return this.stats.Health;
            }
            set
            {
                this.stats.Health = value;
            }
        }
        public int statSpeed
        {
            get
            {
                return this.stats.Speed;
            }
            set
            {
                this.stats.Speed = value;
            }
        }

        public bool IsBurned { get { if (this.effects.Contains(StatusEffect.Burn)){ return true; } return false; } }
    }
}
