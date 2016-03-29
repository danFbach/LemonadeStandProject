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
            if(price > 1)
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

            foreach (customer person in potentialCustomers)
            {
                Thread.Sleep(20);
                if (cupQty > 0)
                {
                    if (person.cashClass.Equals(1))
                    {
                        cupQty -= 1;
                        income += cupPrice;
                        Console.WriteLine(person.customerName + " bought a cup!" + " You now have made " + income.ToString("C2") + " and have " + cupQty + " cups of lemonade remaining.");
                    }
                    else if (person.cashClass.Equals(2))
                    {
                        if (cupPrice <= .35)
                        {
                            cupQty -= 1;
                            income += cupPrice;
                            Console.WriteLine(person.customerName + " bought a cup!" + " You now have made " + income.ToString("C2") + " and have " + cupQty + " cups of lemonade remaining.");
                        }
                    }
                    else if (person.cashClass.Equals(3))
                    {
                        if (cupPrice <= .32)
                        {
                            cupQty -= 1;
                            income += cupPrice;
                            Console.WriteLine(person.customerName + " bought a cup!" + " You now have made " + income.ToString("C2") + " and have " + cupQty + " cups of lemonade remaining.");
                        }
                    }
                    else if (person.cashClass.Equals(4))
                    {
                        if (cupPrice <= .30)
                        {
                            cupQty -= 1;
                            income += cupPrice;
                            Console.WriteLine(person.customerName + " bought a cup!" + " You now have " + income.ToString("C2") + " and " + cupQty + " cups of lemonade remaining.");
                        }
                    }
                    if (person.cashClass.Equals(5))
                    {
                        if(cupPrice <= 27)
                        {
                            cupQty -= 1;
                            income += cupPrice;
                            Console.WriteLine(person.customerName + " bought a cup!" + " You now have made " + income.ToString("C2") + " and have " + cupQty + " cups of lemonade remaining.");
                        }
                    }
                    else if (person.cashClass.Equals(6))
                    {
                        if (cupPrice <= .25)
                        {
                            cupQty -= 1;
                            income += cupPrice;
                            Console.WriteLine(person.customerName + " bought a cup!" + " You now have made " + income.ToString("C2") + " and have " + cupQty + " cups of lemonade remaining.");
                        }
                    }
                    else if (person.cashClass.Equals(7))
                    {
                        if (cupPrice <= .23)
                        {
                            cupQty -= 1;
                            income += cupPrice;
                            Console.WriteLine(person.customerName + " bought a cup!" + " You now have made " + income.ToString("C2") + " and have " + cupQty + " cups of lemonade remaining.");
                        }
                    }
                    else if (person.cashClass.Equals(8))
                    {
                        if (cupPrice <= .20)
                        {
                            cupQty -= 1;
                            income += cupPrice;
                            Console.WriteLine(person.customerName + " bought a cup!" + " You now have " + income.ToString("C2") + " and " + cupQty + " cups of lemonade remaining.");
                        }
                    }
                }
            }
            return income;
        }        
    }
}