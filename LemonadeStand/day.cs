using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LemonadeStand
{
    public class day
    {
        public List<customer> potentialCustomers = new List<customer>();
        public Random cashClass = new Random();
        
        public List<customer> makeNewCustomers(double customerLimit)
        {
            for (int customerNum = 0; customerNum < customerLimit; customerNum++)
            {
                potentialCustomers.Add(new customer(cashClass.Next(1, 5)));
                Thread.Sleep(10);
            }
            Console.Write("number of customers " + potentialCustomers.Count);
            Console.ReadLine();
            return potentialCustomers;
        }
        public void displayCustomers()
        {
            foreach(customer person in potentialCustomers)
            {
                Console.WriteLine(person.customerName + "'s cash class is " + person.cashClass);
            }
        }
    }
}