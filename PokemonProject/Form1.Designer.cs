namespace PokemonProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OpponentPokemon_L5 = new PictureBox();
            Fight = new Button();
            Run = new Button();
            Bag = new Button();
            BattleBases_L2 = new PictureBox();
            PlayerPokemon_L3 = new PictureBox();
            FarBackground_L1 = new PictureBox();
            PlayerPokemonLayer_L3 = new PictureBox();
            Attacks_L4 = new PictureBox();
            Healthbars_L6 = new PictureBox();
            PlayerHealthBar = new PictureBox();
            OpponentHealthBar = new PictureBox();
            OpponentPokemonLayer_L5 = new PictureBox();
            AttackSprite = new PictureBox();
            Pokemon = new Button();
            ((System.ComponentModel.ISupportInitialize)OpponentPokemon_L5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BattleBases_L2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerPokemon_L3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FarBackground_L1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerPokemonLayer_L3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Attacks_L4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Healthbars_L6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerHealthBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OpponentHealthBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OpponentPokemonLayer_L5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AttackSprite).BeginInit();
            SuspendLayout();
            // 
            // OpponentPokemon_L5
            // 
            OpponentPokemon_L5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OpponentPokemon_L5.BackColor = Color.Transparent;
            OpponentPokemon_L5.BackgroundImageLayout = ImageLayout.None;
            OpponentPokemon_L5.Location = new Point(653, 182);
            OpponentPokemon_L5.Name = "OpponentPokemon_L5";
            OpponentPokemon_L5.Size = new Size(152, 150);
            OpponentPokemon_L5.SizeMode = PictureBoxSizeMode.Zoom;
            OpponentPokemon_L5.TabIndex = 0;
            OpponentPokemon_L5.TabStop = false;
            // 
            // Fight
            // 
            Fight.Cursor = Cursors.Hand;
            Fight.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            Fight.FlatAppearance.MouseDownBackColor = Color.Red;
            Fight.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            Fight.FlatStyle = FlatStyle.Flat;
            Fight.Location = new Point(12, 600);
            Fight.Name = "Fight";
            Fight.Size = new Size(285, 85);
            Fight.TabIndex = 1;
            Fight.Text = "Call API";
            Fight.UseVisualStyleBackColor = true;
            Fight.Click += Fight_Click;
            // 
            // Run
            // 
            Run.Location = new Point(912, 600);
            Run.Name = "Run";
            Run.Size = new Size(285, 85);
            Run.TabIndex = 2;
            Run.Text = "Pokemon --";
            Run.UseVisualStyleBackColor = true;
            Run.Click += Run_Click;
            // 
            // Bag
            // 
            Bag.Location = new Point(611, 600);
            Bag.Name = "Bag";
            Bag.Size = new Size(285, 85);
            Bag.TabIndex = 3;
            Bag.Text = "Pokemon ++";
            Bag.UseVisualStyleBackColor = true;
            Bag.Click += Bag_Click;
            // 
            // BattleBases_L2
            // 
            BattleBases_L2.BackColor = Color.Transparent;
            BattleBases_L2.Location = new Point(179, 339);
            BattleBases_L2.Name = "BattleBases_L2";
            BattleBases_L2.Size = new Size(152, 149);
            BattleBases_L2.SizeMode = PictureBoxSizeMode.StretchImage;
            BattleBases_L2.TabIndex = 4;
            BattleBases_L2.TabStop = false;
            BattleBases_L2.Click += backgroundImage_L2_Click;
            // 
            // PlayerPokemon_L3
            // 
            PlayerPokemon_L3.BackColor = Color.Transparent;
            PlayerPokemon_L3.Location = new Point(337, 183);
            PlayerPokemon_L3.Name = "PlayerPokemon_L3";
            PlayerPokemon_L3.Size = new Size(152, 149);
            PlayerPokemon_L3.SizeMode = PictureBoxSizeMode.Zoom;
            PlayerPokemon_L3.TabIndex = 5;
            PlayerPokemon_L3.TabStop = false;
            // 
            // FarBackground_L1
            // 
            FarBackground_L1.BackColor = Color.Silver;
            FarBackground_L1.Location = new Point(21, 339);
            FarBackground_L1.Name = "FarBackground_L1";
            FarBackground_L1.Size = new Size(152, 149);
            FarBackground_L1.SizeMode = PictureBoxSizeMode.StretchImage;
            FarBackground_L1.TabIndex = 6;
            FarBackground_L1.TabStop = false;
            // 
            // PlayerPokemonLayer_L3
            // 
            PlayerPokemonLayer_L3.BackColor = Color.Transparent;
            PlayerPokemonLayer_L3.Location = new Point(337, 338);
            PlayerPokemonLayer_L3.Name = "PlayerPokemonLayer_L3";
            PlayerPokemonLayer_L3.Size = new Size(152, 150);
            PlayerPokemonLayer_L3.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerPokemonLayer_L3.TabIndex = 7;
            PlayerPokemonLayer_L3.TabStop = false;
            // 
            // Attacks_L4
            // 
            Attacks_L4.BackColor = Color.Transparent;
            Attacks_L4.Location = new Point(495, 339);
            Attacks_L4.Name = "Attacks_L4";
            Attacks_L4.Size = new Size(152, 150);
            Attacks_L4.SizeMode = PictureBoxSizeMode.StretchImage;
            Attacks_L4.TabIndex = 8;
            Attacks_L4.TabStop = false;
            // 
            // Healthbars_L6
            // 
            Healthbars_L6.BackColor = Color.Transparent;
            Healthbars_L6.Location = new Point(811, 338);
            Healthbars_L6.Name = "Healthbars_L6";
            Healthbars_L6.Size = new Size(152, 150);
            Healthbars_L6.SizeMode = PictureBoxSizeMode.StretchImage;
            Healthbars_L6.TabIndex = 9;
            Healthbars_L6.TabStop = false;
            // 
            // PlayerHealthBar
            // 
            PlayerHealthBar.BackColor = Color.Transparent;
            PlayerHealthBar.Location = new Point(702, 444);
            PlayerHealthBar.Name = "PlayerHealthBar";
            PlayerHealthBar.Size = new Size(400, 100);
            PlayerHealthBar.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerHealthBar.TabIndex = 10;
            PlayerHealthBar.TabStop = false;
            // 
            // OpponentHealthBar
            // 
            OpponentHealthBar.BackColor = Color.Black;
            OpponentHealthBar.Location = new Point(188, 53);
            OpponentHealthBar.Name = "OpponentHealthBar";
            OpponentHealthBar.Size = new Size(371, 91);
            OpponentHealthBar.SizeMode = PictureBoxSizeMode.StretchImage;
            OpponentHealthBar.TabIndex = 11;
            OpponentHealthBar.TabStop = false;
            // 
            // OpponentPokemonLayer_L5
            // 
            OpponentPokemonLayer_L5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OpponentPokemonLayer_L5.BackColor = Color.Transparent;
            OpponentPokemonLayer_L5.BackgroundImageLayout = ImageLayout.None;
            OpponentPokemonLayer_L5.Location = new Point(653, 338);
            OpponentPokemonLayer_L5.Name = "OpponentPokemonLayer_L5";
            OpponentPokemonLayer_L5.Size = new Size(152, 150);
            OpponentPokemonLayer_L5.SizeMode = PictureBoxSizeMode.Zoom;
            OpponentPokemonLayer_L5.TabIndex = 12;
            OpponentPokemonLayer_L5.TabStop = false;
            // 
            // AttackSprite
            // 
            AttackSprite.BackColor = Color.Transparent;
            AttackSprite.Location = new Point(495, 183);
            AttackSprite.Name = "AttackSprite";
            AttackSprite.Size = new Size(152, 150);
            AttackSprite.SizeMode = PictureBoxSizeMode.StretchImage;
            AttackSprite.TabIndex = 13;
            AttackSprite.TabStop = false;
            // 
            // Pokemon
            // 
            Pokemon.Location = new Point(313, 600);
            Pokemon.Name = "Pokemon";
            Pokemon.Size = new Size(285, 85);
            Pokemon.TabIndex = 14;
            Pokemon.Text = "Pokemon";
            Pokemon.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1209, 698);
            Controls.Add(Pokemon);
            Controls.Add(AttackSprite);
            Controls.Add(OpponentPokemonLayer_L5);
            Controls.Add(OpponentHealthBar);
            Controls.Add(PlayerHealthBar);
            Controls.Add(Attacks_L4);
            Controls.Add(PlayerPokemonLayer_L3);
            Controls.Add(PlayerPokemon_L3);
            Controls.Add(Bag);
            Controls.Add(Run);
            Controls.Add(Fight);
            Controls.Add(OpponentPokemon_L5);
            Controls.Add(BattleBases_L2);
            Controls.Add(FarBackground_L1);
            Controls.Add(Healthbars_L6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Battle";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)OpponentPokemon_L5).EndInit();
            ((System.ComponentModel.ISupportInitialize)BattleBases_L2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerPokemon_L3).EndInit();
            ((System.ComponentModel.ISupportInitialize)FarBackground_L1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerPokemonLayer_L3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Attacks_L4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Healthbars_L6).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerHealthBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)OpponentHealthBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)OpponentPokemonLayer_L5).EndInit();
            ((System.ComponentModel.ISupportInitialize)AttackSprite).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox OpponentPokemon_L5;
        private Button Fight;
        private Button Run;
        private Button Bag;
        private PictureBox BattleBases_L2;
        private PictureBox PlayerPokemon_L3;
        private PictureBox FarBackground_L1;
        private PictureBox PlayerPokemonLayer_L3;
        private PictureBox Attacks_L4;
        private PictureBox Healthbars_L6;
        private PictureBox PlayerHealthBar;
        private PictureBox OpponentHealthBar;
        private PictureBox OpponentPokemonLayer_L5;
        private PictureBox AttackSprite;
        private Button Pokemon;
    }
}