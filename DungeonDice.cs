using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Roll_Project
{

    
    class DungeonDice
    {
        public List<DungeonMembers> Faces = DungeonMembers.DungeonMemberList();
        public DungeonMembers FaceUp { get; set; }

        //gets a list of 7 equals dungeon dice
        static public List<DungeonDice> GetDungeonDice()
        {
            List<DungeonDice> dungeonDiceList = new List<DungeonDice> { };
            for (int i = 0; i < 7; i++)
            {
                dungeonDiceList.Add(new DungeonDice());
            }

            return dungeonDiceList;
        }

      
    }
}
