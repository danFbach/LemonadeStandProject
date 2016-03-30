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
        public List<int> weatherData;

        public void test()
        {
            fileWriter save = new fileWriter(0, 0, 0, 0, 0);
            mainMenu startGame = new mainMenu();
            buySupplies purchaseSupplies = new buySupplies();
            userInterface display = new userInterface();
            weatherSim simulateWeather = new weatherSim();
            lemonadePitchers pitcherInteraction = new lemonadePitchers();
            day beginDayOfBusiness = new day();
            double lemons = stats.lemonCount;
            double iceCubes = stats.iceCount;
            double meltIce = 0;
            double sugar = stats.sugarCount;
            double currentMoneyBalance = stats.money;
            double todaysCupPrice;
            double todaysIncome;
            double packsOfLemonsPurchased;
            double packsOfSugarPurchased;
            double packsOfIcePurchased;
            double slotChoice = 0;
            double todaysProfit;
            double numberPitchersToMake;
            double numberOfPotentialCustomers;
            double startOfDayMoney;
            int todaysWeatherForecast;
            int daysOfSimulation = 0;
            int currentDay = 0;
            int selection;
            int consWidth = 90;
            int consHeight = Console.WindowHeight;
            string customRecipe;
            string gameSave = "";

            Console.SetWindowSize(consWidth, consHeight);
            selection = startGame.gameSelection();
            if (selection.Equals(1))
            {
                //new game
                daysOfSimulation = startGame.pickDayLimit();
                weatherData = simulateWeather.largeScaleWeather(daysOfSimulation);
                save.saveWeather(weatherData);
            }
            else if (selection.Equals(2))
            {
                //reload previous game with correct money, inventory and weather conditions
                fileReader retrieveGameData = new fileReader();
                weatherData = retrieveGameData.getWeatherData();
                slotChoice = retrieveGameData.dataDecoder();
                lemons = retrieveGameData.getLemons();
                sugar = retrieveGameData.getSugar();
                currentMoneyBalance = retrieveGameData.getTotalMoney();
                daysOfSimulation = retrieveGameData.getDayLimit();
                currentDay = retrieveGameData.getDay();
                display.infoBar(lemons, sugar, iceCubes, currentMoneyBalance, 0,currentDay);
                gameSave = "save";
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nThe previous game has loaded. It is day " + (currentDay + 1) + " and there are " + (daysOfSimulation - currentDay) + " days left, including today. \nPress enter to continue.");
                Console.ReadKey();
            }

            for (; currentDay < daysOfSimulation;)
            {

                startOfDayMoney = currentMoneyBalance;
                //daily weather
                todaysWeatherForecast = weatherData[currentDay];
                numberOfPotentialCustomers = simulateWeather.weatherReport(todaysWeatherForecast);
                //buy lemons
                display.infoBar(lemons, sugar, iceCubes, currentMoneyBalance, todaysWeatherForecast, currentDay);
                packsOfLemonsPurchased = purchaseSupplies.purchaseSupplies(lemons, currentMoneyBalance, "lemons");
                currentMoneyBalance = purchaseSupplies.adjustMoneyBalanceOfPurchase(currentMoneyBalance, packsOfLemonsPurchased, "lemons");
                lemons = purchaseSupplies.ingredientTotal(packsOfLemonsPurchased, lemons, "lemons");
                //buy sugar
                display.infoBar(lemons, sugar, iceCubes, currentMoneyBalance, todaysWeatherForecast, currentDay);
                packsOfSugarPurchased = purchaseSupplies.purchaseSupplies(sugar, currentMoneyBalance, "cups of sugar");
                sugar = purchaseSupplies.ingredientTotal(packsOfSugarPurchased, sugar, "sugar");
                currentMoneyBalance = purchaseSupplies.adjustMoneyBalanceOfPurchase(currentMoneyBalance, packsOfSugarPurchased, "sugar");
                //buy ice
                display.infoBar(lemons, sugar, iceCubes, currentMoneyBalance, todaysWeatherForecast, currentDay);
                packsOfIcePurchased = purchaseSupplies.purchaseSupplies(iceCubes, currentMoneyBalance, "ice cubes");
                iceCubes = purchaseSupplies.ingredientTotal(packsOfIcePurchased, iceCubes, "ice");
                currentMoneyBalance = purchaseSupplies.adjustMoneyBalanceOfPurchase(currentMoneyBalance, packsOfIcePurchased, "ice");
                //make pitchers
                display.infoBar(lemons, sugar, iceCubes, currentMoneyBalance, todaysWeatherForecast, currentDay);
                customRecipe = pitcherInteraction.makeARecipe();
                display.infoBar(lemons, sugar, iceCubes, currentMoneyBalance, todaysWeatherForecast, currentDay);
                numberPitchersToMake = pitcherInteraction.selectPitchers(lemons, sugar, iceCubes);
                //subtract ingredients based on pitcher order
                lemons = pitcherInteraction.calcIngredients(lemons, numberPitchersToMake, "lemons");
                sugar = pitcherInteraction.calcIngredients(sugar, numberPitchersToMake, "sugar");
                iceCubes = pitcherInteraction.calcIngredients(iceCubes, numberPitchersToMake, "ice");
                //price/cup set
                display.infoBar(lemons, sugar, iceCubes, currentMoneyBalance, todaysWeatherForecast, currentDay);
                todaysCupPrice = beginDayOfBusiness.setPricePerCup();
                beginDayOfBusiness.makeTodaysCustomers(numberOfPotentialCustomers);
                //sim a day
                todaysIncome = beginDayOfBusiness.daySim(numberPitchersToMake, todaysCupPrice, customRecipe);
                //return money made and reset some values
                todaysProfit = 0;
                currentMoneyBalance += todaysIncome;
                todaysProfit = currentMoneyBalance - startOfDayMoney;
                iceCubes = meltIce;
                //save data from end of day
                currentDay += 1;
                gameSave = save.newSave(gameSave);
                slotChoice = save.newSlot(gameSave,slotChoice);
                save.todaysStats(currentMoneyBalance, currentDay, daysOfSimulation, lemons, sugar, slotChoice);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Today, day " + (currentDay) + ", you made " + todaysIncome.ToString("C2") + ", for a profit of " + todaysProfit.ToString("C2") + "\nPress enter to continue to the next day, " + (daysOfSimulation - (currentDay)) + " days remain, including today.");
                if(currentMoneyBalance < 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You no longer have enough money to continue playing. \nGame over.");
                    break;
                }
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}