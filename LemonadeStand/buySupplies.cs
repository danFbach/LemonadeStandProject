using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class buySupplies
    {

        double lemonPack = 20;
        double sugarPack = 16;
        double icePack = 60;
        double lemonPackPrice = 2.50;
        double sugarPackPrice = 3.50;
        double icePackPrice = 1.75;
        double itemPackPrice;
        double itemPackQty;


        public void storeFront(double lemonCount, double sugarCount, double iceCount, double money)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the lemonade store, we carry everything the lemonade industry might need. Lemons, Sugar and Ice.");
            Console.WriteLine("Money: " + money.ToString("C2") + " Lemons: " + lemonCount + " Sugar: " + sugarCount + " Icecubes: " + iceCount);
        }
        public double purchaseSupplies(double itemQty, double money, string itemType)
        {
            if (itemType.Equals("lemons"))
            {
                itemPackPrice = lemonPackPrice;
                itemPackQty = lemonPack;
            }
            else if (itemType.Equals("cups of sugar"))
            {
                itemPackPrice = sugarPackPrice;
                itemPackQty = sugarPack;
            }
            else if (itemType.Equals("ice cubes"))
            {
                itemPackPrice = icePackPrice;
                itemPackQty = icePack;
            }
            double ingredientPurchaseQty = 0;
            string supplyChoice;
            Console.WriteLine("You have " + itemQty + " " + itemType + ", would you like to buy more? (Y/N)");
            supplyChoice = Console.ReadLine();
            supplyChoice = supplyChoice.ToLower();
            if (supplyChoice.Equals("y"))
            {
                Console.WriteLine(itemPackPrice.ToString("C2") + " for " + itemPackQty + " " + itemType + "! You currently have " + money.ToString("C2") + ". Please enter how many packs you would like.");
                ingredientPurchaseQty = double.Parse(Console.ReadLine());
                return ingredientPurchaseQty;
            }
            return ingredientPurchaseQty;
        }
        //ingredient calc
        public double ingredientTotal(double numberPurchased, double productCount, string type)
        {
            if (type.Equals("lemons"))
            {
                double itemsPerPack = 20;
                productCount += (numberPurchased * itemsPerPack);
                return productCount;
            }
            else if (type.Equals("sugar"))
            {
                double itemsPerPack = 16;
                productCount += (numberPurchased * itemsPerPack);
                return productCount;
            }
            else if (type.Equals("ice"))
            {
                double itemsPerPack = 65;
                productCount += (numberPurchased * itemsPerPack);
                return productCount;
            }
            return productCount;
        }
        //money calc
        public double moneyBalanceAdjustment(double userBalance, double lemonsPurchased, double sugarPurchased, double icePurchased)
        {
            double priceLemons = 2.50;
            double priceSugar = 3;
            double priceIce = 1.50;
            userBalance -= (lemonsPurchased * priceLemons);
            userBalance -= (sugarPurchased * priceSugar);
            userBalance -= (icePurchased * priceIce);
            return userBalance;
        }
    }
}