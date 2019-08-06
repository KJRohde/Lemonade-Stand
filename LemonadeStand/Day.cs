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
        public int numberOfCustomers;
        public Weather weather;
        public Customer customer;
        public List<Customer> customers;
        Random random;
        //construct
        public Day(Random random)
        {
            this.random = random;
            weather = new Weather(random);
            GenerateCustomers();
            weather.GenerateConditions();
            weather.GenerateTemperature();
        }

        //methods
        public List<Customer> GenerateCustomers()
        {
            numberOfCustomers = random.Next(75, 111);
            for (int i = 1; i <= numberOfCustomers; i++)
            {
                customers.Add(new Customer(random));
            }
            return customers;
        }
    }
}
