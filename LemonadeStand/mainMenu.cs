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
        int gameType;
        multiMain startGame = new multiMain();
        Game startSinglePlayer = new Game();
        public void gameSelection()
        {
            Console.WriteLine("Would you like to\n(1) Play single player?\n(2) Play multi player");
            gameType = int.Parse(Console.ReadLine());
            if (gameType.Equals(1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hello player, would you like to...");
                Console.WriteLine("1. Start a new game?");
                Console.WriteLine("2. Load a previous game?");
                gameSelect = int.Parse(Console.ReadLine());
                startSinglePlayer.onePlayerGame(gameSelect);
            }
            else if (gameType.Equals(2))
            {
                startGame.multiplayerSim();
            }
            
        }        
    }
}