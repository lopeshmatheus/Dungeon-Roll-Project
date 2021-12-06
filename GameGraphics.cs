using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Roll_Project
{
    class GameGraphics
    {
        static public string GetDiceGraphics(string diceName)
        {
            string strToReplace = " DICE  ";
            string replacingName = "DICE";
            string dice = Game.ReplaceWordString(strToReplace, diceName, replacingName);
            string standardDice = 
                "┌───────┐\n" +
                "│       │\n" +
                "│" + dice +"│\n" +
                "│       │\n" +
                "└───────┘\n";

            return standardDice;
        }
       
        static public string WriteThePlayers()
        {
            string str1 =
                "┌─────────────────────────────────────────────────┐\n" +
                "│xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx│\n" +
                "│.                                               .│\n" +
                "│.                                               .│\n" +
                "│.                VERY NICE! NOW                 .│\n" +
                "│.                   WRITE THE                   .│\n" +
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

            string xpStr = "               XP xp                        ";
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
                "│.                HOW MANY PLAYERS               .│\n" +
                "│.                   WILL PLAY?                  .│\n" +
                "│.                                               .│\n" +
                "│.                                               .│\n" +
                "│.                                               .│\n" +
                "│xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx│\n" +
                "└─────────────────────────────────────────────────┘\n";
            return s;
        }
        static public string ThrowDice()
        {
            string s =
                "┌─────────────────────────────────────────────────┐\n" +
                "│xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx│\n" +
                "│.                                               .│\n" +
                "│.                YOU DIDN'T THROW YOUR          .│\n" +
                "│.                  DICE YET, PLEASE             .│\n" +
                "│.               THROW YOUR PARTY DICE           .│\n" +
                "│.                  ENTER TO THROW               .│\n" +
                "│.                                               .│\n" +
                "│xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx│\n" +
                "└─────────────────────────────────────────────────┘\n";
            return s;
        }
        static public string ShowDice()
        {
            string s =
                "┌─────────────────────────────────────────────────┐\n" +
                "│xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx│\n" +
                "│.                                               .│\n" +
                "│.                 WOW! YOU THREW                .│\n" +
                "│.                 7 PARTY DICE                  .│\n" +
                "│.              TAKE A LOOK AT THEM              .│\n" +
                "│.                                               .│\n" +
                "│.                                               .│\n" +
                "│xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx│\n" +
                "└─────────────────────────────────────────────────┘\n";

            return s;
        }
        static public string MainMenu()
        {
            string s =
                "┌─────────────────────────────────────────────────┐\n" +
                "│xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx│\n" +
                "│.                                               .│\n" +
                "│.             1.PLAYER INFORMATION              .│\n" +
                "│.             2.ENTER THE DUNGEON               .│\n" +
                "│.             3.GO TO NEXT PLAYER               .│\n" +
                "│.                                               .│\n" +
                "│.                                               .│\n" +
                "│xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx│\n" +
                "└─────────────────────────────────────────────────┘\n";

            return s;
        }
        static public string Dungeon(int currentLvl)
        {
            string strToReplace = "DUNGEON LEVEL LV                 ";
            string replacingName = "LV";
            string level = Game.ReplaceWordString(strToReplace, currentLvl.ToString(), replacingName);
            string s =
                "┌─────────────────────────────────────────────────┐\n" +
                "│xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx│\n" +
                "│." + level + ".│\n" +
                "│.     1. DUNGEON DICE       6.FLEE              .│\n" +
                "│.     2. DRAGON'S LAIR      7.TOKENS            .│\n" +
                "│.     3. PARTY DICE                             .│\n" +
                "│.     4. CEMETERY DICE                          .│\n" +
                "│.     5. FIGHT                                  .│\n" +
                "│xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx│\n" +
                "└─────────────────────────────────────────────────┘\n";

            return s;
        }
        static public string NextPlayer(string name, string name2)
        {
            string strToReplace = "                  ALRIGHT NAME,                ";
            string replacingStr = "NAME";

            string strToReplace2 = "            NOW, IT'S NAME2's ROUND            ";
            string replacingStr2 = "NAME2";


            string str1 = Game.ReplaceWordString(strToReplace, name, replacingStr);
            string str2 = Game.ReplaceWordString(strToReplace2, name2, replacingStr2);
            string s =
                "┌─────────────────────────────────────────────────┐\n" +
                "│xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx│\n" +
                "│.                                               .│\n" +
                "│.                                               .│\n" +
                "│." + str1 + ".│\n" +
                "│." + str2 + ".│\n" +
                "│.                                               .│\n" +
                "│.                                               .│\n" +
                "│.                                               .│\n" +
                "│xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx│\n" +
                "└─────────────────────────────────────────────────┘\n";
            return s;       
        }
        static public string FightOptions()
        {
            string s = "HERE ARE YOUR OPTIONS: \n";
            string s1 = "1.FIGHT THE MONSTERS / OPEN CHESTS\n";
            string s2 = "2. FLEE FROM THE DUNGEON\n";
            string s3 = s + s1 + s2;

            return s3;

        }
        static public string DragonStageHeader(Player player)
        {
            string s = $"PLAYER NAME: {player.Name.ToUpper()}    CURRENT EXP: {player.Exp}\n   CURRENT DUNGEON LEVEL: {Game.CurrentLevel}";
            return s;
        }
       static public void DragonStageFight(List<PartyDice> partyDiceList)
        {
            
            for (int i = 0; i < partyDiceList.Count; i++)
            {
                Console.ForegroundColor = partyDiceList[i].FaceUp.Color;
                Console.WriteLine($"{i}.{partyDiceList[i].FaceUp.Name}");
                partyDiceList[i].Index = i;
            }
            //Console.ForegroundColor = ConsoleColor.White;
            //int userInput = int.Parse(Console.ReadLine());
            //for (int i = 0; i < partyDiceList.Count; i++)
            //{
            //    if (userInput == partyDiceList[i].Index)
            //    {
            //        foreach(DungeonDice dungeonDie in Game.DungeonDiceOnBoard)
            //        {
            //            if (partyDiceList[i].FaceUp.Special == )
            //        }
            //    }
            //}
            
        }
    }
}
