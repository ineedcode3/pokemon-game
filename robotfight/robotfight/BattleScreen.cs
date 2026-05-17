using System;
using System.Threading;
using System.Media;
using Microsoft.VisualBasic;
using robotfight.Properties;
using NAudio.Wave;

namespace robotfight
{
    public partial class battleScreen : Form
    {

        Random rand = new Random();
        GameManager game;
        public Boolean win;
        private int enemyHealth = 100;
        private String name;
        private Pokemon poke;
        Sounds sound = new Sounds();
        public int score;
        public battleScreen(String Name, Pokemon poke)
        {
            InitializeComponent();
            EnemyImage.Parent = this;
            EnemyImage.BackColor = Color.Transparent;
            playerBar.Maximum = poke.getHealth();
            game = new GameManager(poke);
            enemyBar.Maximum = game.getEnemy();
            name = Name;
            this.poke = poke;
            PlayerNameTag.Text = poke.getName();
            updateHealth();
            playerBar.Value = playerBar.Maximum;
            playerImage.Image = PokemonImageDatabase.Back[poke.getName()];
            startText();
            updateMoves();
            updateEnemy();
        }
        public void updateEnemy()
        {
            enemyBar.Value = game.getEnemy();
            EnemyNameTag.Text = game.getEnemyName();
            EnemyImage.Image = PokemonImageDatabase.Front[game.getEnemyName()];
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
                await printSlow("You used " + poke.m1.getName() + ". You dealt " + poke.m1.getDamage() + " damage.");
                updateEnemyHealth();
            }
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            if (game.getPlayerTurn())
            {
                game.playerAttack(2);
                await printSlow("You used " + poke.m2.getName() + ". You dealt " + poke.m2.getDamage() + " damage.");
                updateEnemyHealth();
            }
        }
        private async void button3_Click(object sender, EventArgs e)
        {
            if (game.getPlayerTurn())
            {
                game.playerAttack(3);
                updateEnemyHealth();
                await printSlow("You used " + poke.m3.getName() + ". You dealt " + poke.m3.getDamage() + " damage.");
            }
        }
        private async void button4_Click(object sender, EventArgs e)
        {
            if (game.getPlayerTurn())
            {
                game.playerAttack(4);
                await printSlow("You used " + poke.m4.getName() + ". You dealt " + poke.m4.getDamage() + " damage.");
                updateEnemyHealth();
            }
        }
        public void updateMoves()
        {
            Attack1.Text = poke.m1.getName() + " (" + poke.m1.getPP() + "/" + poke.m1.getMaxpp() + ")";
            Attack2.Text = poke.m2.getName() + " (" + poke.m2.getPP() + "/" + poke.m2.getMaxpp() + ")";
            Attack3.Text = poke.m3.getName() + " (" + poke.m3.getPP() + "/" + poke.m3.getMaxpp() + ")";
            Attack4.Text = poke.m4.getName() + " (" + poke.m4.getPP() + "/" + poke.m4.getMaxpp() + ")";
        }
        public async void enemyTurn()
        {
            if (!game.getwin())
            {
                await Task.Delay(2000);
                int move = rand.Next(1, 5);
                switch (move)
                {
                    case 1:
                        game.enemyAttack(20);
                        enemyAttack(game.EnemyMoveName(1), 20);
                        break;

                    case 2:
                        game.enemyAttack(25);
                        enemyAttack(game.EnemyMoveName(2), 25);
                        break;

                    case 3:
                        game.enemyAttack(30);
                        enemyAttack(game.EnemyMoveName(3), 30);
                        break;

                    case 4:
                        game.enemyAttack(40);
                        enemyAttack(game.EnemyMoveName(4), 40);
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
            await playerAnim();
            updateHealth();
            await printSlow("The enemy " + game.getEnemyName() + " has used " + attackname + ". You took " + damage + " damage");
        }
        public async void updateEnemyHealth()
        {
            EnemyHealth.Text = game.getEnemy() + "hp";
            sound.PlayVineBoom();
            await enemyAnim();
            while (enemyBar.Value > game.getEnemy())
            {
                enemyBar.Value -= 1; // smaller step = smoother animation
                await Task.Delay(10); // controls speed
            }
            checkWin();
            if (!game.getwin())
            {
                enemyTurn();
            }
            updateMoves();
        }
        private void BattleScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public async void enemyDamage(int dmg)
        {
            sound.PlayVineBoom();
            await enemyAnim();
            updateHealth();
            checkWin();
        }
        public void checkWin()
        {
            if (game.checkWin() == 0)
            {
                Form1 form1 = new Form1(true);
                form1.Show();
                this.Hide();
                win = true;
            }
            if (game.checkWin() == 1)
            {
                Form1 form1 = new Form1(false);
                form1.Show();
                this.Hide();
                win = true;
            }
        }
        public async Task playerAnim()
        {
            playerEffect.Visible = true;
            await Task.Delay(500);
            playerEffect.Visible = false;
        }
        public async Task enemyAnim()
        {
            enemyEffect.Visible = true;
            await Task.Delay(500);
            enemyEffect.Visible = false;
        }
        public void updateHealth()
        {
            HealthPlayer.Text = game.getPlayer() + "hp";
            AnimateHealthBar();
            Application.DoEvents();
        }
        private async void AnimateHealthBar()
        {
            while (playerBar.Value > poke.getHealth())
            {
                playerBar.Value -= 1; // smaller step = smoother animation
                await Task.Delay(10); // controls speed
            }
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

        private void EnemyImage_Click(object sender, EventArgs e)
        {

        }
    }
}
