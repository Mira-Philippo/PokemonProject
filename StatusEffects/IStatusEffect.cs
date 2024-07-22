using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonClasses;

namespace StatusEffects
{
    public interface IStatusEffect
    {
        string Name { get; }
        public void StatusConditionEnd();
        public void StatusConditionStart();
        public void StatusConditionActivate();

    }
}
