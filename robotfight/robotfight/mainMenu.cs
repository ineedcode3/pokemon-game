using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robotfight
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            startBtn.Visible = false;
            l1.Visible = true;
            b1.Visible = true;
            b2.Visible = true;
            b3.Visible = true;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            BattleScreen b = new BattleScreen("bob", new Pokemon("Pikachu", 200, new Move("Quick Attack", 10), new Move("Volt Tackle", 20), new Move("Spark", 30), new Move("Thunder Shock",40)));
            b.Show();
            this.Hide();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            BattleScreen b = new BattleScreen("jake", new Pokemon("Charmander", 200, new Move("Quick Attack", 10), new Move("Volt Tackle", 20), new Move("Spark", 30), new Move("Thunder Shock", 40)));
            b.Show();
            this.Hide();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            BattleScreen b = new BattleScreen("nathan", new Pokemon("Bulbasaur", 200, new Move("Quick Attack", 10), new Move("Volt Tackle", 20), new Move("Spark", 30), new Move("Thunder Shock", 40)));
            b.Show();
            this.Hide();
        }
    }
}
