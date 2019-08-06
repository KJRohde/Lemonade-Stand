using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //member variables
        public Weather weather;
        public Customer customer;
        Random random;
        //construct
        public Day(Random random)
        {
            this.random = random;
            weather = new Weather(random);
            customer = new Customer(random);
            customer.GenerateCustomers();
            weather.GenerateConditions();
            weather.GenerateTemperature();
        }

        //methods
    }
}
