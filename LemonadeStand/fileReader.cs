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
        public string strLemons;
        public string strSugar;
        public string strIncome;
        public string strProfit;
        public string strTotalMoney;
        public string strDay;
        public string strDayLimit;
        public void loadinggame()
        {
            
            string filepath = @"c:\users\dan dcc\documents\visual studio 2015\projects\lemonadestandproject\lemonadestand\";
            using (StreamReader loadGame = new StreamReader(filepath + "gamestats.csv"))
            {
                gameData = loadGame.ReadLine();
            }
            
        }
        public void dataDecoder()
        {
            string filepath = @"c:\users\dan dcc\documents\visual studio 2015\projects\lemonadestandproject\lemonadestand\";
            using (StreamReader loadGame = new StreamReader(filepath + "gamestats.csv"))
            {
                gameData = loadGame.ReadLine();
            }
            char delimiter = ',';
            string[] gameData2 = gameData.Split(delimiter);
            strDay = gameData2[0];
            strTotalMoney = gameData2[1];
            strProfit = gameData2[2];
            strIncome = gameData2[3];
            strLemons = gameData2[4];
            strSugar = gameData2[5];
            strDayLimit = gameData2[6];
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
