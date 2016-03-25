using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class buySupplies 
    {
        player user = new player(0, 0, 0, 0);

        double lemonPack = 60;
        double lemonPackPrice = 2.50;
        double icePack = 75;
        double icePackPrice = 1.75;
        double sugarPack = 15;
        double sugarPackPrice = 3.50;

        public void storeFront()
        {
            Console.WriteLine("Welcome to the lemonade store, we carry everything the lemonade industry might need. Lemons, Sugar and Ice.");
            buyLemons();
            buySugar();
            buyIce();
            Console.WriteLine("Money: " + user.money + " Lemons: " + user.lemonCount + " Sugar: " + user.sugarCount + " Icecubes: " + user.iceCount);
        }
        //LEMON STORE
        public void buyLemons()
        {
            string supplyChoice;
            Console.WriteLine("You have " + user.lemonCount + " lemons, would you like to buy more? (Y/N)");
            supplyChoice = Console.ReadLine();
            supplyChoice = supplyChoice.ToLower();
            if (supplyChoice.Equals("y"))
            {
                Console.WriteLine("$" + lemonPackPrice + " for " + lemonPack + " lemons! You currently have $" + user.money +
                    ". Please enter the number of lemon packs you would like to buy.");
                double lemonPurchase = double.Parse(Console.ReadLine());
                user.lemonCount = ingredientTotal(lemonPurchase, user.lemonCount, lemonPack);
                user.money = moneyBalanceAdjustment(user.money, lemonPurchase, lemonPackPrice);
            }
        }
        //ICE STORE 
        public void buyIce()
        {
            string supplyChoice;
            Console.WriteLine("You have " + user.iceCount + " icecubes, would you like to buy more? (Y/N)");
            supplyChoice = Console.ReadLine();
            supplyChoice = supplyChoice.ToLower();
            if (supplyChoice.Equals("y"))
            {
                Console.WriteLine("$" + icePackPrice + " for " + icePack + " icecubes! You currently have $" + user.money +
                ". Please enter the number of ice packs you would like to buy.");
                double icePurchase = double.Parse(Console.ReadLine());
                user.iceCount = ingredientTotal(icePurchase, user.iceCount, icePack);
                user.money = moneyBalanceAdjustment(user.money, icePurchase, icePackPrice);
            }
        }
        //SUGAR STORE        
        public void buySugar()
        {
            string supplyChoice;
            Console.WriteLine("You have " + user.sugarCount + " cups of sugar, would you like to buy more? (Y/N)");
            supplyChoice = Console.ReadLine();
            supplyChoice = supplyChoice.ToLower();
            if (supplyChoice.Equals("y"))
            {
                Console.WriteLine("$" + sugarPackPrice + " for " + sugarPack + " sugarpackets! You currently have $" + user.money +
                ". Please enter the number of sugar packs you would like to buy.");
                double sugarPurchase = double.Parse(Console.ReadLine());
                user.sugarCount = ingredientTotal(sugarPurchase, user.sugarCount, sugarPack);
                user.money = moneyBalanceAdjustment(user.money, sugarPurchase, sugarPackPrice);
            }
        }
        public double ingredientTotal(double numberPurchased, double productCount, double itemsPerPack)
        {
            productCount += (numberPurchased * itemsPerPack);
            return productCount;
        }
        public double moneyBalanceAdjustment(double userBalance, double itemPurchased, double perQtyPrice)
        {
            
            userBalance -= (itemPurchased * perQtyPrice);
            return userBalance;
        }
    }
}
