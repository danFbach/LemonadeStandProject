using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class day
    {
        public void newDay(double forecast)
        {
            player run = new player(0, 0, 0, 0);
            for (int i = 0; i < 50; i++)
            {
                double customerThirst = run.user(forecast);

                if (customerThirst < 50)
                {
                    //they dont buy
                    Console.WriteLine("dont buy");
                }
                else if (customerThirst > 50)
                {
                    Console.WriteLine("buy");
                    //they buy lemonade
                }Console.ReadLine();
            }
        }
    }
}
