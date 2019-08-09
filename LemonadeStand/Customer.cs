using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //Customer Class is open to expansion and closedt to modification. SOLID!!
        //Each customer will always have a temperature and price limit, but there can be child classes added to determine what weather conditions or lemonade tastes are also a factor.
        //member variables

        public int temperatureThreshold;
        public double availableCash;
        public Random random;


        //construct
        public Customer(Random random)
        {
            this.random = random;
            GiveCash();
            GiveThreshold();
        }
        //methods
        public void GiveThreshold()
        {
            temperatureThreshold = random.Next(60, 90);
        }
        public void GiveCash()
        {
            availableCash = random.Next(2, 10) / 10;
        }
    }
}
