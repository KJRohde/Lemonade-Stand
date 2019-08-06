using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Preference
    {
        //member variables
        public int temperatureThreshold;
        public double availableCash;
        Random random;
        //constructs
        public Preference(Random random)
        {
            this.random = random;
        }
        //methods
        public void GiveThreshold()
        {
            temperatureThreshold = random.Next(55, 94);
        }
        public void GiveCash()
        {
            availableCash = random.Next(0.2, 1);
        }
    }
}
