namespace PokemonProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            //Have a sprite loader
            //Remake the battlemanager
            //Get all the pokemon front and back sprites dynamically, possibly via pokeapi again.
            //Save these to resources.resx with a good format, something like pokemon_001_bulbasaur_front
            //use gifs for animated sprites so generation 5 is possible in battle.
            //use these for overworld sprites https://www.deviantart.com/chaoticcherrycake/art/Pokemon-Tileset-From-Public-Tiles-358379026

            //Since the next term will be about databases, possibly move from text files to a database!
            //This will be a bit of a pain actually, its most likely better to keep using TXT or use CSV instead.

            //https://www.spriters-resource.com/ds_dsi/pokemonheartgoldsoulsilver/sheet/27044/ for buttons
            //https://www.spriters-resource.com/ds_dsi/pokemonblackwhite/sheet/43946/ for hp bars
            //https://www.spriters-resource.com/ds_dsi/pokemonplatinum/sheet/18502/ backgrounds
            //going for a HGSS battle menu and overworld with BW pokemon and hp bars.

            //I can write to resources.resx with ResXResourceWriter so i can get all the gifs in there that way.



        }
    }
}