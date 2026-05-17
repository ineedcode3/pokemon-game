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
        public static Move Tackle = new Move("Tackle", 40, 35); // ALL starters (shared basic move)
        public static Move Scratch = new Move("Scratch", 40, 35); // Charmander, others can use too
        public static Move Ember = new Move("Ember", 40, 25); // Charmander line

        // Water Moves
        public static Move WaterGun = new Move("Water Gun", 40, 25); // Squirtle line
        public static Move BubbleBeam = new Move("Bubble Beam", 30, 20); // Squirtle line
        public static Move HydroPump = new Move("Hydro Pump", 90, 5); // late-game Water starter move

        // Grass Moves
        public static Move VineWhip = new Move("Vine Whip", 45, 25); // Bulbasaur line
        public static Move RazorLeaf = new Move("Razor Leaf", 55, 20); // Bulbasaur line
        public static Move LeechSeed = new Move("Leech Seed", 20, 15); // Bulbasaur line

        // Electric Moves
        public static Move ThunderShock = new Move("Thunder Shock", 40, 30); // Pikachu line
        public static Move QuickAttack = new Move("Quick Attack", 15, 40); // Pikachu + Riolu (shared move)
        public static Move Thunderbolt = new Move("Thunderbolt", 90, 10); // Pikachu line

        // Dragon / Legendary Style
        public static Move DragonBreath = new Move("Dragon Breath", 30, 25); // Dragon-type starter
        public static Move RoarOfTime = new Move("Roar of Time", 120, 5); // Legendary-style move
        public static Move AuraSphere = new Move("Aura Sphere", 60, 15); // Riolu / dragon-style users

        // Normal / Utility
        public static Move Growl = new Move("Growl", 0, 30); // ALL starters (shared utility)
        public static Move Rest = new Move("Rest", 0, 10); // healing move
    }

    public static class PokemonImageDatabase
    {
        public static Dictionary<string, Image> Back = new Dictionary<string, Image>
        {
            { "Pikachu", Properties.Resources.pikachu },
            { "Charmander", Properties.Resources.charmander },
            //{ "Squirtle", Properties.Resources.squirtle },
            { "Bulbasaur", Properties.Resources.bulbasaur },
            //{ "Eevee", Properties.Resources.eevee },
            //{ "Riolu", Properties.Resources.riolu },
            //{ "Dratini", Properties.Resources.dratini },
            //{ "Onix", Properties.Resources.onix }
        };
        public static Dictionary<string, Image> Front = new Dictionary<string, Image>
        {
            { "Pikachu", Properties.Resources.pikachuf },
            { "Charmander", Properties.Resources.charmanderf },
            { "Bulbasaur", Properties.Resources.bulbasaurf }
        };
    }
}

