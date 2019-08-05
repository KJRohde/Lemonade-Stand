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
        private Day day;

        //construct
        public Game()
        {
            dayCounter = 1;
        }
        //methods
        public void RunGame()
        {
            Console.WriteLine("Your Lemonade Stand starts with $20.\nYou are able to purchase new supplies and ingredients each day before selling.\nCustomers will decide whether they want to buy your product based on various circumstances.\nYou will have the option to buy and sell each day for 7 days to maximize profits.");
            player1 = new Player();
            Console.ReadLine();
            player1.ChooseName();
            while (dayCounter <= 7)
            {
                Console.WriteLine("It is day " + dayCounter + " of the week. You have $" + inventory.moneyCounter + ".");
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

            }
        }
    }
}
