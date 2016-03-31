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
        public string fileName;
        public string filepath = @"c:\users\dan dcc\documents\visual studio 2015\projects\lemonadestandproject\lemonadestand\";
        public List<int> getWeatherData(double slotChoice)
        {
            if (slotChoice.Equals(1))
            {
                fileName = "weather1.csv";
            }
            else if (slotChoice.Equals(2))
            {
                fileName = "weather2.csv";
            }
            else if (slotChoice.Equals(3))
            {
                fileName = "weather3.csv";
            }
            else if (slotChoice.Equals(0))
            {
                fileName = "multiplayerWeather.csv";
            }
            List<int> weatherRetrieval = new List<int>();
            using (StreamReader loadWeather = new StreamReader(filepath + fileName))
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
        public double dataDecoder()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Please select the game folder in which your game was saved. 1, 2 or 3.");
            int gameSlotNumber = int.Parse(Console.ReadLine());
            if (gameSlotNumber.Equals(1))
            {
                fileName = "gamestats.csv";
            }
            else if(gameSlotNumber.Equals(2))
            {
                fileName = "gamestats2.csv";
            }
            else if (gameSlotNumber.Equals(3))
            {
                fileName = "gamestats3.csv";
            }
                using (StreamReader loadGame = new StreamReader(filepath + fileName))
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
            return gameSlotNumber;
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
        string strDayMulti;
        string strDayLimitMulti;
        string strMoney1;
        string strLemons1;
        string strSugar1;
        string strMoney2;
        string strLemons2;
        string strSugar2;
        public void multiplayerDecoder()
        {
            string fileName = "multiStats.csv";
            using (StreamReader loadGame = new StreamReader(filepath + fileName))
            {
                gameData = loadGame.ReadLine();
            }
            char delimiter = ',';
            string[] gameData2 = gameData.Split(delimiter);
            strDayMulti = gameData2[0];
            strDayLimitMulti = gameData2[1];
            strMoney1 = gameData2[2];
            strLemons1 = gameData2[3];
            strSugar1 = gameData2[4];
            strMoney2 = gameData2[5];
            strLemons2 = gameData2[6];
            strSugar2 = gameData2[7];
        }
        public int getDayMulti()
        {
            int multiDay = Convert.ToInt16(strDayMulti);
            return multiDay;
        }
        public int getDayLimitMulti()
        {
            int multiDayLimit = Convert.ToInt16(strDayLimitMulti);
            return multiDayLimit;
        }
        public double getP1Money()
        {
            double p1Money = Convert.ToDouble(strMoney1);
            return p1Money;
        }
        public double getp1Lemons()
        {
            double p1Lemons = Convert.ToDouble(strLemons1);
            return p1Lemons;
        }
        public double getP1Sugar()
        {
            double p1Sugar = Convert.ToDouble(strSugar1);
            return p1Sugar;
        }
        public double getP2Money()
        {
            double p2Money = Convert.ToDouble(strMoney2);
            return p2Money;
        }
        public double getp2Lemons()
        {
            double p2Lemons = Convert.ToDouble(strLemons2);
            return p2Lemons;
        }
        public double getP2Sugar()
        {
            double p2Sugar = Convert.ToDouble(strSugar2);
            return p2Sugar;
        }
    }    
}
