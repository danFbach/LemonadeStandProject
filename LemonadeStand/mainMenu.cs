using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class mainMenu
    {
        int gameSelect;
        public void gameSelection()
        {
            multiMain startGame = new multiMain();
            Game startSinglePlayer = new Game();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello player, would you like to...");
            Console.WriteLine("1. Start a new game?");
            Console.WriteLine("2. Load a previous game?");
            gameSelect = int.Parse(Console.ReadLine());
            startSinglePlayer.onePlayerGame(gameSelect);
        }        
    }
}