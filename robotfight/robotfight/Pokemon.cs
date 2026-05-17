using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotfight
{
    public class Pokemon
    {
        private String name;
        private int health;
        public Move m1, m2, m3, m4;
        public Pokemon(String n, int h, Move mo1, Move mo2, Move mo3, Move mo4)
        {
            name = n;
            health = h;
            m1 = mo1;
            m2 = mo2;
            m3 = mo3;
            m4 = mo4;
        }
        public void setHealth(int set)
        {
            health = set;
        }
        public int getHealth() { return health; }
        public String getName() { return name; }

        public void changeHealth(int health)
        {
            this.health -= health;
        }
    }
    public class Move
    {
        private String name;
        private int damage;

        public Move(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }
        public String getName() { return name; }
        public int getDamage() { return damage; }
    }
}
