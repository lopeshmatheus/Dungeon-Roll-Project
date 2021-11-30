using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Roll_Project
{
    class GameGraphics
    {

        static public void ReplaceSpace(string str)
        {

        }
        public void Test()
        {

        }
        static public string MageDice()
        {
            string mageDice =
                "┌───────┐\n" +
                "│       │\n" +
                "│ MAGE  │\n" +
                "│       │\n" +
                "└───────┘\n";

            return mageDice;
        }
        static public string ThiefDice()
        {
            string thiefDice =
                "┌───────┐\n" +
                "│       │\n" +
                "│ THIEF │\n" +
                "│       │\n" +
                "└───────┘\n";

            return thiefDice;
        }
        static public string ScrollDice()
        {
            string scrollDice =
                "┌───────┐\n" +
                "│       │\n" +
                "│ SCROLL│\n" +
                "│       │\n" +
                "└───────┘\n";

            return scrollDice;
        }
        static public string ChampDice()
        {
            string champDice =
                "┌───────┐\n" +
                "│       │\n" +
                "│ CHAMP │\n" +
                "│       │\n" +
                "└───────┘\n";

            return champDice;
        }
        static public string ClericDice()
        {
            string clericDice =
                "┌───────┐\n" +
                "│       │\n" +
                "│CLERIC │\n" +
                "│       │\n" +
                "└───────┘\n";

            return clericDice;
        }
        static public string WarriorDice()
        {
            string warriorDice =
                "┌───────┐\n" +
                "│       │\n" +
                "│WARRIOR│\n" +
                "│       │\n" +
                "└───────┘\n";

            return warriorDice;
        }
        static public string CurrentDiceHolding()
        {
            string diceHoldingGra =
                "┌─────────────────────────────────────────────┐\n" +
                "│xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx│\n" +
                "│x                                           x│\n" +
                "│x                                           x│\n" +
                "│x     YOUR ARE HOLDING THESE PARTY DICE!    x│\n" +
                "│x                                           x│\n" +
                "│x                                           x│\n" +
                "│xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx│zn" +
                "└─────────────────────────────────────────────┘\n";
            return diceHoldingGra;

        }
        static public string PlayersNames()
        {

            string playersNames =
                "┌─────────────────────────────────────────────┐\n" +
                "│xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx│\n" +
                "│x                                           x│\n" +
                "│x        Now, tell me the name of the       x│\n" +
                "│x           players and then press          x│\n" +
                "│x                    enter                  x│\n" +
                "│x                                           x│\n" +
                "│xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx│\n" +
                "└─────────────────────────────────────────────┘\n";

            return playersNames;
        }
        static public string WriteThePlayers()
        {
            string str1 = 
                "┌─────────────────────────────────────────────────┐\n" +
                "│xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx│\n" +
                "│.                                               .│\n" +
                "│.                                               .│\n" +
                "│.               VERY NICE! NOW                  .│\n" +
                "│.                  WRITE THE                    .│\n" +
                "│.              NAME OF THE PLAYERS              .│\n" +
                "│.                                               .│\n" +
                "│.                                               .│\n" +
                "│.                                               .│\n" +
                "│.                                               .│\n" +
                "│xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx│\n" +
                "└─────────────────────────────────────────────────┘\n"; 

 
            return str1;
        }
        static public string FirstScreen(string playerName, int xp)
        {
            string nameStr = "                   NAME                        ";
            string replacingName = "NAME";
            var refactoredNameStr = Game.ReplaceWordString(nameStr, playerName, replacingName);

            string xpStr = "                XPxp                         ";
            string replacingXp = "XP";
            string strXp = xp.ToString();
            var refactoredXpStr = Game.ReplaceWordString(xpStr, strXp, replacingXp);



            string infoMenu =

                "┌─────────────────────────────────────────────────┐\n" +
                "│xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx│\n" +
                "│.                                               .│\n" +
                "│." + refactoredNameStr + ".│\n" +
                "│.                                               .│\n" +
                "│." + refactoredXpStr + ".│\n" +
                "│.                                               .│\n" +
                "│.                     PLAY                      .│\n" +
                "│.                                               .│\n" +
                "│.                                               .│\n" +
                "│.                                               .│\n" +
                "│xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx│\n" +
                "└─────────────────────────────────────────────────┘\n";

            return infoMenu;

           
        }
        static public string HowManyPlayers()
        {
            string s = 
                "┌─────────────────────────────────────────────────┐\n" +
                "│xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx│\n" +
                "│.                                               .│\n" +
                "│.                                               .│\n" +
                "│.                HOW MANY PLAYER                .│\n" +
                "│.                  WILL PLAY?                   .│\n" +
                "│.                                               .│\n" +
                "│.                                               .│\n" +
                "│.                                               .│\n" +
                "│xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx│\n" +
                "└─────────────────────────────────────────────────┘\n";
            return s;
        }
    }
}
