using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class multiMain
    {
        public List<int> weatherData;
        public void multiplayerSim()
        {
            double p1Money = 20;
            double p1StartMoney;
            double p1Lemons = 0;
            double p1Sugar = 0;
            double p1Ice = 0;
            double p1CupPrice;
            double p1Income;
            double p1LemonPackQty;
            double p1SugarPackQty;
            double p1IcePackQty;
            double p1Profit;
            double p1PitcherQty;
            double playerNumber1 = 1;
            string p1Recipe = "";

            double p2Money = 20;
            double p2StartMoney;
            double p2Lemons = 0;
            double p2Sugar = 0;
            double p2Ice = 0;
            double p2CupPrice;
            double p2Income;
            double p2LemonPackQty;
            double p2SugarPackQty;
            double p2IcePackQty;
            double p2Profit;
            double p2PitcherQty;
            double playerNumber2 = 2;
            string p2Recipe = "";

            double potentialCustomers;
            double meltIce = 0;
            int dayLimit;
            int todaysWeather;
            int currentDay = 0;

            weatherSim setWeather = new weatherSim();
            userInterface display = new userInterface();
            buySupplies purchaseSupplies = new buySupplies();
            lemonadePitchers pitcherInteraction = new lemonadePitchers();
            day beginDayOfBusiness = new day();

            dayLimit = beginDayOfBusiness.pickDayLimit();
            weatherData = setWeather.largeScaleWeather(dayLimit);
            todaysWeather = weatherData[currentDay];

            for (; currentDay < dayLimit;)
            {
                p1StartMoney = p1Money;
                p2StartMoney = p2Money;
                potentialCustomers = setWeather.weatherReport(todaysWeather);
                //buy lemons p1
                display.infoBar(p1Lemons, p1Sugar, p1Ice, p1Money, todaysWeather, currentDay, playerNumber1);
                p1LemonPackQty = purchaseSupplies.purchaseSupplies(p1Lemons, p1Money, "lemons");
                p1Money = purchaseSupplies.adjustMoneyBalanceOfPurchase(p1Money, p1LemonPackQty, "lemons");
                p1Lemons = purchaseSupplies.ingredientTotal(p1LemonPackQty, p1Lemons, "lemons");
                //buy sugar p1
                display.infoBar(p1Lemons, p1Sugar, p1Ice, p1Money, todaysWeather, currentDay, playerNumber1);
                p1SugarPackQty = purchaseSupplies.purchaseSupplies(p1Sugar, p1Money, "cups of sugar");
                p1Money = purchaseSupplies.adjustMoneyBalanceOfPurchase(p1Money, p1SugarPackQty, "sugar");
                p1Sugar = purchaseSupplies.ingredientTotal(p1SugarPackQty, p1Sugar, "sugar");
                //buy ice p1
                display.infoBar(p1Lemons, p1Sugar, p1Ice, p1Money, todaysWeather, currentDay, playerNumber1);
                p1IcePackQty = purchaseSupplies.purchaseSupplies(p1Ice, p1Money, "ice cubes");
                p1Money = purchaseSupplies.adjustMoneyBalanceOfPurchase(p1Money, p1IcePackQty, "ice");
                p1Ice = purchaseSupplies.ingredientTotal(p1IcePackQty, p1Ice, "ice");
                //buy lemons p2
                display.infoBar(p2Lemons, p2Sugar, p2Ice, p2Money, todaysWeather, currentDay, playerNumber2);
                p2LemonPackQty = purchaseSupplies.purchaseSupplies(p2Lemons, p2Money, "lemons");
                p2Money = purchaseSupplies.adjustMoneyBalanceOfPurchase(p2Money, p2LemonPackQty, "lemons");
                p2Lemons = purchaseSupplies.ingredientTotal(p2LemonPackQty, p2Lemons, "lemons");
                //buy sugar p2
                display.infoBar(p2Lemons, p2Sugar, p2Ice, p2Money, todaysWeather, currentDay, playerNumber2);
                p2SugarPackQty = purchaseSupplies.purchaseSupplies(p2Sugar, p2Money, "cups of sugar");
                p2Money = purchaseSupplies.adjustMoneyBalanceOfPurchase(p2Money, p2SugarPackQty, "sugar");
                p2Sugar = purchaseSupplies.ingredientTotal(p2SugarPackQty, p2Sugar, "sugar");
                //buy ice p2
                display.infoBar(p2Lemons, p2Sugar, p2Ice, p2Money, todaysWeather, currentDay, playerNumber2);
                p2IcePackQty = purchaseSupplies.purchaseSupplies(p2Ice, p2Money, "ice cubes");
                p2Money = purchaseSupplies.adjustMoneyBalanceOfPurchase(p2Money, p2IcePackQty, "ice");
                p2Ice = purchaseSupplies.ingredientTotal(p2IcePackQty, p2Ice, "ice");
                //pitcher p1
                display.infoBar(p1Lemons, p1Sugar, p1Ice, p1Money, todaysWeather, currentDay, playerNumber1);
                p1Recipe = pitcherInteraction.makeARecipe(playerNumber1);
                display.infoBar(p1Lemons, p1Sugar, p1Ice, p1Money, todaysWeather, currentDay, playerNumber1);
                p1PitcherQty = pitcherInteraction.selectPitchers(p1Lemons, p1Sugar, p1Ice, playerNumber1);
                p1Lemons = pitcherInteraction.calcIngredients(p1Lemons, p1PitcherQty, "lemons", playerNumber1);
                p1Sugar = pitcherInteraction.calcIngredients(p1Sugar, p1PitcherQty, "sugar", playerNumber1);
                p1Ice = pitcherInteraction.calcIngredients(p1Ice, p1PitcherQty, "ice", playerNumber1);
                //pitcher p2
                display.infoBar(p2Lemons, p2Sugar, p2Ice, p2Money, todaysWeather, currentDay, playerNumber2);
                p2Recipe = pitcherInteraction.makeARecipe(playerNumber2);
                display.infoBar(p2Lemons, p2Sugar, p2Ice, p2Money, todaysWeather, currentDay, playerNumber2);
                p2PitcherQty = pitcherInteraction.selectPitchers(p2Lemons, p2Sugar, p2Ice, playerNumber2);
                p2Lemons = pitcherInteraction.calcIngredients(p2Lemons, p2PitcherQty, "lemons", playerNumber2);
                p2Sugar = pitcherInteraction.calcIngredients(p2Sugar, p2PitcherQty, "sugar", playerNumber2);
                p2Ice = pitcherInteraction.calcIngredients(p2Ice, p2PitcherQty, "ice", playerNumber2);
                //make customers
                beginDayOfBusiness.makeTodaysCustomers(potentialCustomers);
                //price p1
                display.infoBar(p1Lemons, p1Sugar, p1Ice, p1Money, todaysWeather, currentDay, playerNumber1);
                p1CupPrice = beginDayOfBusiness.setPricePerCup();
                p1Income = beginDayOfBusiness.daySim(p1PitcherQty, p1CupPrice, p1Recipe);
                //price p2
                display.infoBar(p2Lemons, p2Sugar, p2Ice, p2Money, todaysWeather, currentDay, playerNumber2);
                p2CupPrice = beginDayOfBusiness.setPricePerCup();
                p2Income = beginDayOfBusiness.daySim(p2PitcherQty, p2CupPrice, p2Recipe);
                //a wee bit of math
                p1Profit = 0;
                p1Money += p1Income;
                p1Profit = p1Money - p1StartMoney;
                p1Ice = meltIce;
                p2Profit = 0;
                p2Money += p2Income;
                p2Profit = p2Money - p2StartMoney;
                p2Ice = meltIce;

                currentDay += 1;
                display.playerStatComparison(p1Profit, p1Income, p1Money, p2Profit, p2Income, p2Money);

            }





        }
    }
}
