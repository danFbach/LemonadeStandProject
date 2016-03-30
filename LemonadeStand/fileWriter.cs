using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LemonadeStand
{
    public class fileWriter
    {
        //double balanceStorage;
        //double lemonStorage;
        //double sugarStorage;
        //double dayStorage;
        //double dayLimitStorage;
        string outputFile = @"C:\Users\Dan DCC\Documents\Visual Studio 2015\Projects\LemonadeStandProject\LemonadeStand\";
        public fileWriter(double balance, double currentDay, double dayLimit, double lemons, double sugar)
        {
            //balanceStorage = balance;
            //dayStorage = currentDay;
            //dayLimitStorage = dayLimit;
            //lemonStorage = lemons;
            //sugarStorage = sugar;            
        }
        public void saveWeather(List<int> weatherInput)
        {
            using (StreamWriter weather = new StreamWriter(outputFile + "weather.csv"))
            {
                foreach (int weatherInt in weatherInput)
                {
                    string strWeatherDay = weatherInt.ToString();
                    weather.Write(strWeatherDay + ",");
                }
            }
        }
        public void todaysStats(double moneyTotals, double currentDay, double dayLimit, double lemons, double sugar)
        {
            using (StreamWriter saveGame = new StreamWriter(outputFile + "gameStats.csv"))
            {
                string strMoneyTotals = moneyTotals.ToString();
                string strDay = currentDay.ToString();
                string strDayLimit = dayLimit.ToString();
                string strLemons = lemons.ToString();
                string strSugar = sugar.ToString();
                saveGame.WriteLine("{0},{1},{2},{3},{4}{5}", strMoneyTotals, strDay, strDayLimit, strLemons, strSugar, Environment.NewLine);
            }
        }
    }
}