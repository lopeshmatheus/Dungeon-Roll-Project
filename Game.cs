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
        static public int CurrentLevel { get; set; }
        static public int DragonsLair { get; set; }
        static public int PartyDiceGraveyard { get; set; }
        static public int DungeonDiceGraveyard { get; set; }
        static public List<PartyDice> PartyDiceList = PartyDice.GetPartyDice();
        static public List<DungeonDice> DungeonDiceList = DungeonDice.GetDungeonDice();
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

        static public void GameStarting()
        {
            while(Game.Rounds < 3)
            {
                foreach(Player currentPlayer in Game.PlayerList)
                {
                    Console.Clear();
                    Console.WriteLine(GameGraphics.FirstScreen(currentPlayer.Name, currentPlayer.Exp));
                    Console.ReadLine();
                }
            }
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



    }
}
