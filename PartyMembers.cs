using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Roll_Project
{
    class PartyMembers
    {
        public string Name { get; set; }
        public ConsoleColor Color{get; set; }
        public string Special { get; set; }

        public PartyMembers(string name, ConsoleColor color, string special)
        {
            Name = name;
            Color = color;
            Special = special;
        }

        static public List<PartyMembers> PartyMemberList()
        {
            var champion = new PartyMembers("Champ", ConsoleColor.Yellow, "everyone");
            var cleric = new PartyMembers("Cleric", ConsoleColor.White, "skeleton");
            var mage = new PartyMembers("Mage", ConsoleColor.Blue, "ooze");
            var thief = new PartyMembers("Thief", ConsoleColor.DarkMagenta, "chest");
            var scroll = new PartyMembers("Scroll", ConsoleColor.DarkYellow, "reroll");
            var warrior = new PartyMembers("Warrior", ConsoleColor.Green, "goblin");

            List<PartyMembers> partyMemberList = new List<PartyMembers> { champion, cleric, mage, thief, scroll, warrior};

            return partyMemberList;
        }
    }
}
