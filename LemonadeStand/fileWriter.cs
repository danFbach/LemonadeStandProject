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
        StringBuilder csv = new StringBuilder();
        double income2;
        double balance2;
        double dailyProfit;
        double day;
        public List<fileWriter> finances = new List<fileWriter>();
        
        public fileWriter(double income, double balance, double profit, double currentDay)
        {
            income2 = income;
            balance2 = balance;
            dailyProfit = profit;
            day = currentDay + 1;
        }

        public List<fileWriter> saveStats(double dailyIncome, double moneyTotals, double profits, double lemons, double sugar, double day, double dayLimit)
        {
            string outputFile = @"C:\Users\Dan DCC\Documents\Visual Studio 2015\Projects\LemonadeStandProject\LemonadeStand\";
            finances.Add(new fileWriter(dailyIncome, moneyTotals, profits, day));
            using(StreamWriter saveGame = new StreamWriter(outputFile+"gameStats.csv"))
            {
                day += 1;
                string strDailyIncome = dailyIncome.ToString();
                string strMoneyTotals = moneyTotals.ToString();
                string strProfits = profits.ToString();
                string strLemons = lemons.ToString();
                string strSugar = sugar.ToString();
                string strDay = day.ToString();
                string strDayLimit = dayLimit.ToString();
                saveGame.WriteLine("{0},{1},{2},{3},{4},{5},{6}{7}", strDay, strMoneyTotals, strProfits, strDailyIncome, strLemons, strSugar, strDayLimit, Environment.NewLine);
            }                      
            return finances;
        }
    }
}