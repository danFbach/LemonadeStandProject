using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LemonadeStand
{
    public class customer
    {
        Random name = new Random();
        Random tipping = new Random();
        public string customerName;
        public string taste;
        public int tasteClass;
        public int cashClass;
        public int tipper;
        public customer(int cash)
        {
            tasteClass = tipping.Next(1, 8);
            taste = tasteTest(tasteClass);
            Thread.Sleep(5);
            cashClass = cash;
            tipper = tipping.Next(1, 6);
            Thread.Sleep(5);
            int randName = name.Next(1, 11);
            if (randName.Equals(1))
            {
                customerName = "Dan";
            }
            else if (randName.Equals(2))
            {
                customerName = "Lindsay";
            }
            else if (randName.Equals(3))
            {
                customerName = "Bob";
            }
            else if (randName.Equals(4))
            {
                customerName = "Lisa";
            }
            else if (randName.Equals(5))
            {
                customerName = "John";
            }
            else if (randName.Equals(6))
            {
                customerName = "Berry";
            }
            else if (randName.Equals(7))
            {
                customerName = "Matt";
            }
            else if (randName.Equals(8))
            {
                customerName = "Melissa";
            }
            else if (randName.Equals(9))
            {
                customerName = "Mike";
            }
            else if (randName.Equals(10))
            {
                customerName = "Tracy";
            }
        }
        public string tasteTest(int tasteNumber)
        {
            string tasteName;
            if (tasteNumber.Equals(1))
            {
                tasteName = "sour";
                return tasteName;
            }
            else if (tasteNumber.Equals(4))
            {
                tasteName = "sweet";
                return tasteName;
            }
            else if (tasteNumber.Equals(7))
            {
                tasteName = "watery";
                return tasteName;
            }
            return "";
        }
    }
}
