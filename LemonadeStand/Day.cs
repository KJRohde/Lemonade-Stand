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

        //construct
        public Day()
        {
            weather = new Weather();
            customer = new Customer();
            customer.GenerateCustomers();
            weather.GenerateTemp();
            weather.GenerateConditions();
        }
        //methods
    }
}
