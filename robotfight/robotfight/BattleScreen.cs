using System;
using System.Threading;
using System.Media;
using Microsoft.VisualBasic;
using robotfight.Properties;

namespace robotfight
{
    public partial class BattleScreen : Form
    {
        private int playerHealth = 100;
        private int enemyHealth = 100;
        private String name;
        private String pokemon;
        private Pokemon poke;
        private SoundPlayer boom;
        public Boolean playerTurn = true;
        public BattleScreen(String Name, Pokemon poke)
        {
            InitializeComponent();
            name = Name;
            this.poke = poke;
            pokemon = poke.getName();
            updateHealth();
            boom = new SoundPlayer(Resources.vineboom);
            InfoText.Text = "Are you ready to battle? Choose your attack!";
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

        private void BattleScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public async void enemyDamage(int dmg)
        {
            playerTurn = false;
            enemyHealth -= dmg;
            if(enemyHealth < 0)
            {
                enemyHealth = 0;
            }
            EnemyHealth.Text = enemyHealth + "hp";
            boom.Play();
            await enemyAnim();
            playerTurn = true;
            checkWin();
        }
        public void checkWin()
        {
            if(enemyHealth <=0||playerHealth <=0)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }
        public async Task enemyAnim()
        {
            EnemyImage.Location = new Point(EnemyImage.Location.X + 10, EnemyImage.Location.Y - 10);
            await Task.Delay(50);
            EnemyImage.Location = new Point(EnemyImage.Location.X - 10, EnemyImage.Location.Y + 10);
            await Task.Delay(50);
            EnemyImage.Location = new Point(EnemyImage.Location.X + 10, EnemyImage.Location.Y - 10);
            await Task.Delay(50);
            EnemyImage.Location = new Point(EnemyImage.Location.X - 10, EnemyImage.Location.Y + 10);
            await Task.Delay(50);
            EnemyImage.Location = new Point(EnemyImage.Location.X + 10, EnemyImage.Location.Y - 10);
            await Task.Delay(50);
            EnemyImage.Location = new Point(EnemyImage.Location.X - 10, EnemyImage.Location.Y + 10);
            await Task.Delay(50);
            EnemyImage.Location = new Point(EnemyImage.Location.X + 10, EnemyImage.Location.Y - 10);
            await Task.Delay(50);
            EnemyImage.Location = new Point(EnemyImage.Location.X - 10, EnemyImage.Location.Y + 10);
            await Task.Delay(50);
        }
        public void updateHealth()
        {
            HealthPlayer.Text = poke.getHealth().ToString();
        }
    }
}
