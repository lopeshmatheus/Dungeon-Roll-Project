using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Roll_Project
{
    class Treasure
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }

        public Treasure(string name, string description, string color)
        {
            Name = name;
            Description = description;
        }

        static public List<Treasure> GetTreasure()
        {
            var townPortal = new Treasure("Town Portal", "Collect experience equal to current Dungeon Level and escape the Dungeon. " +
                "So if you are at level 7 of the dungeon and you left without this token you would gain 7 experience, with this token you would gain 14 experience.", "cyan");
            var dragonBait = new Treasure("Dragon Bait", "Transform all remaining monsters into Dragon Faces. " +
                "This would allow you to fight the dragon, you would not want to do this unless you had 3 separate party members.", "red");
            var dragonScale = new Treasure("Dragon Scale", "Each pair of Dragon Scales is worth two additional experience at the end of the game. " +
                "These are useless in the actual delve, but good for gaining experience.", "yellow");
            var potion = new Treasure("Potion", "Revive 1 Party Die from the Graveyard and choose its face. " +
                "Potions are your best friend in delves allow you to revive a used Party Die as any character you want.", "orange");
            var ringOfInvisibility = new Treasure("Ring of Invisibility", "Clear all dice from the Dragon's Lair. This does not count as defeating the Dragon. " +
                "You would want to use this if you have to fight a dragon and you are incapable of defeating the dragon; you do not gain experience or treasure by using the ring to sneak past the dragon.","redorange");
            var scroll = new Treasure("Scroll", "Can be used as a Scroll. Scrolls allow you to re-roll any number of Party and/or Dungeon Dice.","orange");

            var scepterOfPower = new Treasure("Scepter Of Power", "Can be used as a Mage","blue");

            var vorpalSword = new Treasure("Vorpal Sword", "Can be used as a Fighter", "green");

            var talisman = new Treasure("Talisman", "Can be used as a Cleric", "white");

            var thievesTools = new Treasure("Thieves' Tools", "Can be used as a Thief", "purple");

            List<Treasure> tempTokensList = new List<Treasure>{ townPortal, dragonBait, dragonScale, potion, ringOfInvisibility, scroll };
            List<Treasure> treasureList = new List<Treasure> { };

            for (int j = 0; j < 6; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    treasureList.Add(tempTokensList[j]);

                }
            }

            List<Treasure> tempList = new List<Treasure> { scepterOfPower, vorpalSword, talisman, thievesTools };

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    treasureList.Add(tempList[j]);
                }
            }

            return treasureList;

            
        }
    }

   
}
