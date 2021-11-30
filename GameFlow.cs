using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Roll_Project
{
    class GameFlow
    {
        static public void StartingGame()
        {
            
            GameMenu.MainMenu();
            Console.ReadLine();
            Game.SetPlayerList();
            Game.GameStarting();
            //int userInput = int.Parse(Console.ReadLine());

            //if (userInput == 1)
            //{
                

            //}
            //else if (userInput == 2)
            //{

            //}
            //else if (userInput == 3)
            //{

            //}


        }
    }
}
