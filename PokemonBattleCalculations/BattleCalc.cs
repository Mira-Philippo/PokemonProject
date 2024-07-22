using PokemonClasses;
using System.Runtime.ConstrainedExecution;

namespace PokemonBattleCalculations
{
    public class BattleCalc
    {
        public int CalculateMoveDamage(Pokemon attackingPokemon, Pokemon defendingPokemon, Move attackingMove, Weather weather)
        {
            //(((2*level)/5)+2)
            float calculationResult = 0;
            calculationResult = 2 * defendingPokemon.Level;
            calculationResult /= 5;
            calculationResult += 2;
            calculationResult *= attackingMove.Power;
            float defenseCalc = attackingPokemon.Attack / defendingPokemon.Defense;
            calculationResult *= defenseCalc;
            calculationResult /= 50;
            calculationResult += 2;
            calculationResult *= WeatherCalculation(weather, attackingMove);
            calculationResult *= GetRandomCrit();
            Math.Floor(calculationResult);
            calculationResult *= GetRandomDamageFactor();
            calculationResult *= IsSTABMove();
            calculationResult *= TypeEffectiveness(defendingPokemon, attackingMove);
            calculationResult *= attackingPokemon.IsBurned;
            return calculationResult;
        }

        public int WeatherCalculation(Weather weather, Move affectedMove)
        {
            return 1;
        }

        public float GetRandomDamageFactor()
        {
            return 1f;
        }
        public float IsSTABMove()
        {
            return 1f;
        }

        public float TypeEffectiveness(PokemonStats defendingPokemon, Move attackingMove)
        {
            return 1f;
        }
    }
}