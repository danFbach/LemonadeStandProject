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
                potentialCustomers.Add(new customer(setCashClass.Next(1, 5)));
                Thread.Sleep(10);
            }
            Console.Write("number of customers " + potentialCustomers.Count);
            Console.ReadLine();
            return potentialCustomers;
        }
        public void displayCustomers()
        {
            foreach(customer person in potentialCustomers)
            {
                Thread.Sleep(20);
                buyChance = 0;
                if (person.cashClass.Equals(1))
                {
                    buyChance = buyOrNot.Next(1,11);
                    Console.WriteLine(person.customerName + ", " + buyChance + ", " + person.cashClass);
                }
                else if (person.cashClass.Equals(2))
                {
                    buyChance = buyOrNot.Next(1, 9);
                    Console.WriteLine(person.customerName + ", " + buyChance + ", " + person.cashClass);
                }
                else if (person.cashClass.Equals(3))
                {
                    buyChance = buyOrNot.Next(1, 8);
                    Console.WriteLine(person.customerName + ", " + buyChance + ", " + person.cashClass);
                }
                else if (person.cashClass.Equals(4))
                {
                    buyChance = buyOrNot.Next(1, 7);
                    Console.WriteLine(person.customerName + ", " + buyChance + ", " + person.cashClass);
                }
                if(buyChance > 4)
                {
                    Console.WriteLine(person.customerName + " bought a cup.");
                }
                else
                {
                    Console.WriteLine(person.customerName + " did not buy a cup.");
                }

            }
        }
        public double selectPitchers(double lemons, double sugar, double iceCubes)
        {
            double numberOfPitchers;
            Console.WriteLine("It takes 5 lemons, 4 cups of sugar and 15 icecubes to make a pitcher of lemonade.");
            Console.WriteLine("You currently have " + lemons + " lemons, " + sugar + " packs of sugar and " + iceCubes + " ice cubes.");
            Console.WriteLine("How many pitchers would you like to make today?");
            numberOfPitchers = double.Parse(Console.ReadLine());

            double lemonsUsed = numberOfPitchers * 5;
            double sugarUsed = numberOfPitchers * 4;
            double iceUsed = numberOfPitchers * 15;

            if(lemons-lemonsUsed < 0)
            {
                Console.WriteLine("You do not have enough lemons to make this many pitchers. Please try a lower number of pitchers.");
                selectPitchers(lemons, sugar, iceCubes);
            }
            else if (sugar - sugarUsed < 0)
            {
                Console.WriteLine("You do not have enough sugar to make this many pitchers. Please try a lower number of pitchers.");
                selectPitchers(lemons, sugar, iceCubes);
            }
            else if (iceCubes - iceUsed < 0)
            {
                Console.WriteLine("You do not have enough ice cubes to make this many pitchers. Please try a lower number of pitchers.");
                selectPitchers(lemons, sugar, iceCubes);
            }
            return numberOfPitchers;            
        }
        public double calcIngredients(double ingredientQty, double numberOfPitchers, string type)
        {
            if (type.Equals("lemons"))
            {
                ingredientQty -= numberOfPitchers * 5;
                return ingredientQty;
            }
            else if (type.Equals("sugar"))
            {
                ingredientQty -= numberOfPitchers * 4;
                return ingredientQty;
            }
            else if (type.Equals("ice"))
            {
                ingredientQty -= numberOfPitchers * 15;
                return ingredientQty;
            }
            return ingredientQty;
        }
    }
}