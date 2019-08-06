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
        private Day day1;
        private Day day2;
        private Day day3;
        private Day day4;
        private Day day5;
        private Day day6;
        private Day day7;
        private double cupCharge;

        //construct
        public Game()
        {
            dayCounter = 1;
            day1 = new Day();
            day2 = new Day();
            day3 = new Day();
            day4 = new Day();
            day5 = new Day();
            day6 = new Day();
            day7 = new Day();

        }
        //methods
        public List<Day> GenerateDays()
        {
            var days = new List<Day>();
            days.Add(day1);
            days.Add(day2);
            days.Add(day3);
            days.Add(day4);
            days.Add(day5);
            days.Add(day6);
            days.Add(day7);
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
                Console.WriteLine("It is day " + dayCounter + " of the week. You have $" + inventory.moneyCounter + ".\n");
                Console.ReadLine();
                Console.WriteLine("Today, it is " + day1.weather.temperature + "degrees outside and it is" + day1.weather.condition + ".");
                Console.WriteLine("You currently have the following ingredients and supplies:\n" + inventory.sugar + " cups of sugar\n" + inventory.lemons + " lemons\n" + inventory.iceCubes + " ice cubes\n" + inventory.cups + " paper cups");
                inventory.AddSugar();
                inventory.ChargeSugar();
                Console.WriteLine("You now have the following ingredients and supplies:\n" + inventory.sugar + " cups of sugar\n" + inventory.lemons + " lemons\n" + inventory.iceCubes + " ice cubes\n" + inventory.cups + " paper cups\nAnd you have $" + inventory.moneyCounter + " remaining.");
                inventory.AddLemons();
                inventory.ChargeLemons();
                Console.WriteLine("You now have the following ingredients and supplies:\n" + inventory.sugar + " cups of sugar\n" + inventory.lemons + " lemons\n" + inventory.iceCubes + " ice cubes\n" + inventory.cups + " paper cups\nAnd you have $" + inventory.moneyCounter + " remaining.");
                inventory.AddIce();
                inventory.ChargeIce();
                Console.WriteLine("You now have the following ingredients and supplies:\n" + inventory.sugar + " cups of sugar\n" + inventory.lemons + " lemons\n" + inventory.iceCubes + " ice cubes\n" + inventory.cups + " paper cups\nAnd you have $" + inventory.moneyCounter + " remaining.");
                inventory.AddCups();
                inventory.ChargeCups();
                Console.WriteLine("You now have the following ingredients and supplies:\n" + inventory.sugar + " cups of sugar\n" + inventory.lemons + " lemons\n" + inventory.iceCubes + " ice cubes\n" + inventory.cups + " paper cups\nAnd you have $" + inventory.moneyCounter + " remaining.");
                Console.WriteLine("You are done buying supplies for today. How much would you like to charge per cup of lemonade in cents?");
                cupCharge = 0.01 * int.Parse(Console.ReadLine());
                inventory.moneyCounter += cupCharge * day1.customer.numberOfCustomers;
                dayCounter++;

            }
        }
    }
}
