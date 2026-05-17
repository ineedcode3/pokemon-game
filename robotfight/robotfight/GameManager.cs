using robotfight.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotfight
{
    public class GameManager
    {
        Random rand = new Random();
        public Boolean win;
        private int enemyHealth = 100;
        private Pokemon poke;
        public Boolean playerTurn = true;
        public GameManager(Pokemon poke)
        {
            this.poke = poke;
        }
        public void playerAttack(int move)
        {
            playerTurn = false;
            switch(move)
            {
                case 1:
                    enemyHealth -= poke.m1.getDamage();
                    break;
                case 2:
                    enemyHealth -= poke.m2.getDamage();
                    break;
                case 3:
                    enemyHealth -= poke.m3.getDamage();
                    break;
                case 4:
                    enemyHealth -= poke.m4.getDamage();
                    break;
            }
        }
        public void enemyMove()
        {
            if (!win)
            {
                Thread.Sleep(2000);
                int move = rand.Next(1, 5);
                switch (move)
                {
                    case 1:
                        enemyAttack(20);
                        break;

                    case 2:
                        enemyAttack(25);
                        break;

                    case 3:
                        enemyAttack(30);
                        break;

                    case 4:
                        enemyAttack(40);
                        break;
                }
            }
        }
        public void enemyAttack(int damage)
        {
            poke.changeHealth(damage);
            if (poke.getHealth() < 0)
            {
                poke.setHealth(0);
            }
        }
        public int checkWin()
        {
            if(poke.getHealth() < 0)
            {
                return 1;
            }
            if (enemyHealth < 0)
            {
                return 0;
            }
            else return -1;
        }
        public int getEnemy() { return enemyHealth; }
        public int getPlayer() { return poke.getHealth(); }
        public Boolean getPlayerTurn() { return playerTurn; }
    }
}
