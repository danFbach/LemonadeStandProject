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
        public int cashClass;
        public int tipper;
        public customer(int cash)
        {
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
                customerName = "Ally";
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
    }
}
