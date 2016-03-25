using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class gameEngine
    {

        day getList = new day();
        public void getCustomers(double numberOfcustomers)
        {
            getList.makeNewCustomers(numberOfcustomers);
            foreach(customer person in getList.potentialCustomers)
            {
                Console.WriteLine(person.cashClass + ", " + person.customerName);
            }            
        }
    }
}
//will need to get customer list
