using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();         
            Game run = new Game();
            run.test();
        }
    }
}
//NEW GOALS
//----Today I continued working on the lemonade stand.It is complete as far as basic requirements so now im adding additional features. 
//----I've added color to make it easier to read, but would like to 'sync up' the colors to further refine the UI. 
//----I've added the ability to make your own blend of lemonade but still need to add flavor sensitivity to the customers. 
//----Customers also have the ability to tip, all on an individual basis, independant of whether and even their likelihood of them buying lemonade, although they must buy lemonade in order to leave a tip.
//----I spent quite a signigicant amount of time today cleaning my code up, making functions more universal, shortening classes(removing code that wasn't needed and/or reworking functions to make them more efficient.) I was able to remove a significant number of lines by the time i was finished. all classes are now under 100 lines. 
//----I've also been able to successfully export and import necessary game data in order to save and reload provious games. I would like to, perhaps, make more than one game saveable, multiple save slots, like an old videogame. That way more than one person can save a game in progress and can finish playing at a later time. 
//----Once I accomplish all of those tasks, my next logical step would be enabling multiplayer 1v1 and 1vAI...perhaps even more...1v'n'.
//----And if I successfully accomplish all of that within a reasonable amount of time, then is cross-computer/cross-platform, playing multiplayer over a LAN.those are my humble goals. :)

//COMPLETED GOALS
//Lemonade Stand Project
//  * Basic Lemonade Stand gameplay must be present(play a lemonade stand online for a bit to get familiar with the gameplay). 
/*  * A weather system that includes a forecast and actual weather. For example, this could mean a predicted forecast for a day or week and then what the actual weather is on the given day. */
//  * Price of product should affect demand. For example, if the price is too high, sales will decrease.
//  * Weather should affect demand. For example, if it is sunny and 90 degrees, sales would likely skyrocket. 
//  * Each customer should be a separate object with its own chance of buying a glass of lemonade. This means how much lemonade is purchased and how much they are willing to pay will vary from customer to customer.
//  * Game must be a minimum of seven days
//  * Bonus Points: Persistent data (file reading/writing) to keep track of game data. For example, how much lemonade is sold and how much profit is made on each day. This will be written and read from a text file.

//Classes You Can Use (you may need more than what is provided):
//Program
//Weather
//Customer
//Game
//Inventory
//Player
//Store
//Day
//UserInterface
//FileReader (for persistent data)
//FileWriter (for persistent data)