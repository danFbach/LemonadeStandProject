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
        double icePack = 65;
        double lemonPackPrice = 2.50;
        double sugarPackPrice = 3.50;
        double icePackPrice = 1.75;


        public void storeFront(double lemonCount, double sugarCount, double iceCount, double money)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the lemonade store, we carry everything the lemonade industry might need. Lemons, Sugar and Ice.");
            Console.WriteLine("Money: " + money.ToString("C2") + " Lemons: " + lemonCount + " Sugar: " + sugarCount + " Icecubes: " + iceCount);
        }
        //LEMON STORE
        public double buyLemons(double lemonCount, double money)
        {
            double lemonPurchase;
            string supplyChoice;
            Console.WriteLine("You have " + lemonCount + " lemons, would you like to buy more? (Y/N)");
            supplyChoice = Console.ReadLine();
            supplyChoice = supplyChoice.ToLower();
            if (supplyChoice.Equals("y"))
            {
                Console.WriteLine(lemonPackPrice.ToString("C2") + " for " + lemonPack + " lemons! You currently have " + money.ToString("C2") +
                    ". Please enter the number of lemon packs you would like to buy.");
                lemonPurchase = double.Parse(Console.ReadLine());
                return lemonPurchase;
            }
            return 0;
        }
        public double buyIce(double iceCount, double money)
        {
            double icePurchase;
            string supplyChoice;
            Console.WriteLine("You have " + iceCount + " ice cubes, would you like to buy more? (Y/N)");
            supplyChoice = Console.ReadLine();
            supplyChoice = supplyChoice.ToLower();
            if (supplyChoice.Equals("y"))
            {
                Console.WriteLine(icePackPrice.ToString("C2") + " for " + icePack + " ice cubes! You currently have " + money.ToString("C2") +
                    ". Please enter the number of ice cubes you would like to buy.");
                icePurchase = double.Parse(Console.ReadLine());
                return icePurchase;
            }
            return 0;
        }
        public double buySugar(double sugarCount, double money)
        {
            double sugarPurchase;
            string supplyChoice;
            Console.WriteLine("You have " + sugarCount + " cups of sugar, would you like to buy more? (Y/N)");
            supplyChoice = Console.ReadLine();
            supplyChoice = supplyChoice.ToLower();
            if (supplyChoice.Equals("y"))
            {
                Console.WriteLine(sugarPackPrice.ToString("C2") + " for " + sugarPack + " cups of sugar! You currently have " + money.ToString("C2") +
                    ". Please enter how many cups of sugar you would like to buy.");
                sugarPurchase = double.Parse(Console.ReadLine());
                return sugarPurchase;
            }
            return 0;
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