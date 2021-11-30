using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Roll_Project
{
    class Hero
    {
        public string Name { get; set; }
        public string Specialty { get; set; }
        public string UniqueAbility { get; set; }
        public string LeveledName { get; set; }
        public string LeveledSpecialty { get; set; }
        public string LeveledUniqueAbility { get; set; }
        public bool IsUniqueAbilityAvailable { get; set; }

        public Hero
            (
            string name, 
            string specialty,
            string uniqueAbility, 
            string leveledName, 
            string leveledSpecialty,
            string leveledUniqueAbility
            )

        {
            Name = name;
            Specialty = specialty;
            UniqueAbility = uniqueAbility;
            LeveledName = leveledName;
            LeveledSpecialty = leveledSpecialty;
            LeveledUniqueAbility = leveledUniqueAbility;


        }
        static public Hero[] GetHeroes()
        {

            
            string minstrelSpecialty = "Thieves may be used as mages and Mages may be used as Thieves";
            string minstrelUniqueAbility = "Bard Song: Discard all dice from the Dragon's Lair";
            string minstrelLeveledName = "Bard";
            string minstrelLeveledSpecialty = "Thieves may be used as Mages and Mages may be used as Thieves. Champions deaft 1 extra monster";
            string minstrelLeveledUniqueAbility = "Bard Song: Discal all dice from the Dragon's Lair";
            Hero minstrel = new Hero("Minstrel", minstrelSpecialty, minstrelUniqueAbility, minstrelLeveledName, minstrelLeveledSpecialty, minstrelLeveledUniqueAbility);

            string crusaderSpecialty = "Fighters may be used as Clerics and Clerics may be used as Fighters";
            string crusaderUniqueAbility = "Holy Strike: Crusader may be used as a Cleric or a Fighter";
            string crusaderLeveledName = "Paladin";
            string crusaderLeveledSpecialty = "Fighters may be used as Clerics and Clerics may be used as Fighters";
            string crusaderLeveledUniqueAbility = "Divine Intervention: Discard 1 Treasure Token to defeat all Monster, open all Chests," +
                "quaff all Pitions, and discard all dice in the Dragon's Lair.";
            Hero crusader = new Hero("Crusader", crusaderSpecialty, crusaderUniqueAbility, crusaderLeveledName, crusaderLeveledSpecialty, crusaderLeveledUniqueAbility);

            string enchantressSpecialty = "Scrolls may be used as any companion";
            string enchantressUniqueAbility = "Charm Monster: Transform 1 monster into a potion";
            string enchantressLeveledName = "Beguiler";
            string enchantressLeveledSpecialty = "Scrolls may be used as any companion";
            string enchantressLeveledUniqueAbility = "Tranform 2 monsters into 1 potion";
            Hero enchantress = new Hero("Enchantress", enchantressSpecialty, enchantressUniqueAbility, enchantressLeveledName, enchantressLeveledSpecialty, enchantressLeveledUniqueAbility);

            Hero[] heroDeck = new Hero[3] { minstrel, crusader, enchantress };
            return heroDeck;
        }
    


    }
}
