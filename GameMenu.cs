using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Roll_Project
{
    class GameMenu
    {
        static public void FirstScreen()
        {
            var title = "DUNGEON ROLL";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);
            string s = "PRESS ENTER TO PLAY THE GAME";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);


        }    

        static public void MainMenu()
        {
            while (Game.Rounds < 3)
            {
                for (int i = 0; i < Game.PlayerList.Count(); i++)
                {
                    bool playerRound = true;
                    bool dungeonRound = true;
                    while (playerRound)
                    {
                        Console.Clear();
                        Console.WriteLine(GameGraphics.MainMenu());
                        int userInput = int.Parse(Console.ReadLine());
                        if (userInput == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(GameGraphics.FirstScreen(Game.PlayerList[i].Name, Game.PlayerList[i].Exp));
                            Console.ReadLine();
                        }
                        else if (userInput == 2)
                        {
                            while(dungeonRound)
                            {
                                Console.Clear();
                                Console.WriteLine(GameGraphics.Dungeon(Game.CurrentLevel));
                                int dungeonInput = int.Parse(Console.ReadLine());
                                if (dungeonInput == 1)
                                {
                                    if (Game.DungeonDiceOnBoard.Count == 0)
                                    {
                                        Game.ShuffleDungeonDice();
                                        Game.ShowDungeonDice();
                                    }
                                    else
                                    {
                                        
                                        Game.ShowDungeonDice();
                                    }
                                }
                                if (dungeonInput ==3)
                                {
                                    if (Game.PlayerList[i].PartyDiceThrown)
                                    {
                                        
                                        Game.ShowPartyDice();
                                    }
                                    else
                                    {
                                        Game.SufflePartyDice();
                                        Game.PlayerList[i].PartyDiceThrown = true;
                                        Game.ShowPartyDice();
                                    }
                                    
                                }
                                if (dungeonInput == 5)
                                {
                                    Game.DungeonStage(Game.PlayerList[i]);
                                }
                            }
                            
                            
                        }
                        else if (userInput == 3)
                        {

                            playerRound = Game.EndTurn();
                            Console.WriteLine(GameGraphics.NextPlayer(Game.PlayerList[i].Name, Game.PlayerList[i + 1].Name));
                            Console.ReadLine();
                        }
                    }
                }
               
            }           
        }     
    }
    
}
