using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        public void test()
        {

            mainMenu startGame = new mainMenu();
            int dayLimiter = startGame.pickDayLimit();

            weatherSim simulateWeather = new weatherSim();
            simulateWeather.largeScaleWeather(dayLimiter);

            for (int currentDay = 0;currentDay < dayLimiter;currentDay++)
            {
                double QtyOfPotentialCustomers = simulateWeather.weatherReport(currentDay);
                Console.WriteLine(QtyOfPotentialCustomers + " should be number of customers, presss enter.");
                Console.ReadLine();

                day startTheLoop = new day();
                startTheLoop.makeNewCustomers(QtyOfPotentialCustomers);
                startTheLoop.displayCustomers();
                Console.ReadKey();
            }

            

            

            //STOREFRONT
            //double ownerBalance = 20;
            //buySupplies run1 = new buySupplies();
            //run1.storeFront(ownerBalance);
            //Console.ReadLine();
        }
    }
}

