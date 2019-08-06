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
        public int numberOfCustomers;
        public int chanceToBuy;
        public double cash;
        public string[] customers;
        Random random;


        //construct
        public Customer(Random random)
        {
            this.random = random;
        }
        //methods
        public int GenerateCustomers()
        {
            numberOfCustomers = random.Next(20, 30);
            return numberOfCustomers;
        }

    }
}
