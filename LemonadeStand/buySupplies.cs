using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class buySupplies 
    {
        double ownerBalance = 20;
        public void storeFront()
        {
            string buyChoice1 = "n";
            Console.WriteLine("Welcome to the lemonade store, we carry everything for your lemonade needs. Lemons, Sugar and Ice.");
            Console.WriteLine("You currently have " + currentLemonQty + " lemons, would you like to buy more? (Y/N)");
            buyChoice1 = Console.ReadLine();
            buyChoice1 = buyChoice1.ToLower();
            if (buyChoice1.Equals("y"))
            {
                buyLemons(ownerBalance);
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
                buyIce(ownerBalance);
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
                buySugar(ownerBalance);
            }
                


        }
        double lemonPack = 60;
        double lemonPackPrice = 2.50;
        public double currentLemonQty;

        //LEMON STORE
        public void buyLemons(double ownerBalance)
        {
            Console.WriteLine("$" + lemonPackPrice + " for " + lemonPack + " lemons! You currently have " + currentLemonQty + " lemons and $" + ownerBalance +
                " Please enter the number of lemon packs you would like to buy.");
            double lemonPurchase = double.Parse(Console.ReadLine());
            Console.WriteLine(lemonPurchase);
            lemonTotal(lemonPurchase);
            moneyBalanceAdjustment(ownerBalance, lemonPurchase);
        }
        public void lemonTotal(double lemonPurchase)
        {
            currentLemonQty += (lemonPurchase * lemonPack);
            Console.Write(", " + currentLemonQty);
        }
        public void moneyBalanceAdjustment(double ownerBalance, double lemonPurchase)
        {
            ownerBalance -= (lemonPurchase * lemonPackPrice);
            Console.Write(", " + ownerBalance);
            Console.WriteLine();
        }

        //ICE STORE
        double currentIceQty;
        double icePack = 75;
        double icePackPrice = 1.75;
        public void buyIce(double ownerBalance)
        {
            Console.WriteLine("$" + icePackPrice + " for " + icePack + " icecubes! You currently have " + currentIceQty + " ices and $" + ownerBalance +
                " Please enter the number of ice packs you would like to buy.");
            double icePurchase = double.Parse(Console.ReadLine());
            Console.WriteLine(icePurchase);
            iceTotal(icePurchase);
            money1BalanceAdjustment(ownerBalance, icePurchase);
        }
        public void iceTotal(double icePurchase)
        {
            currentIceQty += (icePurchase * icePack);
            Console.Write(", " + currentIceQty);
        }
        public void money1BalanceAdjustment(double ownerBalance, double icePurchase)
        {
            ownerBalance -= (icePurchase * icePackPrice);
            Console.Write(", " + ownerBalance);
            Console.WriteLine();
        }

        //SUGAR STORE

        double currentSugarQty;
        double sugarPack = 15;
        double sugarPackPrice = 3.50;
        public void buySugar(double ownerBalance)
        {
            Console.WriteLine("$" + sugarPackPrice + " for " + sugarPack + " sugarpacks! You currently have " + currentSugarQty + " sugars and $" + ownerBalance +
                " Please enter the number of sugar packs you would like to buy.");
            double sugarPurchase = double.Parse(Console.ReadLine());
            Console.WriteLine(sugarPurchase);
            sugarTotal(sugarPurchase);
            money2BalanceAdjustment(ownerBalance, sugarPurchase);
        }
        public void sugarTotal(double sugarPurchase)
        {
            currentSugarQty += (sugarPurchase * sugarPack);
            Console.Write(", " + currentSugarQty);
        }
        public void money2BalanceAdjustment(double ownerBalance, double sugarPurchase)
        {
            ownerBalance -= (sugarPurchase * sugarPackPrice);
            Console.Write(", " + ownerBalance);
        }
    }
}
