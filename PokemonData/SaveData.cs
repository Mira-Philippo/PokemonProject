using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PokemonAPI;

namespace PokemonData
{
    public class SaveData
    {
        static string MoveDataFolderPath;
        static string PokemonDataFolderPath;
        static string SpritesDataFolderPath;

        static void SetupSaveData()
        {
            
                DirectoryInfo rootDirectory = new DirectoryInfo(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                string projectRootMarker = "PokemonProject.sln";

                while (rootDirectory != null && !File.Exists(Path.Combine(rootDirectory.FullName, projectRootMarker)))
                {
                rootDirectory = rootDirectory.Parent;
                }

            if (rootDirectory.FullName != null)
            {
                MoveDataFolderPath = rootDirectory.FullName + "/PokemonData/Data/Moves";
                PokemonDataFolderPath = rootDirectory.FullName + "/PokemonData/Data/Pokemon";
                SpritesDataFolderPath = rootDirectory.FullName + "/PokemonData/Data/Sprites";

            }
            else
            {
                throw new Exception("No root directory found!");
            }
        }
        public static bool SavePokemonDataToFile(Pokemon savePokemon)
        {
            SetupSaveData();
            try
            {
                if (!File.Exists($"{PokemonDataFolderPath}/{savePokemon.name}-{ savePokemon.id:000}.txt"))
                {
                    File.Create($"{PokemonDataFolderPath}/{savePokemon.name}-{savePokemon.id:000}.txt").Close();
                }
                StreamWriter writer = new StreamWriter($"{PokemonDataFolderPath}/{savePokemon.name}-{savePokemon.id:000}.txt");
                writer.WriteLine(savePokemon.name);
                writer.WriteLine(savePokemon.id);
                writer.WriteLine(savePokemon.types[0].type.name);
                if(savePokemon.types.Count > 1)
                {
                    writer.WriteLine(savePokemon.types[1].type.name);
                }
                else
                {
                    writer.WriteLine("none");
                }
                foreach(PokemonStat stat in savePokemon.stats)
                {
                    writer.WriteLine(stat.base_stat);
                }
                writer.WriteLine(savePokemon.weight);
                writer.WriteLine(savePokemon.height);
                writer.Close();
                
                return true;
            }
            catch
            {
                return false;
            }
            return false;
        }
    }
}
