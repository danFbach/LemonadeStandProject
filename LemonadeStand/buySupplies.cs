using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class buySupplies 
    {
        player user = new player( 0, 0, 0, 0);

        double lemonPack = 60;
        double lemonPackPrice = 2.50;
        double icePack = 75;
        double icePackPrice = 1.75;
        double sugarPack = 15;
        double sugarPackPrice = 3.50;

        public void storeFront(double ownerBalance)
        {
            string buyChoice1 = "n";
            Console.WriteLine("Welcome to the lemonade store, we carry everything for your lemonade needs. Lemons, Sugar and Ice.");
            Console.WriteLine("You currently have " + user.lemonCount + " lemons, would you like to buy more? (Y/N)");
            buyChoice1 = Console.ReadLine();
            buyChoice1 = buyChoice1.ToLower();
            if (buyChoice1.Equals("y"))
            {
                buyLemons(user.money);
                buyChoice1 = "n";
            }
            if(buyChoice1.Equals("n"))
            {
                Console.WriteLine("Buy Ice? (Y/N)");
                buyChoice1 = Console.ReadLine();
                buyChoice1 = buyChoice1.ToLower();
            }
            if (buyChoice1.Equals("y"))
            {
                buyIce(user.money);
                buyChoice1 = "n";
            }
            if (buyChoice1.Equals("n"))
            {
                Console.WriteLine("Buy Sugar? (Y/N)");
                buyChoice1 = Console.ReadLine();
                buyChoice1 = buyChoice1.ToLower();
            }
            if (buyChoice1.Equals("y"))
            {
                buySugar(user.money);
            }
        }
        //LEMON STORE
        public void buyLemons(double ownerBalance)
        {
            Console.WriteLine("$" + lemonPackPrice + " for " + lemonPack + " lemons! You currently have " + user.lemonCount + " lemons and $" + ownerBalance +
                " Please enter the number of lemon packs you would like to buy.");
            double lemonPurchase = double.Parse(Console.ReadLine());
            Console.Write(lemonPurchase);
            ingredientTotal(lemonPurchase, user.lemonCount, lemonPack);
            user.money = moneyBalanceAdjustment(user.money, lemonPurchase, lemonPackPrice);
        }
        //ICE STORE 
        public void buyIce(double ownerBalance)
        {
            Console.WriteLine("$" + icePackPrice + " for " + icePack + " icecubes! You currently have " + user.iceCount + " icecubes and $" + ownerBalance +
                " Please enter the number of ice packs you would like to buy.");
            double icePurchase = double.Parse(Console.ReadLine());
            Console.Write(icePurchase);
            ingredientTotal(icePurchase, user.iceCount, icePack);
            user.money = moneyBalanceAdjustment(ownerBalance, icePurchase, icePackPrice);
        }
        //SUGAR STORE        
        public void buySugar(double ownerBalance)
        {
            Console.WriteLine("$" + sugarPackPrice + " for " + sugarPack + " sugarpacks! You currently have " + user.sugarCount + " sugars and $" + ownerBalance +
                " Please enter the number of sugar packs you would like to buy.");
            double sugarPurchase = double.Parse(Console.ReadLine());
            Console.Write(sugarPurchase);
            ingredientTotal(sugarPurchase, user.sugarCount, sugarPack);
            user.money = moneyBalanceAdjustment(ownerBalance, sugarPurchase, sugarPackPrice);
        }
        public void ingredientTotal(double itemPurchase, double itemCount, double itemPack)
        {
            itemCount += (itemPurchase * itemPack);
            Console.Write(", " + itemCount);
        }
        public double moneyBalanceAdjustment(double userBalance, double itemPurchased, double perQtyPrice)
        {
            
            userBalance -= (itemPurchased * perQtyPrice);
            Console.Write(", " + userBalance);
            return userBalance;
        }
    }
}
