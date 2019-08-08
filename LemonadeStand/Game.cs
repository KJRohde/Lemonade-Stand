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
        Random random = new Random();
        private int totalDays;
        private List<Customer> servedTemperature;
        private List<Customer> served;
        private int i;

        //construct
        public Game()
        {
            dayCounter = 1;
        }
        //methods

        public List<Day> GenerateDays()
        {
            days = new List<Day>();
            for (int i = 1; i <= totalDays; i++)
            {
                days.Add(new Day(random));
            }
            return days;
        }
        public void RunGame()
        {
            Console.WriteLine("Your Lemonade Stand starts with $20.\nYou are able to purchase new supplies and ingredients each day before selling.\nCustomers will decide whether they want to buy your product based on various circumstances.\nYou will have the option to buy and sell each day for as many days as you would like, up to 30, to maximize profits.");
            player1 = new Player();
            Console.ReadLine();
            player1.ChooseName();
            Console.WriteLine("How many days will your stand be open?");
            totalDays = int.Parse(Console.ReadLine());
            GenerateDays();
            while (dayCounter <= totalDays)
            {
                inventory.pitcherCounter = 0;
                inventory.iceCubes = 0;
                servedTemperature = new List<Customer>();
                served = new List<Customer>();
                Console.WriteLine("It is day " + dayCounter + " of " + player1.playerName + " being open. You have $" + inventory.moneyCounter + ".\n");
                Console.ReadLine();
                Console.WriteLine("Your Lemonade Stand forecast is below, temperature followed by conditions\n");
                if (totalDays - 7 >= 0)
                {
                    for (i = dayCounter - 1; i <= dayCounter + 5; i++)
                    {
                        Console.WriteLine(days[i].weather.temperature + " " + days[i].weather.condition);
                    }
                }
                else
                {
                    for (i = dayCounter - 1; i <= totalDays - 1; i++)
                    {
                        Console.WriteLine(days[i].weather.temperature + " " + days[i].weather.condition);
                    }
                }
                Console.ReadLine();
                Console.WriteLine("Today, it is " + days[dayCounter - 1].weather.temperature + " degrees outside and it is " + days[dayCounter - 1].weather.condition + ".");
                Console.WriteLine("You currently have the following ingredients and supplies:\n" + inventory.sugar + " cups of sugar\n" + inventory.lemons + " lemons\n" + inventory.iceCubes + " ice cubes\n" + inventory.cups + " paper cups");
                Console.ReadLine(); 
                Console.Clear();
                inventory.AddSugar();
                UserInterface.DisplayInventory();
                Console.Clear();
                inventory.AddLemons();
                Console.WriteLine("You now have the following ingredients and supplies:\n" + inventory.sugar + " cups of sugar\n" + inventory.lemons + " lemons\n" + inventory.iceCubes + " ice cubes\n" + inventory.cups + " paper cups\nAnd you have $" + inventory.moneyCounter + " remaining.");
                Console.Clear();
                inventory.AddIce();
                Console.WriteLine("You now have the following ingredients and supplies:\n" + inventory.sugar + " cups of sugar\n" + inventory.lemons + " lemons\n" + inventory.iceCubes + " ice cubes\n" + inventory.cups + " paper cups\nAnd you have $" + inventory.moneyCounter + " remaining.");
                Console.Clear();
                inventory.AddCups();
                Console.Clear();
                Console.WriteLine("You now have the following ingredients and supplies:\n" + inventory.sugar + " cups of sugar\n" + inventory.lemons + " lemons\n" + inventory.iceCubes + " ice cubes\n" + inventory.cups + " paper cups\nAnd you have $" + inventory.moneyCounter + " remaining.");
                Console.WriteLine("You are done buying supplies for today. How much would you like to charge per cup of lemonade in cents?");
                cupCharge = 0.01 * int.Parse(Console.ReadLine());
                inventory.MakePitchers();
                customersServedTemperature(days[dayCounter - 1].customers, days[dayCounter - 1].weather.temperature);
                //There should now be a list of only customers that meet the temperature threshold
                for (i = 0; i < servedTemperature.Count; i++)
                {
                    customersServed(servedTemperature, servedTemperature[i].availableCash);
                }
                inventory.moneyCounter += served.Count * cupCharge;
                Console.WriteLine("You have made " + inventory.pitcherCounter + " pitchers of lemonade to sell today.");
                //Filter list of customers to yield a list of customer that match temperature threshold and available cash

                Console.WriteLine("You served " + served.Count + " today!");
                Console.WriteLine("You ended today with $" + inventory.moneyCounter + ". and all of your ice has melted");
                Console.ReadLine();
                Console.Clear();
                dayCounter++;

            }
            Console.WriteLine("In " + totalDays + " you were able to make $" + (inventory.moneyCounter - 20) + "from " + player1.playerName + ".");
        }
        List<Customer> customersServedTemperature(List<Customer> customers, int temperature)
        {
            servedTemperature = new List<Customer>();
            foreach (var customer in customers)
            {
                if (customer.temperatureThreshold <= temperature)
                {
                    servedTemperature.Add(customer);
                }
            }
            return servedTemperature;
        }
        List<Customer> customersServed(List<Customer> servedTemperature, double availableCash)
        {
            served = new List<Customer>();
            foreach (var customer in servedTemperature)
            {
            if (customer.availableCash <= cupCharge)
                {
                    served.Add(customer);
                }
            }
            return served;
        }
    }
}
