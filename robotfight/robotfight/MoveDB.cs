using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotfight
{
    public static class MoveDatabase
    {
        // Fire / Basic Attacks
        public static Move Tackle = new Move("Tackle", 25, 35); // ALL starters (shared basic move)
        public static Move Scratch = new Move("Scratch", 25, 35); // Charmander, others can use too
        public static Move Ember = new Move("Ember", 35, 25); // Charmander line

        // Water Moves
        public static Move WaterGun = new Move("Water Gun", 30, 25); // Squirtle line
        public static Move BubbleBeam = new Move("Bubble Beam", 40, 20); // Squirtle line
        public static Move HydroPump = new Move("Hydro Pump", 70, 5); // powerful but limited

        // Grass Moves
        public static Move VineWhip = new Move("Vine Whip", 35, 25); // Bulbasaur line
        public static Move RazorLeaf = new Move("Razor Leaf", 45, 20); // Bulbasaur line

        // Electric Moves
        public static Move ThunderShock = new Move("Thunder Shock", 30, 30); // Pikachu line
        public static Move QuickAttack = new Move("Quick Attack", 20, 40); // Pikachu + Riolu (shared move)
        public static Move Thunderbolt = new Move("Thunderbolt", 65, 10); // Pikachu line

        // Dragon / Legendary Style
        public static Move DragonBreath = new Move("Dragon Breath", 40, 25); // Dragon-type starter
        public static Move RoarOfTime = new Move("Roar of Time", 80, 5); // Legendary-style move
        public static Move AuraSphere = new Move("Aura Sphere", 55, 15); // Riolu / dragon-style users
    }

    public static class PokemonImageDatabase
    {
        public static Dictionary<string, Image> Back = new Dictionary<string, Image>
        {
            { "Pikachu", Properties.Resources.pikachu },
            { "Charmander", Properties.Resources.charmander },
            { "Squirtle", Properties.Resources.squirtle },
            { "Bulbasaur", Properties.Resources.bulbasaur },
            { "Eevee", Properties.Resources.eevee },
            { "Riolu", Properties.Resources.riolu },
            { "Dratini", Properties.Resources.dratini },
            { "Onix", Properties.Resources.onix }
        };
        public static Dictionary<string, Image> Front = new Dictionary<string, Image>
        {
            { "Pikachu", Properties.Resources.pikachuf },
            { "Charmander", Properties.Resources.charmanderf },
            { "Bulbasaur", Properties.Resources.bulbasaurf },
            { "Squirtle", Properties.Resources.squirtlef },
            { "Eevee", Properties.Resources.eeveef },
            { "Riolu", Properties.Resources.rioluf },
            { "Dratini", Properties.Resources.dratinif },
            { "Onix", Properties.Resources.onixf }
        };
    }
}

