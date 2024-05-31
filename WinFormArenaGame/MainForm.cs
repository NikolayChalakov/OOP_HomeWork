using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;
using static ArenaGame.GameEngine;

namespace WinFormArenaGame
{

    public partial class MainForm : Form
    {
        private IWeapon weapon1;
        private IWeapon weapon2;
        private Hero hero1;
        private Hero hero2;

        public MainForm()
        {
            InitializeComponent();
            btnNewGame.Enabled = false;
        }

        private void gameNotification(GameEngine.NotificationArgs args)
        {
            TextBox tbAttacker;
            if (args.Attacker == hero1)
                tbAttacker = tbHero1;
            else
                tbAttacker = tbHero2;

            tbAttacker.AppendText(
                $"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack, 2)} and caused {Math.Round(args.Damage, 2)} damage.\r\n");

            DateTime dt = DateTime.Now;

            while (DateTime.Now - dt < TimeSpan.FromMilliseconds(300))
            {
                Application.DoEvents();
            }
        }
      


        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lbWinner.Text = "";
            tbHero2.Text = "";
            tbHero1.Text = "";
            lbWinner.Visible = false;
            hero1.Weapon = weapon1;
            hero2.Weapon = weapon2;

            GameEngine gameEngine = new GameEngine()
            {
                HeroA = hero1,
                HeroB = hero2,
                NotificationsCallBack = gameNotification
            };

            imgFight.Enabled = true;
            gameEngine.Fight();
            imgFight.Enabled = false;

            lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
            lbWinner.Visible = true;

        }

        private void lbWinner_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNewGameButtonState();
            string selectedItem = comboBox1.SelectedItem.ToString();

            switch (selectedItem)
            {
                case "Sword": weapon1 = new Sword("Sword"); break;
                case "Dagger": weapon1 = new Dagger("Dagger"); break;
                case "LightingSword": weapon1 = new LigtingSword("LightingSword"); break;
                case "EarthShield": weapon1 = new EarthShield("EarthShield"); break;
                case "PokerCard": weapon1 = new PokerCard("PokerCard"); break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(weapon1.SpecialPower);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(weapon2.SpecialPower);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNewGameButtonState();
            string selectedItem = comboBox2.SelectedItem.ToString();

            switch (selectedItem)
            {
                case "Sword": weapon2 = new Sword("Sword"); break;
                case "Dagger": weapon2 = new Dagger("Dagger"); break;
                case "LightingSword": weapon2 = new LigtingSword("LightingSword"); break;
                case "EarthShield": weapon2 = new EarthShield("EarthShield"); break;
                case "PokerCard": weapon2 = new PokerCard("PokerCard"); break;

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNewGameButtonState();
            string selectedItem = comboBox3.SelectedItem.ToString();

            switch (selectedItem)
            {
                case "Knight": hero1 = new Knight("Knight", 10, 20); break;
                case "Assassin": hero1 = new Assassin("Assassin", 10, 5); break;
                case "Barbarian": hero1 = new Barbarian("Barbarian", 10, 20); break;
                case "Archer": hero1 = new Archer("Archer", 5, 30); break;
                case "Summoner": hero1 = new Summoner("Summoner", 10, 15); break;
            }
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNewGameButtonState();
            string selectedItem = comboBox4.SelectedItem.ToString();

            switch (selectedItem)
            {
                case "Knight": hero2 = new Knight("Knight", 10, 20); break;
                case "Assassin": hero2 = new Assassin("Assassin", 10, 5); break;
                case "Barbarian": hero2 = new Barbarian("Barbarian", 10, 20); break;
                case "Archer": hero2 = new Archer("Archer", 5, 30); break;
                case "Summoner": hero2 = new Summoner("Summoner", 10, 15); break;
            }
        }
        private void UpdateNewGameButtonState()
        {
            bool allSelected = comboBox1.SelectedItem != null &&
                               comboBox2.SelectedItem != null &&
                               comboBox3.SelectedItem != null &&
                               comboBox4.SelectedItem != null;

            btnNewGame.Enabled = allSelected;
        }


    }
}