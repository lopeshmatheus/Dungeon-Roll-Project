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
        public string Color { get; set; }
        public string Special { get; set; }

        public PartyMembers(string name, string color, string special)
        {
            Name = name;
            Color = color;
            Special = special;
        }

        static public List<PartyMembers> PartyMemberList()
        {
            var champion = new PartyMembers("Champion", "yellow", "everyone");
            var cleric = new PartyMembers("Cleric", "white", "skeleton");
            var mage = new PartyMembers("Mage", "blue", "ooze");
            var thief = new PartyMembers("Thief", "purple", "chest");
            var scroll = new PartyMembers("Scroll", "orange", "reroll");
            var warrior = new PartyMembers("Warrior", "green", "goblin");

            List<PartyMembers> partyMemberList = new List<PartyMembers> { champion, cleric, mage, thief, scroll, warrior};

            return partyMemberList;
        }
    }
}
