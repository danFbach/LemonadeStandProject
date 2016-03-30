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
            Console.ForegroundColor = ConsoleColor.Red;
            if (weatherRand.Equals(1))
            {
                aCustomer = customers.Next(1, 26);
                return aCustomer;
            }
            else if (weatherRand.Equals(2))
            {
                aCustomer = customers.Next(5, 31);
                return aCustomer;
            }
            else if (weatherRand.Equals(3))
            {
                aCustomer = customers.Next(10, 56);
                return aCustomer;
            }
            else if (weatherRand.Equals(4))
            {
                aCustomer = customers.Next(30, 86);
                return aCustomer;
            }
            else if (weatherRand.Equals(5))
            {
                aCustomer = customers.Next(40, 101);
                return aCustomer;
            }
            return 0;
        }
    }
}