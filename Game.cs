using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dungeon_Roll_Project
{
    class Game
    {
        static public int Rounds { get; set; }
        static public int NumberOfPlayers { get; private set; }
        static public int CurrentLevel { get; set; } = 5;
        static public int DragonsLair { get; set; }
        static public int PartyDiceGraveyard { get; set; }
        static public int DungeonDiceGraveyard { get; set; }
        static public List<PartyDice> PartyDiceList = PartyDice.GetPartyDice();
        static public List<DungeonDice> DungeonDiceList = DungeonDice.GetDungeonDice();
        static public List<DungeonDice> DungeonDiceOnBoard { get; set; } = new List<DungeonDice>();
        static public List<Treasure> AvailableTokens = Treasure.GetTreasure();
        static public List<Player> PlayerList { get; set; } = new List<Player>();
        

        static public void SetNumberOfPlayer(int numberofPlayers)
        {
            NumberOfPlayers = numberofPlayers;
        }
        static public void ResetPartyDiceList()
        {
            PartyDiceList = PartyDice.GetPartyDice();
        }
        static public void ResetDungeonDiceList()
        {
            DungeonDiceList = DungeonDice.GetDungeonDice();
        }
        static public void ResetAvailableTokens()
        {
            AvailableTokens = Treasure.GetTreasure();
        }

        static public void SetPlayerList()
        {
            Console.Clear();
            var s = GameGraphics.HowManyPlayers();
            Console.WriteLine(s);
            int playerNumber = int.Parse(Console.ReadLine());
            Player[] playerArray = new Player[playerNumber];

            for (int i  = 0; i < playerNumber; i++)
            {
                Console.Clear();

                Console.WriteLine(GameGraphics.WriteThePlayers());
                var playerName = Console.ReadLine();
                PlayerList.Add(new Player(playerName));                     
            }
        }

        public static string ReplaceWordString(string stringToReplace, string stringReplacing, string replacingItem)
        {

   
            var strSize = stringToReplace.Length;
            var strReplSize = stringReplacing.Length;

            stringToReplace = stringToReplace.Replace(replacingItem, stringReplacing).Trim();

  
      
            var remainingSizeToAdd = (strSize - strReplSize) / 2;

            stringToReplace = stringToReplace.PadRight(remainingSizeToAdd + stringToReplace.Length);
            stringToReplace = stringToReplace.PadLeft(remainingSizeToAdd + stringToReplace.Length);

            

  
            var newStrSize = stringToReplace.Length;

            if (newStrSize % 2 == 0)
            {
                stringToReplace += " ";
            }

            return stringToReplace;
        }
        static public void SufflePartyDice()
        {
            Random rnd = new Random();
            foreach (PartyDice partyDice in Game.PartyDiceList)
            {
                var rndNumber = rnd.Next(0, 6);
                partyDice.FaceUp = PartyMembers.PartyMemberList()[rndNumber];
            }
        }
        static public void ShowPartyDice()
        {
            Console.Clear();
            foreach (PartyDice die in PartyDiceList)
            {    
                Console.ForegroundColor = die.FaceUp.Color;
                Console.Write(GameGraphics.GetDiceGraphics(die.FaceUp.Name));
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        static public bool EndTurn()
        {
            ResetAvailableTokens();
            ResetDungeonDiceList();
            ResetPartyDiceList();
            ResetCurrentLvl();
            return false;
        }

        static public void ShuffleDungeonDice()
        {
            Random rnd = new Random();
            for (int i = 0; i < CurrentLevel; i++)
            {
                var rndNumber = rnd.Next(0, 6);
                DungeonDiceList[i].FaceUp = DungeonMembers.DungeonMemberList()[rndNumber];
                DungeonDiceOnBoard.Add(DungeonDiceList[i]);
            }
            
        }
        static public void ShowDungeonDice()
        {
            Console.Clear();
            foreach (DungeonDice die in DungeonDiceOnBoard)
            {
                Console.ForegroundColor = die.FaceUp.Color;
                Console.Write(GameGraphics.GetDiceGraphics(die.FaceUp.Name));
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        static public void IncreaseCurrentLvl(int lvl)
        {
            CurrentLevel += lvl;
        }
        static public void ResetCurrentLvl()
        {
            CurrentLevel = 1;
        }
        static public void DungeonStage(Player player)
        {
            GameGraphics.DragonStageHeader(player);

            Console.WriteLine("\nPARTY DICE LIST\n");
            foreach(PartyDice partyDie in PartyDiceList)
            {
                Console.ForegroundColor = partyDie.FaceUp.Color;
                Console.WriteLine(partyDie.FaceUp.Name.ToUpper() + "\n");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nDUNGEON DICE LIST\n");
            Console.ForegroundColor = ConsoleColor.White;
            foreach(DungeonDice dungeonDie in DungeonDiceOnBoard)
            {
                Console.ForegroundColor = dungeonDie.FaceUp.Color;
                Console.WriteLine(dungeonDie.FaceUp.Name.ToUpper() + "\n");
            }
            Console.ForegroundColor = ConsoleColor.White;   
            Console.WriteLine("\n" + GameGraphics.FightOptions());
            Console.ReadKey();

        }
    }
}
