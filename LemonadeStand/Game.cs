using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //member variables
        private Player player1;
        private int dayCounter;
        Inventory inventory = new Inventory(0, 0, 0, 0);
        private List<Day> days;
        private double cupCharge;
        private int customersServed;
        Random random = new Random();

        //construct
        public Game()
        {
            dayCounter = 1;

        }
        //methods
        public List<Day> GenerateDays()
        {
            days = new List<Day>();
            return days;
        }
        public void RunGame()
        {
            Console.WriteLine("Your Lemonade Stand starts with $20.\nYou are able to purchase new supplies and ingredients each day before selling.\nCustomers will decide whether they want to buy your product based on various circumstances.\nYou will have the option to buy and sell each day for 7 days to maximize profits.");
            player1 = new Player();
            Console.ReadLine();
            player1.ChooseName();
            GenerateDays();
            while (dayCounter <= 7)
            {
                inventory.pitcherCounter = 0;
                inventory.iceCubes = 0;
                Console.WriteLine("It is day " + dayCounter + " of the week. You have $" + inventory.moneyCounter + ".\n");
                Console.ReadLine();
                Console.WriteLine("Today, it is " + days[dayCounter-1].weather.temperature + "degrees outside and it is" + days[dayCounter-1].weather.condition + ".");
                Console.WriteLine("You currently have the following ingredients and supplies:\n" + inventory.sugar + " cups of sugar\n" + inventory.lemons + " lemons\n" + inventory.iceCubes + " ice cubes\n" + inventory.cups + " paper cups");
                Console.ReadLine();
                Console.Clear();
                inventory.AddSugar();
                inventory.ChargeSugar();
                Console.WriteLine("You now have the following ingredients and supplies:\n" + inventory.sugar + " cups of sugar\n" + inventory.lemons + " lemons\n" + inventory.iceCubes + " ice cubes\n" + inventory.cups + " paper cups\nAnd you have $" + inventory.moneyCounter + " remaining.");
                Console.Clear();
                inventory.AddLemons();
                inventory.ChargeLemons();
                Console.WriteLine("You now have the following ingredients and supplies:\n" + inventory.sugar + " cups of sugar\n" + inventory.lemons + " lemons\n" + inventory.iceCubes + " ice cubes\n" + inventory.cups + " paper cups\nAnd you have $" + inventory.moneyCounter + " remaining.");
                Console.Clear();
                inventory.AddIce();
                inventory.ChargeIce();
                Console.WriteLine("You now have the following ingredients and supplies:\n" + inventory.sugar + " cups of sugar\n" + inventory.lemons + " lemons\n" + inventory.iceCubes + " ice cubes\n" + inventory.cups + " paper cups\nAnd you have $" + inventory.moneyCounter + " remaining.");
                Console.Clear();
                inventory.AddCups();
                inventory.ChargeCups();
                Console.Clear();
                Console.WriteLine("You now have the following ingredients and supplies:\n" + inventory.sugar + " cups of sugar\n" + inventory.lemons + " lemons\n" + inventory.iceCubes + " ice cubes\n" + inventory.cups + " paper cups\nAnd you have $" + inventory.moneyCounter + " remaining.");
                Console.WriteLine("You are done buying supplies for today. How much would you like to charge per cup of lemonade in cents?");
                cupCharge = 0.01 * int.Parse(Console.ReadLine());
                inventory.MakePitchers();
                Console.WriteLine("You have made " + inventory.pitcherCounter + " pitchers of lemonade to sell today.");
                if (inventory.pitcherCounter * 5 >= days[dayCounter - 1].customer.numberOfCustomers)
                {
                    customersServed = days[dayCounter - 1].customer.numberOfCustomers;
                    inventory.moneyCounter += cupCharge * days[dayCounter - 1].customer.numberOfCustomers;
                    Console.WriteLine("You made " + ((inventory.pitcherCounter * 5) - days[dayCounter - 1].customer.numberOfCustomers) + " too many cups today and served " + customersServed + " customers");
                }
                else
                {
                    customersServed = inventory.pitcherCounter * 5;
                    inventory.moneyCounter += inventory.pitcherCounter * 5 * cupCharge;
                    Console.WriteLine("You ran out of inventory during the day after serving " + customersServed + " customers, leaving more customers without lemonade!");
                }
                Console.WriteLine("You ended today with $" + inventory.moneyCounter + ". and all of your ice has melted");
                Console.ReadLine();
                Console.Clear();
                dayCounter++;

            }
        }
    }
}
