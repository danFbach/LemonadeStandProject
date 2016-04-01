using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class lemonadePitchers
    {
        double p1LemonsPer;
        double p1SugarPer;
        double p1IcePer;
        double p2LemonsPer;
        double p2SugarPer;
        double p2IcePer;
        double lemonsPer;
        double sugarPer;
        double icePer;
        double recipeType;
        bool check = true;
        public string makeARecipe(double playerNum)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("It's time to make the lemonade.");
            Console.WriteLine("Would you like to... \n(1)use the default recipe \n(2)make your own?");
            check = double.TryParse(Console.ReadLine(), out recipeType);
            if (check.Equals(false)) { Console.WriteLine("Invalid entry."); makeARecipe(playerNum); }
            if (recipeType.Equals(1))
            {
                lemonsPer = 5;
                sugarPer = 4;
                icePer = 15;
                if (playerNum.Equals(1))
                {
                    p1LemonsPer = lemonsPer;
                    p1SugarPer = sugarPer;
                    p1IcePer = icePer;
                }
                else if (playerNum.Equals(2))
                {
                    p2LemonsPer = lemonsPer;
                    p2SugarPer = sugarPer;
                    p2IcePer = icePer;
                }
                Console.ForegroundColor = ConsoleColor.White; Console.Write("Ok, that will be ");
                Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(lemonsPer + " Lemons, ");
                Console.ForegroundColor = ConsoleColor.White; Console.Write(sugarPer + " cups of sugar and ");
                Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(sugarPer + " ice cubes ");
                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("per pitcher.");
                return null;
            }
            else if (recipeType.Equals(2))
            {

                lemonsPer = customLemons();
                sugarPer = customSugar();
                icePer = customIce();
                if (playerNum.Equals(1))
                {
                    p1LemonsPer = lemonsPer;
                    p1SugarPer = sugarPer;
                    p1IcePer = icePer;
                }
                else if (playerNum.Equals(2))
                {
                    p2LemonsPer = lemonsPer;
                    p2SugarPer = sugarPer;
                    p2IcePer = icePer;
                }

                if (lemonsPer > 5)
                {
                    return "sour";
                }
                else if (sugarPer > 4)
                {
                    return "sweet";
                }
                else if (sugarPer < 4)
                {
                    return "dull";
                }
                else if (icePer > 15)
                {
                    return "watery";
                }
                else { return null; }
                
            } return null;
        }
        public double customLemons()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("First, I think you should know that you will get 8 cups per pitcher. \nSo, how many lemons would you like to use per pitcher? 5 is default.");
            check = double.TryParse(Console.ReadLine(), out lemonsPer);
            if (check.Equals(false)) { Console.WriteLine("Invalid Entry."); return customLemons(); }
            return lemonsPer;
        }
        public double customSugar()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Second, how many cups of sugar per pitcher? 4 is default.");
            check = double.TryParse(Console.ReadLine(), out sugarPer);
            if (check.Equals(false)) { Console.WriteLine("Invalid Entry."); return customSugar(); }
            return sugarPer;
        }
        public double customIce()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Last, how many ice cubes would you like to put in each pitcher? 15 is default.");
            check = double.TryParse(Console.ReadLine(), out icePer);
            if (check.Equals(false)) { Console.WriteLine("Invalid Entry."); return customIce(); }
            return icePer;
        }

        public double selectPitchers(double lemons, double sugar, double iceCubes, double playerNum)
        {
            bool recipeRetry = true;
            if (playerNum.Equals(1))
            {
                lemonsPer = p1LemonsPer;
                sugarPer = p1SugarPer;
                icePer = p1IcePer;
            }
            else if (playerNum.Equals(2))
            {
                lemonsPer = p2LemonsPer;
                sugarPer = p2SugarPer;
                icePer = p2IcePer;
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            double numberOfPitchers = 0;
            Console.WriteLine("How many pitchers would you like to make today?");
            check = double.TryParse(Console.ReadLine(), out numberOfPitchers);
            if (check.Equals(false)) { Console.WriteLine("Invalid entry."); return selectPitchers(lemons, sugar, iceCubes,playerNum); }
            double lemonsUsed = numberOfPitchers * lemonsPer;
            double sugarUsed = numberOfPitchers * sugarPer;
            double iceUsed = numberOfPitchers * icePer;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            if (lemons - lemonsUsed < 0)
            {
                Console.WriteLine("You do not have enough lemons to make this many pitchers. Please try making fewer pitchers.");
                recipeRetry = false;   
            }
            if (sugar - sugarUsed < 0)
            {
                Console.WriteLine("You do not have enough sugar to make this many pitchers. Please try making fewer pitchers.");
                recipeRetry = false;
            }
            if (iceCubes - iceUsed < 0)
            {
                Console.WriteLine("You do not have enough ice cubes to make this many pitchers. Please try making fewer pitchers.");
                recipeRetry = false;
            }
            if (recipeRetry.Equals(false)) { return selectPitchers(lemons,sugar,iceCubes,playerNum); }
            Console.BackgroundColor = ConsoleColor.Black;
            return numberOfPitchers;
        }
        public double calcIngredients(double ingredientQty, double numberOfPitchers, string type, double playerNum)
        {
            if (playerNum.Equals(1))
            {
                lemonsPer = p1LemonsPer;
                sugarPer = p1SugarPer;
                icePer = p1IcePer;
            }
            else if (playerNum.Equals(2))
            {
                lemonsPer = p2LemonsPer;
                sugarPer = p2SugarPer;
                icePer = p2IcePer;
            }
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
