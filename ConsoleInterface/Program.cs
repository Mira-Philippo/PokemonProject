using PokemonBattleCalculations;
using PokemonAPI;
using PokemonData;
namespace ConsoleInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while (true)
            {
                Console.WriteLine("What do you want to open?");
                Console.WriteLine("API, BATTLE");
                input = Console.ReadLine();
                if (input == "API" || input == "BATTLE")
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Unknown command entered: {input}");
                }
            }
            if(input == "API")
            {
                Console.WriteLine("Starting API...");
                ApiConnection connection = new ApiConnection();
                
                while (true)
                {
                    Console.WriteLine("From what pokemon do you want to save the data?");
                    input = Console.ReadLine();
                    Pokemon pokemon = Pokemon.GetPokemon(input, connection);
                    SaveData.SavePokemonDataToFile(pokemon);
                    pokemon.Print();
                }
            }
            else if(input == "BATTLE")
            {
                Console.WriteLine("Starting Pokemon Battle Calculator...");
                BattleCalc calc = new BattleCalc();
                calc.CalculateMoveDamage(null, null, null, null);
            }
            
        }
    }
}
