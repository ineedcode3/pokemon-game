using System;
using System.Threading;
using System.Media;
using Microsoft.VisualBasic;
using robotfight.Properties;

namespace robotfight
{
    public partial class BattleScreen : Form
    {
        Random rand = new Random();
        private int enemyHealth = 100;
        private String name;
        private Pokemon poke;
        private SoundPlayer boom;
        public Boolean playerTurn = true;
        public BattleScreen(String Name, Pokemon poke)
        {
            InitializeComponent();
            name = Name;
            this.poke = poke;
            PlayerNameTag.Text = poke.getName();
            updateHealth();
            boom = new SoundPlayer(Resources.vineboom);
            boom.Load();
            InfoText.Text = "Hello Trainer " + name + ". Are you ready to battle? Choose your attack!";
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (playerTurn)
            {
                InfoText.Text = "You used " + poke.m1.getName();
                enemyDamage(poke.m1.getDamage());
                
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (playerTurn)
            {
                InfoText.Text = "You used " + poke.m2.getName();
                enemyDamage(poke.m2.getDamage());
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (playerTurn)
            {
                InfoText.Text = "You used " + poke.m3.getName();
                enemyDamage(poke.m3.getDamage());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (playerTurn)
            {
                InfoText.Text = "You used " + poke.m4.getName();
                enemyDamage(poke.m4.getDamage());
            }
        }
        public void enemyTurn()
        {
            Thread.Sleep(2000);
            boom.Play();
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
        public void enemyAttack(String attackname, int damage)
        {
            poke.changeHealth(damage);
            updateHealth();
            InfoText.Text = "The enemy meowth has used " + attackname + ". You took " + damage + " damage";
            playerTurn = true;
        }
        private void BattleScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public async void enemyDamage(int dmg)
        {
            playerTurn = false;
            boom.Play();
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
                boom.Stop();
                Form1 form1 = new Form1(true);
                form1.Show();
                this.Hide();
            }
            if(poke.getHealth()<=0)
            {
                boom.Stop();
                Form1 form1 = new Form1(true);
                form1.Show();
                this.Hide();
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
    }
}
