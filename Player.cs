using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Roll_Project
{
    class Player
    {
        public string Name { get; set; }
        public int Exp { get; set; }
        public List<Object> Inventory { get; set; }
        public List<PartyDice> PartyDice { get; set; }
        private static Random rng = new Random();     
        public bool PartyDiceThrown { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public void IncreaseXp(int xp)
        {
            Exp = xp;
        }
        public void SuffleList()
        {
            
        }
    }
}
