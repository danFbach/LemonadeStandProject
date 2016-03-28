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
            fileWriter save = new fileWriter(0, 0, 0, 0);
            mainMenu startGame = new mainMenu();
            buySupplies purchaseSupplies = new buySupplies();
            weatherSim simulateWeather = new weatherSim();
            lemonadePitchers make = new lemonadePitchers();
            day startTheDay = new day();
            double lemons = stats.lemonCount;
            double icecubes = stats.iceCount;
            double sugar = stats.sugarCount;
            double money = stats.money;
            double cupPrice;
            double dailyIncome;
            int dayLimiter = 0;
            int currentDay = 0;

            int selection = startGame.gameSelection();
            if (selection.Equals(1))
            {
                dayLimiter = startGame.pickDayLimit();
                simulateWeather.largeScaleWeather(dayLimiter);
            }
            else if (selection.Equals(2))
            {
                fileReader retrieveGameData = new fileReader();
                retrieveGameData.dataDecoder();
                lemons = retrieveGameData.getLemons();
                sugar = retrieveGameData.getSugar();
                money = retrieveGameData.getTotalMoney();
                dayLimiter = retrieveGameData.getDayLimit();
                currentDay = retrieveGameData.getDay();
                Console.WriteLine("In your loaded game you have " + (dayLimiter-currentDay) + " days remaining, " + lemons + " lemons, " + sugar + " cups of sugar, no ice and " + money.ToString("C2") );
            }

            for (currentDay = 0; currentDay < dayLimiter; currentDay++)
            {

                double dailyProfit = 0;
                double tempMoney = money;
                //daily weather
                double QtyOfPotentialCustomers = simulateWeather.weatherReport(currentDay);
                purchaseSupplies.storeFront(lemons, sugar, icecubes, money);
                //store
                double lemonPurchase = purchaseSupplies.buyLemons(lemons, money);
                lemons = purchaseSupplies.ingredientTotal(lemonPurchase, lemons, "lemons");
                money = purchaseSupplies.moneyBalanceAdjustment(money, lemonPurchase, "lemons");
                double sugarPurchase = purchaseSupplies.buySugar(sugar, money);
                sugar = purchaseSupplies.ingredientTotal(sugarPurchase, sugar, "sugar");
                money = purchaseSupplies.moneyBalanceAdjustment(money, sugarPurchase, "sugar");
                double icePurchase = purchaseSupplies.buyIce(icecubes, money);
                icecubes = purchaseSupplies.ingredientTotal(icePurchase, icecubes, "ice");
                money = purchaseSupplies.moneyBalanceAdjustment(money, sugarPurchase, "ice");
                Console.WriteLine("You have " + money.ToString("C2") + ", " + lemons + " lemons, " + sugar + " cups of sugar and " + icecubes + " ice cubes.");
                //make pitchers
                double pitcherQty = make.selectPitchers(lemons, sugar, icecubes);
                lemons = make.calcIngredients(lemons, pitcherQty, "lemons");
                sugar = make.calcIngredients(sugar, pitcherQty, "sugar");
                icecubes = make.calcIngredients(icecubes, pitcherQty, "ice");
                //price cup
                cupPrice = startTheDay.pricePerCup();
                startTheDay.makeNewCustomers(QtyOfPotentialCustomers);
                //return money made
                dailyIncome = startTheDay.daySim(pitcherQty, cupPrice);
                money += dailyIncome;
                dailyProfit = money - tempMoney;
                save.saveStats(dailyIncome, money, dailyProfit, lemons, sugar, currentDay, dayLimiter);
                icecubes = 0;
                Console.WriteLine("You have " + money.ToString("C2") + ", " + lemons + " lemons, " + sugar + " cups of sugar and " + icecubes + " ice cubes because they melted.");
            }            
            Console.ReadLine();
        }
    }
}