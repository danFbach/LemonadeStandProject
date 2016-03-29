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
        public List<int> weatherstuff;

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
                //new game
                dayLimiter = startGame.pickDayLimit();
                weatherstuff = simulateWeather.largeScaleWeather(dayLimiter);
                save.saveWeather(weatherstuff);
            }
            else if (selection.Equals(2))
            {
                //reload previous game with correct money, inventory and weather conditions
                fileReader retrieveGameData = new fileReader();
                weatherstuff = retrieveGameData.getWeatherData();
                retrieveGameData.dataDecoder();
                lemons = retrieveGameData.getLemons();
                sugar = retrieveGameData.getSugar();
                money = retrieveGameData.getTotalMoney();
                dayLimiter = retrieveGameData.getDayLimit();
                currentDay = retrieveGameData.getDay();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("In your loaded game you have " + (dayLimiter-(currentDay)) + " days remaining, " + lemons + " lemons, " + sugar + " cups of sugar, no ice and " + money.ToString("C2") );
            }

            for (;currentDay < dayLimiter;)
            {

                double tempMoney = money;
                //daily weather
                int todaysWeather = weatherstuff[currentDay];
                double QtyOfPotentialCustomers = simulateWeather.weatherReport(todaysWeather);
                purchaseSupplies.storeFront(lemons, sugar, icecubes, money);
                //store
                double lemonPurchase = purchaseSupplies.purchaseSupplies(lemons, money, "lemons");
                double sugarPurchase = purchaseSupplies.purchaseSupplies(sugar, money, "cups of sugar");
                double icePurchase = purchaseSupplies.purchaseSupplies(icecubes, money, "ice cubes");
                money = purchaseSupplies.moneyBalanceAdjustment(money, lemonPurchase, sugarPurchase, icePurchase);
                lemons = purchaseSupplies.ingredientTotal(lemonPurchase, lemons, "lemons");
                sugar = purchaseSupplies.ingredientTotal(sugarPurchase, sugar, "sugar");
                icecubes = purchaseSupplies.ingredientTotal(icePurchase, icecubes, "ice");
                Console.WriteLine("You have " + money.ToString("C2") + ", " + lemons + " lemons, " + sugar + " cups of sugar and " + icecubes + " ice cubes.");
                //make pitchers
                double pitcherQty = make.selectPitchers(lemons, sugar, icecubes);
                //subtract ingredients based on pitchers qty
                lemons = make.calcIngredients(lemons, pitcherQty, "lemons");
                sugar = make.calcIngredients(sugar, pitcherQty, "sugar");
                icecubes = make.calcIngredients(icecubes, pitcherQty, "ice");
                //price cup
                cupPrice = startTheDay.pricePerCup();
                startTheDay.makeNewCustomers(QtyOfPotentialCustomers);
                //sim a day
                dailyIncome = startTheDay.daySim(pitcherQty, cupPrice);
                //return money made and reset some values
                double dailyProfit = 0;
                money += dailyIncome;
                dailyProfit = money - tempMoney;
                icecubes = 0;
                //save data from end of day
                save.saveStats(dailyIncome, money, dailyProfit, lemons, sugar, currentDay, dayLimiter);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine( "Today, day " + (currentDay + 1) + ", you made " + dailyIncome.ToString("C2") + ", for a profit of " + dailyProfit.ToString("C2") + " You now have " + money.ToString("C2") + " in your pocket, " + lemons + " lemons, " + sugar + " cups of sugar and " + icecubes + " ice cubes because they melted. Press enter to continue to the next day, "+(dayLimiter-(currentDay+1))+" days remain.");
                Console.ReadKey();
                Console.Clear();
                currentDay += 1;
            }            
            Console.ReadLine();
        }
    }
}