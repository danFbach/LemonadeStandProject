using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class userInterface
    {
        public void infoBar(double lemonCount, double sugarCount, double iceCount, double money, double todayWeather, double currentDay, double player)
        {
            if (player.Equals(1)) { Console.Clear(); }            
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Player " + player + " | ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(" Day " + (currentDay + 1) + " | ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Money: " + money.ToString("C2"));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Lemons: " + lemonCount);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Sugar: " + sugarCount);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" Icecubes: " + iceCount);
            if (todayWeather.Equals(1))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@" | 50 - Thunderstorms Expected");
            }
            else if (todayWeather.Equals(2))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@" | 55 - Light Rain Expected");

            }
            else if (todayWeather.Equals(3))
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(@" | 65 - Partly Cloudy");

            }
            else if (todayWeather.Equals(4))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@" | 75 - A few clouds in the Sky");

            }
            else if (todayWeather.Equals(5))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@" | 90 - Clear Skies!");
            }
        }
        public void playerStatComparison(double profit, double income, double money, double player)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Player " + player +" made ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(income.ToString("C2"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" for a profit of ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(profit.ToString("C2"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Bringing their total money to ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(money.ToString("C2"));
        }
        public void playerCheck(double p1Income, double p1Money, double p2Income, double p2Money)
        {
            if (p1Income > p2Income) { Console.WriteLine("Player 1 had the most income today."); }
            else if (p2Income > p1Income) { Console.WriteLine("Player 2 had the most income today."); }

            if(p1Money > p2Money) { Console.WriteLine("Player 1 has the most money overall."); }
            else if (p2Money > p1Money) { Console.WriteLine("Player 2 has the most money overall."); }

            Console.ReadKey();
        }
        public void displayTurn(double player)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Player " + player + "'s turn.");
        }
    }
}
