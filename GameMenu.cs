using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Roll_Project
{
    class GameMenu
    {
        static public void MainMenu()
        {
            
            var title = @"


▓█████▄  █    ██  ███▄    █   ▄████ ▓█████  ▒█████   ███▄    █     ██▀███   ▒█████   ██▓     ██▓    
▒██▀ ██▌ ██  ▓██▒ ██ ▀█   █  ██▒ ▀█▒▓█   ▀ ▒██▒  ██▒ ██ ▀█   █    ▓██ ▒ ██▒▒██▒  ██▒▓██▒    ▓██▒    
░██   █▌▓██  ▒██░▓██  ▀█ ██▒▒██░▄▄▄░▒███   ▒██░  ██▒▓██  ▀█ ██▒   ▓██ ░▄█ ▒▒██░  ██▒▒██░    ▒██░    
░▓█▄   ▌▓▓█  ░██░▓██▒  ▐▌██▒░▓█  ██▓▒▓█  ▄ ▒██   ██░▓██▒  ▐▌██▒   ▒██▀▀█▄  ▒██   ██░▒██░    ▒██░    
░▒████▓ ▒▒█████▓ ▒██░   ▓██░░▒▓███▀▒░▒████▒░ ████▓▒░▒██░   ▓██░   ░██▓ ▒██▒░ ████▓▒░░██████▒░██████▒
 ▒▒▓  ▒ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒  ░▒   ▒ ░░ ▒░ ░░ ▒░▒░▒░ ░ ▒░   ▒ ▒    ░ ▒▓ ░▒▓░░ ▒░▒░▒░ ░ ▒░▓  ░░ ▒░▓  ░
 ░ ▒  ▒ ░░▒░ ░ ░ ░ ░░   ░ ▒░  ░   ░  ░ ░  ░  ░ ▒ ▒░ ░ ░░   ░ ▒░     ░▒ ░ ▒░  ░ ▒ ▒░ ░ ░ ▒  ░░ ░ ▒  ░
 ░ ░  ░  ░░░ ░ ░    ░   ░ ░ ░ ░   ░    ░   ░ ░ ░ ▒     ░   ░ ░      ░░   ░ ░ ░ ░ ▒    ░ ░     ░ ░   
   ░       ░              ░       ░    ░  ░    ░ ░           ░       ░         ░ ░      ░  ░    ░  ░
 ░                                                                                                 ";
            
            Console.WriteLine(title);
            string s = "PRESS ENTER TO PLAY THE GAME";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);

        }
     
    }
    
}
