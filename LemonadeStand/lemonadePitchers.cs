using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class lemonadePitchers
    {
        public double selectPitchers(double lemons, double sugar, double iceCubes)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            double numberOfPitchers = 0;
            Console.WriteLine("It takes 5 lemons, 4 cups of sugar and 15 icecubes to make a pitcher of lemonade.");
            Console.WriteLine("You currently have " + lemons + " lemons, " + sugar + " packs of sugar and " + iceCubes + " ice cubes.");
            Console.WriteLine("How many pitchers would you like to make today?");
            numberOfPitchers = double.Parse(Console.ReadLine());
            double lemonsUsed = numberOfPitchers * 5;
            double sugarUsed = numberOfPitchers * 4;
            double iceUsed = numberOfPitchers * 15;

            if (lemons - lemonsUsed < 0)
            {
                Console.WriteLine("You do not have enough lemons to make this many pitchers. Please try making fewer pitchers.");
                selectPitchers(lemons, sugar, iceCubes);
            }
            else if (sugar - sugarUsed < 0)
            {
                Console.WriteLine("You do not have enough sugar to make this many pitchers. Please try making fewer pitchers.");
                selectPitchers(lemons, sugar, iceCubes);
            }
            else if (iceCubes - iceUsed < 0)
            {
                Console.WriteLine("You do not have enough ice cubes to make this many pitchers. Please try making fewer pitchers.");
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
