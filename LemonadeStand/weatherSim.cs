using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class weatherSim
    {
        double weatherRand = 0;
        public weatherSim()
        {

        }
        public double weatherReport()
        {
            Random forecast = new Random();
            int weatherRand = forecast.Next(1,6);

            if (weatherRand.Equals(1))
            {
                Console.WriteLine("Today is going to be cold and there will be thunderstorms, a very poor day to be a lemonade stand entrepenuer.");
                return weatherRand;
            }
            else if (weatherRand.Equals(2))
            {
                Console.WriteLine("The weather will be cool and and drizzling rain. You'll probably get a few customers today.");
                return weatherRand;
            }
            else if (weatherRand.Equals(3))
            {
                Console.WriteLine("Its warm, but hazy. A decent number of people should buy some today.");
                return weatherRand;
            }
            else if (weatherRand.Equals(4))
            {
                Console.WriteLine("It's 70 to 80 degrees out today and it's partly cloudy. Should be a good day!");
                return weatherRand;
            }
            else if (weatherRand.Equals(5))
            {
                Console.WriteLine("90 and not a cloud in the sky! better stock up on supplies!");
                return weatherRand;
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







