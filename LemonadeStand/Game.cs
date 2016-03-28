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
            weatherSim simulateWeather = new weatherSim();
            lemonadePitchers make = new lemonadePitchers();
            day startTheDay = new day();
            int dayLimiter = startGame.pickDayLimit();
            double lemons = stats.lemonCount;
            double icecubes = stats.iceCount;
            double sugar = stats.sugarCount;
            double money = stats.money;
            double cupPrice;

            simulateWeather.largeScaleWeather(dayLimiter);

            for (int currentDay = 0;currentDay < dayLimiter;currentDay++)
            {
                //daily weather
                double QtyOfPotentialCustomers = simulateWeather.weatherReport(currentDay);
                purchaseSupplies.storeFront(lemons, sugar, icecubes, money);
                //store
                double lemonPurchase = purchaseSupplies.buyLemons(lemons,money);
                lemons = purchaseSupplies.ingredientTotal(lemonPurchase, lemons, "lemons");
                money = purchaseSupplies.moneyBalanceAdjustment(money,lemonPurchase,"lemons");
                double sugarPurchase = purchaseSupplies.buySugar(sugar,money);
                sugar = purchaseSupplies.ingredientTotal(sugarPurchase, sugar, "sugar");
                money = purchaseSupplies.moneyBalanceAdjustment(money, sugarPurchase, "sugar");
                double icePurchase = purchaseSupplies.buyIce(icecubes,money);
                icecubes = purchaseSupplies.ingredientTotal(icePurchase, icecubes, "ice");
                money = purchaseSupplies.moneyBalanceAdjustment(money, sugarPurchase, "ice");
                Console.WriteLine("You have $" + money + ", " + lemons + " lemons, " + sugar + " cups of sugar and " + icecubes + " ice cubes.");
                //make pitchers
                double pitcherQty = make.selectPitchers(lemons, sugar, icecubes);
                lemons = make.calcIngredients(lemons, pitcherQty, "lemons");
                sugar = make.calcIngredients(sugar, pitcherQty, "sugar");
                icecubes = make.calcIngredients(icecubes, pitcherQty, "ice");
                //price cup
                cupPrice = startTheDay.pricePerCup();
                startTheDay.makeNewCustomers(QtyOfPotentialCustomers);
                //return money made
                money += startTheDay.daySim(pitcherQty,cupPrice);
                Console.WriteLine("You have $" + money + ", " + lemons + " lemons, " + sugar + " cups of sugar and " + icecubes + " ice cubes.");
            }           
        }
    }
}