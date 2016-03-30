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
        bool errorCheck;
        public void makeARecipe()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("It's time to make the lemonade.");
            Console.WriteLine("Would you like to... \n(1)use the default recipe \n(2)make your own?");
            errorCheck = double.TryParse(Console.ReadLine(), out recipeType);
            if (errorCheck.Equals(false)) { makeARecipe(); }
            if (recipeType.Equals(1))
            {
                lemonsPer = 5;
                sugarPer = 4;
                icePer = 15;
                Console.ForegroundColor = ConsoleColor.White; Console.Write("Ok, that will be ");
                Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(lemonsPer + " Lemons, ");
                Console.ForegroundColor = ConsoleColor.White; Console.Write(sugarPer + " cups of sugar and ");
                Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(sugarPer + " ice cubes ");
                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("per pitcher.");
            }
            else if (recipeType.Equals(2))
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("First, I think you should know that you will get 8 cups per pitcher. So, how many lemons would you like to use per pitcher?");
                double.TryParse(Console.ReadLine(), out lemonsPer);
                Console.WriteLine("Second, how many cups of sugar per pitcher?");
                double.TryParse(Console.ReadLine(), out sugarPer);
                Console.WriteLine("Last, how many ice cubes would you like to put in each pitcher?");
                double.TryParse(Console.ReadLine(), out icePer);
            }
        }
        public double selectPitchers(double lemons, double sugar, double iceCubes)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            double numberOfPitchers = 0;
            Console.WriteLine("How many pitchers would you like to make today?");
            errorCheck = double.TryParse(Console.ReadLine(), out numberOfPitchers);
            if (errorCheck.Equals(false)) { return selectPitchers(lemons, sugar, iceCubes); }
            double lemonsUsed = numberOfPitchers * lemonsPer;
            double sugarUsed = numberOfPitchers * sugarPer;
            double iceUsed = numberOfPitchers * icePer;

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            if (lemons - lemonsUsed < 0)
            {
                Console.WriteLine("You do not have enough lemons to make this many pitchers. Please try making fewer pitchers.");
                return selectPitchers(lemons, sugar, iceCubes);
            }
            else if (sugar - sugarUsed < 0)
            {
                Console.WriteLine("You do not have enough sugar to make this many pitchers. Please try making fewer pitchers.");
                return selectPitchers(lemons, sugar, iceCubes);
            }
            else if (iceCubes - iceUsed < 0)
            {
                Console.WriteLine("You do not have enough ice cubes to make this many pitchers. Please try making fewer pitchers.");
                return selectPitchers(lemons, sugar, iceCubes);
            }
            Console.BackgroundColor = ConsoleColor.Black;
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
