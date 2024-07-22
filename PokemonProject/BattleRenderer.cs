using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonProject
{
    internal class BattleRenderer : Control
    {
        public int playerPokemonID;
        public int opponentPokemonID;
        public string battleBase;

        private Point pokemon1Position;
        private Point pokemon2Position;

        protected override void OnPaint(PaintEventArgs e)
        {
            Image pokemonImage = Image.FromFile($"..\\..\\..\\PokemonSprites/pokemon_{playerPokemonID}_back_default.gif");
            e.Graphics.DrawImage(pokemonImage, this.pokemon1Position);
            pokemonImage = Image.FromFile($"..\\..\\..\\PokemonSprites/pokemon_{playerPokemonID}_front_default.gif");
            e.Graphics.DrawImage(pokemonImage, this.pokemon2Position);

            pokemonImage.Dispose();
            pokemonImage = null;
        }
    }
}
