using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LemonadeStand
{
    public class weatherSim
    {
        public List<int> dailyWeather = new List<int>();
        public double weatherRand = 0;
        public List<int> largeScaleWeather(int dayLimit)
        {
            Random forecast = new Random();
            for (int days = 0; days < dayLimit; days++)
            {
                dailyWeather.Add(forecast.Next(1, 6));
                Thread.Sleep(10);
            }
            return dailyWeather;
        }
        public double weatherReport(int todaysWeather)
        {
            double aCustomer;
            Random customers = new Random();
            int weatherRand;
            weatherRand = todaysWeather;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("It's a new day to sell lemonade and the weather today will be...");
            if (weatherRand.Equals(1))
            {
                Console.WriteLine("...Cold and there will be thunderstorms, a very poor day to be a lemonade stand entrepenuer.");
                aCustomer = customers.Next(1, 75);
                return aCustomer;
            }
            else if (weatherRand.Equals(2))
            {
                Console.WriteLine("...Cool and and drizzling rain. You'll probably get a few customers today.");
                aCustomer = customers.Next(10, 80);
                return aCustomer;
            }
            else if (weatherRand.Equals(3))
            {
                Console.WriteLine("...Warm, but hazy. A decent number of people should buy some today.");
                aCustomer = customers.Next(20, 80);
                return aCustomer;
            }
            else if (weatherRand.Equals(4))
            {
                Console.WriteLine("70 to 80 degrees out and partly cloudy. It should be a good day to sell some lemonade!");
                aCustomer = customers.Next(40, 85);
                return aCustomer;
            }
            else if (weatherRand.Equals(5))
            {
                Console.WriteLine("90 and not a cloud in the sky! better stock up on supplies!");
                aCustomer = customers.Next(40, 101);
                return aCustomer;
            }
            return 0;
        }
    }
}