using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Roll_Project
{
    class DungeonMembers
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public DungeonMembers(string name, string color)
        {
            Name = name;
            Color = color;
        }

        static public List<DungeonMembers> DungeonMemberList()
        {
            var dragon = new DungeonMembers("Dragon", "Red");
            var goblin = new DungeonMembers("Goblin", "green");
            var skeleton = new DungeonMembers("Skeleton", "white");
            var ooze = new DungeonMembers("Ooze", "blue");
            var potion = new DungeonMembers("Potion", "orange");
            var chest = new DungeonMembers("Chest", "purple");

            List<DungeonMembers> monsterList = new List<DungeonMembers> { dragon, goblin, skeleton, ooze, potion, chest };
            return monsterList;
        }
    }
}
