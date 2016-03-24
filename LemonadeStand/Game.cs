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




            //STOREFRONT
            //double ownerBalance = 20;
            //buySupplies run1 = new buySupplies();
            //run1.storeFront(ownerBalance);
            //Console.ReadLine();

            weatherSim run = new weatherSim();
            double forecast = run.weatherReport();
            Console.WriteLine(forecast);
            Console.ReadLine();

            day startTheLoop = new day();
            startTheLoop.newDay(forecast);

            customer run1 = new customer();
            run1.makeNewCustomers();


            for (int i = 0; i < 50; i++)
            {
                run1.listStuff(i);
                startTheLoop.iterateList(i);
                Console.WriteLine();
            }

            Console.ReadLine();
          }        
    }
}
