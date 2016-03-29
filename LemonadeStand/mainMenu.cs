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
            Console.WriteLine("How many weeks will we run the simulation, 1, 2 or 3?");
            dayLimit = int.Parse(Console.ReadLine());
            switch (dayLimit)
            {
                case (1):
                    dayLimit = 7;
                    return dayLimit;
                case (2):
                    dayLimit = 14;
                    return dayLimit;
                case (3):
                    dayLimit = 21;
                    return dayLimit; 
                default:
                    pickDayLimit();
                    break;
            }
            return dayLimit;
        }
    }
}
