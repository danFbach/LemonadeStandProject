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
        public int pickDayLimit()
        {
            Console.WriteLine("Pick number of days to run simulation.");
            dayLimit = int.Parse(Console.ReadLine());
            return dayLimit;
        }
    }
}
