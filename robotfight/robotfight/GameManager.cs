using robotfight.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotfight
{
    public class GameManager
    {
        Random rand = new Random();
        public Boolean win=false;
        private int enemyHealth;
        private Pokemon poke;
        public Boolean playerTurn = true;
        private Pokemon enemy;
        public GameManager(Pokemon poke)
        {
            this.poke = poke;
            enemy = pokemonDB.Charmander;
            enemyHealth = enemy.getHealth();
        }
        public void playerAttack(int move)
        {
            playerTurn = false;
            switch(move)
            {
                case 1:
                    enemyHealth -= poke.m1.getDamage();
                    poke.m1.useMove();
                    break;
                case 2:
                    enemyHealth -= poke.m2.getDamage();
                    poke.m2.useMove();
                    break;
                case 3:
                    enemyHealth -= poke.m3.getDamage();
                    poke.m3.useMove();
                    break;
                case 4:
                    enemyHealth -= poke.m4.getDamage();
                    poke.m4.useMove();
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
                        enemyAttack(enemy.m1.getDamage());
                        break;

                    case 2:
                        enemyAttack(enemy.m2.getDamage());
                        break;

                    case 3:
                        enemyAttack(enemy.m3.getDamage());
                        break;

                    case 4:
                        enemyAttack(enemy.m4.getDamage());
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
            playerTurn = true;
        }
        public int checkWin()
        {
            if(poke.getHealth() <= 0)
            {
                win = true;
                return 1;
            }
            if (enemyHealth <= 0)
            {
                win = true;
                return 0;
            }
            else return -1;
        }
        public void setPlayerTurn(Boolean a)
        {
            playerTurn = a;
        }
        public int getEnemy() { return enemyHealth; }
        public String getEnemyName() { return enemy.getName(); }
        public int getPlayer() { return poke.getHealth(); }
        public Boolean getwin() { return win; }
        public Boolean getPlayerTurn() { return playerTurn; }
        public String EnemyMoveName(int a)
        {
            switch(a)
            {
                case 1:
                    return enemy.m1.getName();
                case 2:
                    return enemy.m2.getName();
                case 3:
                    return enemy.m3.getName();
                case 4:
                    return enemy.m4.getName();
            }
            return "ERROR";
        }
    }
}
