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
        public ConsoleColor Color { get; set; }

        public DungeonMembers(string name, ConsoleColor color)
        {
            Name = name;
            Color = color;
        }

        static public List<DungeonMembers> DungeonMemberList()
        {
            var dragon = new DungeonMembers("Dragon", ConsoleColor.Red);
            var goblin = new DungeonMembers("Goblin", ConsoleColor.Green) ;
            var skeleton = new DungeonMembers("Skltn", ConsoleColor.White);
            var ooze = new DungeonMembers("Ooze", ConsoleColor.Blue);
            var potion = new DungeonMembers("Potion", ConsoleColor.DarkYellow);
            var chest = new DungeonMembers("Chest", ConsoleColor.DarkCyan);

            List<DungeonMembers> monsterList = new List<DungeonMembers> { dragon, goblin, skeleton, ooze, potion, chest };
            return monsterList;          
        }
    }
}
