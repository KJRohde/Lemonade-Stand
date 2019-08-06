using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //member variables

        public Preference preference;
        Random random;


        //construct
        public Customer(Random random)
        {
            this.random = random;
            preference.GiveCash();
            preference.GiveThreshold();
        }
        //methods
    }
}
