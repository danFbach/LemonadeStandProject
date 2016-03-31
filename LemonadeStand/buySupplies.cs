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
        double sugarPackPrice = 2.50;
        double icePackPrice = 1.75;
        double itemPackPrice;
        double itemPackQty;
        string fillIn;
        bool check = true;
        public double purchaseSupplies(double itemQty, double money, string itemType)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to the lemonade store, we carry everything the lemonade industry needs.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The default pitcher needs 5 lemons, 4 cups of sugar and 15 ice cubes and makes 8 sellable cups.");
            Console.ForegroundColor = ConsoleColor.Red;
            double ingredientPurchaseQty = 0;
            string supplyChoice;
            Console.Write("You have ");
            if (itemType.Equals("lemons"))
            {
                itemPackPrice = lemonPackPrice;
                itemPackQty = lemonPack;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (itemType.Equals("cups of sugar"))
            {
                itemPackPrice = sugarPackPrice;
                itemPackQty = sugarPack;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (itemType.Equals("ice cubes"))
            {
                itemPackPrice = icePackPrice;
                itemPackQty = icePack;
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            Console.Write(itemQty + " " + itemType);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(", would you like to buy more? (Y/N)");
            supplyChoice = Console.ReadLine();
            supplyChoice = supplyChoice.ToLower();
            if (supplyChoice.Equals("y"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(itemPackPrice.ToString("C2"));
                if (itemType.Equals("lemons"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    fillIn = " packs of ";
                }
                else if (itemType.Equals("cups of sugar"))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    fillIn = " ";
                }
                else if (itemType.Equals("ice cubes"))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    fillIn = " bags of ";
                }
                Console.Write(" for " + itemPackQty + " " + itemType);
                Console.ForegroundColor = ConsoleColor.Red; Console.Write("! You currently have ");
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(money.ToString("C2"));
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please enter how many packs you would like.");
                check = double.TryParse(Console.ReadLine(), out ingredientPurchaseQty);
                if (check.Equals(false)) { return purchaseSupplies(itemQty, money, itemType); }
                if ((ingredientPurchaseQty * itemPackPrice) > money)
                {
                    Console.WriteLine("You do not have enough money to buy " + ingredientPurchaseQty + fillIn + itemType + ".");
                    return purchaseSupplies(itemQty, money, itemType);
                }
                else { return ingredientPurchaseQty; }
            }
            else if (supplyChoice.Equals("n")) { return ingredientPurchaseQty; }
            else return purchaseSupplies(itemQty, money, itemType);
        }
        public double ingredientTotal(double numberPurchased, double productCount, string type)
        {
            double itemsPerPack = 0;
            if (type.Equals("lemons"))
            {
                itemsPerPack = lemonPack;
            }
            else if (type.Equals("sugar"))
            {
                itemsPerPack = sugarPack;
            }
            else if (type.Equals("ice"))
            {
                itemsPerPack = icePack;
            }
            productCount += (numberPurchased * itemsPerPack);
            return productCount;
        }
        public double adjustMoneyBalanceOfPurchase(double userBalance, double numberPurchased, string type)
        {
            double itemPrice = 0;

            if (type.Equals("lemons"))
            {
                itemPrice = lemonPackPrice;
            }
            else if (type.Equals("sugar"))
            {
                itemPrice = sugarPackPrice;
            }
            else if(type.Equals("ice"))
            {
                itemPrice = icePackPrice;
            }
            userBalance -= (numberPurchased * itemPrice);
            return userBalance;
        }
    }
}