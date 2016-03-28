using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class mainMenu
    {
        int dayLimit;
        int gameSelect;
        public int gameSelection()
        {
            Console.WriteLine("Hello player, would you like to...");
            Console.WriteLine("1. Start a new game?");
            Console.WriteLine("2. Load an old game?");
            gameSelect = int.Parse(Console.ReadLine());
            return gameSelect;
        }


        public int pickDayLimit()
        {
            Console.WriteLine("Pick number of days to run simulation.");
            dayLimit = int.Parse(Console.ReadLine());
            return dayLimit;
        }
    }
}
