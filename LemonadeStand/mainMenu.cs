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
        bool check;
        multiMain startGame = new multiMain();
        singleMain startSinglePlayer = new singleMain();
        public void gameSelection()
        {
            Console.WriteLine("Would you like to\n(1) Play single player?\n(2) Play multi player");
            check = int.TryParse(Console.ReadLine(), out gameType);
            if (check.Equals(false)) { gameSelection(); Console.WriteLine("Invalid entry."); }
            if (gameType.Equals(1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hello player, would you like to...");
                Console.WriteLine("1. Start a new game?");
                Console.WriteLine("2. Load a previous game?");
                check = int.TryParse(Console.ReadLine(), out gameSelect);
                if (check.Equals(false)) { gameSelection(); Console.WriteLine("Invalid entry."); }
                startSinglePlayer.onePlayerGame(gameSelect);
            }
            else if (gameType.Equals(2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Would you like to...");
                Console.WriteLine("1. Start a new game?");
                Console.WriteLine("2. Load the previous game?");
                check = int.TryParse(Console.ReadLine(), out gameSelect);
                if (check.Equals(false)) { gameSelection(); Console.WriteLine("Invalid entry."); }
                startGame.multiplayerSim(gameSelect);
            }
        }
    }
}