using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LemonadeStand
{
    public class day
    {
        public double income = 0;
        public List<customer> potentialCustomers = new List<customer>();
        public Random setCashClass = new Random();
        public Random buyOrNot = new Random();
        public double buyChance;
        public List<customer> makeNewCustomers(double customerLimit)
        {
            for (int customerNum = 0; customerNum < customerLimit; customerNum++)
            {
                potentialCustomers.Add(new customer(setCashClass.Next(1, 9)));
                Thread.Sleep(10);
            }
            return potentialCustomers;
        }
        public double pricePerCup()
        {
            double price;
            Console.WriteLine("What would you like your price per cup to be today?");
            price = double.Parse(Console.ReadLine());
            if (price > 1)
            {
                price = price / 100;
            }
            Console.WriteLine("Great, you will be selling your lemonade for " + price.ToString("C2"));
            Console.WriteLine("Press enter to begin the day of selling.");
            Console.ReadKey();
            return price;
        }
        public double daySim(double pitcherQty, double cupPrice)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            double cupQty = pitcherQty * 8;
            double income = 0;
            double cupPriceLimit = 0;
            foreach (customer person in potentialCustomers)
            {
                Thread.Sleep(20);
                if (cupQty > 0)
                {
                    if (person.cashClass.Equals(1))
                    {
                        cupQty -= 1;
                        income += cupPrice;
                        Console.WriteLine(person.customerName + " bought a cup!" + " You now have " + income.ToString("C2") + " and " + cupQty + " cups of lemonade remaining.");
                    }
                    else if (person.cashClass.Equals(2))
                    {
                        cupPriceLimit = .35;
                    }
                    else if (person.cashClass.Equals(3))
                    {
                        cupPriceLimit = .32;
                    }
                    else if (person.cashClass.Equals(4))
                    {
                        cupPriceLimit = .30;
                    }
                    else if (person.cashClass.Equals(5))
                    {
                        cupPriceLimit = 27;
                    }
                    else if (person.cashClass.Equals(6))
                    {
                        cupPriceLimit = .25;
                    }
                    else if (person.cashClass.Equals(7))
                    {
                        cupPriceLimit = .23;
                    }
                    else if (person.cashClass.Equals(8))
                    {
                        cupPriceLimit = .20;
                    }
                    if (cupPrice <= cupPriceLimit)
                    {
                        cupQty -= 1;
                        income += cupPrice;
                        Console.WriteLine(person.customerName + " bought a cup!" + " You now have " + income.ToString("C2") + " and " + cupQty + " cups of lemonade remaining.");
                    }
                }
            }
            Console.WriteLine("Feel free to look at what your customers bought, press enter to continue.");
            return income;
        }
    }
}