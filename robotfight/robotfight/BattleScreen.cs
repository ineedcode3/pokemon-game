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
        public Boolean win;
        private int enemyHealth = 100;
        private String name;
        private Pokemon poke;
        public Boolean playerTurn = true;
        Sounds sound = new Sounds();
        public BattleScreen(String Name, Pokemon poke)
        {
            InitializeComponent();
            name = Name;
            this.poke = poke;
            PlayerNameTag.Text = poke.getName();
            updateHealth();
            //InfoText.Text = "Hello Trainer " + name + ". Are you ready to battle? Choose your attack!";
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
            if (playerTurn)
            {
                enemyDamage(poke.m1.getDamage());
                await printSlow("You used " + poke.m1.getName());
                //InfoText.Text = "You used " + poke.m1.getName();
                
            }
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            if (playerTurn)
            {
                enemyDamage(poke.m2.getDamage());
                await printSlow("You used " + poke.m2.getName());
                //InfoText.Text = "You used " + poke.m2.getName();
                
            }
        }
        private async void button3_Click(object sender, EventArgs e)
        {
            if (playerTurn)
            {
                enemyDamage(poke.m3.getDamage());
                await printSlow("You used " + poke.m3.getName());
                //InfoText.Text = "You used " + poke.m3.getName;
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if (playerTurn)
            {
                enemyDamage(poke.m4.getDamage());
                await printSlow("You used " + poke.m4.getName());                
            }
        }
        public void enemyTurn()
        {
            if(!win)
            {
                Thread.Sleep(2000);
                int move = rand.Next(1, 5);
                switch (move)
                {
                    case 1:
                        enemyAttack("Growl", 20);
                        break;

                    case 2:
                        enemyAttack("Scratch", 25);
                        break;

                    case 3:
                        enemyAttack("Bite", 30);
                        break;

                    case 4:
                        enemyAttack("Pounce", 40);
                        break;
                }
            }
        }
        public async void enemyAttack(String attackname, int damage)
        {
            poke.changeHealth(damage);
            if(poke.getHealth()<0)
            {
                poke.setHealth(0);
            }
            updateHealth();
            sound.PlayVineBoom();
            await printSlow("The enemy meowth has used " + attackname + ". You took " + damage + " damage");
            //InfoText.Text = "The enemy meowth has used " + attackname + ". You took " + damage + " damage";
            playerTurn = true;
            checkWin();
        }
        private void BattleScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public async void enemyDamage(int dmg)
        {
            sound.PlayVineBoom();
            playerTurn = false;
            enemyHealth -= dmg;
            if(enemyHealth < 0)
            {
                enemyHealth = 0;
            }
            EnemyHealth.Text = enemyHealth + "hp";
            await enemyAnim();
            checkWin();
            enemyTurn();
        }
        public void checkWin()
        {
            if(enemyHealth <=0)
            { 
                Form1 form1 = new Form1(true);
                form1.Show();
                this.Hide();
                win = true;
            }
            if(poke.getHealth()<=0)
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
            HealthPlayer.Text = poke.getHealth().ToString()+"hp";
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
