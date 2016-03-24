using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    
    public class player
    {
        public double money = 20;
        public double lemonCount = 0;
        public double sugarCount = 0;
        public double iceCount = 0;
        public player(double money, double lemonCount, double sugarCount, double iceCount)
        {
            
        }
        public double user(double forecast)
        {               
            double aCustomer;
            Random customers = new Random();
            
                if (forecast.Equals(1))
                {
                    aCustomer = customers.Next(1, 75);
                    return aCustomer;
                }
                else if (forecast.Equals(2))
                {
                    aCustomer = customers.Next(10, 80);
                    return aCustomer;
                }
                else if (forecast.Equals(3))
                {
                    aCustomer = customers.Next(20, 70);
                    return aCustomer;
                }
                else if (forecast.Equals(4))
                {
                    aCustomer = customers.Next(40, 85);
                    return aCustomer;
                }
                else if (forecast.Equals(5))
                {
                    aCustomer = customers.Next(40, 101);
                    return aCustomer;
                }
                return 0;
        }
    }
}
