using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotfight
{
    public static class pokemonDB
    {
        // Fire starter
        public static Pokemon Charmander = new Pokemon(
            "Charmander",
            100,
            MoveDatabase.Scratch,
            MoveDatabase.Ember,
            MoveDatabase.Tackle,
            MoveDatabase.QuickAttack
        );

        // Water starter
        public static Pokemon Squirtle = new Pokemon(
            "Squirtle",
            110,
            MoveDatabase.Tackle,
            MoveDatabase.WaterGun,
            MoveDatabase.BubbleBeam,
            MoveDatabase.QuickAttack
        );

        // Grass starter
        public static Pokemon Bulbasaur = new Pokemon(
            "Bulbasaur",
            105,
            MoveDatabase.VineWhip,
            MoveDatabase.RazorLeaf,
            MoveDatabase.Tackle,
            MoveDatabase.Scratch
        );

        // Electric starter
        public static Pokemon Pikachu = new Pokemon(
            "Pikachu",
            95,
            MoveDatabase.ThunderShock,
            MoveDatabase.QuickAttack,
            MoveDatabase.Thunderbolt,
            MoveDatabase.Tackle
        );

        // Dragon starter
        public static Pokemon Dratini = new Pokemon(
            "Dratini",
            110,
            MoveDatabase.DragonBreath,
            MoveDatabase.AuraSphere,
            MoveDatabase.Tackle,
            MoveDatabase.RoarOfTime
        );

        // Fighting type
        public static Pokemon Riolu = new Pokemon(
            "Riolu",
            130,
            MoveDatabase.AuraSphere,
            MoveDatabase.QuickAttack,
            MoveDatabase.Tackle,
            MoveDatabase.Scratch
        );

        // Tank
        public static Pokemon Onix = new Pokemon(
            "Onix",
            140,
            MoveDatabase.Tackle,
            MoveDatabase.DragonBreath,
            MoveDatabase.BubbleBeam,
            MoveDatabase.RazorLeaf
        );

        // Normal
        public static Pokemon Eevee = new Pokemon(
            "Eevee",
            120,
            MoveDatabase.Tackle,
            MoveDatabase.QuickAttack,
            MoveDatabase.Scratch,
            MoveDatabase.Ember
        );
        public static Dictionary<string, Pokemon> name = new Dictionary<string, Pokemon>
        {
            { "Pikachu", Pikachu},
            { "Eevee", Eevee},
            { "Onix", Onix},
            { "Riolu", Riolu},
            { "Dratini", Dratini},
            { "Bulbasaur", Bulbasaur},
            { "Charmander", Charmander},
            { "Squirtle", Squirtle}
        };
    }
}
