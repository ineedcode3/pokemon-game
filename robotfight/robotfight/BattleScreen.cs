using System;
using System.Threading;
using System.Media;
using Microsoft.VisualBasic;
using robotfight.Properties;
using NAudio.Wave;

namespace robotfight
{
    public partial class BattleScreen : Form
    {
        
        Random rand = new Random();
        GameManager game;
        public Boolean win;
        private int enemyHealth = 100;
        private String name;
        private Pokemon poke;
        Sounds sound = new Sounds();
        public BattleScreen(String Name, Pokemon poke)
        {
            InitializeComponent();
            game = new GameManager(poke);
            name = Name;
            this.poke = poke;
            PlayerNameTag.Text = poke.getName();
            updateHealth();
            if (poke.getName().Equals("Pikachu"))
            {
                playerImage.Image = (Resources.pikachu);
            }
            if (poke.getName().Equals("Charmander"))
            {
                playerImage.Image = (Resources.charmander);
            }
            if (poke.getName().Equals("Bulbasaur"))
            {
                playerImage.Image = (Resources.bulbasaur);
            }
            startText();
            
        }

        private async void startText()
        {
            await printSlow("Hello Trainer " + name + ". Are you ready to battle? Choose your attack!");
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if (game.getPlayerTurn())
            {
                game.playerAttack(1);
                await printSlow("You used " + poke.m1.getName());
                updateEnemyHealth();
            }
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            if (game.getPlayerTurn())
            {
                game.playerAttack(2);
                await printSlow("You used " + poke.m2.getName());
                updateEnemyHealth();
            }
        }
        private async void button3_Click(object sender, EventArgs e)
        {
            if (game.getPlayerTurn())
            {
                game.playerAttack(3);
                updateEnemyHealth();
                await printSlow("You used " + poke.m3.getName());
                
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if (game.getPlayerTurn())
            {
                game.playerAttack(4);
                await printSlow("You used " + poke.m4.getName());
                updateEnemyHealth();
            }
        }
        public async void enemyTurn()
        {
            if(!win)
            {
                await Task.Delay(2000);
                int move = rand.Next(1, 5);
                switch (move)
                {
                    case 1:
                        game.enemyAttack(20);
                        enemyAttack("Quick Attack", 20);
                        break;

                    case 2:
                        game.enemyAttack(25);
                        enemyAttack("Pounce", 25);
                        break;

                    case 3:
                        game.enemyAttack(30);
                        enemyAttack("Scratch", 30);
                        break;

                    case 4:
                        game.enemyAttack(40);
                        enemyAttack("Growl", 40);
                        break;
                }
                game.setPlayerTurn(true);
                checkWin();
            }
        }
        public async void enemyAttack(String attackname, int damage)
        {
            updateHealth();
            sound.PlayVineBoom();
            await printSlow("The enemy meowth has used " + attackname + ". You took " + damage + " damage");
            updateHealth();
        }
        public void updateEnemyHealth()
        {
            EnemyHealth.Text = game.getEnemy() + "hp";
            checkWin();
            sound.PlayVineBoom();
            enemyTurn();
        }
        private void BattleScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public async void enemyDamage(int dmg)
        {
            sound.PlayVineBoom();
            updateEnemyHealth();
            updateHealth();
            await enemyAnim();
            checkWin();
        }
        public void checkWin()
        {
            if(game.checkWin()==0)
            { 
                Form1 form1 = new Form1(true);
                form1.Show();
                this.Hide();
                win = true;
            }
            if(game.checkWin()==1)
            {
                Form1 form1 = new Form1(false);
                form1.Show();
                this.Hide();
                win = true;
            }
        }
        public async Task enemyAnim()
        {
            EnemyImage.Location = new Point(EnemyImage.Location.X + 10, EnemyImage.Location.Y - 10);
            await Task.Delay(100);
            EnemyImage.Location = new Point(EnemyImage.Location.X - 10, EnemyImage.Location.Y + 10);
            await Task.Delay(100);
            EnemyImage.Location = new Point(EnemyImage.Location.X + 10, EnemyImage.Location.Y - 10);
            await Task.Delay(100);
            EnemyImage.Location = new Point(EnemyImage.Location.X - 10, EnemyImage.Location.Y + 10);
            await Task.Delay(100);
            EnemyImage.Location = new Point(EnemyImage.Location.X + 10, EnemyImage.Location.Y - 10);
            await Task.Delay(100);
            EnemyImage.Location = new Point(EnemyImage.Location.X - 10, EnemyImage.Location.Y + 10);
            await Task.Delay(100);
            EnemyImage.Location = new Point(EnemyImage.Location.X + 10, EnemyImage.Location.Y - 10);
            await Task.Delay(100);
            EnemyImage.Location = new Point(EnemyImage.Location.X - 10, EnemyImage.Location.Y + 10);
            await Task.Delay(100);
        }
        public void updateHealth()
        {
            HealthPlayer.Text = game.getPlayer()+"hp";
            Application.DoEvents();

        }

        public async Task printSlow(string toPrint)
        {
            InfoText.Text = "";
            string[] words = toPrint.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                InfoText.Text += words[i] + " ";
                await Task.Delay(50); // waits without freezing UI
            }
        }
        
    }
}
