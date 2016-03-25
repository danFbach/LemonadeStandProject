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
            buySupplies purchaseSupplies = new buySupplies();
            int dayLimiter = startGame.pickDayLimit();

            weatherSim simulateWeather = new weatherSim();
            simulateWeather.largeScaleWeather(dayLimiter);

            for (int currentDay = 0;currentDay < dayLimiter;currentDay++)
            {                
                purchaseSupplies.storeFront();
                Console.ReadLine();

                double QtyOfPotentialCustomers = simulateWeather.weatherReport(currentDay);
                Console.WriteLine(QtyOfPotentialCustomers + " should be number of customers, presss enter.");
                Console.ReadLine();

                day startTheLoop = new day();
                startTheLoop.makeNewCustomers(QtyOfPotentialCustomers);
                startTheLoop.displayCustomers();
                Console.ReadKey();
            }





            //STOREFRONT

        }
    }
}

