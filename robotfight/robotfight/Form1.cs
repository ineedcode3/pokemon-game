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
    public partial class Form1 : Form
    {
        private String winText = "Congratualations! You won!";
        public Form1(Boolean Playerwin)
        {
            InitializeComponent();
            if (Playerwin)
            {
                label1.Text = winText;
            }
            else
            {
                label1.Text = "Oof you lost to a computer. You are trash";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
