using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        player stats = new player();
        public void test()
        {
            mainMenu startGame = new mainMenu();
            buySupplies purchaseSupplies = new buySupplies();
            int dayLimiter = startGame.pickDayLimit();
            double lemons = stats.lemonCount;
            double icecubes = stats.iceCount;
            double sugar = stats.sugarCount;
            double money = stats.money;

            weatherSim simulateWeather = new weatherSim();
            simulateWeather.largeScaleWeather(dayLimiter);

            for (int currentDay = 0;currentDay < dayLimiter;currentDay++)
            {                
                purchaseSupplies.storeFront(lemons, sugar, icecubes, money);
                double lemonPurchase = purchaseSupplies.buyLemons(lemons,money);
                lemons = purchaseSupplies.ingredientTotal(lemonPurchase, lemons, "lemons");
                money = purchaseSupplies.moneyBalanceAdjustment(money,lemonPurchase,"lemons");
                double sugarPurchase = purchaseSupplies.buySugar(sugar,money);
                sugar = purchaseSupplies.ingredientTotal(sugarPurchase, sugar, "sugar");
                money = purchaseSupplies.moneyBalanceAdjustment(money, sugarPurchase, "sugar");
                double icePurchase = purchaseSupplies.buyIce(icecubes,money);
                icecubes = purchaseSupplies.ingredientTotal(icePurchase, icecubes, "ice");
                money = purchaseSupplies.moneyBalanceAdjustment(money, sugarPurchase, "ice");
                Console.WriteLine(money + ", " + lemons + ", " + sugar + ", " + icecubes);
                Console.ReadLine();

                double QtyOfPotentialCustomers = simulateWeather.weatherReport(currentDay);
                Console.WriteLine(QtyOfPotentialCustomers + " should be number of customers, presss enter.");
                Console.ReadLine();

                day startTheDay = new day();
                startTheDay.makeNewCustomers(QtyOfPotentialCustomers);
                startTheDay.displayCustomers();

                double pitcherQty = startTheDay.selectPitchers(lemons, sugar, icecubes);
                lemons = startTheDay.calcIngredients(lemons, pitcherQty, "lemons");
                sugar = startTheDay.calcIngredients(lemons, pitcherQty, "sugar");
                icecubes = startTheDay.calcIngredients(lemons, pitcherQty, "ice");

                Console.WriteLine(money + ", " + lemons + ", " + sugar + ", " + icecubes);


                Console.ReadKey();
            }           
        }
    }
}

//get customers to buy lemonade...
//have player choose to make x # of pitchers
//build engine to account for cups purchased/pitchers being consumed/money coming in