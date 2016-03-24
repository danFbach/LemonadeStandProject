using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LemonadeStand
{
    public class day
    {
        int dayTimeLimit = 50;
        public List<string> thirsty = new List<string>();

        public void newDay(double forecast)
        {

            player run = new player(0, 0, 0, 0);
            for (int customerNum = 0; customerNum < dayTimeLimit; customerNum++)
            {
                double customerThirst = run.user(forecast);
                if (customerThirst < 50)
                {
                    thirsty.Add("don't buy");
                }
                else if (customerThirst > 50)
                {
                    thirsty.Add("buy");
                } Thread.Sleep(100);

            }
        }
            public void iterateList(int i)
        {
            Console.Write("   " + thirsty[i]);
        }   
    }
}


