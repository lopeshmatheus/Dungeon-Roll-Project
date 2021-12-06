using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Roll_Project
{
    class PartyDice
    {
        public List<PartyMembers> Faces = PartyMembers.PartyMemberList();
        public PartyMembers FaceUp { get; set; }
        public int Index { get; set; }

        static public List<PartyDice> GetPartyDice()
        {
            List<PartyDice> partyDiceList = new List<PartyDice> { };
            for (int i = 0; i < 7; i++)
            {
                partyDiceList.Add(new PartyDice());
            }

            return partyDiceList;
        }
      

    }
}
