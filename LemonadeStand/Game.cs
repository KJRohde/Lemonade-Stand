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
        public Player player1;
        public int dayCounter;
        Inventory inventory = new Inventory(0, 0, 0, 0);
        public List<Day> days;
        private double cupCharge;
        Random random = new Random();
        public int totalDays;
        private List<Customer> servedTemperature;
        private List<Customer> served;
        private int i;
        private int cupsLemonade;

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
                servedTemperature = new List<Customer>();
                served = new List<Customer>();
                UserInterface.BeginDay(inventory, player1);
                GenerateForecast();
                Console.Clear();
                UserInterface.DisplayInventory(inventory);
                inventory.AddSugar();
                UserInterface.DisplayInventory(inventory);
                inventory.AddLemons();
                UserInterface.DisplayInventory(inventory);
                inventory.AddIce();
                UserInterface.DisplayInventory(inventory);
                inventory.AddCups();
                UserInterface.DisplayInventory(inventory);
                Console.Clear();
                UserInterface.DisplayInventory(inventory);
                inventory.PlanPitchersSugar();
                inventory.PlanPitchersLemon();
                inventory.PlanPitchersIce();
                Console.Clear();
                GetCupCharge();
                inventory.MakePitchers();
                Console.WriteLine("Made " + inventory.pitcherCounter + " pitchers.");
                Console.ReadLine();
                cupsLemonade = inventory.pitcherCounter * 5;
                Console.WriteLine("Made " + cupsLemonade + " cups.");
                Console.ReadLine();
                customersServedTemperature(days[dayCounter - 1].customers, days[dayCounter - 1].weather.temperature);
                for (i = 0; i < servedTemperature.Count; i++)
                {
                    customersServed(servedTemperature, servedTemperature[i].availableCash);
                }
                if (served.Count > cupsLemonade)
                {
                    Console.WriteLine("You ran out of lemonade before the end of the day.");
                    inventory.moneyCounter += cupsLemonade * cupCharge;
                }
                else
                {
                    Console.WriteLine("Out of the " + (cupsLemonade) + " cups of lemonade you made, you served " + served.Count + " customers!");
                    inventory.moneyCounter += served.Count * cupCharge;
                }          
                UserInterface.EndDay(inventory);
                inventory.pitcherCounter = 0;
                cupsLemonade = 0;
                inventory.iceCubes = 0;
                dayCounter++;
            }
            UserInterface.EndGame(inventory, player1);
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
        public void GenerateForecast()
        {
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
        }
        public double GetCupCharge()
        {
            Console.WriteLine("You are done buying supplies and making pitchers for today. How much would you like to charge per cup of lemonade in cents?");
            while (double.TryParse(Console.ReadLine(), out cupCharge))
            {
                cupCharge *= 0.01;
                return (cupCharge);
            }
            return GetCupCharge();
        }
    }
}
