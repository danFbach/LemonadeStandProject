﻿using System;
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
        public bool check = true;
        int dayLimit;
        public int pickDayLimit()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("How many weeks will we run the simulation, 1, 2 or 3?");
            check = int.TryParse(Console.ReadLine(), out dayLimit);
            if (check.Equals(false)) { Console.WriteLine("Invalid entry."); return pickDayLimit(); }
            switch (dayLimit)
            {
                case (1):
                    dayLimit = 7;
                    return dayLimit;
                case (2):
                    dayLimit = 14;
                    return dayLimit;
                case (3):
                    dayLimit = 21;
                    return dayLimit;
                default:
                    pickDayLimit();
                    break;
            }
            return dayLimit;
        }
        public List<customer> makeTodaysCustomers(double customerLimit)
        {
            Console.Write("Generating todays customers.");
            potentialCustomers.Clear();
            for (int customerNum = 0; customerNum < customerLimit; customerNum++)
            {
                potentialCustomers.Add(new customer(setCashClass.Next(1, 9)));
                Thread.Sleep(10);
                Console.Write(".");
            }
            return potentialCustomers;
        }        
        public double setPricePerCup()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            double price;
            Console.WriteLine("\nWhat would you like your price per cup to be today? \nMost customers are comfortable paying $0.20 - $0.35, but some will pay more.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("If you charge too little you may get a lot of customers but you won't make enough money.\nBut charge too much and you'll scare them all away.");
            Console.ForegroundColor = ConsoleColor.White;
            check = double.TryParse(Console.ReadLine(),out price);
            if (check.Equals(false)) { Console.WriteLine("Invalid entry."); return setPricePerCup(); }
            if (price > 1)
            {
                price = price / 100;
            }
            Console.Write("Great, you will be selling your lemonade for ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(price.ToString("C2"));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press enter to begin the day of selling.");
            Console.ReadKey();
            return price;
        }
        public double daySim(double pitcherQty, double cupPrice, string customRecipe)
        {
            Console.WriteLine();
            double availableCupQty = pitcherQty * 8;
            double income = 0;
            double cupPriceLimit = 0;
            double tip;
            double tipCount = 0;
            double potentialCount = potentialCustomers.Count;
            double actualCount = 0;
            double secondCupCount = 0;
            foreach (customer person in potentialCustomers)
            {                
                tip = 0;
                Thread.Sleep(20);
                if (availableCupQty > 0)
                {
                    if (person.cashClass.Equals(1))
                    {
                        cupPriceLimit = 1;
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
                        if (person.tipper.Equals(3))
                        {
                            tip = .15;
                            availableCupQty -= 1;
                            income += cupPrice + tip;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Money: " + income.ToString("C2"));
                            Console.WriteLine(" " + person.customerName + " bought a cup and gave you a " + tip.ToString("C2") + " tip! You have "+ availableCupQty + " cups of lemonade left.");
                            tipCount++;
                        }
                        else if (person.tipper.Equals(2))
                        {
                            tip = .05;
                            availableCupQty -= 1;
                            income += cupPrice + tip;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Money: " + income.ToString("C2"));
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" " +person.customerName + " bought a cup and gave you a " + tip.ToString("C2") + " tip! You have " + availableCupQty + " cups of lemonade left.");
                            tipCount++;
                        }                    
                        else
                        {
                            availableCupQty -= 1;
                            income += cupPrice;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Money: " + income.ToString("C2"));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" " + person.customerName + " bought a cup!" + " You have " + availableCupQty + " cups of lemonade left.");
                        }
                        if (person.taste.Equals(customRecipe))
                        {
                            availableCupQty -= 1;
                            income += cupPrice;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Money: " + income.ToString("C2"));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" " + person.customerName + " bought a 2nd cup because they love that " + person.taste + " flavor!" + " You have " + availableCupQty + " cups of lemonade left.");
                            secondCupCount++;
                        }
                        actualCount++;
                    }                    
                }
            }Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Of the " + potentialCount + " potential customers, you were able to sell to " + actualCount + " people today. You sold a second cup to " + secondCupCount + " people. \n" + "You had " + tipCount + " customers tip you today too!" + "\nFeel free to look at what your customers bought today. Press enter.");
            Console.ReadKey();
            return income;
        }
    }
}