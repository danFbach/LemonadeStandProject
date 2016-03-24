using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class weatherSim
    {
        public int weatherReport()
        {
            Random forecast = new Random();
            Random customers = new Random();
            int aDayCustomers = 0;
            int weatherNum = forecast.Next(1,6);

            if (weatherNum.Equals(1))
            {
                Console.WriteLine("Today is going to be cold and there will be thunderstorms, a very poor day to be a lemonade stand entrepenuer.");
                aDayCustomers = customers.Next(1,30);
                return aDayCustomers;
            }
            else if (weatherNum.Equals(2))
            {
                Console.WriteLine("The weather will be cool and and drizzling rain. You'll probably get a few customers today.");
                aDayCustomers = customers.Next(10,30);
                return aDayCustomers;
            }
            else if (weatherNum.Equals(3))
            {
                Console.WriteLine("Its warm, but hazy. A decent number of people should buy some today.");
                aDayCustomers = customers.Next(20,60);
                return aDayCustomers;
            }
            else if (weatherNum.Equals(4))
            {
                Console.WriteLine("It's 70 to 80 degrees out today and it's partly cloudy. Should be a good day!");
                aDayCustomers = customers.Next(45,75);
                return aDayCustomers;
            }
            else if (weatherNum.Equals(5))
            {
                Console.WriteLine("90 and not a cloud in the sky! better stock up on supplies!");
                aDayCustomers = customers.Next(60,90);
                return aDayCustomers;
            }return 0;
        }
    }
}
//public int weatherRandom(Random digit2)
//{
//    int randForecast = 0;
//    randForecast = digit2.Next(1,5);
//    switch(randForecast)
//    {
//        case (1)://cool thunderstorms - fewest customers
//        return randForecast;
//        case (2)://cool rainy - fewer customers
//        return randForecast;
//        case (3)://warm partly cloudy - some customers
//        return randForecast;
//        case (4)://warm sunny - more customers
//        return randForecast;
//        case (5)://hot sunny - most customers
//        return randForecast;
//        default:
//        return randForecast;
//    }







