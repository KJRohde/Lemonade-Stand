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
        Random random = new Random();
        public string[] customers;


        //construct
        public Customer()
        {

        }

        //methods
        public int GenerateCustomers()
        {
            numberOfCustomers = random.Next(20, 30);
            return numberOfCustomers;
        }

    }
}
