
using System.ComponentModel;
using System.Windows.Forms;

namespace PokemonProject
{
    public partial class Form1 : Form
    {
        public int number = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Fight_Click(object sender, EventArgs e)
        {
            APICall.CallAPI();
        }

        private void Run_Click(object sender, EventArgs e)
        {

        }

        private void Bag_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FarBackground_L1.Location = new Point(0, 0);
            FarBackground_L1.Size = new Size(1214, 563);
            FarBackground_L1.Controls.Add(BattleBases_L2); //BattleBases is on top of FarBackground


            BattleBases_L2.Location = new Point(100, 0);
            BattleBases_L2.Size = new Size(1086, 563);
            BattleBases_L2.Controls.Add(OpponentPokemonLayer_L5); //OpponentPokemonLayer is on top of the battle bases


            OpponentPokemonLayer_L5.Location = new Point(0, 0);
            OpponentPokemonLayer_L5.Size = new Size(1086, 563);
            OpponentPokemonLayer_L5.Controls.Add(OpponentPokemon_L5);
            OpponentPokemonLayer_L5.Controls.Add(Attacks_L4);

            //Attacks_L4.BringToFront();

            Attacks_L4.Location = new Point(0, 0);
            Attacks_L4.Size = new Size(1086, 563);
            Attacks_L4.Controls.Add(AttackSprite);
            Attacks_L4.Controls.Add(PlayerPokemonLayer_L3);
            PlayerPokemonLayer_L3.SendToBack();
            PlayerPokemonLayer_L3.Controls.Add(OpponentHealthBar);
            PlayerPokemonLayer_L3.Controls.Add(PlayerHealthBar);

            PlayerPokemonLayer_L3.Location = new Point(0, 0);
            PlayerPokemonLayer_L3.Size = new Size(1086, 563);
            PlayerPokemonLayer_L3.Controls.Add(PlayerPokemon_L3);

            OpponentPokemon_L5.Image = Image.FromFile($"..\\..\\..\\PokemonSprites/pokemon_003_front_default.gif");
            OpponentPokemon_L5.Size = new Size((int)(OpponentPokemon_L5.Image.Size.Width * 3), (int)(OpponentPokemon_L5.Image.Size.Height * 3));
            OpponentPokemon_L5.Location = new Point(710 - OpponentPokemon_L5.Size.Width / 2, 310 - OpponentPokemon_L5.Size.Height);

            PlayerPokemon_L3.Image = Image.FromFile($"..\\..\\..\\PokemonSprites/pokemon_006_back_default.gif");
            PlayerPokemon_L3.Size = new Size((int)(PlayerPokemon_L3.Image.Size.Width * 5), (int)(PlayerPokemon_L3.Image.Size.Height * 5));
            PlayerPokemon_L3.Location = new Point(270 - PlayerPokemon_L3.Size.Width / 2, 630 - PlayerPokemon_L3.Size.Height);




            BattleBases_L2.Image = Image.FromFile($"..\\..\\..\\Battle/battlebase_path.png");
            PlayerHealthBar.Image = Image.FromFile($"..\\..\\..\\Battle/healthbar_player.png");
            OpponentHealthBar.Image = Image.FromFile($"..\\..\\..\\Battle/healthbar_opponent.png");
            Fight.Image = Image.FromFile($"..\\..\\..\\Battle/button_fight2.png");
        }

        private void backgroundImage_L2_Click(object sender, EventArgs e)
        {

        }
    }
}