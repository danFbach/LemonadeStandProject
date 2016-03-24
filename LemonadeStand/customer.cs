using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class customer
    {
        

        int customerLimit = 50;
        public List<List<string>> customerLog = new List<List<string>>();
        public List<string> customerNames = new List<string>();
        public day listMerge = new day();
        public void makeNewCustomers()
        {
            for (int customerNum = 0; customerNum < customerLimit; customerNum++)
            {

                customerNames.Add("Customer " + customerNum);
            }
        }           
            public void listStuff(int i)
        {

            Console.Write(customerNames[i]);
        }
    }
}
 
