using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class fileWriter
    {
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

        public List<fileWriter> saveStats(double dailyIncome, double moneyTotals, double profits, double day)
        {
            finances.Add(new fileWriter(dailyIncome, moneyTotals, profits, day));
            return finances;

        }
        public void displayStats()
        {
            foreach (fileWriter stat in finances)
            {
                Console.WriteLine("On day " + stat.day + " you made " + stat.income2.ToString("C2") + ", for a profit of " + stat.dailyProfit.ToString("C2") + ", leaving you with a balance of " + stat.balance2.ToString("C2"));
            }
        }
    }
}