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
        string fileName;
        double gameSlot;
        string saveChoice;
        string outputFile = @"C:\Users\Dan DCC\Documents\Visual Studio 2015\Projects\LemonadeStandProject\LemonadeStand\";
        public fileWriter(double balance, double currentDay, double dayLimit, double lemons, double sugar)
        {           
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
        public void todaysStats(double moneyTotals, double currentDay, double dayLimit, double lemons, double sugar,double slotChoice)
        {
            if (slotChoice.Equals(1))
            {
                fileName = "gameStats.csv";
            }
            else if (slotChoice.Equals(2))
            {
                fileName = "gameStats2.csv";
            }
            else if (slotChoice.Equals(3))
            {
                fileName = "gameStats3.csv";
            }
            using (StreamWriter saveGame = new StreamWriter(outputFile + fileName))
            {
                string strMoneyTotals = moneyTotals.ToString();
                string strDay = currentDay.ToString();
                string strDayLimit = dayLimit.ToString();
                string strLemons = lemons.ToString();
                string strSugar = sugar.ToString();
                saveGame.WriteLine("{0},{1},{2},{3},{4}{5}", strMoneyTotals, strDay, strDayLimit, strLemons, strSugar, Environment.NewLine);
            }                        
        }
        public string newSave(string gameSave)
        {
            if (!gameSave.Equals("save"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("If you would like to save the game please type save now, otherwise press enter to continue.");
                saveChoice = Console.ReadLine();
                saveChoice = saveChoice.ToLower();
                return saveChoice;
            }
            else return gameSave;  
        }
        public double newSlot(string gameSave, double gameSlot)
        {            
            if (gameSave.Equals("save") && gameSlot.Equals(0))
            {
                Console.WriteLine("Please select a slot to save your game to. \nSlot 1, 2 or 3.");
                gameSlot = double.Parse(Console.ReadLine());
                return gameSlot;                
            }
            else
            return gameSlot;
        }
    }
}