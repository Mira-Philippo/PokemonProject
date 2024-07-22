using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PokemonAPI
{
    public class PokemonSprites
    {
        public string front_default {  get; set; }
        public string front_shiny { get; set; }
        public string front_female { get; set; }
        public string front_shiny_female { get; set; }

        public string back_default { get; set; }
        public string back_shiny { get; set;}
        public string back_female { get; set;}
        public string back_shiny_female { get; set;}

        public static List<Image> GetSprite(object pokemonIdentification, ApiConnection conn)
        {
            string data = string.Empty;
            if (pokemonIdentification is string str)
            {
                data = (string)conn.GetResultFromUrl("pokemon/" + str);
            }
            else if (pokemonIdentification is int num)
            {
                data = (string)conn.GetResultFromUrl("pokemon/" + num);
            }
            Pokemon result = Pokemon.ConvertJsonToObject(data);
            List<Image> images = new List<Image>();
            images.Add(Image.FromStream(new MemoryStream(conn.webClient.DownloadData(result.sprites.front_default))));
            images.Add(Image.FromStream(new MemoryStream(conn.webClient.DownloadData(result.sprites.back_default))));
            images.Add(Image.FromStream(new MemoryStream(conn.webClient.DownloadData(result.sprites.front_shiny))));
            images.Add(Image.FromStream(new MemoryStream(conn.webClient.DownloadData(result.sprites.back_shiny))));

            if (result.sprites.front_female != null)
            {
                images.Add(Image.FromStream(new MemoryStream(conn.webClient.DownloadData(result.sprites.front_female))));
                images.Add(Image.FromStream(new MemoryStream(conn.webClient.DownloadData(result.sprites.back_female))));
                images.Add(Image.FromStream(new MemoryStream(conn.webClient.DownloadData(result.sprites.front_shiny_female))));
                images.Add(Image.FromStream(new MemoryStream(conn.webClient.DownloadData(result.sprites.back_shiny_female))));
            }

            return images;
        }
    }
}
