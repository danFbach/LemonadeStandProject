using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LemonadeStand
{
    public class fileReader
    {
        string gameData;
        string weatherData;
        public string strLemons;
        public string strSugar;
        public string strIncome;
        public string strProfit;
        public string strTotalMoney;
        public string strDay;
        public string strDayLimit;
        public string filepath = @"c:\users\dan dcc\documents\visual studio 2015\projects\lemonadestandproject\lemonadestand\";
        public List<int> getWeatherData()
        {
            List<int> weatherRetrieval = new List<int>();
            using (StreamReader loadWeather = new StreamReader(filepath + "weather.csv"))
            {
                weatherData = loadWeather.ReadLine();
            }
            char removal = ',';
            string[] decodeWeather = weatherData.Split(removal);
            int dayOfWeather = decodeWeather.Count();
            for (int i = 0;i < dayOfWeather-1;i++)
            {
                int dayWeather = Convert.ToInt16(decodeWeather[i]);
                weatherRetrieval.Add(dayWeather);
            }
            return weatherRetrieval;
        }
        
        public void dataDecoder()
        {
            using (StreamReader loadGame = new StreamReader(filepath + "gamestats.csv"))
            {
                gameData = loadGame.ReadLine();
            }
            char delimiter = ',';
            string[] gameData2 = gameData.Split(delimiter);
            strTotalMoney = gameData2[0];
            strDay = gameData2[1];
            strDayLimit = gameData2[2];
            strLemons = gameData2[3];
            strSugar = gameData2[4];
        }
        public double getLemons()
        {
            double lemons = Convert.ToDouble(strLemons);
            return lemons;
        }
        public double getSugar()
        {
            double sugar = Convert.ToDouble(strSugar);
            return sugar;
        }
        public int getDay()
        {
            int day = Convert.ToInt16(strDay);
            return day;
        }
        public double getTotalMoney()
        {
            double totalMoney = Convert.ToDouble(strTotalMoney);
            return totalMoney;
        }
        public double getProfit()
        {
            double profit = Convert.ToDouble(strProfit);
            return profit;
        }
        public double getIncome()
        {
            double income = Convert.ToDouble(strIncome);
            return income;
        }public int getDayLimit()
        {
            int dayLimit = Convert.ToInt16(strDayLimit);
            return dayLimit;
        }
    }
}
