using PokemonClasses;
using System.Runtime.ConstrainedExecution;

namespace PokemonBattleCalculations
{
    public class BattleCalc
    {
        public int CalculateMoveDamage(Pokemon attackingPokemon, Pokemon defendingPokemon, Move attackingMove, BattleState state)
        {
            //(((2*level)/5)+2)
            float calculationResult = 0;
            calculationResult = 2 * defendingPokemon.Level;
            calculationResult /= 5;
            calculationResult += 2;
            calculationResult *= attackingMove.Power;
            float defenseCalc = attackingPokemon.statAttack / defendingPokemon.statDefense;
            calculationResult *= defenseCalc;
            calculationResult /= 50;
            calculationResult += 2;
            calculationResult *= WeatherCalculation(state.Weather, attackingMove);
            calculationResult *= GetRandomCrit(state.Random);
            Math.Floor(calculationResult);
            calculationResult *= GetRandomDamageFactor();
            calculationResult *= IsSTABMove();
            calculationResult *= TypeEffectiveness(defendingPokemon, attackingMove);
            if (attackingPokemon.IsBurned) { calculationResult *= 0.5f; };
            return (int)calculationResult;
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

        public float TypeEffectiveness(Pokemon defendingPokemon, Move attackingMove)
        {
            return 1f;
        }

        public float GetRandomCrit(int randomValue)
        {
            return 1;
        }
    }
}