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
        Sounds sound = new Sounds();
        String pokemon;
        bool expand = false;
        public mainMenu()
        {
            InitializeComponent();
            sound.PlayMusic();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            startBtn.Visible = false;
            pokemon = pokemonDrop.SelectedItem.ToString();
            BattleScreen b = new BattleScreen("bob", pokemonDB.name[pokemon]);
            b.Show();
            this.Hide();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            BattleScreen b = new BattleScreen("bob", pokemonDB.name[pokemon]);
            //b.Show();
            //this.Hide();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            BattleScreen b = new BattleScreen("jake", pokemonDB.Charmander);
            //b.Show();
            //this.Hide();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            BattleScreen b = new BattleScreen("nathan", pokemonDB.Bulbasaur);
            //b.Show();
            //this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
