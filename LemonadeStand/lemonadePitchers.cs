using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class lemonadePitchers
    {
        double lemonsPer;
        double sugarPer;
        double icePer;
        double recipeType;
        public void makeARecipe()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("It's time to make the lemonade. Would you like to (1)use the default recipe or (2)make your own?");
            recipeType = double.Parse(Console.ReadLine());
            if (recipeType.Equals(1))
            {
                Console.WriteLine("Ok, that's 5 lemons, 4 cups of sugar and 15 icecubes to make a pitcher of lemonade.");
                lemonsPer = 5;
                sugarPer = 4;
                icePer = 15;
            }
            else if (recipeType.Equals(2))
            {
                Console.WriteLine("First, I think you should know that you will get 8 cups per pitcher. So, how many lemons would you like to use per pitcher?");
                lemonsPer = double.Parse(Console.ReadLine());
                Console.WriteLine("Second, how many cups of sugar per pitcher?");
                sugarPer = double.Parse(Console.ReadLine());
                Console.WriteLine("Last, how many ice cubes would you like to put in each pitcher?");
                icePer = double.Parse(Console.ReadLine());
            }
        }
        public double selectPitchers(double lemons, double sugar, double iceCubes)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            double numberOfPitchers = 0;
            Console.WriteLine("You currently have " + lemons + " lemons, " + sugar + " packs of sugar and " + iceCubes + " ice cubes.");
            Console.WriteLine("How many pitchers would you like to make today?");
            numberOfPitchers = double.Parse(Console.ReadLine());
            double lemonsUsed = numberOfPitchers * lemonsPer;
            double sugarUsed = numberOfPitchers * sugarPer;
            double iceUsed = numberOfPitchers * icePer;

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
                ingredientQty -= numberOfPitchers * lemonsPer;
                return ingredientQty;
            }
            else if (type.Equals("sugar"))
            {
                ingredientQty -= numberOfPitchers * sugarPer;
                return ingredientQty;
            }
            else if (type.Equals("ice"))
            {
                ingredientQty -= numberOfPitchers * icePer;
                return ingredientQty;
            }
            return ingredientQty;
        }
    }
}
