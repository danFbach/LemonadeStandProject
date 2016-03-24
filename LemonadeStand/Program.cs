using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game run = new Game();
            run.test();

        }
    }
}
                    //Lemonade Stand Project
                    //  * Basic Lemonade Stand gameplay must be present(play a lemonade stand online for a bit to get familiar with the gameplay). 
                    //  * A weather system that includes a forecast and actual weather.For example, this could mean a predicted forecast for a day or week and then what the actual weather is on the given day. 
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